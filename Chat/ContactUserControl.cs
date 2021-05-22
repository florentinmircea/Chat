using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class ContactUserControl : UserControl
    {
        //private string 
        MainForm mainForm;

        public ContactUserControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        private String _userName;

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; contactUsernameLabel.Text = value; }
        }

        private String _lastMessage;

        public String LastMessage
        {
            get { return _lastMessage; }
            set { _lastMessage = value; contactLastMessageLabel.Text = value; }
        }

        private Image _profilePicture;

        public Image ProfilePicture
        {
            get { return _profilePicture; }
            set { _profilePicture = value; pictureBox1.Image = value; }
        }

        private void ContactUserControl_Load(object sender, EventArgs e)
        {

        }

        public void paintPanel(Color color)
        {
            panel2.BackColor = color;
        }

        private void contactLastMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactUserControl_Click(object sender, EventArgs e)
        {
            mainForm.messageModel("v","vds");
        }
    }
}
