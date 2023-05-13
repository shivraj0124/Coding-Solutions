namespace uid_project
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            navbar = new Panel();
            logo1 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            contact = new Label();
            logo2 = new Label();
            Home = new Label();
            navbar_user_btn = new Panel();
            signup = new Button();
            login = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            navbar_user_btn.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(0, 72, 124);
            navbar.Controls.Add(logo1);
            navbar.Controls.Add(pictureBox1);
            navbar.Controls.Add(label1);
            navbar.Controls.Add(label2);
            navbar.Controls.Add(contact);
            navbar.Controls.Add(logo2);
            navbar.Controls.Add(Home);
            navbar.Controls.Add(navbar_user_btn);
            navbar.Location = new Point(2, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1176, 82);
            navbar.TabIndex = 1;
            // 
            // logo1
            // 
            logo1.AutoSize = true;
            logo1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            logo1.ForeColor = SystemColors.ButtonFace;
            logo1.Location = new Point(104, 7);
            logo1.Name = "logo1";
            logo1.Size = new Size(127, 38);
            logo1.TabIndex = 2;
            logo1.Text = "CODING";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._58c94536cfb85cf1e698f9e2493f0557_removebg_preview__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1015, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(390, 32);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 2;
            label2.Text = "ABOUT";
            label2.Click += label2_Click;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            contact.ForeColor = SystemColors.ButtonFace;
            contact.Location = new Point(481, 32);
            contact.Name = "contact";
            contact.Size = new Size(112, 30);
            contact.TabIndex = 2;
            contact.Text = "CONTACT";
            contact.Click += contact_Click;
            // 
            // logo2
            // 
            logo2.AutoSize = true;
            logo2.BackColor = Color.Transparent;
            logo2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            logo2.ForeColor = SystemColors.ButtonFace;
            logo2.Location = new Point(130, 38);
            logo2.Name = "logo2";
            logo2.Size = new Size(171, 38);
            logo2.TabIndex = 2;
            logo2.Text = "SOLUTIONS";
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Home.ForeColor = SystemColors.ButtonFace;
            Home.Location = new Point(307, 31);
            Home.Name = "Home";
            Home.Size = new Size(77, 30);
            Home.TabIndex = 2;
            Home.Text = "HOME";
            Home.Click += Home_Click;
            // 
            // navbar_user_btn
            // 
            navbar_user_btn.Controls.Add(signup);
            navbar_user_btn.Controls.Add(login);
            navbar_user_btn.Location = new Point(774, 7);
            navbar_user_btn.Name = "navbar_user_btn";
            navbar_user_btn.Size = new Size(235, 72);
            navbar_user_btn.TabIndex = 2;
            // 
            // signup
            // 
            signup.BackColor = Color.FromArgb(232, 241, 245);
            signup.FlatAppearance.BorderColor = Color.FromArgb(0, 86, 145);
            signup.FlatStyle = FlatStyle.Flat;
            signup.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            signup.ForeColor = Color.FromArgb(0, 86, 145);
            signup.Location = new Point(109, 18);
            signup.Name = "signup";
            signup.Size = new Size(110, 44);
            signup.TabIndex = 1;
            signup.Text = "Sign up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(232, 241, 245);
            login.FlatAppearance.BorderColor = Color.FromArgb(0, 86, 145);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.FromArgb(0, 86, 145);
            login.Location = new Point(3, 18);
            login.Name = "login";
            login.Size = new Size(86, 44);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 241, 245);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(80, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 289);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.rear_view_programmer_working_all_night_long;
            pictureBox2.Location = new Point(656, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(326, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 28);
            label3.MaximumSize = new Size(600, 0);
            label3.Name = "label3";
            label3.Size = new Size(591, 225);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 241, 245);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(80, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 289);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 52);
            label4.MaximumSize = new Size(600, 0);
            label4.Name = "label4";
            label4.Size = new Size(591, 225);
            label4.TabIndex = 1;
            label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.rear_view_programmer_working_all_night_long;
            pictureBox3.Location = new Point(26, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(326, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1205, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(navbar);
            MaximumSize = new Size(1227, 698);
            Name = "About";
            Text = "About";
            Load += About_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            navbar_user_btn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Label logo1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label contact;
        private Label logo2;
        private Label Home;
        private Panel navbar_user_btn;
        private Button signup;
        private Button login;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox3;
    }
}