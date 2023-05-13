using System.Data.SqlClient;
using uid_project.Properties;

namespace uid_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string username = Global_data.username;
            if (username == null)
            {
                //navbar_userdata.Hide();
                navbar_user_btn.Show();
            }
            else
            {
                //navbar_username.Text = username;
                navbar_user_btn.Hide();
                //navbar_userdata.Show();
            }
            label1.Text = username;
            int left = 53;
            int top = 623;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("select * from categeries", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cat_id = (int)reader[0];
                    string title = (string)reader[1];
                    string description = (string)reader[2];

                    Panel cat_card = new Panel();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Button Questions = new Button();
                    PictureBox pictureBox1 = new PictureBox();
                    this.Controls.Add(cat_card);

                    cat_card.BackColor = Color.MintCream;
                    // cat_card.BackgroundImage = Properties.Resources.software_development_programming_coding_vector_concept_123447_266_removebg_preview;
                    //cat_card.BackgroundImageLayout = ImageLayout.Stretch;
                    cat_card.BorderStyle = BorderStyle.Fixed3D;
                    cat_card.Controls.Add(pictureBox1);
                    cat_card.Controls.Add(label3);
                    cat_card.Controls.Add(Questions);
                    cat_card.Controls.Add(label2);
                    cat_card.Controls.Add(label1);
                    cat_card.Location = new Point(left, top);
                    cat_card.Name = "cat_card";
                    cat_card.Size = new Size(342, 419);
                    cat_card.TabIndex = 1;
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Properties.Resources._16fb44c86a13139846e93123deb55cbb_removebg_preview;
                    pictureBox1.Location = new Point(16, 3);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(63, 54);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.TabIndex = 2;
                    pictureBox1.TabStop = false;
                    // 
                    // label3
                    // 
                    label3.BorderStyle = BorderStyle.Fixed3D;
                    label3.Location = new Point(3, 70);
                    label3.Name = "label3";
                    label3.Size = new Size(323, 3);
                    label3.TabIndex = 2;
                    label3.Text = cat_id.ToString();
                    // 
                    // Questions
                    //             
                    Questions.BackColor = Color.FromArgb(0, 74, 124);
                    Questions.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    Questions.FlatStyle = FlatStyle.Flat;
                    Questions.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                    Questions.ForeColor = SystemColors.ButtonHighlight;
                    Questions.Location = new Point(16, 354);
                    Questions.Name = "Questions";
                    Questions.Size = new Size(140, 43);
                    Questions.TabIndex = 2;
                    Questions.Text = "Questions";
                    Questions.UseVisualStyleBackColor = false;
                    Questions.Click += Questions_Click;
                    // 
                    // label2
                    // 
                    label2.AutoSize = true;
                    label2.BackColor = Color.Transparent;
                    label2.ForeColor = SystemColors.ActiveCaptionText;
                    label2.Location = new Point(16, 111);
                    label2.MaximumSize = new Size(310, 0);
                    label2.Name = "label2";
                    label2.Size = new Size(306, 224);
                    label2.TabIndex = 2;
                    label2.Text = description;
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
                    label1.Location = new Point(16, 73);
                    label1.Name = "label1";
                    label1.Size = new Size(193, 38);
                    label1.TabIndex = 2;
                    label1.Text = title;

                    left += 365;

                    void Questions_Click(object sender, EventArgs e)
                    {
                        Global_data.categories_id = cat_id;
                        questions q = new questions();
                        this.Hide();
                        q.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again" + ex);
            }

            top += 440;
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
            footer_text.Location = new Point(449, 23);
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

        private void contact_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string username = Global_data.username;
            if (username == null)
            {
                //navbar_userdata.Hide();
                navbar_user_btn.Show();
            }
            else
            {
                //navbar_username.Text = username;
                navbar_user_btn.Hide();
                //navbar_userdata.Show();
            }
            label1.Text = username;
            int left = 53;
            int top = 623;

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shivraj\\Documents\\uid_project.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand("select * from categeries", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cat_id = (int)reader[0];
                    string title = (string)reader[1];
                    string description = (string)reader[2];

                    Panel cat_card = new Panel();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Button Questions = new Button();
                    PictureBox pictureBox1 = new PictureBox();
                    this.Controls.Add(cat_card);

                    cat_card.BackColor = Color.MintCream;
                    // cat_card.BackgroundImage = Properties.Resources.software_development_programming_coding_vector_concept_123447_266_removebg_preview;
                    //cat_card.BackgroundImageLayout = ImageLayout.Stretch;
                    cat_card.BorderStyle = BorderStyle.Fixed3D;
                    cat_card.Controls.Add(pictureBox1);
                    cat_card.Controls.Add(label3);
                    cat_card.Controls.Add(Questions);
                    cat_card.Controls.Add(label2);
                    cat_card.Controls.Add(label1);
                    cat_card.Location = new Point(left, top);
                    cat_card.Name = "cat_card";
                    cat_card.Size = new Size(342, 419);
                    cat_card.TabIndex = 1;
                    // 
                    // pictureBox1
                    // 
                    pictureBox1.Image = Properties.Resources._16fb44c86a13139846e93123deb55cbb_removebg_preview;
                    pictureBox1.Location = new Point(16, 3);
                    pictureBox1.Name = "pictureBox1";
                    pictureBox1.Size = new Size(63, 54);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.TabIndex = 2;
                    pictureBox1.TabStop = false;
                    // 
                    // label3
                    // 
                    label3.BorderStyle = BorderStyle.Fixed3D;
                    label3.Location = new Point(3, 70);
                    label3.Name = "label3";
                    label3.Size = new Size(323, 3);
                    label3.TabIndex = 2;
                    label3.Text = cat_id.ToString();
                    // 
                    // Questions
                    //             
                    Questions.BackColor = Color.FromArgb(0, 74, 124);
                    Questions.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
                    Questions.FlatStyle = FlatStyle.Flat;
                    Questions.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
                    Questions.ForeColor = SystemColors.ButtonHighlight;
                    Questions.Location = new Point(16, 354);
                    Questions.Name = "Questions";
                    Questions.Size = new Size(140, 43);
                    Questions.TabIndex = 2;
                    Questions.Text = "Questions";
                    Questions.UseVisualStyleBackColor = false;
                    Questions.Click += Questions_Click;
                    // 
                    // label2
                    // 
                    label2.AutoSize = true;
                    label2.BackColor = Color.Transparent;
                    label2.ForeColor = SystemColors.ActiveCaptionText;
                    label2.Location = new Point(16, 111);
                    label2.MaximumSize = new Size(310, 0);
                    label2.Name = "label2";
                    label2.Size = new Size(306, 224);
                    label2.TabIndex = 2;
                    label2.Text = description;
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
                    label1.Location = new Point(16, 73);
                    label1.Name = "label1";
                    label1.Size = new Size(193, 38);
                    label1.TabIndex = 2;
                    label1.Text = title;

                    left += 365;

                    void Questions_Click(object sender, EventArgs e)
                    {
                        Global_data.categories_id = cat_id;
                        questions q = new questions();
                        this.Hide();
                        q.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again" + ex);
            }

            top += 440;
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
            footer_text.Location = new Point(449, 23);
            footer_text.Name = "footer_text";
            footer_text.Size = new Size(301, 30);
            footer_text.TabIndex = 0;
            footer_text.Text = "CODINGSOLUTIONS @2023";
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
            profile p = new profile();
            this.Hide();
            p.Show();
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

        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contact_Click_1(object sender, EventArgs e)
        {
            Contact c = new Contact();
            this.Hide();
            c.Show();
        }
    }
}