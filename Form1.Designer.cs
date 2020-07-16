namespace SerialGUI
{
    partial class Form1
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
            this.WriteDataByteCount = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.WriteDataByteCountLabel = new System.Windows.Forms.Label();
            this.WriteOperationCount = new System.Windows.Forms.NumericUpDown();
            this.OperationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReadGroupBox = new System.Windows.Forms.GroupBox();
            this.ReadOperationCountLabel = new System.Windows.Forms.Label();
            this.ReadDataByteCountLabel = new System.Windows.Forms.Label();
            this.ReadOperationCount = new System.Windows.Forms.NumericUpDown();
            this.ReadDataByteCount = new System.Windows.Forms.NumericUpDown();
            this.WriteGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteOperationCountLabel = new System.Windows.Forms.Label();
            this.COMConnectionComboBox = new System.Windows.Forms.ComboBox();
            this.COMConnectionLabel = new System.Windows.Forms.Label();
            this.COMConnectionButton = new System.Windows.Forms.Button();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.WriteDataByteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriteOperationCount)).BeginInit();
            this.OperationsGroupBox.SuspendLayout();
            this.ReadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadOperationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadDataByteCount)).BeginInit();
            this.WriteGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WriteDataByteCount
            // 
            this.WriteDataByteCount.Location = new System.Drawing.Point(105, 56);
            this.WriteDataByteCount.Name = "WriteDataByteCount";
            this.WriteDataByteCount.Size = new System.Drawing.Size(50, 20);
            this.WriteDataByteCount.TabIndex = 0;
            this.WriteDataByteCount.ValueChanged += new System.EventHandler(this.OperationCount_ValueChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(308, 47);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "start GUI";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // WriteDataByteCountLabel
            // 
            this.WriteDataByteCountLabel.AutoSize = true;
            this.WriteDataByteCountLabel.Location = new System.Drawing.Point(17, 50);
            this.WriteDataByteCountLabel.Name = "WriteDataByteCountLabel";
            this.WriteDataByteCountLabel.Size = new System.Drawing.Size(55, 26);
            this.WriteDataByteCountLabel.TabIndex = 2;
            this.WriteDataByteCountLabel.Text = "No. of \r\nDatabytes";
            // 
            // WriteOperationCount
            // 
            this.WriteOperationCount.Location = new System.Drawing.Point(105, 19);
            this.WriteOperationCount.Name = "WriteOperationCount";
            this.WriteOperationCount.Size = new System.Drawing.Size(50, 20);
            this.WriteOperationCount.TabIndex = 3;
            this.WriteOperationCount.ValueChanged += new System.EventHandler(this.WriteOperationCount_ValueChanged);
            // 
            // OperationsGroupBox
            // 
            this.OperationsGroupBox.Controls.Add(this.ReadGroupBox);
            this.OperationsGroupBox.Controls.Add(this.WriteGroupBox);
            this.OperationsGroupBox.Location = new System.Drawing.Point(22, 88);
            this.OperationsGroupBox.Name = "OperationsGroupBox";
            this.OperationsGroupBox.Size = new System.Drawing.Size(361, 125);
            this.OperationsGroupBox.TabIndex = 5;
            this.OperationsGroupBox.TabStop = false;
            this.OperationsGroupBox.Text = "Operations";
            this.OperationsGroupBox.Enter += new System.EventHandler(this.OperationsGroupBox_Enter);
            // 
            // ReadGroupBox
            // 
            this.ReadGroupBox.Controls.Add(this.ReadOperationCountLabel);
            this.ReadGroupBox.Controls.Add(this.ReadDataByteCountLabel);
            this.ReadGroupBox.Controls.Add(this.ReadOperationCount);
            this.ReadGroupBox.Controls.Add(this.ReadDataByteCount);
            this.ReadGroupBox.Location = new System.Drawing.Point(185, 19);
            this.ReadGroupBox.Name = "ReadGroupBox";
            this.ReadGroupBox.Size = new System.Drawing.Size(170, 93);
            this.ReadGroupBox.TabIndex = 7;
            this.ReadGroupBox.TabStop = false;
            this.ReadGroupBox.Text = "Read";
            // 
            // ReadOperationCountLabel
            // 
            this.ReadOperationCountLabel.AutoSize = true;
            this.ReadOperationCountLabel.Location = new System.Drawing.Point(9, 21);
            this.ReadOperationCountLabel.Name = "ReadOperationCountLabel";
            this.ReadOperationCountLabel.Size = new System.Drawing.Size(90, 13);
            this.ReadOperationCountLabel.TabIndex = 4;
            this.ReadOperationCountLabel.Text = "No. of Operations";
            // 
            // ReadDataByteCountLabel
            // 
            this.ReadDataByteCountLabel.AutoSize = true;
            this.ReadDataByteCountLabel.Location = new System.Drawing.Point(17, 50);
            this.ReadDataByteCountLabel.Name = "ReadDataByteCountLabel";
            this.ReadDataByteCountLabel.Size = new System.Drawing.Size(55, 26);
            this.ReadDataByteCountLabel.TabIndex = 2;
            this.ReadDataByteCountLabel.Text = "No. of \r\nDatabytes";
            // 
            // ReadOperationCount
            // 
            this.ReadOperationCount.Location = new System.Drawing.Point(105, 19);
            this.ReadOperationCount.Name = "ReadOperationCount";
            this.ReadOperationCount.Size = new System.Drawing.Size(50, 20);
            this.ReadOperationCount.TabIndex = 3;
            // 
            // ReadDataByteCount
            // 
            this.ReadDataByteCount.Location = new System.Drawing.Point(105, 56);
            this.ReadDataByteCount.Name = "ReadDataByteCount";
            this.ReadDataByteCount.Size = new System.Drawing.Size(50, 20);
            this.ReadDataByteCount.TabIndex = 0;
            // 
            // WriteGroupBox
            // 
            this.WriteGroupBox.Controls.Add(this.WriteOperationCountLabel);
            this.WriteGroupBox.Controls.Add(this.WriteDataByteCountLabel);
            this.WriteGroupBox.Controls.Add(this.WriteOperationCount);
            this.WriteGroupBox.Controls.Add(this.WriteDataByteCount);
            this.WriteGroupBox.Location = new System.Drawing.Point(6, 19);
            this.WriteGroupBox.Name = "WriteGroupBox";
            this.WriteGroupBox.Size = new System.Drawing.Size(170, 93);
            this.WriteGroupBox.TabIndex = 6;
            this.WriteGroupBox.TabStop = false;
            this.WriteGroupBox.Text = "Write";
            // 
            // WriteOperationCountLabel
            // 
            this.WriteOperationCountLabel.AutoSize = true;
            this.WriteOperationCountLabel.Location = new System.Drawing.Point(9, 21);
            this.WriteOperationCountLabel.Name = "WriteOperationCountLabel";
            this.WriteOperationCountLabel.Size = new System.Drawing.Size(90, 13);
            this.WriteOperationCountLabel.TabIndex = 4;
            this.WriteOperationCountLabel.Text = "No. of Operations";
            this.WriteOperationCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // COMConnectionComboBox
            // 
            this.COMConnectionComboBox.FormattingEnabled = true;
            this.COMConnectionComboBox.Location = new System.Drawing.Point(67, 12);
            this.COMConnectionComboBox.Name = "COMConnectionComboBox";
            this.COMConnectionComboBox.Size = new System.Drawing.Size(235, 21);
            this.COMConnectionComboBox.TabIndex = 6;
            // 
            // COMConnectionLabel
            // 
            this.COMConnectionLabel.AutoSize = true;
            this.COMConnectionLabel.Location = new System.Drawing.Point(26, 15);
            this.COMConnectionLabel.Name = "COMConnectionLabel";
            this.COMConnectionLabel.Size = new System.Drawing.Size(34, 13);
            this.COMConnectionLabel.TabIndex = 7;
            this.COMConnectionLabel.Text = "COM:";
            // 
            // COMConnectionButton
            // 
            this.COMConnectionButton.Location = new System.Drawing.Point(308, 12);
            this.COMConnectionButton.Name = "COMConnectionButton";
            this.COMConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.COMConnectionButton.TabIndex = 8;
            this.COMConnectionButton.Text = "connect";
            this.COMConnectionButton.UseVisualStyleBackColor = true;
            this.COMConnectionButton.Click += new System.EventHandler(this.COMConnectionButton_Click);
            // 
            // DeviceComboBox
            // 
            this.DeviceComboBox.FormattingEnabled = true;
            this.DeviceComboBox.Location = new System.Drawing.Point(67, 49);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(235, 21);
            this.DeviceComboBox.TabIndex = 9;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(19, 52);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(41, 13);
            this.DeviceLabel.TabIndex = 10;
            this.DeviceLabel.Text = "Device";
            this.DeviceLabel.Click += new System.EventHandler(this.DeviceLabel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(408, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 258);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DeviceLabel);
            this.Controls.Add(this.DeviceComboBox);
            this.Controls.Add(this.COMConnectionButton);
            this.Controls.Add(this.COMConnectionLabel);
            this.Controls.Add(this.COMConnectionComboBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.OperationsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WriteDataByteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WriteOperationCount)).EndInit();
            this.OperationsGroupBox.ResumeLayout(false);
            this.ReadGroupBox.ResumeLayout(false);
            this.ReadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadOperationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadDataByteCount)).EndInit();
            this.WriteGroupBox.ResumeLayout(false);
            this.WriteGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WriteDataByteCount;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label WriteDataByteCountLabel;
        private System.Windows.Forms.NumericUpDown WriteOperationCount;
        private System.Windows.Forms.GroupBox OperationsGroupBox;
        private System.Windows.Forms.GroupBox WriteGroupBox;
        private System.Windows.Forms.Label WriteOperationCountLabel;
        private System.Windows.Forms.GroupBox ReadGroupBox;
        private System.Windows.Forms.Label ReadOperationCountLabel;
        private System.Windows.Forms.Label ReadDataByteCountLabel;
        private System.Windows.Forms.NumericUpDown ReadOperationCount;
        private System.Windows.Forms.NumericUpDown ReadDataByteCount;
        private System.Windows.Forms.ComboBox COMConnectionComboBox;
        private System.Windows.Forms.Label COMConnectionLabel;
        private System.Windows.Forms.Button COMConnectionButton;
        private System.Windows.Forms.ComboBox DeviceComboBox;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

