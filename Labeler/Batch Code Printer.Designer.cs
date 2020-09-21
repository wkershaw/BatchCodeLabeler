namespace Labeler
{
    partial class BatchCodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchCodeForm));
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BatchCode = new System.Windows.Forms.TextBox();
            this.StartingNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfBottles = new System.Windows.Forms.NumericUpDown();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.ComboBox();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBottles)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            resources.ApplyResources(this.CreateButton, "CreateButton");
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_ClickAsync);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BatchCode
            // 
            resources.ApplyResources(this.BatchCode, "BatchCode");
            this.BatchCode.Name = "BatchCode";
            // 
            // StartingNumber
            // 
            resources.ApplyResources(this.StartingNumber, "StartingNumber");
            this.StartingNumber.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.StartingNumber.Name = "StartingNumber";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // NumberOfBottles
            // 
            resources.ApplyResources(this.NumberOfBottles, "NumberOfBottles");
            this.NumberOfBottles.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.NumberOfBottles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfBottles.Name = "NumberOfBottles";
            this.NumberOfBottles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Prefix
            // 
            resources.ApplyResources(this.Prefix, "Prefix");
            this.Prefix.Name = "Prefix";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // LabelSize
            // 
            this.LabelSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.LabelSize, "LabelSize");
            this.LabelSize.FormattingEnabled = true;
            this.LabelSize.Name = "LabelSize";
            // 
            // ConnectionLabel
            // 
            resources.ApplyResources(this.ConnectionLabel, "ConnectionLabel");
            this.ConnectionLabel.Name = "ConnectionLabel";
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.TabStop = false;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BatchCodeForm
            // 
            this.AcceptButton = this.CreateButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfBottles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartingNumber);
            this.Controls.Add(this.BatchCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Name = "BatchCodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBottles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BatchCode;
        private System.Windows.Forms.NumericUpDown StartingNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberOfBottles;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LabelSize;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}

