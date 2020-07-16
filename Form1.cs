using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialGUI
{
    public partial class Form1 : Form
    {
        Form form2 = new Form();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // if write databyte count is not-zero and non-negative
            if (this.WriteDataByteCount.Value > 0)
            {
                // if write operations is non-zero and non-negative
                if (this.WriteOperationCount.Value > 0)
                {
                    Point writeOperationPosition = new Point(20, 20);

                    for (int i = 0; i<this.WriteOperationCount.Value; i++)
                    {
                        WriteOperation wOp = new WriteOperation(form2, writeOperationPosition, (int)this.WriteDataByteCount.Value, i);
                        writeOperationPosition.Y += wOp.GroupBoxHeight;
                    }
                    
                    // hide form1 after submission
                    this.Hide();        

                    form2.Size = new Size(280, 150+(int)WriteOperationCount.Value*150);

                    // if form 2 is closed, close whole application
                    form2.FormClosed += (s, args) => this.Close();
                    // bring up main form
                    form2.Show();
                } else {
                    // if operationCount is <= 0, disable button
                    this.SubmitButton.Enabled = false;
                    // change color of textbox label and focus on textbox
                    this.WriteOperationLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.WriteOperationCount.Focus();
                }  
            } else
            {
                // if dataCount is <= 0, disable button
                this.SubmitButton.Enabled = false;
                // change color of textbox label and focus on textbox
                this.WriteDataByteCountLabel.ForeColor = Color.FromArgb(255, 0, 0);
                this.WriteDataByteCount.Focus();
            }

        } 
        private void OperationCount_ValueChanged(object sender, EventArgs e)
        {
            // check if operationCount is valid
            if(this.WriteDataByteCount.Value > 0)
            {
                // change label color back to normal
                this.WriteDataByteCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
                // enable button
                this.SubmitButton.Enabled = true;
            }
        }

        private void WriteOperationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeviceLabel_Click(object sender, EventArgs e)
        {

        }

        private void COMConnectionButton_Click(object sender, EventArgs e)
        {
            this.statusLabel.ForeColor = Color.FromArgb(255, 0, 0);
            this.statusLabel.Text = sender + ": not yet implemented!";
        }

        private void OperationsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void WriteOperationCount_ValueChanged(object sender, EventArgs e)
        {
            // check if operationCount is valid
            if (this.WriteOperationCount.Value > 0)
            {
                // change label color back to normal
                this.WriteOperationLabel.ForeColor = Color.FromArgb(0, 0, 0);
                // enable button
                this.SubmitButton.Enabled = true;
            }
        }
    }
}
