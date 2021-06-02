using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class MainForm : Form
    {
        public static User otherUser;
        Login pointer;
        private Color[] colorScheme;
        private string colorMode;
        static List<Message> messageListLocal = new List<Message>();
        static List<MessageBlob> messageBlobList = new List<MessageBlob>();
        public MessageController mc;
        ContactUserControl[] contactList = new ContactUserControl[Login.userList.Count];

        public MainForm(Login point)
        {
            pointer = point;
            InitializeComponent();
            populateList();
            colorScheme = new Color[] { Color.FromArgb(221, 228, 225), Color.FromArgb(112, 164, 194), Color.FromArgb(53, 58, 90) };
            colorMode = "LIGHT";
            RefreshColorScheme(colorMode);
        }

        private void SetColorScheme(Color lightColor, Color mediumColor, Color darkColor)
        {
            colorScheme[0] = lightColor;
            colorScheme[1] = mediumColor;
            colorScheme[2] = darkColor;
        }

        private void RefreshColorScheme(string colorMode)
        {
            if (colorMode.Equals("LIGHT"))
            {
                BackColor = colorScheme[1];
                menuStrip.BackColor = colorScheme[0];
                groupBox_conv.BackColor = colorScheme[1];
                groupBox_myProfile.BackColor = colorScheme[1];
                messagesFlowLayout.BackColor = colorScheme[0];
                richTextBox_conv.BackColor = colorScheme[0];
                contactListFlowLayoutPanel.BackColor = colorScheme[0];
                foreach (ContactUserControl contact in contactListFlowLayoutPanel.Controls)
                    contact.paintPanel(colorScheme[2]);
                groupBox_conv.ForeColor = Color.Black;
                groupBox_myProfile.ForeColor = Color.Black;
                label_darkMode.ForeColor = Color.Black;
                foreach (MessageBlob msb in messagesFlowLayout.Controls)
                    if (msb.getSender())
                    {
                        msb.BackColor = colorScheme[2];
                        msb.ForeColor = colorScheme[0];
                    }
                    else
                    {
                        msb.BackColor = colorScheme[1];
                        msb.ForeColor = Color.Black;
                    }
            }
            else if (colorMode.Equals("DARK"))
            {
                BackColor = colorScheme[2];
                menuStrip.BackColor = colorScheme[0];
                groupBox_conv.BackColor = colorScheme[2];
                groupBox_myProfile.BackColor = colorScheme[2];
                messagesFlowLayout.BackColor = colorScheme[1];
                richTextBox_conv.BackColor = colorScheme[1];
                contactListFlowLayoutPanel.BackColor = colorScheme[1];
                foreach (ContactUserControl contact in contactListFlowLayoutPanel.Controls)
                    contact.paintPanel(colorScheme[0]);
                groupBox_conv.ForeColor = colorScheme[0];
                groupBox_myProfile.ForeColor = colorScheme[0];
                label_darkMode.ForeColor = colorScheme[0];
                foreach (MessageBlob msb in messagesFlowLayout.Controls)
                    if (msb.getSender())
                    {
                        msb.BackColor = colorScheme[0];
                        msb.ForeColor = Color.Black;
                    }
                    else
                    {
                        msb.BackColor = colorScheme[2];
                        msb.ForeColor = colorScheme[0];
                    }
            }
        }

        private void blueLagoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(221, 228, 225), Color.FromArgb(112, 164, 194), Color.FromArgb(53, 58, 90));
            RefreshColorScheme(colorMode);
        }

        private void pinkDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(234, 202, 195), Color.FromArgb(242, 166, 190), Color.FromArgb(133, 128, 179));
            RefreshColorScheme(colorMode);
        }

        private void richBurgundyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(184, 179, 189), Color.FromArgb(109, 54, 85), Color.FromArgb(82, 0, 37));
            RefreshColorScheme(colorMode);
        }

        private void springGreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(196, 216, 172), Color.FromArgb(143, 204, 147), Color.FromArgb(73, 110, 110));
            RefreshColorScheme(colorMode);
        }

        private void tourquoiseDreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(227, 242, 227), Color.FromArgb(17, 164, 166), Color.FromArgb(29, 76, 94));
            RefreshColorScheme(colorMode);
        }

        private void vintageHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(183, 204, 192), Color.FromArgb(207, 129, 119), Color.FromArgb(63, 61, 82));
            RefreshColorScheme(colorMode);
        }

        private void violetBluesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetColorScheme(Color.FromArgb(255, 252, 235), Color.FromArgb(139, 149, 201), Color.FromArgb(73, 67, 104));
            RefreshColorScheme(colorMode);
        }

        private void trackBar_darkMode_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_darkMode.Value == 0)
                colorMode = "LIGHT";
            else
                colorMode = "DARK";
            RefreshColorScheme(colorMode);
        }

        private void populateList()
        {

            string university = Login.userList[Login.currentUserIndex].faculty;
            for (int i = 0; i < contactList.Length; i++)
            {
                if (i != Login.currentUserIndex && Login.userList[i].faculty == university)
                {
                    contactList[i] = new ContactUserControl(this);
                    contactList[i].UserName = Login.userList[i].username;
                    contactList[i].pictureBox1.ImageLocation = Login.userList[i].picture;
                    contactList[i].UserEntity = Login.userList[i];
                    contactListFlowLayoutPanel.Controls.Add(contactList[i]);
                }
            }
            label_nrContacte.Text = contactListFlowLayoutPanel.Controls.Count + " contacts";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            messagesFlowLayout.Invoke((MethodInvoker)(() => messagesFlowLayout.Controls.Clear()));
            Login.userDictionary.Clear();
            Login.userList.Clear();
            Login.userKeys.Clear();
            for (int i = 0; i < contactList.Length; i++)
            {
                contactList[i] = null;
            }
            if (Login.running == false)
            {
                Login.Get_users();
            }
            Login.isAuth = false;
            pointer.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_ageContact.Text = "";
            label_cityContact.Text = "";
            label_username.Text = Login.userList[Login.currentUserIndex].fullName;
            label_varsta.Text = Login.userList[Login.currentUserIndex].age;
            label_city.Text = Login.userList[Login.currentUserIndex].city;
            labelFaculty.Text = Login.userList[Login.currentUserIndex].faculty;
            pictureBox1.ImageLocation = Login.userList[Login.currentUserIndex].picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            mc = new MessageController(Login.userList[Login.currentUserIndex].username, "", this);
            //if (contactListFlowLayoutPanel.Controls.Count > 0)
            //{
            //    mc.updateOtherUser(contactList[0].UserEntity);
            //    updateOtherUserData(contactList[0].UserEntity);
            //}
        }

        public void updateOtherUserData(User otherUserEntity)
        {
            label_ageContact.Invoke((MethodInvoker)(() => label_ageContact.Text = otherUserEntity.age));
            label_cityContact.Invoke((MethodInvoker)(() => label_cityContact.Text = otherUserEntity.city));
            pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.ImageLocation = otherUserEntity.picture));
            groupBox_conv.Invoke((MethodInvoker)(() => groupBox_conv.Text = otherUserEntity.username));
        }

        public void updateMessageView(List<Message> messageList, string currentUser, string otherUser)
        {
            try
            {
                lock (((ICollection)messageList).SyncRoot)
                {
                    messagesFlowLayout.Invoke((MethodInvoker)(() => messagesFlowLayout.Controls.Clear()));
                    foreach (var x in messageList)
                    {
                        MessageBlob msb = new MessageBlob(x.message, x.timestamp, x.sender == currentUser, Char.ToString(x.sender[0]).ToUpper());
                        messagesFlowLayout.Invoke((MethodInvoker)(() => messagesFlowLayout.Controls.Add(msb)));
                    }
                }
            }
            catch { };
        }

        private async void richTextBox_conv_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (richTextBox_conv.Text.Length > 0)
                {
                    e.Handled = true;
                    DateTime now = DateTime.Now;
                    string format = "G";
                    CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("ro-RO");
                    string time = now.ToString(format, cultureInfo);
                    String message = richTextBox_conv.Text;
                    richTextBox_conv.Text = "";
                    richTextBox_conv.SelectionStart = 0;
                    var messag = new Message
                    {
                        dts = (DateTime?)null,
                        timestamp = time,
                        messageType = "TEXT",
                        message = message,
                        mediaUrl = "",
                        sender = Login.userList[Login.currentUserIndex].username
                    };

                    string aux;
                    string firstUser = messag.sender;
                    string secondUser = otherUser.username;
                    if (String.Compare(firstUser, secondUser) > 0)
                    {
                        aux = firstUser;
                        firstUser = secondUser;
                        secondUser = aux;
                    }
                    PushResponse response = await Login.client.PushAsync("messages/" + firstUser + "_" + secondUser, messag);
                }
            }
        }

        private void messagesFlowLayout_ControlAdded(object sender, ControlEventArgs e)
        {
            messagesFlowLayout.ScrollControlIntoView(e.Control);
            RefreshColorScheme(colorMode);
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountEdit accountEdit = new AccountEdit(pointer, this);
            accountEdit.ShowDialog();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountEdit accountEdit = new AccountEdit(pointer, this);
            accountEdit.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void textBox_searchContact_TextChanged(object sender, EventArgs e)
        {
            if (textBox_searchContact.Text != "")
            {
                string contactNameTemplate = textBox_searchContact.Text;
                ArrayList newUserList = new ArrayList();
                contactListFlowLayoutPanel.Controls.Clear();
                for (int i = 0; i < Login.userList.Count; i++)
                {
                    if (i != Login.currentUserIndex && Login.userList[i].username.Contains(contactNameTemplate))
                    {
                        ContactUserControl aux = new ContactUserControl(this);
                        aux.UserName = Login.userList[i].username;
                        aux.pictureBox1.ImageLocation = Login.userList[i].picture;
                        aux.UserEntity = Login.userList[i];
                        contactListFlowLayoutPanel.Controls.Add(aux);
                    }
                }
            }
            else
            {
                contactListFlowLayoutPanel.Controls.Clear();
                for (int i = 0; i < contactList.Length; i++)
                {
                    contactListFlowLayoutPanel.Controls.Add(contactList[i]);
                }
            }
            RefreshColorScheme(colorMode);
        }
    }
}
