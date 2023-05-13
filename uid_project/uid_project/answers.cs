using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uid_project.Properties;

namespace uid_project
{
    public partial class answers : Form
    {
        public answers()
        {
            InitializeComponent();
        }
        string username = Global_data.username;
        int user_id = Global_data.userid;
        int q_id = Global_data.question_id;

        private void answers_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            if (username == null)
            {
                //navbar_userdata.Hide();
                navbar_user_btn.Show();
                panel2.Show();
            }
            else
            {
                //navbar_username.Text = username;
                navbar_user_btn.Hide();
                panel1.Show();
                //navbar_userdata.Show();
            }
            label1.Text = username;

            int left = 60;
            int top = 543;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from answers where q_id=@q_id order by ans_id desc";
            cmd.Parameters.AddWithValue("@q_id", q_id);
            int count = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = 10;
                    int ans_id = (int)reader[0];
                    string a_text = (string)reader[3];
                    int a_u_id = (int)reader[1];
                    string user = null;

                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from login_system where user_Id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id", a_u_id);
                    try
                    {
                        SqlDataReader r = cmd2.ExecuteReader();
                        if (r.Read())
                        {
                            user = (string)r[3];
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                    Panel ans_panel = new Panel();
                    Panel ans_text_panel = new Panel();
                    Label ans_text = new Label();
                    Label username_label = new Label();
                    PictureBox pictureBox1 = new PictureBox();
                    this.Controls.Add(ans_panel);

                    ans_panel.BackColor = Color.FromArgb(232, 241, 245);
                    ans_panel.Controls.Add(ans_text_panel);
                    ans_panel.Controls.Add(username_label);
                    ans_panel.Controls.Add(pictureBox1);
                    ans_panel.Location = new Point(left, top);
                    ans_panel.Name = "ans_panel";
                    ans_panel.Size = new Size(1084, 261);
                    ans_panel.TabIndex = 6;
                    ans_panel.Paint += panel2_Paint;
                    // 
                    // ans_text_panel
                    // 
                    ans_text_panel.AutoScroll = true;
                    ans_text_panel.Controls.Add(ans_text);
                    ans_text_panel.Location = new Point(277, 31);
                    ans_text_panel.Name = "ans_text_panel";
                    ans_text_panel.Size = new Size(780, 207);
                    ans_text_panel.TabIndex = 2;
                    // 
                    // ans_text
                    // 
                    ans_text.AutoSize = true;
                    ans_text.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    ans_text.Location = new Point(14, 10);
                    ans_text.MaximumSize = new Size(730, 0);
                    ans_text.Name = "ans_text";
                    ans_text.Size = new Size(725, 728);
                    ans_text.TabIndex = 0;
                    ans_text.Text = a_text;
                    // 
                    // username_label
                    // 
                    username_label.AutoSize = true;
                    username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    username_label.Location = new Point(91, 206);
                    username_label.Name = "username_label";
                    username_label.Size = new Size(103, 32);
                    username_label.TabIndex = 1;
                    username_label.Text = user;
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Properties.Resources.undraw_Pic_profile_re_7g2h_removebg_preview;
                    pictureBox1.Location = new Point(46, 27);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(198, 176);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.TabIndex = 0;
                    pictureBox1.TabStop = false;

                    top += 275;
                }

                if (count == 0)
                {
                    Label noans_text = new Label();
                    this.Controls.Add(noans_text);

                    noans_text.AutoSize = true;
                    noans_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    noans_text.ForeColor = Color.FromArgb(0, 72, 124);
                    noans_text.Location = new Point(102, 567);
                    noans_text.Name = "noans_text";
                    noans_text.Size = new Size(1039, 32);
                    noans_text.TabIndex = 7;
                    noans_text.Text = "No One posted  the answer yet. Be the first person to post answers and start conversation.";
                }
            }
            catch (Exception ex) { }

