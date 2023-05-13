namespace uid_project
{
    partial class questions
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
            label1 = new Label();
            about = new Label();
            contact = new Label();
            logo2 = new Label();
            Home = new Label();
            navbar_user_btn = new Panel();
            signup = new Button();
            login = new Button();
            panel1 = new Panel();
            post_btn = new Button();
            input_des = new TextBox();
            input_title = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            post_hide_panel = new Panel();
            label5 = new Label();
            back = new Button();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            navbar_user_btn.SuspendLayout();
            panel1.SuspendLayout();
            post_hide_panel.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(0, 72, 124);
            navbar.Controls.Add(logo1);
            navbar.Controls.Add(pictureBox3);
            navbar.Controls.Add(label1);
            navbar.Controls.Add(about);
            navbar.Controls.Add(contact);
            navbar.Controls.Add(logo2);
            navbar.Controls.Add(Home);
            navbar.Controls.Add(navbar_user_btn);
            navbar.Location = new Point(0, 1);
            navbar.Name = "navbar";
            navbar.Size = new Size(1202, 82);
            navbar.TabIndex = 1;
            // 
            // logo1
            // 
            logo1.AutoSize = true;
            logo1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            logo1.ForeColor = SystemColors.ButtonFace;
            logo1.Location = new Point(92, 0);
            logo1.Name = "logo1";
            logo1.Size = new Size(127, 38);
            logo1.TabIndex = 2;
            logo1.Text = "CODING";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._58c94536cfb85cf1e698f9e2493f0557_removebg_preview__1_;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 99);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1022, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // about
            // 
            about.AutoSize = true;
            about.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            about.ForeColor = SystemColors.ButtonFace;
            about.Location = new Point(402, 32);
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
            contact.Location = new Point(493, 31);
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
            logo2.Location = new Point(130, 32);
            logo2.Name = "logo2";
            logo2.Size = new Size(171, 38);
            logo2.TabIndex = 2;
            logo2.Text = "SOLUTIONS";
            logo2.Click += logo2_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Home.ForeColor = SystemColors.ButtonFace;
            Home.Location = new Point(319, 31);
            Home.Name = "Home";
            Home.Size = new Size(77, 30);
            Home.TabIndex = 2;
            Home.Text = "HOME";
            Home.Click += Home_Click;
            Home.MouseHover += Home_MouseHover;
            // 
            // navbar_user_btn
            // 
            navbar_user_btn.Controls.Add(signup);
            navbar_user_btn.Controls.Add(login);
            navbar_user_btn.Location = new Point(797, 7);
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
            panel1.Controls.Add(post_btn);
            panel1.Controls.Add(input_des);
            panel1.Controls.Add(input_title);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(55, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 362);
            panel1.TabIndex = 2;
            // 
            // post_btn
            // 
            post_btn.BackColor = Color.FromArgb(0, 86, 145);
            post_btn.FlatStyle = FlatStyle.Flat;
            post_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            post_btn.ForeColor = Color.FromArgb(232, 241, 245);
            post_btn.Location = new Point(89, 300);
            post_btn.Name = "post_btn";
            post_btn.Size = new Size(121, 38);
            post_btn.TabIndex = 4;
            post_btn.Text = "POST";
            post_btn.UseVisualStyleBackColor = false;
            post_btn.Click += post_btn_Click;
            // 
            // input_des
            // 
            input_des.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            input_des.Location = new Point(89, 169);
            input_des.Multiline = true;
            input_des.Name = "input_des";
            input_des.Size = new Size(927, 108);
            input_des.TabIndex = 3;
            // 
            // input_title
            // 
            input_title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input_title.Location = new Point(89, 59);
            input_title.Name = "input_title";
            input_title.Size = new Size(927, 39);
            input_title.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 123);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 0;
            label2.Text = "Tittle";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 561);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 3;
            label4.Text = "QUESTIONS";
            // 
            // post_hide_panel
            // 
            post_hide_panel.BackColor = Color.FromArgb(232, 241, 245);
            post_hide_panel.Controls.Add(label5);
            post_hide_panel.Location = new Point(58, 155);
            post_hide_panel.Name = "post_hide_panel";
            post_hide_panel.Size = new Size(1078, 359);
            post_hide_panel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(332, 157);
            label5.Name = "label5";
            label5.Size = new Size(413, 32);
            label5.TabIndex = 0;
            label5.Text = "LOGIN FIRST TO POST A QUESTION";
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.Location = new Point(12, 89);
            back.Name = "back";
            back.Size = new Size(42, 34);
            back.TabIndex = 5;
            back.Text = "⇽";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // questions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1205, 642);
            Controls.Add(back);
            Controls.Add(post_hide_panel);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(navbar);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximumSize = new Size(1227, 698);
            Name = "questions";
            Text = "questions";
            Load += questions_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            navbar_user_btn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            post_hide_panel.ResumeLayout(false);
            post_hide_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel navbar;
        private Label label1;
        private Label about;
        private Label contact;
        private Label logo1;
        private Label logo2;
        private Label Home;
        private Panel navbar_user_btn;
        private Button signup;
        private Button login;
        private Panel panel1;
        private Button post_btn;
        private TextBox input_title;
        private Label label3;
        private Label label2;
        private TextBox input_des;
        private Label label4;
        private Panel post_hide_panel;
        private Label label5;
        private PictureBox pictureBox3;
        private Button back;
    }
}