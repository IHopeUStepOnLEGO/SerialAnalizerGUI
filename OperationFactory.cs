using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SerialGUI
{

    /*** IOperation interface ***/
    public interface IOperation
    {

    }

    /*** ReadOperation Class ***/
    public class ReadOperation : IOperation
    {
        GroupBox targetGroupBox;

        // private values to hold form and offset of controls added by this class
        private int _textBoxWidth = 60;
        private int _textBoxHeight = 20;
        private int _textBoxHOffset = 70;
        private int _buttonWidth = 50;
        private int _buttonHeight = 20;

        private int _groupBoxHeight;
        private int _groupBoxWidth = 250;

        // properties to change the private values from outside
        public int TextBoxWidth
        {
            get { return _textBoxWidth; }
            set { _textBoxWidth = value; }
        }

        public int TextBoxHeight
        {
            get { return _textBoxHeight; }
            set { _textBoxHeight = value; }
        }

        public int TextBoxHOffset
        {
            get { return _textBoxHOffset; }
            set { _textBoxHOffset = value; }
        }

        public int ButtonWidth
        {
            get { return _buttonWidth; }
            set { _buttonWidth = value; }
        }

        public int ButtonHeight
        {
            get { return _buttonHeight; }
            set { _buttonHeight = value; }
        }

        public int GroupBoxHeight
        {
            get { return _groupBoxHeight; }
            set { _groupBoxHeight = value; }
        }

        public int GroupBoxWidth
        {
            get { return _groupBoxWidth; }
        }
        public ReadOperation(Form targetForm, Point originPoint, int dataByteCount, int iterationCounter = 1)
        {
            // check if target form already has an group box for read operations
            if (targetForm.Controls.Find("readOperationGroupBox", false).FirstOrDefault() as GroupBox == null)
            {
                // create a GroupBox to hold all operations if not present
                GroupBox readOperationGroupBox = new GroupBox();
                readOperationGroupBox.Text = "read operations";
                readOperationGroupBox.Name = "readOperationGroupBox";
                readOperationGroupBox.Location = originPoint;
                readOperationGroupBox.Size = new Size(_groupBoxWidth, 40);

                // add GroupBox to targetForm
                targetForm.Controls.Add(readOperationGroupBox);
            }

            // for each read operation, create a GroupBox
            GroupBox rGroup = new GroupBox();
            rGroup.Location = new Point(originPoint.X + 200, originPoint.Y);
            rGroup.Text = "read" + iterationCounter;
            GroupBoxHeight = 40 + (dataByteCount * _textBoxHeight) + (dataByteCount + 1) * 5;
            rGroup.Size = new Size(230, _groupBoxHeight);
            rGroup.Name = "rGroupBox" + iterationCounter;

            // add groupbox to target form
            GroupBox targetGroupBox = targetForm.Controls.Find("readOperationGroupBox", true).FirstOrDefault() as GroupBox;
            targetGroupBox.Height = _groupBoxHeight;
            targetGroupBox.Controls.Add(rGroup);

            Point rGroupContentOriginPoint = new Point(originPoint.X + _groupBoxWidth, originPoint.Y + 20);

            // add an label for slaveAddress textbox 
            Label slvAddrTBLabel = new Label();
            slvAddrTBLabel.Location = new Point(rGroupContentOriginPoint.X - 10, rGroupContentOriginPoint.Y - 20 - (iterationCounter * _groupBoxHeight));
            slvAddrTBLabel.Text = "rSlaveAddress:";
            slvAddrTBLabel.Name = "rSlaveAddressLabel" + iterationCounter;


            // add slaveAddressTextBox
            TextBox slvAddrTB = new TextBox();
            slvAddrTB.Height = _textBoxHeight;
            slvAddrTB.Width = _textBoxWidth;
            slvAddrTB.Location = new Point(rGroupContentOriginPoint.X, rGroupContentOriginPoint.Y - (iterationCounter * _groupBoxHeight));
            slvAddrTB.Name = "rSlaveAddressTextBox" + iterationCounter;


            // Add dataByte textbox to receive
            TextBox dataByteTB = new TextBox();
            dataByteTB.Height = _textBoxHeight;
            dataByteTB.Width = _textBoxWidth;
            dataByteTB.Location = new Point(rGroupContentOriginPoint.X + _textBoxHOffset, rGroupContentOriginPoint.Y + 25 - (iterationCounter * _groupBoxHeight));
            dataByteTB.Name = "rDataByteTextBox" + iterationCounter;

            // add dataByteText Box to target Form
            rGroup.Controls.Add(dataByteTB);

            // add a receive button
            Button receiveButton = new Button();
            receiveButton.Width = _buttonWidth;
            receiveButton.Height = _buttonHeight;
            receiveButton.Text = "receive" + iterationCounter;
            receiveButton.Name = "rReceiveButton" + iterationCounter;
            receiveButton.Location = new Point(rGroupContentOriginPoint.X + _textBoxWidth + 80, rGroupContentOriginPoint.Y - (iterationCounter * this.GroupBoxHeight));

            // add all non-dynamic components
            rGroup.Controls.Add(slvAddrTB);
            rGroup.Controls.Add(receiveButton);
            //rGroup.Controls.Add(dataByteLabel);
            rGroup.Controls.Add(slvAddrTBLabel);

            // add groupbox to target form
            targetGroupBox = targetForm.Controls.Find("readOperationGroupBox", false).FirstOrDefault() as GroupBox;
            targetGroupBox.Height += _groupBoxHeight;
            targetGroupBox.Controls.Add(rGroup);
        }
    }

    /*** WriteOperation Class ***/
    public class WriteOperation : IOperation
    {
        GroupBox targetGroupBox;

        // private values to hold form and offset of controls added by this class
        private int _textBoxWidth = 60;
        private int _textBoxHeight = 20;
        private int _textBoxHOffset = 70;
        private int _buttonWidth = 50;
        private int _buttonHeight = 20;

        private int _groupBoxHeight;
        private int _groupBoxWidth = 250;

        // properties to change the private values from outside
        public int TextBoxWidth
        {
            get { return _textBoxWidth; }
            set { _textBoxWidth = value; }
        }

        public int TextBoxHeight
        {
            get { return _textBoxHeight; }
            set { _textBoxHeight = value; }
        }

        public int TextBoxHOffset
        {
            get { return _textBoxHOffset; }
            set { _textBoxHOffset = value; }
        }

        public int ButtonWidth
        {
            get { return _buttonWidth; }
            set { _buttonWidth = value; }
        }

        public int ButtonHeight
        {
            get { return _buttonHeight; }
            set { _buttonHeight = value; }
        }

        public int GroupBoxHeight
        {
            get { return _groupBoxHeight; }
            set { _groupBoxHeight = value; }
        }

        public int GroupBoxWidth
        {
            get { return _groupBoxWidth; }
        }

        public WriteOperation(Form targetForm, Point originPoint, int dataByteCount, int iterationCounter = 1)
        {
            // check if target form already has an group box for write operations

            if (targetForm.Controls.Find("writeOperationGroupBox", false).FirstOrDefault() as GroupBox == null)
            {
                // create a GroupBox to hold all operations
                GroupBox writeOperationGroupBox = new GroupBox();
                writeOperationGroupBox.Text = "write operations";
                writeOperationGroupBox.Name = "writeOperationGroupBox";
                writeOperationGroupBox.Location = originPoint;
                writeOperationGroupBox.Size = new Size(_groupBoxWidth, 40);

                // add GroupBox to targetForm
                targetForm.Controls.Add(writeOperationGroupBox);
            }

            // for each write operation, create a GroupBox
            GroupBox wGroup = new GroupBox();
            wGroup.Location = new Point(originPoint.X - 10, originPoint.Y+10);
            wGroup.Text = "write" + iterationCounter;
            GroupBoxHeight = 40 + (dataByteCount * _textBoxHeight) + (dataByteCount + 1) * 5;
            wGroup.Size = new Size(230, _groupBoxHeight);
            wGroup.Name = "wGroupBox" + iterationCounter;

            Point wGroupContentOriginPoint = new Point(originPoint.X - 5, originPoint.Y + 20);

            // add an label for slaveAddress textbox 
            Label slvAddrTBLabel = new Label();
            slvAddrTBLabel.Location = new Point(wGroupContentOriginPoint.X - 10, wGroupContentOriginPoint.Y - 20 - (iterationCounter * _groupBoxHeight));
            slvAddrTBLabel.Text = "slaveAddress:";
            slvAddrTBLabel.Name = "wSlaveAddressLabel" + iterationCounter;

            // add slaveAddressTextBox
            TextBox slvAddrTB = new TextBox();
            slvAddrTB.Height = _textBoxHeight;
            slvAddrTB.Width = _textBoxWidth;
            slvAddrTB.Location = new Point(wGroupContentOriginPoint.X, wGroupContentOriginPoint.Y - (iterationCounter * _groupBoxHeight));
            slvAddrTB.Name = "wSlaveAddressTextBox" + iterationCounter;

            // add an label for databyte textboxes
            Label dataByteLabel = new Label();
            dataByteLabel.Location = new Point(wGroupContentOriginPoint.X + _textBoxHOffset, wGroupContentOriginPoint.Y - 20 - (iterationCounter * _groupBoxHeight));
            dataByteLabel.Text = "dataBytes:";
            dataByteLabel.Name = "wdataBytes" + iterationCounter;

            // Add dataByte Count dynamically
            for (int i = 0; i < dataByteCount; i++)
            {
                TextBox dataByteTB = new TextBox();
                dataByteTB.Height = _textBoxHeight;
                dataByteTB.Width = _textBoxWidth;
                dataByteTB.Location = new Point(wGroupContentOriginPoint.X + _textBoxHOffset, wGroupContentOriginPoint.Y + (i * 25) - (iterationCounter * _groupBoxHeight));
                dataByteTB.Name = "wDataByteTextBox" + i;

                // add dataByteText Box to target Form
                wGroup.Controls.Add(dataByteTB);
            }

            // add a send button
            Button sendButton = new Button();
            sendButton.Width = _buttonWidth;
            sendButton.Height = _buttonHeight;
            sendButton.Text = "send" + iterationCounter;
            sendButton.Name = "wSendButton" + iterationCounter;
            sendButton.Location = new Point(wGroupContentOriginPoint.X + _textBoxWidth + 80, wGroupContentOriginPoint.Y - (iterationCounter * this.GroupBoxHeight));

            // add all non-dynamic components
            wGroup.Controls.Add(slvAddrTB);
            wGroup.Controls.Add(sendButton);
            wGroup.Controls.Add(dataByteLabel);
            wGroup.Controls.Add(slvAddrTBLabel);



            // add groupbox to target form
            targetGroupBox = targetForm.Controls.Find("writeOperationGroupBox", false).FirstOrDefault() as GroupBox;
            targetGroupBox.Height += _groupBoxHeight;
            targetGroupBox.Controls.Add(wGroup);
        }
    }

    /*** OperationType enumeration ***/
    public enum OperationType
    {
        Read,
        Write
    }

    /*** OperationFactory Class ***/
    class OperationFactory
    {
        public OperationFactory()
        {

        }

        public IOperation CreateOperation(OperationType type, Form targetForm, Point originPoint, int dataByteCount, int iterationCounter = 1)
        { 
            switch(type)
            {
                case OperationType.Read: 
                    return new ReadOperation(targetForm, originPoint, dataByteCount, iterationCounter);
                case OperationType.Write:
                    return new WriteOperation(targetForm, originPoint, dataByteCount, iterationCounter);
                default:
                    throw new NotSupportedException();
            }
            
        }
    }
}
