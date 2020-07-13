using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerialGUI
{
    class WriteOperation
    {
        // private values to hold form and offset of controls added by this class
        private int textBoxWidth = 60;
        private int textBoxHeight = 40;
        private int textBoxHOffset = 70;
        private int buttonWidth = 50;
        private int buttonHeigt = 20;
        public WriteOperation(Form targetForm, Point originPoint, int dataByteCount, int iterationCounter=0)
        {
            // create an group box to hold all content
            GroupBox wGroup = new GroupBox();
            wGroup.Location = originPoint;
            wGroup.Text = "write" + iterationCounter;
            wGroup.Size = new Size(225, 125);

            wGroup.Name = "wGroupBox" + iterationCounter;

            Point wGroupContentOriginPoint = new Point(originPoint.X - 10, originPoint.Y + 20);

            // add an label for slaveAddress textbox 
            Label slvAddrTBLabel = new Label();
            slvAddrTBLabel.Location = new Point(wGroupContentOriginPoint.X -10, wGroupContentOriginPoint.Y - 20  -(iterationCounter*150));
            slvAddrTBLabel.Text = "slaveAddress:";
            slvAddrTBLabel.Name = "slaveAddressLabel" + iterationCounter;


            // add slaveAddressTextBox
            TextBox slvAddrTB = new TextBox();
            slvAddrTB.Height = textBoxHeight;
            slvAddrTB.Width = textBoxWidth;
            slvAddrTB.Location = wGroupContentOriginPoint;
            slvAddrTB.Name = "slaveAddressTextBox" + iterationCounter;

            // add an label for databyte textboxes
            Label dataByteLabel = new Label();
            dataByteLabel.Location = new Point(wGroupContentOriginPoint.X + textBoxHOffset, wGroupContentOriginPoint.Y - 20 - (iterationCounter * 150));
            dataByteLabel.Text = "dataBytes:";
           

            // Add dataByte Count dynamically
            for (int i = 0; i<dataByteCount; i++)
            {
                TextBox dataByteTB = new TextBox();
                dataByteTB.Height = textBoxHeight;
                dataByteTB.Width = textBoxWidth;
                dataByteTB.Location = new Point(wGroupContentOriginPoint.X + textBoxHOffset, wGroupContentOriginPoint.Y +(i* 25) - (iterationCounter * 150));
                dataByteTB.Name = "dataByteTextBox" + i;

                // add dataByteText Box to target Form
                wGroup.Controls.Add(dataByteTB);
            }

            // add a send button
            Button sendButton = new Button();
            sendButton.Width = buttonWidth;
            sendButton.Height = buttonHeigt;
            sendButton.Text = "send" + iterationCounter;
            sendButton.Name = "sendButton" + iterationCounter;
            sendButton.Location = new Point(wGroupContentOriginPoint.X + textBoxWidth + 80, wGroupContentOriginPoint.Y - (iterationCounter * 150));


            // add all non-dynamic components
            wGroup.Controls.Add(slvAddrTB);
            wGroup.Controls.Add(sendButton);
            wGroup.Controls.Add(dataByteLabel);
            wGroup.Controls.Add(slvAddrTBLabel);

            // add groupbox to target form
            targetForm.Controls.Add(wGroup);
        }
    }
}
