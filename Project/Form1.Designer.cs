namespace Project
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            button3 = new Button();
            panel5 = new Panel();
            label12 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 71);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 26);
            label1.Name = "label1";
            label1.Size = new Size(246, 39);
            label1.TabIndex = 1;
            label1.Text = "00 : 00 : 00 AM       ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = Properties.Resources.Simple_icon_time_svg__1___1___1_;
            pictureBox2.Location = new Point(368, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 38);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(564, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(614, 39);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(573, 34);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 4;
            label3.Text = "Поиск по ФИО...";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.Image = Properties.Resources.png_clipart_computer_icons_magnifying_glass_magnifier_magnifying_glass_glass_illustrator__1___1_;
            button2.Location = new Point(1184, 26);
            button2.Name = "button2";
            button2.Size = new Size(40, 39);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 654);
            panel1.TabIndex = 6;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(27, 243);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(109, 19);
            radioButton4.TabIndex = 13;
            radioButton4.Text = "Выписываются";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged_1;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 204);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 12;
            radioButton3.Text = "Заняты";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 162);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 19);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Свободные";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 117);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 19);
            radioButton1.TabIndex = 10;
            radioButton1.Text = "Зарезервировано";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(27, 20);
            label2.Name = "label2";
            label2.Size = new Size(301, 52);
            label2.TabIndex = 9;
            label2.Text = "Статус                 ";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(433, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 654);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(49, 20);
            label4.Name = "label4";
            label4.Size = new Size(336, 52);
            label4.TabIndex = 10;
            label4.Text = "Список гостей       ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(980, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 654);
            panel3.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(222, 22);
            label14.Name = "label14";
            label14.Size = new Size(0, 50);
            label14.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(188, 594);
            button3.Name = "button3";
            button3.Size = new Size(144, 38);
            button3.TabIndex = 19;
            button3.Text = "Просмотр карточки";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cyan;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(25, 508);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 57);
            panel5.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(91, 20);
            label12.Name = "label12";
            label12.Size = new Size(88, 21);
            label12.TabIndex = 2;
            label12.Text = "16.02.2023";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 10);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 1;
            label10.Text = "Дата выезда";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(25, 436);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 57);
            panel4.TabIndex = 17;
            panel4.Paint += panel4_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(87, 21);
            label11.Name = "label11";
            label11.Size = new Size(88, 21);
            label11.TabIndex = 1;
            label11.Text = "16.02.2023";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 0;
            label9.Text = "Дата заезда";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(25, 383);
            label8.Name = "label8";
            label8.Size = new Size(226, 27);
            label8.TabIndex = 16;
            label8.Text = "ФИО                                  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(25, 319);
            label6.Name = "label6";
            label6.Size = new Size(70, 27);
            label6.TabIndex = 13;
            label6.Text = "Статус";
            label6.Click += label6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.u632396_prof_2000__1___2_;
            pictureBox3.Location = new Point(64, 90);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 200);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(25, 20);
            label5.Name = "label5";
            label5.Size = new Size(191, 52);
            label5.TabIndex = 11;
            label5.Text = "Номер №";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += tick;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Зарезервировано", "Свободные", "Заняты", "Выписываются" });
            comboBox1.Location = new Point(113, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1365, 775);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        public TextBox textBox2;
        private Label label3;
        private Button button2;
        private Panel panel1;
        public Panel panel2;
        private Panel panel3;
        private Label label2;
        private RadioButton radioButton2;
        public RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label8;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Button button3;
        private Label label12;
        private Label label11;
        private Label label14;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
    }
}