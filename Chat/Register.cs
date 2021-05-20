using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Chat
{
    public partial class Register : Form
    {
        Login pointer;
        public Register(Login point)
        {
            pointer = point;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Email=email_Textbox.Text, Fullname=fullname_Textbox.Text, Username=username_Textbox.Text, Password=password_Textbox.Text, Confirmpassword=confirmPass_Textbox.Text, Picturelink=picture_Textbox.Text;
            if(Email.Length>4 && Fullname.Length>4 && Username.Length>4 && Picturelink.Length>4)
            {
                if(Password==Confirmpassword)
                {
                    var user = new User
                    {
                        email = Email,
                        fullName=Fullname,
                        username=Username,
                        password=Password,
                        picture=Picturelink
                        
                    };
                    PushResponse response = await Login.client.PushAsync("users", user);
                    MessageBox.Show("User created!");
                    this.Close();
                    pointer.Show();
                }
                else
                {
                    MessageBox.Show("Password mismatch!");
                }
            }
            else
            {
                MessageBox.Show("Complete all the fields!");
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            pointer.Show();
        }
    }
}
