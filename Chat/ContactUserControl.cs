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

        private User _user;

        public User UserEntity
        {
            get { return _user; }
            set { _user = value; }
        }


        public ContactUserControl(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private String _userName;

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; contactUsernameLabel.Text = value; }
        }

        private Image _profilePicture;

        public Image ProfilePicture
        {
            get { return _profilePicture; }
            set { _profilePicture = value; pictureBox1.Image = value; }
        }

        public void paintPanel(Color color)
        {
            panel2.BackColor = color;
        }

        private void ContactUserControl_Click(object sender, EventArgs e)
        {
            mainForm.mc.updateOtherUser(_user);
            mainForm.updateOtherUserData(_user);
            MainForm.otherUser = _user;
        }

        private void ContactUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.mc.updateOtherUser(_user);
            mainForm.updateOtherUserData(_user);
            MainForm.otherUser = _user;
        }

        private void contactUsernameLabel_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.mc.updateOtherUser(_user);
            mainForm.updateOtherUserData(_user);
            MainForm.otherUser = _user;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.mc.updateOtherUser(_user);
            mainForm.updateOtherUserData(_user);
            MainForm.otherUser = _user;
        }

        private void contactLastMessageLabel_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.mc.updateOtherUser(_user);
            mainForm.updateOtherUserData(_user);
            MainForm.otherUser = _user;
        }
    }
}
