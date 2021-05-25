using System;
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
    public partial class AccountEdit : Form
    {
        static Dictionary<string, Faculty> facultiesDictionary;
        static List<Faculty> facultiesList = new List<Faculty>();
        public AccountEdit()
        {
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User deleted!");
            //needs implementation
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User updated!");
            //needs implementation
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

        private void AccountEdit_Load(object sender, EventArgs e)
        {
            Get_faculties();
            foreach (var item in facultiesList)
            {
                faculty_combo.Items.Add(item.name);
            }
            faculty_combo.SelectedItem= Login.userList[Login.currentUserIndex].faculty;
            fullName_text.Text=Login.userList[Login.currentUserIndex].fullName;
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
