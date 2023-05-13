namespace uid_project
{
    partial class Contact
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            about = new Label();
            label2 = new Label();
            logo2 = new Label();
            Home = new Label();
            navbar_user_btn = new Panel();
            signup = new Button();
            login = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            input_mail = new TextBox();
            label6 = new Label();
            post_btn = new Button();
            input_msg = new TextBox();
            input_username = new TextBox();
            label3 = new Label();
            label4 = new Label();
            post_hide_panel = new Panel();
            label5 = new Label();
            notification = new Panel();
            notification_label = new Label();
            notification_cancel_btn = new Button();
            notification_message = new Label();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            navbar_user_btn.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            post_hide_panel.SuspendLayout();
            notification.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(0, 72, 124);
            navbar.Controls.Add(logo1);
            navbar.Controls.Add(pictureBox1);
            navbar.Controls.Add(label1);
            navbar.Controls.Add(about);
            navbar.Controls.Add(label2);
            navbar.Controls.Add(logo2);
            navbar.Controls.Add(Home);
            navbar.Controls.Add(navbar_user_btn);
            navbar.Location = new Point(1, 1);
            navbar.Name = "navbar";
            navbar.Size = new Size(1180, 82);
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
            // about
            // 
            about.AutoSize = true;
            about.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            about.ForeColor = SystemColors.ButtonFace;
            about.Location = new Point(390, 32);
            about.Name = "about";
            about.Size = new Size(85, 30);
            about.TabIndex = 2;
            about.Text = "ABOUT";
            about.Click += about_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(481, 32);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 2;
            label2.Text = "CONTACT";
            label2.Click += label2_Click;
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
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(input_mail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(post_btn);
            panel1.Controls.Add(input_msg);
            panel1.Controls.Add(input_username);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(66, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 455);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.undraw_Personal_text_re_vqj3_removebg_preview;
            pictureBox2.Location = new Point(649, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(419, 384);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // input_mail
            // 
            input_mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input_mail.Location = new Point(61, 164);
            input_mail.Name = "input_mail";
            input_mail.Size = new Size(581, 39);
            input_mail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 116);
            label6.Name = "label6";
            label6.Size = new Size(76, 32);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // post_btn
            // 
            post_btn.BackColor = Color.FromArgb(0, 86, 145);
            post_btn.FlatStyle = FlatStyle.Flat;
            post_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            post_btn.ForeColor = Color.FromArgb(232, 241, 245);
            post_btn.Location = new Point(63, 399);
            post_btn.Name = "post_btn";
            post_btn.Size = new Size(121, 38);
            post_btn.TabIndex = 4;
            post_btn.Text = "POST";
            post_btn.UseVisualStyleBackColor = false;
            post_btn.Click += post_btn_Click;
            // 
            // input_msg
            // 
            input_msg.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            input_msg.Location = new Point(61, 268);
            input_msg.Multiline = true;
            input_msg.Name = "input_msg";
            input_msg.Size = new Size(582, 108);
            input_msg.TabIndex = 3;
            // 
            // input_username
            // 
            input_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input_username.Location = new Point(56, 59);
            input_username.Name = "input_username";
            input_username.Size = new Size(584, 39);
            input_username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 223);
            label3.Name = "label3";
            label3.Size = new Size(126, 32);
            label3.TabIndex = 1;
            label3.Text = "Meassage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(56, 24);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 0;
            label4.Text = "Username";
            // 
            // post_hide_panel
            // 
            post_hide_panel.BackColor = Color.FromArgb(232, 241, 245);
            post_hide_panel.Controls.Add(label5);
            post_hide_panel.Location = new Point(43, 164);
            post_hide_panel.Name = "post_hide_panel";
            post_hide_panel.Size = new Size(1110, 455);
            post_hide_panel.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(331, 206);
            label5.Name = "label5";
            label5.Size = new Size(412, 32);
            label5.TabIndex = 0;
            label5.Text = "LOGIN FIRST TO SEND A MESSAGE.";
            // 
            // notification
            // 
            notification.BackColor = SystemColors.GradientActiveCaption;
            notification.Controls.Add(notification_label);
            notification.Controls.Add(notification_cancel_btn);
            notification.Controls.Add(notification_message);
            notification.Location = new Point(1, 89);
            notification.Name = "notification";
            notification.Size = new Size(1171, 55);
            notification.TabIndex = 8;
            // 
            // notification_label
            // 
            notification_label.AutoSize = true;
            notification_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            notification_label.Location = new Point(53, 17);
            notification_label.Name = "notification_label";
            notification_label.Size = new Size(216, 28);
            notification_label.TabIndex = 2;
            notification_label.Text = "Signup sucessfull !!!!!";
            // 
            // notification_cancel_btn
            // 
            notification_cancel_btn.Location = new Point(1113, 11);
            notification_cancel_btn.Name = "notification_cancel_btn";
            notification_cancel_btn.Size = new Size(41, 34);
            notification_cancel_btn.TabIndex = 1;
            notification_cancel_btn.Text = "×";
            notification_cancel_btn.UseVisualStyleBackColor = true;
            notification_cancel_btn.Click += notification_cancel_btn_Click;
            // 
            // notification_message
            // 
            notification_message.AutoSize = true;
            notification_message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            notification_message.Location = new Point(141, 14);
            notification_message.Name = "notification_message";
            notification_message.Size = new Size(0, 32);
            notification_message.TabIndex = 0;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1205, 642);
            Controls.Add(notification);
            Controls.Add(post_hide_panel);
            Controls.Add(panel1);
            Controls.Add(navbar);
            MaximumSize = new Size(1227, 698);
            Name = "Contact";
            Text = "Contact";
            Load += Contact_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            navbar_user_btn.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            post_hide_panel.ResumeLayout(false);
            post_hide_panel.PerformLayout();
            notification.ResumeLayout(false);
            notification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Label logo1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label about;
        private Label label2;
        private Label logo2;
        private Label Home;
        private Panel navbar_user_btn;
        private Button signup;
        private Button login;
        private Panel panel1;
        private Button post_btn;
        private TextBox input_msg;
        private TextBox input_username;
        private Label label3;
        private Label label4;
        private Panel post_hide_panel;
        private Label label5;
        private PictureBox pictureBox2;
        private TextBox input_mail;
        private Label label6;
        private Panel notification;
        private Label notification_label;
        private Button notification_cancel_btn;
        private Label notification_message;
    }
}