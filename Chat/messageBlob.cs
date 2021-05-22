using System;
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
        public messageBlob(string message, string timestamp, Boolean sender, string initial)
        {
            InitializeComponent();
            this.message = message;
            this.sender = sender;
            this.initial = initial;
            this.timestamp = timestamp;
            label1.Text = message;
            label2.Text = initial;
            label3.Text = timestamp;

            if (!sender)
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
    }
}
