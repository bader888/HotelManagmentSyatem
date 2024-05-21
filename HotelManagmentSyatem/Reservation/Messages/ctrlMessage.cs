using HotelLogic;
using HotelManagmentSyatem.Global_Classes;
using System;
using System.Windows.Forms;

namespace HotelManagmentSyatem.Reservation.Messages
{
    public partial class ctrlMessage : UserControl
    {

        int MsgID = -1;
        clsMessage _message;


        public ctrlMessage()
        {
            InitializeComponent();
        }

        private void ResetMsgValues()
        {
            lblMsgDate.Text = "[??-??]";
            lblMsgTitle.Text = "[???????]";

        }
        private void ShowMessageData()
        {

            lblMsgDate.Text = clsFormat.DateToShort((DateTime)_message.MsgDate);
            lblMsgTitle.Text = _message.MsgSubject;

            this.Tag = _message.messageID;

        }

        public void LoadMessageData(int MsgID)
        {
            _message = clsMessage.FindMessageByID(MsgID);
            if (_message == null)
                ResetMsgValues();

            ShowMessageData();


        }

        private void bunifuPanel9_Click(object sender, EventArgs e)
        {
            if (_message != null)

                MessageBox.Show(_message.MsgBody, _message.MsgSubject, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}