            top += 60;
            Panel footer = new Panel();
            Label footer_text = new Label();
            this.Controls.Add(footer);
            footer.BackColor = Color.FromArgb(0, 86, 145);
            footer.Controls.Add(footer_text);
            footer.Location = new Point(-3, top);
            footer.Name = "footer";
            footer.Size = new Size(1180, 60);
            footer.TabIndex = 4;
            // 
            // footer_text
            // 
            footer_text.AutoSize = true;
            footer_text.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            footer_text.ForeColor = Color.FromArgb(232, 241, 245);
            footer_text.Location = new Point(360, 23);
            footer_text.Name = "footer_text";
            footer_text.Size = new Size(301, 30);
            footer_text.TabIndex = 0;
            footer_text.Text = "CODINGSOLUTIONS @2023";
        }


       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            this.Hide();
            s.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            this.Hide();
            p.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            questions q = new questions();
            this.Hide();
            q.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            this.Hide();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void answers_Load_1(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            if (username == null)
            {
                //navbar_userdata.Hide();
                navbar_user_btn.Show();
                panel2.Show();
            }
            else
            {
                //navbar_username.Text = username;
                navbar_user_btn.Hide();
                panel1.Show();
                //navbar_userdata.Show();
            }
            label1.Text = username;

            int left = 60;
            int top = 543;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from answers where q_id=@q_id order by ans_id desc";
            cmd.Parameters.AddWithValue("@q_id", q_id);
            int count = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = 10;
                    int ans_id = (int)reader[0];
                    string a_text = (string)reader[3];
                    int a_u_id = (int)reader[1];
                    string user = null;

                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from login_system where user_Id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id", a_u_id);
                    try
                    {
                        SqlDataReader r = cmd2.ExecuteReader();
                        if (r.Read())
                        {
                            user = (string)r[3];
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                    Panel ans_panel = new Panel();
                    Panel ans_text_panel = new Panel();
                    Label ans_text = new Label();
                    Label username_label = new Label();
                    PictureBox pictureBox1 = new PictureBox();
                    this.Controls.Add(ans_panel);

                    ans_panel.BackColor = Color.FromArgb(232, 241, 245);
                    ans_panel.Controls.Add(ans_text_panel);
                    ans_panel.Controls.Add(username_label);
                    ans_panel.Controls.Add(pictureBox1);
                    ans_panel.Location = new Point(left, top);
                    ans_panel.Name = "ans_panel";
                    ans_panel.Size = new Size(1084, 261);
                    ans_panel.TabIndex = 6;
                    ans_panel.Paint += panel2_Paint;
                    // 
                    // ans_text_panel
                    // 
                    ans_text_panel.AutoScroll = true;
                    ans_text_panel.Controls.Add(ans_text);
                    ans_text_panel.Location = new Point(277, 31);
                    ans_text_panel.Name = "ans_text_panel";
                    ans_text_panel.Size = new Size(780, 207);
                    ans_text_panel.TabIndex = 2;
                    // 
                    // ans_text
                    // 
                    ans_text.AutoSize = true;
                    ans_text.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    ans_text.Location = new Point(14, 10);
                    ans_text.MaximumSize = new Size(730, 0);
                    ans_text.Name = "ans_text";
                    ans_text.Size = new Size(725, 728);
                    ans_text.TabIndex = 0;
                    ans_text.Text = a_text;
                    // 
                    // username_label
                    // 
                    username_label.AutoSize = true;
                    username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    username_label.Location = new Point(91, 206);
                    username_label.Name = "username_label";
                    username_label.Size = new Size(103, 32);
                    username_label.TabIndex = 1;
                    username_label.Text = user;
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Properties.Resources.undraw_Pic_profile_re_7g2h_removebg_preview;
                    pictureBox1.Location = new Point(46, 27);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(198, 176);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.TabIndex = 0;
                    pictureBox1.TabStop = false;

                    top += 275;
                }

                if (count == 0)
                {
                    Label noans_text = new Label();
                    this.Controls.Add(noans_text);

                    noans_text.AutoSize = true;
                    noans_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    noans_text.ForeColor = Color.FromArgb(0, 72, 124);
                    noans_text.Location = new Point(102, 567);
                    noans_text.Name = "noans_text";
                    noans_text.Size = new Size(1039, 32);
                    noans_text.TabIndex = 7;
                    noans_text.Text = "No One posted  the answer yet. Be the first person to post answers and start conversation.";
                }
            }
            catch (Exception ex) { }

            top += 60;
            Panel footer = new Panel();
            Label footer_text = new Label();
            this.Controls.Add(footer);
            footer.BackColor = Color.FromArgb(0, 86, 145);
            footer.Controls.Add(footer_text);
            footer.Location = new Point(-3, top);
            footer.Name = "footer";
            footer.Size = new Size(1180, 60);
            footer.TabIndex = 4;
            // 
            // footer_text
            // 
            footer_text.AutoSize = true;
            footer_text.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            footer_text.ForeColor = Color.FromArgb(232, 241, 245);
            footer_text.Location = new Point(360, 23);
            footer_text.Name = "footer_text";
            footer_text.Size = new Size(301, 30);
            footer_text.TabIndex = 0;
            footer_text.Text = "CODINGSOLUTIONS @2023";
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void about_Click_1(object sender, EventArgs e)
        {
            About a = new About();
            this.Hide();
            a.Show();
        }

        private void contact_Click_1(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void signup_Click_1(object sender, EventArgs e)
        {
            Signup s = new Signup();
            this.Hide();
            s.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            questions q = new questions();
            this.Hide();
            q.Show();
        }
        private void post_btn_Click(object sender, EventArgs e)
        {
            string ans_txt = input_des.Text;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into [answers](user_id,q_id,text)values(@u_id,@q_id,@text)";
            cmd.Parameters.AddWithValue("@u_id", user_id);
            cmd.Parameters.AddWithValue("@q_id", q_id);
            cmd.Parameters.AddWithValue("@text", ans_txt);
            try
            {
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    answers a = new answers();
                    this.Close();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Somethinng went wrong");
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
