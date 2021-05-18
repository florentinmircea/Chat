﻿using System;
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
        public MainForm(Login point)
        {
            pointer = point;
            InitializeComponent();
            populateList();
            checkList();
            contactListFlowLayoutPanel.AutoScroll = true;
        }

        private void populateList()
        {
            ContactUserControl[] contactList = new ContactUserControl[10];
            for (int i = 0; i < contactList.Length; i++)
            {
                contactList[i] = new ContactUserControl();
                contactList[i].UserName = "Contact " + i;
                contactList[i].LastMessage = "Message blah";
                contactList[i].ProfilePicture = Resource.defaultProfilePicture;
                contactListFlowLayoutPanel.Controls.Add(contactList[i]);
            }
        }
        private void checkList()
        {
            MessageBox.Show(contactListFlowLayoutPanel.Controls.Count.ToString());
        }
        private void button_searchContact_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pointer.Show();
        }
    }
}
