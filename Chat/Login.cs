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
        public static bool isAuth = false;
        bool newUser = false;
        int currentUserIndex;
        Dictionary<string, User> userDictionary;
        List<User> userList = new List<User>();
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "inXj8sTPJUWlgLwQVJZSR2p4NR7EeJ4xZwHobH09",
            BasePath = "https://poli-chat-db-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            if (client != null) { }
            //MessageBox.Show("conn established"); 
            else
                MessageBox.Show("Connection error"); 
        }
        private async void Get_users()
        {
            var response = await client.GetAsync("users");
            userDictionary = response.ResultAs<Dictionary<string, User>>();
            if(userDictionary!=null)
            {
                var aux = from x in userDictionary select x;
                foreach(var item in aux)
                {
                    userList.Add(item.Value);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(newUser)
            {
                Get_users();
            }
            string current_username = textBox1.Text;
            string current_password = textBox2.Text;
            if (current_password == "" || current_username == "")
            {
                MessageBox.Show("Please insert Username and password!");
            }
            else
            {
                
                for (int i = 0; i < userList.Count; i++)
                {
                    if(userList[i].username==current_username && userList[i].password==current_password)
                    {
                        isAuth = true;
                        currentUserIndex = i;
                        break;
                    }
                }
                if(isAuth)
                {
                    textBox2.Text = "";
                    this.Hide();
                    MainForm mainForm = new MainForm(this,userList[currentUserIndex].fullName);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong Username or password!");
                }
            }
            
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Get_users();
        }

        private void label_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newUser = true;
            this.Hide();
            Register registerForm = new Register(this);
            registerForm.ShowDialog();
        }
    }
}
