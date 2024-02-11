namespace LW1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox4 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 70);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 114);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Код";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 161);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 2;
            label3.Text = "Количество полос";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 204);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 3;
            label4.Text = "Продано билетов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 247);
            label5.Name = "label5";
            label5.Size = new Size(240, 20);
            label5.TabIndex = 4;
            label5.Text = "Среднее количество пассажиров";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 290);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 5;
            label6.Text = "Доход за месяц";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 333);
            label7.Name = "label7";
            label7.Size = new Size(196, 20);
            label7.TabIndex = 6;
            label7.Text = "Количество происшествий";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(424, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(424, 154);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(424, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(424, 197);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(125, 27);
            numericUpDown2.TabIndex = 12;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(424, 326);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(125, 27);
            numericUpDown3.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(154, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(424, 396);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox4);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление аэропорта";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private Button button2;
    }
}