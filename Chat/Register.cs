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
            bool isMailValid = false;
            string Email=email_Textbox.Text, Fullname=fullname_Textbox.Text, Username=username_Textbox.Text, Password=password_Textbox.Text, Confirmpassword=confirmPass_Textbox.Text, Picturelink=picture_Textbox.Text,City=city_Textbox.Text,Age=age_Textbox.Text;
            if(Email.Length > 6)
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                isMailValid = addr.Address == Email ? true : false;
            }
            
            if (isMailValid && Fullname.Length>6 && Username.Length>6 && Picturelink.Length>6 && Convert.ToInt32(Age)>17 && City.Length>4)
            {
                if(Password==Confirmpassword && Password.Length>=6)
                {
                    var user = new User
                    {
                        email = Email,
                        fullName=Fullname,
                        username=Username,
                        password=Password,
                        picture=Picturelink,
                        age=Age,
                        city=City
                    };
                    PushResponse response = await Login.client.PushAsync("users", user);
                    MessageBox.Show("User created!");
                    Login.Get_users();
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
                if(Convert.ToInt32(Age) > 17)
                    MessageBox.Show("Complete all the fields!");
                else
                    MessageBox.Show("Minimum age 17!");
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            pointer.Show();
        }
    }
}
