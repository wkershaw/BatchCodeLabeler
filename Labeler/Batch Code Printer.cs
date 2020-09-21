using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;
using Task = System.Threading.Tasks.Task;

namespace Labeler
{
    public partial class BatchCodeForm : Form
    {
        private struct LabelSetup
        {
            public int pagewidth;
            public string fontsize;
            public int offset;
            public string batchcode;
            public string prefix;
            public int startNumber;
            public int quantity;
        }

        ZebraPrinter printer;
        bool cancel = false;

        public BatchCodeForm()
        {
            InitializeComponent();

            //Set Label Size Options
            //Small: 158 points wide
            //Large: 235 points wide
            LabelSize.Items.AddRange(
                new object[]
                {
                    "Small (2cm x 1.2cm)",
                    "Large (3cm x 2cm)"
                });
            LabelSize.SelectedIndex = 1;
            
            
            //Try to connect to the printer
            try
            {
                //Connect to first availaible printer
                ConnectToPrinter();
            }
            catch (Exception error)
            {
                ConnectionLabel.Text = "Printer cannot be found, close the program and try again :" + error.Message; 
                CreateButton.Enabled = false;
            }
        }

        private async void CreateButton_ClickAsync(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;
            cancel = false;

            //Check that the printer is ready
            if (!PrinterIsReady())
            {
                ConnectionLabel.Text = "Printer is not ready to print, close the program and try again";
                return;
            }

            //Create a new LabelSetup and add information from the form
            LabelSetup l;
            l.batchcode = BatchCode.Text;
            l.startNumber = (int)StartingNumber.Value;
            l.quantity = (int)NumberOfBottles.Value;
            l.prefix = Prefix.Text;

            //Change the page width and font size based on label size
            if (LabelSize.SelectedIndex == 0)
            {
                l.pagewidth = 158;
                l.fontsize = "43,18";
                l.offset = 20;
            }
            else
            {
                l.pagewidth = 235;
                l.fontsize = "45,20";
                l.offset = 40;
            }

            //Print the labels using the label setup
            await Task.Factory.StartNew(() =>
                {
                    PrintAndWait(l);
                }
            );

            cancel = false;
            CreateButton.Enabled = true;

        }

        private void PrintAndWait(LabelSetup l, int time = 3000)
        {
            PrintLabels(l);
            Thread.Sleep(time);
            while (!PrinterIsReady());
        }

        private void PrintLabels(LabelSetup l)
        {
            //Define the label format used to layout the label
            string labelFormat =
                $"^XA" +                                // Start the format
                $"^DFE:LABEL.ZPL^FS" +                  // Set the name of the format file
                $"^PW{l.pagewidth}" +                     // Set the pagewidth
                $"^A@N,{l.fontsize},E:TT0003M_.FNT" +     // Set the font and fontsize
                $"^FO0,{l.offset}" +                      // Set the starting position using the offset
                $"^FB{l.pagewidth},2,0,C" +               // Create a field block to center the text, max 2 lines
                $"^FN1\"Batch Code Text\"^FS" +         // Define the label text into variable slot 1
                $"^XZ";                                 // End the format

            //Send the label format to the printer
            printer.SendCommand(labelFormat);


            //Initialise a dictionary to pass variables to the printer
            Dictionary<int, string> vars = new Dictionary<int, string> { };

            //Print each label individually, providing a string for the label text via the dictionary
            for (int i = 0; i < l.quantity; i++)
            {
                if (cancel)
                {
                    break;
                }
                //Change the text based on the size of the label
                if (l.pagewidth < 200)
                {
                    vars[1] = $"{l.batchcode}\\&";
                    vars[1] += $"{l.prefix}{l.startNumber + i}\\&";
                }
                else
                {
                    vars[1] = $"{l.batchcode}\\&";
                    vars[1] += $"Bottle: {l.prefix}{l.startNumber + i}\\&";
                }

                //Print the label with associated text
                printer.PrintStoredFormat("E:LABEL.ZPL", vars);
            }


        }
        
        private void ConnectToPrinter()
        {
            DiscoveredUsbPrinter discoveredPrinter = UsbDiscoverer.GetZebraUsbPrinters(new ZebraPrinterFilter())[0];
            Connection connection = discoveredPrinter.GetConnection();
            connection.Open();
            printer = ZebraPrinterFactory.GetInstance(connection);
            ConnectionLabel.Text = "Printer Connected!";
        }
        
        private bool PrinterIsReady()
        {
            bool ready;
            try
            {
                ready = printer != null && printer.GetCurrentStatus().isReadyToPrint;
            }catch (Exception)
            {
                ready = false;
            }
            return ready;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancel = true;
        }
    }
}
