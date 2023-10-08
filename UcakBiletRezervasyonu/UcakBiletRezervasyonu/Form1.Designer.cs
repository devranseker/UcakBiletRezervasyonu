namespace UcakBiletRezervasyonu
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
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(41, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Information ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(89, 105);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(118, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 113);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Clock :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 78);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Date : ";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara ", "Manisa ", "Bursa ", "İstanbul", "Sivas ", "Erzurum " });
            comboBox2.Location = new Point(86, 43);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara ", "Bursa ", "İstanbul", "Sivas ", "Erzurum ", "Trabzon " });
            comboBox1.Location = new Point(86, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 43);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "Where  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 20);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "From where  :";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(328, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 195);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passenger Information ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(139, 161);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(139, 116);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(118, 23);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(139, 89);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(118, 23);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 116);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 7;
            label8.Text = "Phone :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 92);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "IdNo :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 59);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 1;
            label6.Text = "Passenger Surname :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Passenger name :";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ButtonFace;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(41, 332);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(612, 94);
            listBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(41, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 109);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(53, 26);
            label9.Name = "label9";
            label9.Size = new Size(325, 48);
            label9.TabIndex = 0;
            label9.Text = "DEVRAN  Airlines ";
            // 
            // button2
            // 
            button2.Location = new Point(213, 43);
            button2.Name = "button2";
            button2.Size = new Size(56, 23);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 459);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Uçuş Bilgileri ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private ListBox listBox1;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
        private Button button2;
    }
}