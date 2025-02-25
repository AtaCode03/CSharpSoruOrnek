namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnSoruNo = new Label();
            btnDogru = new Label();
            btnYanlıs = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnsonraki = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(520, 215);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(12, 221);
            btnA.Name = "btnA";
            btnA.Size = new Size(202, 62);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Visible = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(238, 221);
            btnB.Name = "btnB";
            btnB.Size = new Size(202, 62);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Visible = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(12, 289);
            btnC.Name = "btnC";
            btnC.Size = new Size(202, 62);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Visible = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(238, 289);
            btnD.Name = "btnD";
            btnD.Size = new Size(202, 62);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Visible = false;
            btnD.Click += btnD_Click;
            // 
            // btnSoruNo
            // 
            btnSoruNo.AutoSize = true;
            btnSoruNo.Location = new Point(555, 29);
            btnSoruNo.Name = "btnSoruNo";
            btnSoruNo.Size = new Size(61, 20);
            btnSoruNo.TabIndex = 5;
            btnSoruNo.Text = "SoruNO";
            // 
            // btnDogru
            // 
            btnDogru.AutoSize = true;
            btnDogru.Location = new Point(555, 63);
            btnDogru.Name = "btnDogru";
            btnDogru.Size = new Size(92, 20);
            btnDogru.TabIndex = 6;
            btnDogru.Text = "Doğru Sayısı";
            // 
            // btnYanlıs
            // 
            btnYanlıs.AutoSize = true;
            btnYanlıs.Location = new Point(555, 95);
            btnYanlıs.Name = "btnYanlıs";
            btnYanlıs.Size = new Size(87, 20);
            btnYanlıs.TabIndex = 7;
            btnYanlıs.Text = "Yanlış Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(666, 29);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 8;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 63);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(666, 95);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(491, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(637, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // btnsonraki
            // 
            btnsonraki.Location = new Point(555, 135);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(128, 58);
            btnsonraki.TabIndex = 13;
            btnsonraki.Text = "Sonraki Soru";
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 375);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 14;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(491, 407);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "label1";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnsonraki);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnYanlıs);
            Controls.Add(btnDogru);
            Controls.Add(btnSoruNo);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label btnSoruNo;
        private Label btnDogru;
        private Label btnYanlıs;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnsonraki;
        private Label label7;
        private Label label8;
    }
}
