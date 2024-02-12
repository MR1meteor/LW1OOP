namespace LW1;

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
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        button2 = new Button();
        button3 = new Button();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        label14 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(537, 12);
        button1.Name = "button1";
        button1.Size = new Size(251, 47);
        button1.TabIndex = 0;
        button1.Text = "Добавить аэропорт";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(356, 126);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 1;
        label1.Tag = "based";
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(356, 164);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 2;
        label2.Tag = "based";
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(356, 202);
        label3.Name = "label3";
        label3.Size = new Size(50, 20);
        label3.TabIndex = 3;
        label3.Tag = "based";
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(356, 241);
        label4.Name = "label4";
        label4.Size = new Size(50, 20);
        label4.TabIndex = 4;
        label4.Tag = "based";
        label4.Text = "label4";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(356, 283);
        label5.Name = "label5";
        label5.Size = new Size(50, 20);
        label5.TabIndex = 5;
        label5.Tag = "based";
        label5.Text = "label5";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(356, 318);
        label6.Name = "label6";
        label6.Size = new Size(50, 20);
        label6.TabIndex = 6;
        label6.Tag = "based";
        label6.Text = "label6";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(356, 350);
        label7.Name = "label7";
        label7.Size = new Size(50, 20);
        label7.TabIndex = 7;
        label7.Tag = "based";
        label7.Text = "label7";
        // 
        // button2
        // 
        button2.Location = new Point(251, 12);
        button2.Name = "button2";
        button2.Size = new Size(280, 47);
        button2.TabIndex = 8;
        button2.Tag = "based";
        button2.Text = "Редактировать данные";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(12, 12);
        button3.Name = "button3";
        button3.Size = new Size(233, 47);
        button3.TabIndex = 9;
        button3.Tag = "based";
        button3.Text = "Удалить аэропорт";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(234, 126);
        label8.Name = "label8";
        label8.Size = new Size(77, 20);
        label8.TabIndex = 10;
        label8.Tag = "based";
        label8.Text = "Название";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(276, 164);
        label9.Name = "label9";
        label9.Size = new Size(35, 20);
        label9.TabIndex = 11;
        label9.Tag = "based";
        label9.Text = "Код";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(178, 202);
        label10.Name = "label10";
        label10.Size = new Size(136, 20);
        label10.TabIndex = 12;
        label10.Tag = "based";
        label10.Text = "Количество полос";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(178, 241);
        label11.Name = "label11";
        label11.Size = new Size(133, 20);
        label11.TabIndex = 13;
        label11.Tag = "based";
        label11.Text = "Продано билетов";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(74, 283);
        label12.Name = "label12";
        label12.Size = new Size(240, 20);
        label12.TabIndex = 14;
        label12.Tag = "based";
        label12.Text = "Среднее количество пассажиров";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(193, 318);
        label13.Name = "label13";
        label13.Size = new Size(118, 20);
        label13.TabIndex = 15;
        label13.Tag = "based";
        label13.Text = "Доход за месяц";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(115, 350);
        label14.Name = "label14";
        label14.Size = new Size(196, 20);
        label14.TabIndex = 16;
        label14.Tag = "based";
        label14.Text = "Количество происшествий";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label14);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Аэропорты";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Button button2;
    private Button button3;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
}