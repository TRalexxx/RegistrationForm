using System.Drawing;
using System.Windows.Forms;

namespace RegistrationForm
{
    partial class Form1
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

        bool isPressed = false;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_L = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password_L = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.repeatPass_L = new System.Windows.Forms.Label();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.gender_L = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Panel();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.accept = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.enBtn = new System.Windows.Forms.Button();
            this.geBtn = new System.Windows.Forms.Button();
            this.ruBtn = new System.Windows.Forms.Button();
            this.ukrBtn = new System.Windows.Forms.Button();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_L
            // 
            resources.ApplyResources(this.login_L, "login_L");
            this.login_L.Name = "login_L";
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            // 
            // password_L
            // 
            resources.ApplyResources(this.password_L, "password_L");
            this.password_L.Name = "password_L";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            // 
            // repeatPass_L
            // 
            resources.ApplyResources(this.repeatPass_L, "repeatPass_L");
            this.repeatPass_L.Name = "repeatPass_L";
            // 
            // repeatPassword
            // 
            resources.ApplyResources(this.repeatPassword, "repeatPassword");
            this.repeatPassword.Name = "repeatPassword";
            // 
            // gender_L
            // 
            resources.ApplyResources(this.gender_L, "gender_L");
            this.gender_L.Name = "gender_L";
            // 
            // gender
            // 
            this.gender.Controls.Add(this.male);
            this.gender.Controls.Add(this.female);
            this.gender.Controls.Add(this.other);
            resources.ApplyResources(this.gender, "gender");
            this.gender.Name = "gender";
            // 
            // male
            // 
            resources.ApplyResources(this.male, "male");
            this.male.Name = "male";
            // 
            // female
            // 
            resources.ApplyResources(this.female, "female");
            this.female.Name = "female";
            // 
            // other
            // 
            resources.ApplyResources(this.other, "other");
            this.other.Name = "other";
            // 
            // accept
            // 
            resources.ApplyResources(this.accept, "accept");
            this.accept.Name = "accept";
            // 
            // clear
            // 
            resources.ApplyResources(this.clear, "clear");
            this.clear.Name = "clear";
            // 
            // cancel
            // 
            resources.ApplyResources(this.cancel, "cancel");
            this.cancel.Name = "cancel";
            // 
            // enBtn
            // 
            resources.ApplyResources(this.enBtn, "enBtn");
            this.enBtn.Name = "enBtn";
            this.enBtn.UseVisualStyleBackColor = true;
            this.enBtn.Click += new System.EventHandler(this.enBtn_Click);
            // 
            // geBtn
            // 
            resources.ApplyResources(this.geBtn, "geBtn");
            this.geBtn.Name = "geBtn";
            this.geBtn.UseVisualStyleBackColor = true;
            this.geBtn.Click += new System.EventHandler(this.geBtn_Click);
            // 
            // ruBtn
            // 
            resources.ApplyResources(this.ruBtn, "ruBtn");
            this.ruBtn.Name = "ruBtn";
            this.ruBtn.UseVisualStyleBackColor = true;
            this.ruBtn.Click += new System.EventHandler(this.ruBtn_Click);
            // 
            // ukrBtn
            // 
            resources.ApplyResources(this.ukrBtn, "ukrBtn");
            this.ukrBtn.Name = "ukrBtn";
            this.ukrBtn.UseVisualStyleBackColor = true;
            this.ukrBtn.Click += new System.EventHandler(this.ukrBtn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ukrBtn);
            this.Controls.Add(this.ruBtn);
            this.Controls.Add(this.geBtn);
            this.Controls.Add(this.enBtn);
            this.Controls.Add(this.login_L);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_L);
            this.Controls.Add(this.password);
            this.Controls.Add(this.repeatPass_L);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.gender_L);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.cancel);
            this.Name = "Form1";
            this.gender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Clear_Click(object sender, System.EventArgs e)
        {
            login.Clear();
            password.Clear();
            repeatPassword.Clear();
        }

        private void Other_Click(object sender, System.EventArgs e)
        {
            isPressed = true;
        }

        private void Female_Click(object sender, System.EventArgs e)
        {
            isPressed = true;
        }

        private void Male_Click(object sender, System.EventArgs e)
        {
            isPressed = true;
        }

        private void Accept_Click(object sender, System.EventArgs e)
        {
            if (!login.Text.Equals(""))
            {
                if (password.Text.Equals(repeatPassword.Text) && password.Text.Length!=0)
                {
                    if (isPressed) MessageBox.Show("Registretion successfull!", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("You need to choose gender", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Passwords are incorrect", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("You need enter correct login", "Caption", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Label login_L;
        Label password_L;
        Label repeatPass_L;
        Label gender_L;

        TextBox login;
        TextBox password;
        TextBox repeatPassword;

        Panel gender;

        RadioButton male;
        RadioButton female;
        RadioButton other;

        Button accept;
        Button clear;
        Button cancel;

        #endregion

        private Button enBtn;
        private Button geBtn;
        private Button ruBtn;
        private Button ukrBtn;
    }
}

