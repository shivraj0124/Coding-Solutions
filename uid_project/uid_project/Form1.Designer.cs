namespace uid_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navbar = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.Label();
            this.logo2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.navbar_user_btn = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.information_title = new System.Windows.Forms.Label();
            this.infromation = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.categeries = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar_user_btn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(124)))));
            this.navbar.Controls.Add(this.logo1);
            this.navbar.Controls.Add(this.pictureBox1);
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.about);
            this.navbar.Controls.Add(this.contact);
            this.navbar.Controls.Add(this.logo2);
            this.navbar.Controls.Add(this.Home);
            this.navbar.Controls.Add(this.navbar_user_btn);
            this.navbar.Location = new System.Drawing.Point(-3, -4);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1180, 82);
            this.navbar.TabIndex = 0;
            this.navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.navbar_Paint);
            // 
            // logo1
            // 
            this.logo1.AutoSize = true;
            this.logo1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo1.Location = new System.Drawing.Point(104, 7);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(109, 32);
            this.logo1.TabIndex = 2;
            this.logo1.Text = "CODING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uid_project.Properties.Resources._58c94536cfb85cf1e698f9e2493f0557_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1015, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.about.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.about.Location = new System.Drawing.Point(390, 32);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(73, 25);
            this.about.TabIndex = 2;
            this.about.Text = "ABOUT";
            this.about.Click += new System.EventHandler(this.about_Click_1);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contact.Location = new System.Drawing.Point(481, 32);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(97, 25);
            this.contact.TabIndex = 2;
            this.contact.Text = "CONTACT";
            this.contact.Click += new System.EventHandler(this.contact_Click_1);
            // 
            // logo2
            // 
            this.logo2.AutoSize = true;
            this.logo2.BackColor = System.Drawing.Color.Transparent;
            this.logo2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo2.Location = new System.Drawing.Point(130, 38);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(146, 32);
            this.logo2.TabIndex = 2;
            this.logo2.Text = "SOLUTIONS";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(307, 31);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(68, 25);
            this.Home.TabIndex = 2;
            this.Home.Text = "HOME";
            this.Home.Click += new System.EventHandler(this.Home_Click_1);
            // 
            // navbar_user_btn
            // 
            this.navbar_user_btn.Controls.Add(this.signup);
            this.navbar_user_btn.Controls.Add(this.login);
            this.navbar_user_btn.Location = new System.Drawing.Point(774, 7);
            this.navbar_user_btn.Name = "navbar_user_btn";
            this.navbar_user_btn.Size = new System.Drawing.Size(235, 72);
            this.navbar_user_btn.TabIndex = 2;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.signup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.signup.Location = new System.Drawing.Point(109, 18);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(110, 44);
            this.signup.TabIndex = 1;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click_1);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(145)))));
            this.login.Location = new System.Drawing.Point(3, 18);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(86, 44);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.information_title);
            this.panel1.Controls.Add(this.infromation);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 365);
            this.panel1.TabIndex = 2;
            // 
            // information_title
            // 
            this.information_title.AutoSize = true;
            this.information_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.information_title.Location = new System.Drawing.Point(204, 20);
            this.information_title.Name = "information_title";
            this.information_title.Size = new System.Drawing.Size(228, 37);
            this.information_title.TabIndex = 2;
            this.information_title.Text = "CODING FORUM";
            // 
            // infromation
            // 
            this.infromation.AutoSize = true;
            this.infromation.Location = new System.Drawing.Point(73, 65);
            this.infromation.MaximumSize = new System.Drawing.Size(600, 0);
            this.infromation.Name = "infromation";
            this.infromation.Size = new System.Drawing.Size(598, 207);
            this.infromation.TabIndex = 1;
            this.infromation.Text = resources.GetString("infromation.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::uid_project.Properties.Resources.undraw_Programming_re_kg9v_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(732, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(408, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // categeries
            // 
            this.categeries.AutoSize = true;
            this.categeries.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categeries.Location = new System.Drawing.Point(486, 543);
            this.categeries.Name = "categeries";
            this.categeries.Size = new System.Drawing.Size(197, 41);
            this.categeries.TabIndex = 3;
            this.categeries.Text = "CATEGORIES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1205, 642);
            this.Controls.Add(this.categeries);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navbar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1227, 698);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar_user_btn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel navbar;
        private Label about;
        private Label contact;
        private Label logo1;
        private Label logo2;
        private Label Home;
        private Panel navbar_user_btn;
        private Button signup;
        private Button login;
        private Panel panel1;
        private Label information_title;
        private Label infromation;
        private PictureBox pictureBox3;
        private Label categeries;
        private Label label1;
        private PictureBox pictureBox1;
    }
}