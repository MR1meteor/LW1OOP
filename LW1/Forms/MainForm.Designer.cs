namespace LW1.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            AACheckbox = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            CompareArList = new Button();
            addBtn = new PictureBox();
            editModeBtn = new PictureBox();
            incidentsTextbox = new TextBox();
            incomeTextbox = new TextBox();
            touristsTextbox = new TextBox();
            ticketsTextbox = new TextBox();
            runwaysTextbox = new TextBox();
            codeTextbox = new TextBox();
            nameTextbox = new TextBox();
            incidentsLabel = new Label();
            incomeLabel = new Label();
            touristsLabel = new Label();
            ticketsLabel = new Label();
            runwaysLabel = new Label();
            codeLabel = new Label();
            nameLabel = new Label();
            saveBtn = new Button();
            delBtn = new Button();
            airportsList = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editModeBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AACheckbox);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(CompareArList);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(editModeBtn);
            panel1.Controls.Add(incidentsTextbox);
            panel1.Controls.Add(incomeTextbox);
            panel1.Controls.Add(touristsTextbox);
            panel1.Controls.Add(ticketsTextbox);
            panel1.Controls.Add(runwaysTextbox);
            panel1.Controls.Add(codeTextbox);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(incidentsLabel);
            panel1.Controls.Add(incomeLabel);
            panel1.Controls.Add(touristsLabel);
            panel1.Controls.Add(ticketsLabel);
            panel1.Controls.Add(runwaysLabel);
            panel1.Controls.Add(codeLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(delBtn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(351, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 344);
            panel1.TabIndex = 0;
            // 
            // AACheckbox
            // 
            AACheckbox.AutoSize = true;
            AACheckbox.Location = new Point(190, 177);
            AACheckbox.Margin = new Padding(3, 2, 3, 2);
            AACheckbox.Name = "AACheckbox";
            AACheckbox.Size = new Size(15, 14);
            AACheckbox.TabIndex = 23;
            AACheckbox.UseVisualStyleBackColor = true;
            AACheckbox.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new Point(130, 8);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Военный";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Location = new Point(6, 8);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Гражданский";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // CompareArList
            // 
            CompareArList.Location = new Point(5, 275);
            CompareArList.Margin = new Padding(3, 2, 3, 2);
            CompareArList.Name = "CompareArList";
            CompareArList.Size = new Size(341, 22);
            CompareArList.TabIndex = 20;
            CompareArList.Text = "Замер производительности";
            CompareArList.UseVisualStyleBackColor = true;
            CompareArList.Click += CompareArList_Click;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.InitialImage = null;
            addBtn.Location = new Point(269, 2);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(31, 26);
            addBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            addBtn.TabIndex = 19;
            addBtn.TabStop = false;
            addBtn.Click += addBtnClick;
            // 
            // editModeBtn
            // 
            editModeBtn.Cursor = Cursors.Hand;
            editModeBtn.Image = (Image)resources.GetObject("editModeBtn.Image");
            editModeBtn.InitialImage = null;
            editModeBtn.Location = new Point(304, 2);
            editModeBtn.Margin = new Padding(3, 2, 3, 2);
            editModeBtn.Name = "editModeBtn";
            editModeBtn.Size = new Size(31, 26);
            editModeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            editModeBtn.TabIndex = 18;
            editModeBtn.TabStop = false;
            editModeBtn.Click += editAirport;
            // 
            // incidentsTextbox
            // 
            incidentsTextbox.Location = new Point(211, 244);
            incidentsTextbox.Margin = new Padding(3, 2, 3, 2);
            incidentsTextbox.Name = "incidentsTextbox";
            incidentsTextbox.Size = new Size(110, 23);
            incidentsTextbox.TabIndex = 16;
            // 
            // incomeTextbox
            // 
            incomeTextbox.Location = new Point(211, 206);
            incomeTextbox.Margin = new Padding(3, 2, 3, 2);
            incomeTextbox.Name = "incomeTextbox";
            incomeTextbox.Size = new Size(110, 23);
            incomeTextbox.TabIndex = 15;
            // 
            // touristsTextbox
            // 
            touristsTextbox.Location = new Point(211, 168);
            touristsTextbox.Margin = new Padding(3, 2, 3, 2);
            touristsTextbox.Name = "touristsTextbox";
            touristsTextbox.Size = new Size(110, 23);
            touristsTextbox.TabIndex = 14;
            // 
            // ticketsTextbox
            // 
            ticketsTextbox.Location = new Point(211, 134);
            ticketsTextbox.Margin = new Padding(3, 2, 3, 2);
            ticketsTextbox.Name = "ticketsTextbox";
            ticketsTextbox.Size = new Size(110, 23);
            ticketsTextbox.TabIndex = 13;
            // 
            // runwaysTextbox
            // 
            runwaysTextbox.Location = new Point(211, 100);
            runwaysTextbox.Margin = new Padding(3, 2, 3, 2);
            runwaysTextbox.Name = "runwaysTextbox";
            runwaysTextbox.Size = new Size(110, 23);
            runwaysTextbox.TabIndex = 12;
            // 
            // codeTextbox
            // 
            codeTextbox.Location = new Point(211, 69);
            codeTextbox.Margin = new Padding(3, 2, 3, 2);
            codeTextbox.Name = "codeTextbox";
            codeTextbox.Size = new Size(110, 23);
            codeTextbox.TabIndex = 11;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(211, 35);
            nameTextbox.Margin = new Padding(3, 2, 3, 2);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(110, 23);
            nameTextbox.TabIndex = 10;
            // 
            // incidentsLabel
            // 
            incidentsLabel.AutoSize = true;
            incidentsLabel.Location = new Point(5, 249);
            incidentsLabel.Name = "incidentsLabel";
            incidentsLabel.Size = new Size(157, 15);
            incidentsLabel.TabIndex = 9;
            incidentsLabel.Text = "Количество происшествий";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new Point(5, 211);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new Size(92, 15);
            incomeLabel.TabIndex = 8;
            incomeLabel.Text = "Доход за месяц";
            // 
            // touristsLabel
            // 
            touristsLabel.AutoSize = true;
            touristsLabel.Location = new Point(5, 173);
            touristsLabel.Name = "touristsLabel";
            touristsLabel.Size = new Size(108, 15);
            touristsLabel.TabIndex = 7;
            touristsLabel.Text = "Средний турпоток";
            // 
            // ticketsLabel
            // 
            ticketsLabel.AutoSize = true;
            ticketsLabel.Location = new Point(5, 140);
            ticketsLabel.Name = "ticketsLabel";
            ticketsLabel.Size = new Size(104, 15);
            ticketsLabel.TabIndex = 6;
            ticketsLabel.Text = "Продано билетов";
            // 
            // runwaysLabel
            // 
            runwaysLabel.AutoSize = true;
            runwaysLabel.Location = new Point(5, 106);
            runwaysLabel.Name = "runwaysLabel";
            runwaysLabel.Size = new Size(109, 15);
            runwaysLabel.TabIndex = 5;
            runwaysLabel.Text = "Количество полос";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(5, 74);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(27, 15);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Код";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(5, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(193, 308);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 26);
            saveBtn.TabIndex = 2;
            saveBtn.Tag = "save";
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // delBtn
            // 
            delBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            delBtn.Cursor = Cursors.Hand;
            delBtn.Location = new Point(3, 308);
            delBtn.Margin = new Padding(3, 2, 3, 2);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(174, 26);
            delBtn.TabIndex = 1;
            delBtn.Text = "Удалить";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // airportsList
            // 
            airportsList.Alignment = ListViewAlignment.Left;
            airportsList.Dock = DockStyle.Left;
            airportsList.LabelWrap = false;
            airportsList.Location = new Point(0, 0);
            airportsList.Margin = new Padding(3, 2, 3, 2);
            airportsList.Name = "airportsList";
            airportsList.Size = new Size(330, 344);
            airportsList.TabIndex = 1;
            airportsList.UseCompatibleStateImageBehavior = false;
            airportsList.SelectedIndexChanged += SelectedItemChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 344);
            Controls.Add(airportsList);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(718, 383);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)editModeBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label nameLabel;
        private Button saveBtn;
        private Button delBtn;
        private Label runwaysLabel;
        private Label codeLabel;
        private Label touristsLabel;
        private Label ticketsLabel;
        private TextBox nameTextbox;
        private Label incidentsLabel;
        private Label incomeLabel;
        private TextBox incidentsTextbox;
        private TextBox incomeTextbox;
        private TextBox touristsTextbox;
        private TextBox ticketsTextbox;
        private TextBox runwaysTextbox;
        private TextBox codeTextbox;
        private PictureBox editModeBtn;
        private PictureBox addBtn;
        private ListView airportsList;
        private Button CompareArList;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox AACheckbox;
    }
}