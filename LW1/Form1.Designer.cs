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
        dataGridView1 = new DataGridView();
        ModelColumn = new DataGridViewTextBoxColumn();
        NSPColumn = new DataGridViewTextBoxColumn();
        RouteColumn = new DataGridViewTextBoxColumn();
        MileageColumn = new DataGridViewTextBoxColumn();
        AddNewTransport = new Button();
        ExitButton = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ModelColumn, NSPColumn, RouteColumn, MileageColumn });
        dataGridView1.Location = new Point(14, 9);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(782, 345);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellContentClick += ItemSelected;
        dataGridView1.CellContentDoubleClick += ItemEdit;
        // 
        // ModelColumn
        // 
        ModelColumn.HeaderText = "Модель";
        ModelColumn.Name = "ModelColumn";
        ModelColumn.ReadOnly = true;
        ModelColumn.Width = 190;
        // 
        // NSPColumn
        // 
        NSPColumn.HeaderText = "ФИО Водителя";
        NSPColumn.Name = "NSPColumn";
        NSPColumn.ReadOnly = true;
        NSPColumn.Width = 240;
        // 
        // RouteColumn
        // 
        RouteColumn.HeaderText = "Маршрут";
        RouteColumn.Name = "RouteColumn";
        RouteColumn.ReadOnly = true;
        RouteColumn.Width = 150;
        // 
        // MileageColumn
        // 
        MileageColumn.HeaderText = "Пробег";
        MileageColumn.Name = "MileageColumn";
        MileageColumn.ReadOnly = true;
        MileageColumn.Width = 150;
        // 
        // AddNewTransport
        // 
        AddNewTransport.Location = new Point(14, 373);
        AddNewTransport.Name = "AddNewTransport";
        AddNewTransport.Size = new Size(94, 23);
        AddNewTransport.TabIndex = 1;
        AddNewTransport.Text = "Добавить ТС";
        AddNewTransport.UseVisualStyleBackColor = true;
        AddNewTransport.Click += AddNewTransport_Click;
        // 
        // ExitButton
        // 
        ExitButton.Location = new Point(669, 373);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(75, 23);
        ExitButton.TabIndex = 2;
        ExitButton.Text = "Выход";
        ExitButton.UseVisualStyleBackColor = true;
        ExitButton.Click += ExitButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ExitButton);
        Controls.Add(AddNewTransport);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn ModelColumn;
    private DataGridViewTextBoxColumn NSPColumn;
    private DataGridViewTextBoxColumn RouteColumn;
    private DataGridViewTextBoxColumn MileageColumn;
    private Button AddNewTransport;
    private Button ExitButton;
}