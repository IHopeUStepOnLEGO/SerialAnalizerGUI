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
        OperationFactory opFactory = new OperationFactory();

        public Form1()
        {
            InitializeComponent();
            // set operation counters to 1
            this.WriteOperationCount.Value = 1;
            this.WriteDataByteCount.Value = 1;

            this.ReadOperationCount.Value = 1;

            // set device selection to disabled until connection established
            this.DeviceComboBox.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // prepare new form
            form2 = new Form();

            /*** WRITE OPERATION ***/
            // if write operations is non-zero and non-negative
            if (this.WriteOperationCount.Value > 0)
            {
                // if write databyte count is not-zero and non-negative
                if (this.WriteDataByteCount.Value > 0)
                {
                    // create origin point for the group box containing all operations
                    Point writeGroupBoxPosition = new Point(20, 20);

                    for (int i = 0; i<this.WriteOperationCount.Value; i++)
                    {
                        // create an new groupbox in form2
                        IOperation wOp = opFactory.CreateOperation(OperationType.Write, form2, writeGroupBoxPosition, (int)this.WriteDataByteCount.Value, i);

                        // increment writeOperationPosition.Y by the height of the added component*operation count
                        writeGroupBoxPosition.Y += form2.Controls.Find("wGroupBox" + i, true).FirstOrDefault().Height;
                    }

                } else {
                    // if data bytes <= 0, set value to 1 and restart this function
                    this.WriteDataByteCount.Value = 1;
                    this.SubmitButton_Click(sender, e);
                }
            } else {
                // if operation count is <= 0, set value to 1 and restart this function
                this.WriteOperationCount.Value = 1;
                this.SubmitButton_Click(sender, e);
            }

            /*** READ OPERATION ***/
            if(this.ReadOperationCount.Value > 0)
            {
                Point readGroupBoxPosition = new Point(form2.Controls.Find("writeOperationGroupBox", true).FirstOrDefault().Width+40, 20);

                for(int i = 0; i< this.ReadOperationCount.Value; i++)
                {
                    IOperation rOp = opFactory.CreateOperation(OperationType.Read, form2, readGroupBoxPosition, 1, i);
                    readGroupBoxPosition.Y += form2.Controls.Find("rGroupBox" + i, true).FirstOrDefault().Height;
                }
            }

            try
            {
                // hide form1 after submission
                this.Hide();
                // get bigger hight from read/write and take the biggest one as starting window size
                int dynamicWindowSize = form2.Controls.Find("writeOperationGroupBox", false).FirstOrDefault().Height > form2.Controls.Find("readOperationGroupBox", false).FirstOrDefault().Height ? form2.Controls.Find("writeOperationGroupBox", false).FirstOrDefault().Height + 40 : form2.Controls.Find("readOperationGroupBox", false).FirstOrDefault().Height + 40;                
                form2.Size = new Size(form2.Controls.Find("writeOperationGroupBox", false).FirstOrDefault().Width + 40 + form2.Controls.Find("readOperationGroupBox", false).FirstOrDefault().Width + 30, dynamicWindowSize /*20px border*/ + 20  /*Yoffset from top */ + 100);
                

                // if form 2 is closed, show form1 again
                form2.FormClosed += (s, args) => this.Show();
                // show form2
                form2.Show();
            } catch
            {
                // call this function again and create form 2 anew
                this.SubmitButton_Click(sender, e);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OperationCount_ValueChanged(object sender, EventArgs e)
        {

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

        }


        private void ReadOperationCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
