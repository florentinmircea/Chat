
namespace Chat
{
    partial class ContactUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactUsernameLabel = new System.Windows.Forms.Label();
            this.contactLastMessageLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 71);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contactUsernameLabel
            // 
            this.contactUsernameLabel.AutoSize = true;
            this.contactUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.contactUsernameLabel.Location = new System.Drawing.Point(81, 0);
            this.contactUsernameLabel.Name = "contactUsernameLabel";
            this.contactUsernameLabel.Size = new System.Drawing.Size(81, 35);
            this.contactUsernameLabel.TabIndex = 2;
            this.contactUsernameLabel.Text = "label1";
            // 
            // contactLastMessageLabel
            // 
            this.contactLastMessageLabel.AutoSize = true;
            this.contactLastMessageLabel.Location = new System.Drawing.Point(84, 45);
            this.contactLastMessageLabel.Name = "contactLastMessageLabel";
            this.contactLastMessageLabel.Size = new System.Drawing.Size(46, 17);
            this.contactLastMessageLabel.TabIndex = 3;
            this.contactLastMessageLabel.Text = "label2";
            this.contactLastMessageLabel.Click += new System.EventHandler(this.contactLastMessageLabel_Click);
            // 
            // ContactUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactLastMessageLabel);
            this.Controls.Add(this.contactUsernameLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ContactUserControl";
            this.Size = new System.Drawing.Size(483, 71);
            this.Load += new System.EventHandler(this.ContactUserControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContactUserControl_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label contactUsernameLabel;
        private System.Windows.Forms.Label contactLastMessageLabel;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
