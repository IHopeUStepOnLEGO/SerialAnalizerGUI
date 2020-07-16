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
        Form form2;
        WriteOperation wOp;

        public Form1()
        {
            InitializeComponent();
            // set operation counters to 1
            this.WriteOperationCount.Value = 1;
            this.WriteDataByteCount.Value = 1;

            this.ReadOperationCount.Value = 1;
            this.ReadDataByteCount.Value = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // prepare new form
            form2 = new Form();

            // if write databyte count is not-zero and non-negative
            if (this.WriteOperationCount.Value > 0)
            {
                // if write operations is non-zero and non-negative
                if (this.WriteDataByteCount.Value > 0)
                {
                    Point writeOperationPosition = new Point(20, 20);

                    for (int i = 0; i<this.WriteOperationCount.Value; i++)
                    {
                        // create an new groupbox in form2
                        wOp = new WriteOperation(form2, writeOperationPosition, (int)this.WriteDataByteCount.Value, i);
                        // increment writeOperationPosition.Y by the height of the added component*operation count
                        writeOperationPosition.Y += wOp.GroupBoxHeight;                      
                    }
 
                } else {
                    // if dataCount is <= 0, disable button
                    this.SubmitButton.Enabled = false;
                    // change color of textbox label and focus on textbox
                    this.WriteDataByteCountLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.WriteDataByteCount.Focus();
                }
            } else {
                // if operation count is <= 0, disable button
                this.SubmitButton.Enabled = false;
                // change color of textbox label and focus on textbox
                this.WriteOperationCountLabel.ForeColor = Color.FromArgb(255, 0, 0);
                this.WriteOperationCount.Focus();
            }


            /*
            // if read data count is non-zero and non negative
            if (this.ReadOperationCount.Value > 0)
            {
                // if read data bytes are non-zero and non-negative
                if(this.ReadDataByteCount.Value > 0)
                {
                    Point readOperationPosition = new Point(20, 20);

                    for (int i=0; i<this.ReadOperationCount.Value; i++)
                    {
                        // new read operation
                        // increment readOperationPosition.Y by the height of the added component*operation count
                        //readOperationPosition.Y += GenericUriParserOptions.GroupBoxHeight;
                    }
                } else
                {
                    // if dataCount is <= 0, disable button
                    this.SubmitButton.Enabled = false;
                    // change color of textbox label and focus on textbox
                    this.ReadDataByteCountLabel.ForeColor = Color.FromArgb(255, 0, 0);
                    this.ReadDataByteCountLabel.Focus();
                }
            } else
            {
                // if operation count is <= 0, disable button
                this.SubmitButton.Enabled = false;
                // change color of textbox label and focus on textbox
                this.WriteOperationCountLabel.ForeColor = Color.FromArgb(255, 0, 0);
                this.WriteOperationCount.Focus();
            }*/

            // hide form1 after submission
            this.Hide();
            form2.Size = new Size(wOp.GroupBoxWidth+ 40, 150 + (int)WriteOperationCount.Value * 150);
            // if form 2 is closed, show form1 again
            form2.FormClosed += (s, args) => this.Show();
            try
            {
                // show form2
                form2.Show();
            } catch
            {
                // call this function again and create form 2 anew
                this.SubmitButton_Click(sender, e);
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

        private void WriteOperationCountLabel_Click(object sender, EventArgs e)
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
                this.WriteOperationCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
                // enable button
                this.SubmitButton.Enabled = true;
            }
        }


        private void ReadOperationCount_ValueChanged(object sender, EventArgs e)
        {
            // check if operationCount is valid
            if(this.ReadOperationCount.Value >0)
            {
                // change label color back to normal
                this.ReadOperationCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
                // enable button
                this.SubmitButton.Enabled = true;
            }
        }
    }
}
