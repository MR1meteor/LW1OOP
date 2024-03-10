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
            CompareArList = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editModeBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Location = new Point(399, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 450);
            panel1.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.InitialImage = null;
            addBtn.Location = new Point(307, 3);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(35, 35);
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
            editModeBtn.Location = new Point(348, 3);
            editModeBtn.Name = "editModeBtn";
            editModeBtn.Size = new Size(35, 35);
            editModeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            editModeBtn.TabIndex = 18;
            editModeBtn.TabStop = false;
            editModeBtn.Click += editAirport;
            // 
            // incidentsTextbox
            // 
            incidentsTextbox.Location = new Point(241, 325);
            incidentsTextbox.Name = "incidentsTextbox";
            incidentsTextbox.Size = new Size(125, 27);
            incidentsTextbox.TabIndex = 16;
            // 
            // incomeTextbox
            // 
            incomeTextbox.Location = new Point(241, 274);
            incomeTextbox.Name = "incomeTextbox";
            incomeTextbox.Size = new Size(125, 27);
            incomeTextbox.TabIndex = 15;
            // 
            // touristsTextbox
            // 
            touristsTextbox.Location = new Point(241, 224);
            touristsTextbox.Name = "touristsTextbox";
            touristsTextbox.Size = new Size(125, 27);
            touristsTextbox.TabIndex = 14;
            // 
            // ticketsTextbox
            // 
            ticketsTextbox.Location = new Point(241, 179);
            ticketsTextbox.Name = "ticketsTextbox";
            ticketsTextbox.Size = new Size(125, 27);
            ticketsTextbox.TabIndex = 13;
            // 
            // runwaysTextbox
            // 
            runwaysTextbox.Location = new Point(241, 134);
            runwaysTextbox.Name = "runwaysTextbox";
            runwaysTextbox.Size = new Size(125, 27);
            runwaysTextbox.TabIndex = 12;
            // 
            // codeTextbox
            // 
            codeTextbox.Location = new Point(241, 92);
            codeTextbox.Name = "codeTextbox";
            codeTextbox.Size = new Size(125, 27);
            codeTextbox.TabIndex = 11;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(241, 47);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(125, 27);
            nameTextbox.TabIndex = 10;
            // 
            // incidentsLabel
            // 
            incidentsLabel.AutoSize = true;
            incidentsLabel.Location = new Point(6, 332);
            incidentsLabel.Name = "incidentsLabel";
            incidentsLabel.Size = new Size(196, 20);
            incidentsLabel.TabIndex = 9;
            incidentsLabel.Text = "Количество происшествий";
            // 
            // incomeLabel
            // 
            incomeLabel.AutoSize = true;
            incomeLabel.Location = new Point(6, 281);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new Size(118, 20);
            incomeLabel.TabIndex = 8;
            incomeLabel.Text = "Доход за месяц";
            // 
            // touristsLabel
            // 
            touristsLabel.AutoSize = true;
            touristsLabel.Location = new Point(6, 231);
            touristsLabel.Name = "touristsLabel";
            touristsLabel.Size = new Size(136, 20);
            touristsLabel.TabIndex = 7;
            touristsLabel.Text = "Средний турпоток";
            // 
            // ticketsLabel
            // 
            ticketsLabel.AutoSize = true;
            ticketsLabel.Location = new Point(6, 186);
            ticketsLabel.Name = "ticketsLabel";
            ticketsLabel.Size = new Size(133, 20);
            ticketsLabel.TabIndex = 6;
            ticketsLabel.Text = "Продано билетов";
            // 
            // runwaysLabel
            // 
            runwaysLabel.AutoSize = true;
            runwaysLabel.Location = new Point(6, 141);
            runwaysLabel.Name = "runwaysLabel";
            runwaysLabel.Size = new Size(136, 20);
            runwaysLabel.TabIndex = 5;
            runwaysLabel.Text = "Количество полос";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(6, 99);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(35, 20);
            codeLabel.TabIndex = 4;
            codeLabel.Text = "Код";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(6, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(77, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.Location = new Point(221, 402);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(175, 35);
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
            delBtn.Location = new Point(3, 402);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(199, 35);
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
            airportsList.Name = "airportsList";
            airportsList.Size = new Size(376, 450);
            airportsList.TabIndex = 1;
            airportsList.UseCompatibleStateImageBehavior = false;
            airportsList.SelectedIndexChanged += SelectedItemChanged;
            // 
            // CompareArList
            // 
            CompareArList.Location = new Point(6, 367);
            CompareArList.Name = "CompareArList";
            CompareArList.Size = new Size(390, 29);
            CompareArList.TabIndex = 20;
            CompareArList.Text = "Замер производительности";
            CompareArList.UseVisualStyleBackColor = true;
            CompareArList.Click += CompareArList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(airportsList);
            Controls.Add(panel1);
            MinimumSize = new Size(818, 497);
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
    }
}