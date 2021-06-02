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
        public static bool running = false;
        public static int currentUserIndex;
        public static Dictionary<string, User> userDictionary;
        public static List<User> userList = new List<User>();
        public static List<string> userKeys = new List<string>();
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "inXj8sTPJUWlgLwQVJZSR2p4NR7EeJ4xZwHobH09",
            BasePath = "https://poli-chat-db-default-rtdb.firebaseio.com/"
        };
        public static IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
            PaintForm();
            client = new FireSharp.FirebaseClient(config);
            if (client != null) { }
            else
                MessageBox.Show("Connection error");
        }

        public static async void Get_users()
        {
            running = true;
            var response = await client.GetAsync("users");
            userDictionary = response.ResultAs<Dictionary<string, User>>();
            if (userDictionary != null)
            {
                var aux = from x in userDictionary select x;
                foreach (var item in aux)
                {
                    userList.Add(item.Value);
                    userKeys.Add(item.Key);
                }
            }
            running = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string current_username = textBox1.Text;
            string current_password = textBox2.Text;
            if (current_password == "" || current_username == "")
            {
                MessageBox.Show("Please insert username and/or password!");
            }
            else
            {

                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].username == current_username && userList[i].password == current_password)
                    {
                        isAuth = true;
                        currentUserIndex = i;
                        break;
                    }
                }
                if (isAuth)
                {
                    textBox2.Text = "";
                    this.Hide();
                    MainForm mainForm = new MainForm(this);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Get_users();
        }

        private void label_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register registerForm = new Register(this);
            registerForm.ShowDialog();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaintForm()
        {
            Color lightColor = Color.FromArgb(221, 228, 225);
            Color mediumColor = Color.FromArgb(112, 164, 194);
            Color darkColor = Color.FromArgb(53, 58, 90);
            BackColor = lightColor;
            button_login.BackColor = mediumColor;
            button_login.ForeColor = darkColor;
            button_exit.BackColor = mediumColor;
            button_exit.ForeColor = darkColor;
            pictureBox_logo.BackColor = lightColor;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = darkColor;
            }
        }
    }
}
