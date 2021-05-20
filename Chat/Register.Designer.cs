
namespace Chat
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email_Textbox = new System.Windows.Forms.TextBox();
            this.fullname_Textbox = new System.Windows.Forms.TextBox();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.confirmPass_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Picture link";
            // 
            // email_Textbox
            // 
            this.email_Textbox.Location = new System.Drawing.Point(301, 103);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Size = new System.Drawing.Size(255, 22);
            this.email_Textbox.TabIndex = 5;
            // 
            // fullname_Textbox
            // 
            this.fullname_Textbox.Location = new System.Drawing.Point(301, 142);
            this.fullname_Textbox.Name = "fullname_Textbox";
            this.fullname_Textbox.Size = new System.Drawing.Size(255, 22);
            this.fullname_Textbox.TabIndex = 6;
            // 
            // username_Textbox
            // 
            this.username_Textbox.Location = new System.Drawing.Point(301, 181);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(255, 22);
            this.username_Textbox.TabIndex = 7;
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(301, 222);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(255, 22);
            this.password_Textbox.TabIndex = 8;
            // 
            // confirmPass_Textbox
            // 
            this.confirmPass_Textbox.Location = new System.Drawing.Point(301, 265);
            this.confirmPass_Textbox.Name = "confirmPass_Textbox";
            this.confirmPass_Textbox.Size = new System.Drawing.Size(255, 22);
            this.confirmPass_Textbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Confirm Password";
            // 
            // picture_Textbox
            // 
            this.picture_Textbox.Location = new System.Drawing.Point(301, 308);
            this.picture_Textbox.Name = "picture_Textbox";
            this.picture_Textbox.Size = new System.Drawing.Size(255, 22);
            this.picture_Textbox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture_Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPass_Textbox);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.fullname_Textbox);
            this.Controls.Add(this.email_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_Textbox;
        private System.Windows.Forms.TextBox fullname_Textbox;
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.TextBox confirmPass_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox picture_Textbox;
        private System.Windows.Forms.Button button1;
    }
}