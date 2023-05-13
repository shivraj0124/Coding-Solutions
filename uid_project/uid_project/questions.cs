using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uid_project.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace uid_project
{
    public partial class questions : Form
    {
        public questions()
        {
            InitializeComponent();
        }
        int cat_id = Global_data.categories_id;
        string username = Global_data.username;
        int user_id = Global_data.userid;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            string q_title = input_title.Text;
            string q_des = input_des.Text;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into [questions](qtittle,qdescription,cat_id,u_id)values(@qtittle,@qdescription,@cat_id,@u_id)";
            cmd.Parameters.AddWithValue("@qtittle", q_title);
            cmd.Parameters.AddWithValue("@qdescription", q_des);
            cmd.Parameters.AddWithValue("@cat_id", cat_id);
            cmd.Parameters.AddWithValue("@u_id", user_id);
            try
            {
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    questions q = new questions();
                    this.Close();
                    q.Show();
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

        private void questions_Load(object sender, EventArgs e)
        {

            panel1.Hide();
            post_hide_panel.Hide();
            if (username == null)
            {
                //navbar_userdata.Hide();
                navbar_user_btn.Show();
                post_hide_panel.Show();
            }
            else
            {
                //navbar_username.Text = username;
                navbar_user_btn.Hide();
                panel1.Show();
                //navbar_userdata.Show();
            }
            label1.Text = username;

            int left = 58;
            int top = 645;
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from questions where cat_id=@cat_id order by q_id desc";
            cmd.Parameters.AddWithValue("@cat_id", cat_id);
            int count = 0;
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count = 10;
                    int q_id = (int)reader[0];
                    string q_title = (string)reader[1];
                    string q_des = (string)reader[2];
                    int q_u_id = (int)reader[5];
                    string user = null;

                    SqlConnection conn1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.Connection = conn1;
                    cmd.CommandText = "select * from login_system where user_id=@user_id";
                    cmd.Parameters.AddWithValue("@user_id", q_u_id);
                    try
                    {
                        conn1.Open();
                        SqlDataReader r = cmd2.ExecuteReader();
                        if (r.Read())
                        {
                            user = (string)r[3];

                        }

                    }
                    catch (Exception ex)
                    {

                    }

                    Panel ques_panel = new Panel();
                    Label q_user = new Label();
                    Button ans_btn = new Button();
                    Panel ques_des_panel = new Panel();
                    Label des = new Label();
                    Label title = new Label();
                    PictureBox user_pic = new PictureBox();
                    this.Controls.Add(ques_panel);
                    //119 886

                    ques_panel.BackColor = Color.FromArgb(232, 241, 245);
                    ques_panel.Controls.Add(ans_btn);
                    ques_panel.Controls.Add(q_user);
                    ques_panel.Controls.Add(title);
                    ques_panel.Controls.Add(ques_des_panel);
                    ques_panel.Controls.Add(user_pic);
                    ques_panel.Location = new Point(left, top);
                    ques_panel.Name = "ques_panel";
                    ques_panel.Size = new Size(850, 285);
                    ques_panel.TabIndex = 7;
                    // 
                    // user_pic
                    // 
                    user_pic.Image = Properties.Resources.users_vector_icon_png_260862_removebg_preview;
                    user_pic.Location = new Point(34, 41);
                    user_pic.Name = "user_pic";
                    user_pic.Size = new Size(173, 162);
                    user_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    user_pic.TabIndex = 0;
                    user_pic.TabStop = false;
                    // 
                    // ques_des_panel
                    // 
                    ques_des_panel.AutoScroll = true;
                    ques_des_panel.Controls.Add(des);
                    ques_des_panel.Location = new Point(249, 62);
                    ques_des_panel.Name = "ques_des_panel";
                    ques_des_panel.Size = new Size(799, 160);
                    ques_des_panel.TabIndex = 1;
                    // 
                    // title
                    // 
                    title.AutoSize = true;
                    title.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                    title.Location = new Point(249, 20);
                    title.Name = "title";
                    title.Size = new Size(432, 30);
                    title.TabIndex = 2;
                    title.Text = q_title;
                    // 
                    // des
                    // 
                    des.AutoSize = true;
                    des.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    des.Location = new Point(26, 16);
                    des.MaximumSize = new Size(730, 0);
                    des.Name = "des";
                    des.Size = new Size(728, 196);
                    des.TabIndex = 0;
                    des.Text = q_des;
                    // 
                    // q_user
                    // 
                    q_user.AutoSize = true;
                    q_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    q_user.Location = new Point(75, 206);
                    q_user.Name = "q_user";
                    q_user.Size = new Size(93, 32);
                    q_user.TabIndex = 8;
                    q_user.Text = user;
                    // 
                    // ans_btn
                    // 
                    ans_btn.BackColor = Color.FromArgb(0, 86, 145);
                    ans_btn.FlatAppearance.BorderSize = 0;
                    ans_btn.FlatStyle = FlatStyle.Flat;
                    ans_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                    ans_btn.ForeColor = Color.FromArgb(232, 241, 245);
                    ans_btn.Location = new Point(700, 234);//909
                    ans_btn.Name = "ans_btn";
                    ans_btn.Size = new Size(121, 37);
                    ans_btn.TabIndex = 9;
                    ans_btn.Text = "Answers";
                    ans_btn.UseVisualStyleBackColor = false;
                    ans_btn.Click += ans_btn_Click;

                    top += 300;

                    void ans_btn_Click(object sender, EventArgs e)
                    {
                        Global_data.question_id = q_id;
                        answers a = new answers();
                        this.Hide();
                        a.Show();
                    }

                }

                if (count == 0)
                {
                    Label noque_text = new Label();
                    this.Controls.Add(noque_text);

                    noque_text.AutoSize = true;
                    noque_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    noque_text.ForeColor = Color.FromArgb(0, 72, 124);
                    noque_text.Location = new Point(191, 610);
                    noque_text.Name = "noque_text";
                    noque_text.Size = new Size(811, 32);
                    noque_text.TabIndex = 5;
                    noque_text.Text = "No One posted a question yet.  post  a question ans start conversation";
                }

            }
            catch (Exception ex)
            {

            }

            top += 60;
            Panel footer = new Panel();
            Label footer_text = new Label();
            this.Controls.Add(footer);
            footer.BackColor = Color.FromArgb(0, 86, 145);
            footer.Controls.Add(footer_text);
            footer.Location = new Point(-3, top);
            footer.Name = "footer";
            footer.Size = new Size(945, 60);
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







        private void Home_MouseHover(object sender, EventArgs e)
        {

        }

        private void logo2_Click(object sender, EventArgs e)
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
            Form1 form = new Form1();
            this.Hide();
            form.Show();
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
    }
}
