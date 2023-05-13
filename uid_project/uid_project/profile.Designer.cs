namespace uid_project
{
    partial class profile
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
            navbar = new Panel();
            logo1 = new Label();
            pictureBox3 = new PictureBox();
            about = new Label();
            contact = new Label();
            logo2 = new Label();
            Home = new Label();
            panel1 = new Panel();
            email = new Label();
            username = new Label();
            lname = new Label();
            fname = new Label();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navbar.BackColor = Color.FromArgb(0, 72, 124);
            navbar.Controls.Add(logo1);
            navbar.Controls.Add(pictureBox3);
            navbar.Controls.Add(about);
            navbar.Controls.Add(contact);
            navbar.Controls.Add(logo2);
            navbar.Controls.Add(Home);
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1172, 84);
            navbar.TabIndex = 2;
            navbar.Paint += navbar_Paint;
            // 
            // logo1
            // 
            logo1.AutoSize = true;
            logo1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            logo1.ForeColor = SystemColors.ButtonFace;
            logo1.Location = new Point(191, 9);
            logo1.Name = "logo1";
            logo1.Size = new Size(127, 38);
            logo1.TabIndex = 2;
            logo1.Text = "CODING";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._58c94536cfb85cf1e698f9e2493f0557_removebg_preview__1_;
            pictureBox3.Location = new Point(91, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // about
            // 
            about.AutoSize = true;
            about.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            about.ForeColor = SystemColors.ButtonFace;
            about.Location = new Point(478, 28);
            about.Name = "about";
            about.Size = new Size(85, 30);
            about.TabIndex = 2;
            about.Text = "ABOUT";
            about.Click += about_Click;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            contact.ForeColor = SystemColors.ButtonFace;
            contact.Location = new Point(569, 29);
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
            logo2.Location = new Point(218, 43);
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
            Home.Location = new Point(395, 29);
            Home.Name = "Home";
            Home.Size = new Size(77, 30);
            Home.TabIndex = 2;
            Home.Text = "HOME";
            Home.Click += Home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 241, 245);
            panel1.Controls.Add(email);
            panel1.Controls.Add(username);
            panel1.Controls.Add(lname);
            panel1.Controls.Add(fname);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(149, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 450);
            panel1.TabIndex = 3;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(544, 259);
            email.Name = "email";
            email.Size = new Size(280, 32);
            email.TabIndex = 9;
            email.Text = "yashmulik95@gmail.com";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(544, 202);
            username.Name = "username";
            username.Size = new Size(87, 32);
            username.TabIndex = 8;
            username.Text = "Yash02";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(544, 134);
            lname.Name = "lname";
            lname.Size = new Size(74, 32);
            lname.TabIndex = 7;
            lname.Text = "Mulik";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(544, 71);
            fname.Name = "fname";
            fname.Size = new Size(61, 32);
            fname.TabIndex = 6;
            fname.Text = "Yash";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 72, 124);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(232, 241, 245);
            button1.Location = new Point(471, 330);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 5;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(377, 261);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(353, 202);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(353, 134);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 71);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.follow_me_social_business_theme_design_24877_52233_removebg_preview;
            pictureBox1.Location = new Point(15, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1205, 642);
            Controls.Add(panel1);
            Controls.Add(navbar);
            MaximumSize = new Size(1227, 698);
            Name = "profile";
            Text = "profile";
            Load += profile_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Label logo1;
        private PictureBox pictureBox3;
        private Label about;
        private Label contact;
        private Label logo2;
        private Label Home;
        private Panel panel1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label email;
        private Label username;
        private Label lname;
        private Label fname;
    }
}