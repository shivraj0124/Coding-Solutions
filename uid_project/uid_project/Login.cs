﻿using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            notification.Hide();

            int top = 659;

            Panel footer = new Panel();
            Label footer_text = new Label();
            this.Controls.Add(footer);
            footer.BackColor = Color.FromArgb(0, 86, 145);
            footer.Controls.Add(footer_text);
            footer.Location = new Point(-3, top);
            footer.Name = "footer";
            footer.Size = new Size(945,60);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from login_system where username=@user";
            command.Parameters.AddWithValue("@user", user);
            try
            {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string getpass = (string)reader[5];
                    int u_id = (int)reader[0];
                    string getuser = (string)reader[3];
                    if (getpass == pass)
                    {
                        Global_data.username = getuser;
                        Global_data.userid = u_id;
                        notification.Show();
                        notification_label.Text = "login sucessful";
                        Form1 f = new Form1();
                        this.Close();
                        f.Show();
                    }
                    else
                    {
                        notification.Show();
                        notification_label.Text = "username or password is not valid";
                    }
                }
                else
                {
                    notification.Show();
                    notification_label.Text = "username or password is not valid";
                }

            }
            catch (Exception ex)
            {
                notification.Show();
                notification_label.Text = "Something went wrong please try again";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void notification_cancel_btn_Click(object sender, EventArgs e)
        {
            notification.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s = new Signup();
            this.Hide();
            s.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

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

        private void contact_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s= new Signup();
            this.Hide();
            s.Show();
        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select * from login_system where username=@user";
            command.Parameters.AddWithValue("@user", user);
            try
            {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string getpass = (string)reader[5];
                    int u_id = (int)reader[0];
                    string getuser = (string)reader[3];
                    if (getpass == pass)
                    {
                        Global_data.username = getuser;
                        Global_data.userid = u_id;
                        notification.Show();
                        notification_label.Text = "login sucessful";
                        Form1 f = new Form1();
                        this.Close();
                        f.Show();
                    }
                    else
                    {
                        notification.Show();
                        notification_label.Text = "username or password is not valid";
                    }
                }
                else
                {
                    notification.Show();
                    notification_label.Text = "username or password is not valid";
                }

            }
            catch (Exception ex)
            {
                notification.Show();
                notification_label.Text = "Something went wrong please try again";
            }
        
    }

        private void Login_Load_1(object sender, EventArgs e)
        {
            notification.Hide();

            int top = 659;

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
    }
}
