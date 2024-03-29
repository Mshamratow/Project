namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(53, 65);
            label2.Name = "label2";
            label2.Size = new Size(338, 52);
            label2.TabIndex = 10;
            label2.Text = "Карточка гостя      ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(55, 166);
            label8.Name = "label8";
            label8.Size = new Size(307, 34);
            label8.TabIndex = 17;
            label8.Text = "ФИО                                  ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(55, 250);
            label1.Name = "label1";
            label1.Size = new Size(305, 34);
            label1.TabIndex = 18;
            label1.Text = "Дата рождения                 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(55, 329);
            label3.Name = "label3";
            label3.Size = new Size(249, 34);
            label3.TabIndex = 19;
            label3.Text = "Оплата                      ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(316, 329);
            button1.Name = "button1";
            button1.Size = new Size(46, 34);
            button1.TabIndex = 20;
            button1.Text = "▼";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSlateGray;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(53, 419);
            button2.Name = "button2";
            button2.Size = new Size(58, 52);
            button2.TabIndex = 21;
            button2.Text = "—";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(117, 421);
            label4.Name = "label4";
            label4.Size = new Size(92, 47);
            label4.TabIndex = 22;
            label4.Text = "  00  ";
            // 
            // button3
            // 
            button3.BackColor = Color.LightSlateGray;
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(215, 419);
            button3.Name = "button3";
            button3.Size = new Size(58, 52);
            button3.TabIndex = 23;
            button3.Text = "➕";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(293, 426);
            label5.Name = "label5";
            label5.Size = new Size(246, 42);
            label5.TabIndex = 24;
            label5.Text = "Количество дней";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.ForestGreen;
            checkBox1.Location = new Point(55, 516);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(180, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Путешествую с животными";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(578, 699);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label8;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        public Label label4;
        private Button button3;
        private Label label5;
        private CheckBox checkBox1;
    }
}