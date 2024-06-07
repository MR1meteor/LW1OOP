namespace LW1;

partial class OPP_LB6
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
        SumCalcLogs = new ListView();
        SysTimeLogs = new ListView();
        CountToThreeLogs = new ListView();
        SumCalc = new Button();
        ShowSysTime = new Button();
        CountThree = new Button();
        ArrSize = new NumericUpDown();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)ArrSize).BeginInit();
        SuspendLayout();
        // 
        // SumCalcLogs
        // 
        SumCalcLogs.Location = new Point(8, 63);
        SumCalcLogs.Name = "SumCalcLogs";
        SumCalcLogs.Size = new Size(228, 184);
        SumCalcLogs.TabIndex = 0;
        SumCalcLogs.UseCompatibleStateImageBehavior = false;
        SumCalcLogs.View = View.List;
        // 
        // SysTimeLogs
        // 
        SysTimeLogs.Location = new Point(264, 63);
        SysTimeLogs.Name = "SysTimeLogs";
        SysTimeLogs.Size = new Size(251, 184);
        SysTimeLogs.TabIndex = 1;
        SysTimeLogs.UseCompatibleStateImageBehavior = false;
        SysTimeLogs.View = View.List;
        // 
        // CountToThreeLogs
        // 
        CountToThreeLogs.Location = new Point(549, 63);
        CountToThreeLogs.Name = "CountToThreeLogs";
        CountToThreeLogs.Size = new Size(239, 184);
        CountToThreeLogs.TabIndex = 2;
        CountToThreeLogs.UseCompatibleStateImageBehavior = false;
        CountToThreeLogs.View = View.List;
        // 
        // SumCalc
        // 
        SumCalc.Location = new Point(156, 12);
        SumCalc.Name = "SumCalc";
        SumCalc.Size = new Size(80, 45);
        SumCalc.TabIndex = 3;
        SumCalc.Text = "Вычислить сумму";
        SumCalc.UseVisualStyleBackColor = true;
        SumCalc.Click += SumCalc_Click;
        // 
        // ShowSysTime
        // 
        ShowSysTime.Location = new Point(264, 12);
        ShowSysTime.Name = "ShowSysTime";
        ShowSysTime.Size = new Size(251, 45);
        ShowSysTime.TabIndex = 4;
        ShowSysTime.Text = "Показать время";
        ShowSysTime.UseVisualStyleBackColor = true;
        ShowSysTime.Click += ShowSysTime_Click;
        // 
        // CountThree
        // 
        CountThree.Location = new Point(549, 12);
        CountThree.Name = "CountThree";
        CountThree.Size = new Size(239, 45);
        CountThree.TabIndex = 5;
        CountThree.Text = "Счёт до 3х";
        CountThree.UseVisualStyleBackColor = true;
        CountThree.Click += CountThree_Click;
        // 
        // ArrSize
        // 
        ArrSize.Location = new Point(27, 34);
        ArrSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        ArrSize.Name = "ArrSize";
        ArrSize.Size = new Size(120, 23);
        ArrSize.TabIndex = 6;
        ArrSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(8, 9);
        label1.Name = "label1";
        label1.Size = new Size(142, 15);
        label1.TabIndex = 7;
        label1.Text = "Введите размер массива";
        // 
        // OPP_LB6
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label1);
        Controls.Add(ArrSize);
        Controls.Add(CountThree);
        Controls.Add(ShowSysTime);
        Controls.Add(SumCalc);
        Controls.Add(CountToThreeLogs);
        Controls.Add(SysTimeLogs);
        Controls.Add(SumCalcLogs);
        Name = "OPP_LB6";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)ArrSize).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListView SumCalcLogs;
    private ListView SysTimeLogs;
    private ListView CountToThreeLogs;
    private Button SumCalc;
    private Button ShowSysTime;
    private Button CountThree;
    private NumericUpDown ArrSize;
    private Label label1;
}