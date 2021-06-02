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
        static Dictionary<string, Faculty> facultiesDictionary;
        static List<Faculty> facultiesList = new List<Faculty>();

        public Register(Login point)
        {
            pointer = point;
            InitializeComponent();
            PaintForm();
        }

        private async void button_register_Click(object sender, EventArgs e)
        {
            bool isMailValid = false;
            string Email = email_Textbox.Text, Fullname = fullname_Textbox.Text, Username = username_Textbox.Text, Password = password_Textbox.Text, Confirmpassword = confirmPass_Textbox.Text, Picturelink = picture_Textbox.Text, City = city_Textbox.Text, Age = age_Textbox.Text, Faculty = comboBox1.SelectedItem.ToString();
            int resultAge;
            if (Email.Length > 6)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(Email);
                    isMailValid = addr.Address == Email ? true : false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Wrong email format");
                }
            }
            if (Picturelink.Length == 0)
            {
                Picturelink = "https://www.happitime.co.uk/images/uploads/profile.jpg";
            }

            if (isMailValid && Fullname.Length > 6 && Username.Length > 6 && Picturelink.Length > 6 && Int32.TryParse(Age, out resultAge) && resultAge >= 17 && City.Length > 4 && comboBox1.SelectedIndex > -1)
            {
                if (Password == Confirmpassword && Password.Length >= 6)
                {
                    var user = new User
                    {
                        email = Email,
                        fullName = Fullname,
                        username = Username,
                        password = Password,
                        picture = Picturelink,
                        age = Age,
                        city = City,
                        faculty = Faculty
                    };
                    PushResponse response = await Login.client.PushAsync("users", user);
                    MessageBox.Show("User created!");
                    Login.userDictionary.Clear();
                    Login.userList.Clear();
                    Login.userKeys.Clear();
                    facultiesDictionary.Clear();
                    facultiesList.Clear();
                    comboBox1.Items.Clear();
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
                if (!Int32.TryParse(Age, out resultAge))
                    MessageBox.Show("Complete all the fields!");
                else
                {
                    if (resultAge < 17)
                        MessageBox.Show("Minimum age 17!");
                    else
                        MessageBox.Show("Complete all the fields!");
                }
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            facultiesDictionary.Clear();
            facultiesList.Clear();
            comboBox1.Items.Clear();
            pointer.Show();
        }

        private void PaintForm()
        {
            Color lightColor = Color.FromArgb(221, 228, 225);
            Color mediumColor = Color.FromArgb(112, 164, 194);
            Color darkColor = Color.FromArgb(53, 58, 90);
            BackColor = lightColor;
            button_register.BackColor = mediumColor;
            button_register.ForeColor = darkColor;
            label_welcome.BackColor = lightColor;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = darkColor;
            }
        }

        public static void Get_faculties()
        {
            var response = Login.client.Get("faculties");
            facultiesDictionary = response.ResultAs<Dictionary<string, Faculty>>();
            if (facultiesDictionary != null)
            {
                var aux = from x in facultiesDictionary select x;
                foreach (var item in aux)
                {
                    facultiesList.Add(item.Value);
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.ActiveControl = fullname_Textbox;
            Get_faculties();
            foreach (var item in facultiesList)
            {
                comboBox1.Items.Add(item.name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }
    }
}
