namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanl�s = 0;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnsonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            label4.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "T�rkiye'nin ba�kenti neresidir?";
                btnA.Text = "�stanbul";
                btnB.Text = "Ankara";
                btnC.Text = "�zmir";
                btnD.Text = "Amasya";
                label7.Text = "Ankara";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "2 + 2 ka� eder?";
                btnA.Text = "4";
                btnB.Text = "5";
                btnC.Text = "6";
                btnD.Text = "7";
                label7.Text = "4";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Su ka� derecede donar?";
                btnA.Text = "25";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "0";
                label7.Text = "0";
            }
            if(soruNo == 4)
            {
                richTextBox1.Text = "Tebrikler testi btirdiniz\n" +
                    $"Do�ru say�n�z {label5.Text}\n" +
                    $"Yanl�� say�n�z {label6.Text}";
                btnA.Visible = false;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                btnsonraki.Visible = false;
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label8.Text = btnA.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanl�s++;
                label6.Text = yanl�s.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label8.Text = btnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanl�s++;
                label6.Text = yanl�s.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label8.Text = btnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanl�s++;
                label6.Text = yanl�s.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;

            label8.Text = btnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanl�s++;
                label6.Text = yanl�s.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}
