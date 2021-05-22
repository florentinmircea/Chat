using FireSharp.Config;
using FireSharp.Interfaces;
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
    public partial class MainForm : Form
    {
        Login pointer;
        private Color[] colorScheme;
        private string colorMode;
        static Dictionary<string,Message> messageDictionary;
        static List<Message> messageList = new List<Message>();
        static List<messageBlob> messageBlobList = new List<messageBlob>();
        public MainForm(Login point)
        {
            pointer = point;
            InitializeComponent();
            populateList();
            checkList();
            contactListFlowLayoutPanel.AutoScroll = true;
            colorScheme = new Color[] { Color.FromArgb(221, 228, 225), Color.FromArgb(112, 164, 194), Color.FromArgb(53, 58, 90) };
            colorMode = "LIGHT";
            RefreshColorScheme(colorMode);
            client = new FireSharp.FirebaseClient(config);
            if (client != null) { }
            //MessageBox.Show("conn established"); 
            else
                MessageBox.Show("Connection error");

            message("cds", "ewcs");
        }

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "inXj8sTPJUWlgLwQVJZSR2p4NR7EeJ4xZwHobH09",
            BasePath = "https://poli-chat-db-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client;

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
                button_searchContact.BackColor = colorScheme[0];
                groupBox_conv.BackColor = colorScheme[1];
                groupBox_myProfile.BackColor = colorScheme[1];
                //listBox_conv.BackColor = colorScheme[0];
                richTextBox_conv.BackColor = colorScheme[0];
                contactListFlowLayoutPanel.BackColor = colorScheme[0];
                foreach (ContactUserControl contact in contactListFlowLayoutPanel.Controls)
                    contact.paintPanel(colorScheme[2]);
                groupBox_conv.ForeColor = Color.Black;
                groupBox_myProfile.ForeColor = Color.Black;
                label_darkMode.ForeColor = Color.Black;
            }
            else if (colorMode.Equals("DARK"))
            {
                BackColor = colorScheme[2];
                menuStrip.BackColor = colorScheme[0];
                button_searchContact.BackColor = colorScheme[0];
                groupBox_conv.BackColor = colorScheme[2];
                groupBox_myProfile.BackColor = colorScheme[2];
                //listBox_conv.BackColor = colorScheme[1];
                richTextBox_conv.BackColor = colorScheme[1];
                contactListFlowLayoutPanel.BackColor = colorScheme[1];
                foreach (ContactUserControl contact in contactListFlowLayoutPanel.Controls)
                    contact.paintPanel(colorScheme[0]);
                groupBox_conv.ForeColor = colorScheme[0];
                groupBox_myProfile.ForeColor = colorScheme[0];
                label_darkMode.ForeColor = colorScheme[0];
            }
        }



        private void populateList()
        {
            ContactUserControl[] contactList = new ContactUserControl[10];
            for (int i = 0; i < contactList.Length; i++)
            {
                contactList[i] = new ContactUserControl(this);
                contactList[i].UserName = "Contact " + i;
                contactList[i].LastMessage = "Message blah";
                contactList[i].ProfilePicture = Resource.defaultProfilePicture;
                contactListFlowLayoutPanel.Controls.Add(contactList[i]);
            }
        }
        private void checkList()
        {
            // MessageBox.Show(contactListFlowLayoutPanel.Controls.Count.ToString());
        }
        private void button_searchContact_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pointer.Show();
            Login.isAuth = false;
        }

        private void groupBox_conv_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_username.Text = Login.userList[Login.currentUserIndex].fullName;
            label_varsta.Text = Login.userList[Login.currentUserIndex].age;
            label_city.Text = Login.userList[Login.currentUserIndex].city;
            pictureBox1.ImageLocation= Login.userList[Login.currentUserIndex].picture;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        public async void message(string currentUser, string otherUser)
        {
            //MessageBox.Show("Current user index : " + currentUser + ", Receiver User Index = " + otherUser);
            //alphabetical order
            currentUser = "florentinmircea";
            otherUser =  "robertbudai";

            var response = await client.GetAsync("messages/"+currentUser+"_"+otherUser);
            messageDictionary = response.ResultAs<Dictionary<string, Message>>();
            if (messageDictionary != null)
            {
                var aux = from x in messageDictionary select x;
                foreach (var item in aux)
                {
                    messageList.Add(item.Value);
                }
            }
            //messageList.Sort()
            //order messages
            updateView(messageList, currentUser, otherUser);
        }
        public void updateView(List<Message> messageList, string currentUser, string otherUser)
        {
            foreach (var x in messageList)
            {
                messageBlob msb = new messageBlob(x.message, x.timestamp,x.sender==currentUser, Char.ToString(x.sender[0]).ToUpper());
                messageBlobList.Add(msb);
                messagesFlowLayout.Controls.Add(msb);
            }
        }
    }

}
