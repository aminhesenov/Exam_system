namespace Exam_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool k = false;

            if (maskedTextBox1.Text == string.Empty)
            {
                k = true;
                errorProvider1.SetError(maskedTextBox1, "sdf1 empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (maskedTextBox2.Text == string.Empty)
            {
                k = true;
                errorProvider2.SetError(maskedTextBox2, "sdf2 empty");
            }
            else
            {
                errorProvider2.Clear();
            }
            if (maskedTextBox3.Text == string.Empty)
            {
                k = true;
                errorProvider3.SetError(maskedTextBox3, "TSI empty");
            }
            else
            {
                errorProvider3.Clear();
            }
            if (maskedTextBox4.Text == string.Empty)
            {
                k = true;
                errorProvider4.SetError(maskedTextBox4, "DVM empty");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (maskedTextBox5.Text == string.Empty)
            {
                k = true;
                errorProvider5.SetError(maskedTextBox5, "SSI empty");
            }
            else
            {
                errorProvider5.Clear();
            }
            if (textBox1.Text == string.Empty)
            {
                k = true;
                errorProvider6.SetError(textBox1, "fullname empty");
            }
            else
            {
                errorProvider6.Clear();
            }
            if (textBox2.Text == string.Empty)
            {
                k = true;
                errorProvider7.SetError(textBox2, "Profession empty");
            }
            else
            {
                errorProvider7.Clear();
            }

            int sdf1 = int.Parse(maskedTextBox1.Text);
            int sdf2 = int.Parse(maskedTextBox2.Text);
            int tsi = int.Parse(maskedTextBox3.Text);
            int dvm = int.Parse(maskedTextBox4.Text);
            int ssi = int.Parse(maskedTextBox5.Text);
            string fullname = textBox1.Text;
            string prof = textBox2.Text;
            int avg = 0;
            if ((sdf1 >= 0 && sdf1 <= 15) &&
                (sdf2 >= 0 && sdf2 <= 15 && k == false)
                )
            {
                avg += sdf1 + sdf2;
            }
            else
            {
                MessageBox.Show("Qiymət 0-15 arası daxil edilir");
                k = true;
            }
            if ((tsi >= 0 && tsi <= 10) &&
                (dvm >= 0 && dvm <= 10))
            {
                avg += tsi + dvm;
            }
            else
            {
                MessageBox.Show("Qiymət 0-10 arası daxil edilir");
                k = true;
            }
            if ((ssi >= 0 && ssi <= 50))
            {
                avg += ssi;
            }
            else
            {
                MessageBox.Show("Qiymət 0-50 arası daxil edilir");
                k = true;
            }

            if (avg >= 91 && avg <= 100 && k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "A");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);

            }
            else if (avg >= 81 && avg <= 90 && k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "B");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);


            }
            else if (avg >= 71 && avg <= 80 && k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "C");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);


            }
            else if (avg >= 61 && avg <= 70 && ssi >= 17 && k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "D");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);


            }
            else if (avg >= 51 && avg <= 60 && ssi >= 17 && k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "E");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);
            }
            else if (k == false)
            {
                dataGridView1.Rows.Add(fullname, prof, avg, "F");
                notifyIcon1.BalloonTipTitle = "Bildiriş";
                notifyIcon1.BalloonTipText = "Tələbənin qiyməti sistemə əlavə edildir!";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(3000);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proqram bağlansınmı?",
                           "Tətbiq bildirişi",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}



