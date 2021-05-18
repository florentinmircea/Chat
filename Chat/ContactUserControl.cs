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
        public ContactUserControl()
        {
            InitializeComponent();
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
    }
}
