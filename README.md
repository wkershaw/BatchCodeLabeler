The solution serves as an alternative method of printing batch code labels. My final solution is implemented on top of an SDK provided by Zebra. It provides a simple user interface, built with WinForms, to generate a label template that is then loaded onto the printer, resulting in a simple and fast workflow.

The project also allowed me the opportunity to learn the ZPL language - the language used to communicate with Zebra printers. Whilst it is unlikely that I will need to use this language in my career, I enjoyed the challenge to learn and implement in such a low-level language.

The final ZPL code used within the project is as follows:

^XA // Start the format
^DFE:LABEL.ZPL^FS // Set the name of the format file
^PW{l.pagewidth} // Set the page width
^A@N,{l.fontsize},E:TT0003M_.FNT // Set the font and font size
^FO0,{l.offset} // Set the starting position using the offset
^FB{l.pagewidth},2,0,C // Create a field block to center the text, max 2 lines
^FN1\"Batch Code Text\"^FS // Define the label text into variable slot 1
^XZ // End the format
