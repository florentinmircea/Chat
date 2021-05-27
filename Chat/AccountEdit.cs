﻿using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class AccountEdit : Form
    {
        Login pointer;
        MainForm pointerMainForm;
        static Dictionary<string, Faculty> facultiesDictionary;
        static List<Faculty> facultiesList = new List<Faculty>();
        public AccountEdit(Login point,MainForm pointerMain)
        {
            pointer = point;
            pointerMainForm = pointerMain;
            InitializeComponent();
            PaintForm();
        }

        private void PaintForm()
        {
            Color lightColor = Color.FromArgb(221, 228, 225);
            Color mediumColor = Color.FromArgb(112, 164, 194);
            Color darkColor = Color.FromArgb(53, 58, 90);
            BackColor = lightColor;
            update_btn.BackColor = mediumColor;
            update_btn.ForeColor = darkColor;
            delete_btn.BackColor = Color.DarkRed;
            delete_btn.ForeColor = Color.White;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.ForeColor = darkColor;
            }
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await Login.client.DeleteAsync("users/"+Login.userKeys[Login.currentUserIndex]);
            if(response.StatusCode.ToString().Equals("OK"))
            {
                MessageBox.Show("User deleted!");
                this.Close();
                pointerMainForm.Close();
                Login.userDictionary.Clear();
                Login.userList.Clear();
                Login.Get_users();
                pointer.textBox1.Text = "";
                pointer.ActiveControl = pointer.textBox1;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            bool isMailValid = false;
            string Email = email_text.Text, Fullname = fullName_text.Text, Username = username_text.Text, Password = textBox7.Text, Confirmpassword = textBox8.Text, Picturelink = pictureLink_text.Text, City = city_text.Text, Age = age_text.Text, Faculty = faculty_combo.SelectedItem.ToString();
            if (Email.Length > 6)
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                isMailValid = addr.Address == Email ? true : false;
            }

            if (isMailValid && Fullname.Length > 6 && Username.Length > 6 && Picturelink.Length > 6 && Convert.ToInt32(Age) > 17 && City.Length > 4 && faculty_combo.SelectedIndex > -1)
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

                    FirebaseResponse response = await Login.client.UpdateAsync("users/" + Login.userKeys[Login.currentUserIndex], user);
                    MessageBox.Show("User updated! \nLog in again to see the changes ");
                    Login.userDictionary.Clear();
                    Login.userList.Clear();
                    Login.Get_users();
                    this.Close();
                    pointerMainForm.Close();
                }
                else
                {
                    MessageBox.Show("Password mismatch!");
                }
            }
            else
            {
                if (Convert.ToInt32(Age) > 17)
                    MessageBox.Show("Complete all the fields!");
                else
                    MessageBox.Show("Minimum age 17!");
            }
        }

        private void faculty_combo_DropDown(object sender, EventArgs e)
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

        private void AccountEdit_Load(object sender, EventArgs e)
        {
            Get_faculties();
            foreach (var item in facultiesList)
            {
                faculty_combo.Items.Add(item.name);
            }
            faculty_combo.SelectedItem = Login.userList[Login.currentUserIndex].faculty;
            fullName_text.Text = Login.userList[Login.currentUserIndex].fullName;
            age_text.Text = Login.userList[Login.currentUserIndex].age;
            city_text.Text = Login.userList[Login.currentUserIndex].city;
            pictureLink_text.Text = Login.userList[Login.currentUserIndex].picture;
            email_text.Text = Login.userList[Login.currentUserIndex].email;
            username_text.Text = Login.userList[Login.currentUserIndex].username;
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
    }
}
