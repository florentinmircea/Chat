using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.MicroKernel.Registration;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Graph;

namespace Chat
{
    public partial class Login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "inXj8sTPJUWlgLwQVJZSR2p4NR7EeJ4xZwHobH09",
            BasePath = "https://poli-chat-db-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            if (client != null) { }
            //MessageBox.Show("conn established"); 
            else
                MessageBox.Show("Connection error"); 
        }
        private string users = "";
        async private void get_users()
        {
            //Task response = await client.Get(@"poli-chat-db-default-rtdb/users");
            //string ResUser = response.ResultAs<string>();// database result
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string current_username = textBox1.Text;
            string current_password = textBox2.Text;
            if (current_password == "" || current_username == "")
            {
                MessageBox.Show("Please insert Username and password!");
            }
            else
            {
                //get_users();
                //MessageBox.Show(users);
            }
            this.Hide();
            MainForm mainForm = new MainForm(this);
            mainForm.ShowDialog();
        }
    }
}
