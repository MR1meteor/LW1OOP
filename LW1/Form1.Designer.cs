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
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(302, 209);
        button1.Name = "button1";
        button1.Size = new Size(202, 29);
        button1.TabIndex = 0;
        button1.Text = "Добавить аэропорт";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(94, 133);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 1;
        label1.Tag = "based";
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(94, 171);
        label2.Name = "label2";
        label2.Size = new Size(50, 20);
        label2.TabIndex = 2;
        label2.Tag = "based";
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(94, 209);
        label3.Name = "label3";
        label3.Size = new Size(50, 20);
        label3.TabIndex = 3;
        label3.Tag = "based";
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(94, 248);
        label4.Name = "label4";
        label4.Size = new Size(50, 20);
        label4.TabIndex = 4;
        label4.Tag = "based";
        label4.Text = "label4";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(94, 290);
        label5.Name = "label5";
        label5.Size = new Size(50, 20);
        label5.TabIndex = 5;
        label5.Tag = "based";
        label5.Text = "label5";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(94, 325);
        label6.Name = "label6";
        label6.Size = new Size(50, 20);
        label6.TabIndex = 6;
        label6.Tag = "based";
        label6.Text = "label6";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(94, 357);
        label7.Name = "label7";
        label7.Size = new Size(50, 20);
        label7.TabIndex = 7;
        label7.Tag = "based";
        label7.Text = "label7";
        // 
        // button2
        // 
        button2.Location = new Point(302, 280);
        button2.Name = "button2";
        button2.Size = new Size(126, 41);
        button2.TabIndex = 8;
        button2.Tag = "based";
        button2.Text = "Редактировать";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(302, 348);
        button3.Name = "button3";
        button3.Size = new Size(126, 38);
        button3.TabIndex = 9;
        button3.Tag = "based";
        button3.Text = "Удалить";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
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
}