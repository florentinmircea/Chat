using System.Windows.Forms;
namespace Chat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBox_conv = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.groupBox_myProfile = new System.Windows.Forms.GroupBox();
            this.label_city = new System.Windows.Forms.Label();
            this.label_nrContacte = new System.Windows.Forms.Label();
            this.label_varsta = new System.Windows.Forms.Label();
            this.textBox_searchContact = new System.Windows.Forms.TextBox();
            this.button_searchContact = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_conv = new System.Windows.Forms.GroupBox();
            this.label_cityContact = new System.Windows.Forms.Label();
            this.label_ageContact = new System.Windows.Forms.Label();
            this.contactListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_myProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_conv.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(468, 410);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // listBox_conv
            // 
            this.listBox_conv.FormattingEnabled = true;
            this.listBox_conv.ItemHeight = 28;
            this.listBox_conv.Location = new System.Drawing.Point(16, 83);
            this.listBox_conv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_conv.Name = "listBox_conv";
            this.listBox_conv.Size = new System.Drawing.Size(441, 228);
            this.listBox_conv.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.label_username.Location = new System.Drawing.Point(109, 24);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(162, 45);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "username";
            // 
            // groupBox_myProfile
            // 
            this.groupBox_myProfile.Controls.Add(this.label_city);
            this.groupBox_myProfile.Controls.Add(this.label_nrContacte);
            this.groupBox_myProfile.Controls.Add(this.label_varsta);
            this.groupBox_myProfile.Controls.Add(this.pictureBox1);
            this.groupBox_myProfile.Controls.Add(this.label_username);
            this.groupBox_myProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_myProfile.Location = new System.Drawing.Point(12, 5);
            this.groupBox_myProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_myProfile.Name = "groupBox_myProfile";
            this.groupBox_myProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_myProfile.Size = new System.Drawing.Size(446, 122);
            this.groupBox_myProfile.TabIndex = 5;
            this.groupBox_myProfile.TabStop = false;
            this.groupBox_myProfile.Text = "My profile";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label_city.Location = new System.Drawing.Point(109, 78);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(39, 23);
            this.label_city.TabIndex = 7;
            this.label_city.Text = "City";
            // 
            // label_nrContacte
            // 
            this.label_nrContacte.AutoSize = true;
            this.label_nrContacte.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label_nrContacte.Location = new System.Drawing.Point(109, 96);
            this.label_nrContacte.Name = "label_nrContacte";
            this.label_nrContacte.Size = new System.Drawing.Size(77, 23);
            this.label_nrContacte.TabIndex = 6;
            this.label_nrContacte.Text = "Contacts";
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label_varsta.Location = new System.Drawing.Point(109, 60);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(40, 23);
            this.label_varsta.TabIndex = 5;
            this.label_varsta.Text = "Age";
            // 
            // textBox_searchContact
            // 
            this.textBox_searchContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_searchContact.Location = new System.Drawing.Point(121, 131);
            this.textBox_searchContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_searchContact.Name = "textBox_searchContact";
            this.textBox_searchContact.Size = new System.Drawing.Size(337, 34);
            this.textBox_searchContact.TabIndex = 7;
            // 
            // button_searchContact
            // 
            this.button_searchContact.Location = new System.Drawing.Point(27, 136);
            this.button_searchContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_searchContact.Name = "button_searchContact";
            this.button_searchContact.Size = new System.Drawing.Size(78, 23);
            this.button_searchContact.TabIndex = 8;
            this.button_searchContact.Text = "Search";
            this.button_searchContact.UseVisualStyleBackColor = true;
            this.button_searchContact.Click += new System.EventHandler(this.button_searchContact_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(16, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 52);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 330);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 42);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // groupBox_conv
            // 
            this.groupBox_conv.Controls.Add(this.label_cityContact);
            this.groupBox_conv.Controls.Add(this.label_ageContact);
            this.groupBox_conv.Controls.Add(this.pictureBox2);
            this.groupBox_conv.Controls.Add(this.richTextBox1);
            this.groupBox_conv.Controls.Add(this.listBox_conv);
            this.groupBox_conv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_conv.Location = new System.Drawing.Point(474, 10);
            this.groupBox_conv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_conv.Name = "groupBox_conv";
            this.groupBox_conv.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_conv.Size = new System.Drawing.Size(473, 385);
            this.groupBox_conv.TabIndex = 8;
            this.groupBox_conv.TabStop = false;
            this.groupBox_conv.Text = "usenameContact";
            // 
            // label_cityContact
            // 
            this.label_cityContact.AutoSize = true;
            this.label_cityContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_cityContact.Location = new System.Drawing.Point(99, 55);
            this.label_cityContact.Name = "label_cityContact";
            this.label_cityContact.Size = new System.Drawing.Size(34, 20);
            this.label_cityContact.TabIndex = 12;
            this.label_cityContact.Text = "City";
            // 
            // label_ageContact
            // 
            this.label_ageContact.AutoSize = true;
            this.label_ageContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_ageContact.Location = new System.Drawing.Point(99, 35);
            this.label_ageContact.Name = "label_ageContact";
            this.label_ageContact.Size = new System.Drawing.Size(36, 20);
            this.label_ageContact.TabIndex = 9;
            this.label_ageContact.Text = "Age";
            // 
            // contactListFlowLayoutPanel
            // 
            this.contactListFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contactListFlowLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contactListFlowLayoutPanel.Location = new System.Drawing.Point(12, 174);
            this.contactListFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactListFlowLayoutPanel.Name = "contactListFlowLayoutPanel";
            this.contactListFlowLayoutPanel.Size = new System.Drawing.Size(446, 227);
            this.contactListFlowLayoutPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 247);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 410);
            this.Controls.Add(this.contactListFlowLayoutPanel);
            this.Controls.Add(this.groupBox_conv);
            this.Controls.Add(this.button_searchContact);
            this.Controls.Add(this.textBox_searchContact);
            this.Controls.Add(this.groupBox_myProfile);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_myProfile.ResumeLayout(false);
            this.groupBox_myProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_conv.ResumeLayout(false);
            this.groupBox_conv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MainForm(int code) // code o sa fie asociat pt fiacare user, si dupa asta putem sti care utilizator este logat
        {
            InitializeComponent();
            MessageBox.Show(code.ToString());
        }

        private Splitter splitter1;
        private ListBox listBox_conv;
        private PictureBox pictureBox1;
        private Label label_username;
        private GroupBox groupBox_myProfile;
        private Label label_nrContacte;
        private Label label_varsta;
        private TextBox textBox_searchContact;
        private Button button_searchContact;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Label label_city;
        private GroupBox groupBox_conv;
        private Label label_cityContact;
        private Label label_ageContact;
        private FlowLayoutPanel contactListFlowLayoutPanel;
        private Panel panel1;
    }
}