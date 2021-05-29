﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chat
{
    public partial class messageBlob : UserControl
    {
        private string message;
        private Boolean sender;
        private string initial;
        private string timestamp;
        private int nrOfLines;
        private int fontSize = 16;
        private int nrOfCharsInRow = 24;
        public messageBlob(string message, string timestamp, Boolean sender, string initial)
        {
            double aux = Convert.ToDouble(message.Length) / nrOfCharsInRow;
            nrOfLines = Convert.ToInt32(Math.Ceiling(aux));
            InitializeComponent();
            this.Height = 42 + (nrOfLines - 1) * fontSize;

            //this.panel2.Height = 15 + (nrOfLines - 1) * fontSize;
            this.panel1.Height = fontSize * nrOfLines;
            this.label1.Height = fontSize * nrOfLines;

            //this.panel3.Height = 60;
            //this.panel2.Dock = DockStyle.Top;
            //this.panel3.Dock = DockStyle.Bottom;
            //this.label3.Dock = DockStyle.Bottom;
            //this.label3.Location = new Point(25, 0);

            for (int j = 1; j < nrOfLines; j++ )
            {
                for (int i = 23; i >0; i--)
                {
                    if (message[24 * (j-1) + i] == ' ')
                    {
                        message = message.Insert(24 * (j-1) + i, "\n");
                        i = 0;
                    }
                }
            }
            this.message = message;
            this.sender = sender;
            this.initial = initial;
            this.timestamp = timestamp;
            label1.Text = message;
            label2.Text = initial;
            label3.Text = timestamp;

            if (sender)
            {
                label1.Dock = DockStyle.Right;
                label2.Dock = DockStyle.Right;
                label3.Dock = DockStyle.Right;
            }
            else
            {
                label1.Dock = DockStyle.Left;
                label2.Dock = DockStyle.Left;
                label3.Dock = DockStyle.Left;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void messageBlob_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
