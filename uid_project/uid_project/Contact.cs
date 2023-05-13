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

namespace uid_project
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        string username = Global_data.username;
        int user_id = Global_data.userid;
        private void Contact_Load(object sender, EventArgs e)
        {
            notification.Hide();
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
                input_username.Text = username;
                //navbar_userdata.Show();
            }
            label1.Text = username;

            int top = 630;
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

        private void Home_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            About a = new About();
            this.Hide();
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            string user = input_username.Text;
            string email = input_mail.Text;
            string text = input_msg.Text;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into contact (user_id,username,email,text)values(@u_id,@username,@email,@text)";
            cmd.Parameters.AddWithValue("@u_id", user_id);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@text", text);

            try
            {
                conn.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    notification.Show();
                    notification_label.Text = "Message send suceessfully";
                }
                else
                {
                    notification.Show();
                    notification_label.Text = "Something went wrong!!!!";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void notification_cancel_btn_Click(object sender, EventArgs e)
        {
            notification.Hide();
        }
    }
}
