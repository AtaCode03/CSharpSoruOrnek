namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlýs = 0;
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
                richTextBox1.Text = "Türkiye'nin baþkenti neresidir?";
                btnA.Text = "Ýstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "Ýzmir";
                btnD.Text = "Amasya";
                label7.Text = "Ankara";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "2 + 2 kaç eder?";
                btnA.Text = "4";
                btnB.Text = "5";
                btnC.Text = "6";
                btnD.Text = "7";
                label7.Text = "4";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Su kaç derecede donar?";
                btnA.Text = "25";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "0";
                label7.Text = "0";
            }
            if(soruNo == 4)
            {
                richTextBox1.Text = "Tebrikler testi btirdiniz\n" +
                    $"Doðru sayýnýz {label5.Text}\n" +
                    $"Yanlýþ sayýnýz {label6.Text}";
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
                yanlýs++;
                label6.Text = yanlýs.ToString();
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
                yanlýs++;
                label6.Text = yanlýs.ToString();
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
                yanlýs++;
                label6.Text = yanlýs.ToString();
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
                yanlýs++;
                label6.Text = yanlýs.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}
