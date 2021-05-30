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
            this.label_username = new System.Windows.Forms.Label();
            this.groupBox_myProfile = new System.Windows.Forms.GroupBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_nrContacte = new System.Windows.Forms.Label();
            this.label_varsta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_searchContact = new System.Windows.Forms.TextBox();
            this.richTextBox_conv = new System.Windows.Forms.RichTextBox();
            this.groupBox_conv = new System.Windows.Forms.GroupBox();
            this.messagesFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label_cityContact = new System.Windows.Forms.Label();
            this.label_ageContact = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contactListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.colorSchemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueLagoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richBurgundyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.springGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tourquoiseDreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vintageHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetBluesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar_darkMode = new System.Windows.Forms.TrackBar();
            this.label_darkMode = new System.Windows.Forms.Label();
            this.groupBox_myProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_conv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_darkMode)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 29);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(351, 491);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(4, 22);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(120, 32);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "username";
            // 
            // groupBox_myProfile
            // 
            this.groupBox_myProfile.Controls.Add(this.labelFaculty);
            this.groupBox_myProfile.Controls.Add(this.label_city);
            this.groupBox_myProfile.Controls.Add(this.label_nrContacte);
            this.groupBox_myProfile.Controls.Add(this.label_varsta);
            this.groupBox_myProfile.Controls.Add(this.pictureBox1);
            this.groupBox_myProfile.Controls.Add(this.label_username);
            this.groupBox_myProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_myProfile.Location = new System.Drawing.Point(9, 33);
            this.groupBox_myProfile.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_myProfile.Name = "groupBox_myProfile";
            this.groupBox_myProfile.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_myProfile.Size = new System.Drawing.Size(334, 158);
            this.groupBox_myProfile.TabIndex = 5;
            this.groupBox_myProfile.TabStop = false;
            this.groupBox_myProfile.Text = "My profile";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaculty.Location = new System.Drawing.Point(122, 106);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(54, 20);
            this.labelFaculty.TabIndex = 8;
            this.labelFaculty.Text = "Faculty";
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_city.Location = new System.Drawing.Point(122, 80);
            this.label_city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(34, 20);
            this.label_city.TabIndex = 7;
            this.label_city.Text = "City";
            // 
            // label_nrContacte
            // 
            this.label_nrContacte.AutoSize = true;
            this.label_nrContacte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nrContacte.Location = new System.Drawing.Point(122, 131);
            this.label_nrContacte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nrContacte.Name = "label_nrContacte";
            this.label_nrContacte.Size = new System.Drawing.Size(66, 20);
            this.label_nrContacte.TabIndex = 6;
            this.label_nrContacte.Text = "Contacts";
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_varsta.Location = new System.Drawing.Point(122, 56);
            this.label_varsta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(36, 20);
            this.label_varsta.TabIndex = 5;
            this.label_varsta.Text = "Age";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_searchContact
            // 
            this.textBox_searchContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_searchContact.Location = new System.Drawing.Point(11, 202);
            this.textBox_searchContact.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_searchContact.Name = "textBox_searchContact";
            this.textBox_searchContact.Size = new System.Drawing.Size(334, 29);
            this.textBox_searchContact.TabIndex = 7;
            this.textBox_searchContact.TextChanged += new System.EventHandler(this.textBox_searchContact_TextChanged);
            // 
            // richTextBox_conv
            // 
            this.richTextBox_conv.Location = new System.Drawing.Point(8, 393);
            this.richTextBox_conv.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_conv.Name = "richTextBox_conv";
            this.richTextBox_conv.Size = new System.Drawing.Size(381, 56);
            this.richTextBox_conv.TabIndex = 11;
            this.richTextBox_conv.Text = "";
            this.richTextBox_conv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_conv_KeyDown_1);
            // 
            // groupBox_conv
            // 
            this.groupBox_conv.Controls.Add(this.messagesFlowLayout);
            this.groupBox_conv.Controls.Add(this.label_cityContact);
            this.groupBox_conv.Controls.Add(this.label_ageContact);
            this.groupBox_conv.Controls.Add(this.pictureBox2);
            this.groupBox_conv.Controls.Add(this.richTextBox_conv);
            this.groupBox_conv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox_conv.Location = new System.Drawing.Point(356, 55);
            this.groupBox_conv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.groupBox_conv.Name = "groupBox_conv";
            this.groupBox_conv.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_conv.Size = new System.Drawing.Size(397, 460);
            this.groupBox_conv.TabIndex = 8;
            this.groupBox_conv.TabStop = false;
            this.groupBox_conv.Text = "Select a contact to see the conversation";
            // 
            // messagesFlowLayout
            // 
            this.messagesFlowLayout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.messagesFlowLayout.AutoScroll = true;
            this.messagesFlowLayout.Location = new System.Drawing.Point(8, 84);
            this.messagesFlowLayout.Margin = new System.Windows.Forms.Padding(2);
            this.messagesFlowLayout.Name = "messagesFlowLayout";
            this.messagesFlowLayout.Size = new System.Drawing.Size(381, 302);
            this.messagesFlowLayout.TabIndex = 13;
            this.messagesFlowLayout.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messagesFlowLayout_ControlAdded);
            // 
            // label_cityContact
            // 
            this.label_cityContact.AutoSize = true;
            this.label_cityContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cityContact.Location = new System.Drawing.Point(64, 50);
            this.label_cityContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cityContact.Name = "label_cityContact";
            this.label_cityContact.Size = new System.Drawing.Size(29, 17);
            this.label_cityContact.TabIndex = 12;
            this.label_cityContact.Text = "City";
            // 
            // label_ageContact
            // 
            this.label_ageContact.AutoSize = true;
            this.label_ageContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ageContact.Location = new System.Drawing.Point(63, 29);
            this.label_ageContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ageContact.Name = "label_ageContact";
            this.label_ageContact.Size = new System.Drawing.Size(31, 17);
            this.label_ageContact.TabIndex = 9;
            this.label_ageContact.Text = "Age";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // contactListFlowLayoutPanel
            // 
            this.contactListFlowLayoutPanel.AutoScroll = true;
            this.contactListFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.contactListFlowLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contactListFlowLayoutPanel.Location = new System.Drawing.Point(9, 239);
            this.contactListFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contactListFlowLayoutPanel.Name = "contactListFlowLayoutPanel";
            this.contactListFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.contactListFlowLayoutPanel.Size = new System.Drawing.Size(334, 265);
            this.contactListFlowLayoutPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 201);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSchemesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(762, 29);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // colorSchemesToolStripMenuItem
            // 
            this.colorSchemesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueLagoonToolStripMenuItem,
            this.pinkDrinkToolStripMenuItem,
            this.richBurgundyToolStripMenuItem,
            this.springGreenToolStripMenuItem,
            this.tourquoiseDreamToolStripMenuItem,
            this.vintageHouseToolStripMenuItem,
            this.violetBluesToolStripMenuItem});
            this.colorSchemesToolStripMenuItem.Name = "colorSchemesToolStripMenuItem";
            this.colorSchemesToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.colorSchemesToolStripMenuItem.Text = "Color schemes";
            // 
            // blueLagoonToolStripMenuItem
            // 
            this.blueLagoonToolStripMenuItem.Image = global::Chat.Resource.Blue_lagoon;
            this.blueLagoonToolStripMenuItem.Name = "blueLagoonToolStripMenuItem";
            this.blueLagoonToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.blueLagoonToolStripMenuItem.Text = "Blue Lagoon";
            this.blueLagoonToolStripMenuItem.Click += new System.EventHandler(this.blueLagoonToolStripMenuItem_Click);
            // 
            // pinkDrinkToolStripMenuItem
            // 
            this.pinkDrinkToolStripMenuItem.Image = global::Chat.Resource.Pink_drink;
            this.pinkDrinkToolStripMenuItem.Name = "pinkDrinkToolStripMenuItem";
            this.pinkDrinkToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.pinkDrinkToolStripMenuItem.Text = "Pink Drink";
            this.pinkDrinkToolStripMenuItem.Click += new System.EventHandler(this.pinkDrinkToolStripMenuItem_Click);
            // 
            // richBurgundyToolStripMenuItem
            // 
            this.richBurgundyToolStripMenuItem.Image = global::Chat.Resource.Rich_burgundy;
            this.richBurgundyToolStripMenuItem.Name = "richBurgundyToolStripMenuItem";
            this.richBurgundyToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.richBurgundyToolStripMenuItem.Text = "Rich Burgundy";
            this.richBurgundyToolStripMenuItem.Click += new System.EventHandler(this.richBurgundyToolStripMenuItem_Click);
            // 
            // springGreenToolStripMenuItem
            // 
            this.springGreenToolStripMenuItem.Image = global::Chat.Resource.Spring_green;
            this.springGreenToolStripMenuItem.Name = "springGreenToolStripMenuItem";
            this.springGreenToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.springGreenToolStripMenuItem.Text = "Spring Green";
            this.springGreenToolStripMenuItem.Click += new System.EventHandler(this.springGreenToolStripMenuItem_Click);
            // 
            // tourquoiseDreamToolStripMenuItem
            // 
            this.tourquoiseDreamToolStripMenuItem.Image = global::Chat.Resource.Tourqoise_dream;
            this.tourquoiseDreamToolStripMenuItem.Name = "tourquoiseDreamToolStripMenuItem";
            this.tourquoiseDreamToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.tourquoiseDreamToolStripMenuItem.Text = "Tourquoise Dream";
            this.tourquoiseDreamToolStripMenuItem.Click += new System.EventHandler(this.tourquoiseDreamToolStripMenuItem_Click);
            // 
            // vintageHouseToolStripMenuItem
            // 
            this.vintageHouseToolStripMenuItem.Image = global::Chat.Resource.Vintage_house;
            this.vintageHouseToolStripMenuItem.Name = "vintageHouseToolStripMenuItem";
            this.vintageHouseToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.vintageHouseToolStripMenuItem.Text = "Vintage House";
            this.vintageHouseToolStripMenuItem.Click += new System.EventHandler(this.vintageHouseToolStripMenuItem_Click);
            // 
            // violetBluesToolStripMenuItem
            // 
            this.violetBluesToolStripMenuItem.Image = global::Chat.Resource.Violet_blues;
            this.violetBluesToolStripMenuItem.Name = "violetBluesToolStripMenuItem";
            this.violetBluesToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.violetBluesToolStripMenuItem.Text = "Violet Blues";
            this.violetBluesToolStripMenuItem.Click += new System.EventHandler(this.violetBluesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.editAccountToolStripMenuItem.Text = "Edit account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trackBar_darkMode
            // 
            this.trackBar_darkMode.LargeChange = 1;
            this.trackBar_darkMode.Location = new System.Drawing.Point(622, 33);
            this.trackBar_darkMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.trackBar_darkMode.Maximum = 1;
            this.trackBar_darkMode.Name = "trackBar_darkMode";
            this.trackBar_darkMode.Size = new System.Drawing.Size(38, 45);
            this.trackBar_darkMode.TabIndex = 15;
            this.trackBar_darkMode.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_darkMode.ValueChanged += new System.EventHandler(this.trackBar_darkMode_ValueChanged);
            // 
            // label_darkMode
            // 
            this.label_darkMode.AutoSize = true;
            this.label_darkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_darkMode.Location = new System.Drawing.Point(653, 33);
            this.label_darkMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_darkMode.Name = "label_darkMode";
            this.label_darkMode.Size = new System.Drawing.Size(87, 20);
            this.label_darkMode.TabIndex = 16;
            this.label_darkMode.Text = "Dark mode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.label_darkMode);
            this.Controls.Add(this.contactListFlowLayoutPanel);
            this.Controls.Add(this.groupBox_conv);
            this.Controls.Add(this.textBox_searchContact);
            this.Controls.Add(this.groupBox_myProfile);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.trackBar_darkMode);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_myProfile.ResumeLayout(false);
            this.groupBox_myProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_conv.ResumeLayout(false);
            this.groupBox_conv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_darkMode)).EndInit();
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
        private GroupBox groupBox_myProfile;
        private Label label_nrContacte;
        private TextBox textBox_searchContact;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox_conv;
        private GroupBox groupBox_conv;
        private Label label_cityContact;
        private Label label_ageContact;
        private FlowLayoutPanel contactListFlowLayoutPanel;
        private Panel panel1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem colorSchemesToolStripMenuItem;
        private ToolStripMenuItem blueLagoonToolStripMenuItem;
        private ToolStripMenuItem pinkDrinkToolStripMenuItem;
        private ToolStripMenuItem richBurgundyToolStripMenuItem;
        private ToolStripMenuItem springGreenToolStripMenuItem;
        private ToolStripMenuItem tourquoiseDreamToolStripMenuItem;
        private ToolStripMenuItem vintageHouseToolStripMenuItem;
        private ToolStripMenuItem violetBluesToolStripMenuItem;
        private TrackBar trackBar_darkMode;
        private Label label_darkMode;
        public FlowLayoutPanel messagesFlowLayout;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem editAccountToolStripMenuItem;
        public Label label_username;
        public Label label_varsta;
        public Label label_city;
        public PictureBox pictureBox1;
        private Label labelFaculty;
        private ToolStripMenuItem deleteAccountToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}