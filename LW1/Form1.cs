namespace LW1;

public partial class Form1 : Form

{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form2 addAirportWindow = new();
        Hide();
        addAirportWindow.LaunchWindow(this);
        this.button1.Width = 120;
        this.button1.Height = 70;
        this.button1.Location = new Point(670, 25);
        updateData();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("Лабораторная работа № 1 \"Аэропорт\" 22ВП3 Бригада №5 Сафронов Новосельцев");
    }

    private void updateData() 
    {
        ListView list = new ListView();
        list.Height = 100;
        list.Width = 100;
        list.Location = new Point(125, 25);
        foreach(Airport item in Airport.airports)
        {
            ListViewItem listItem = new ListViewItem();
            listItem.Text = "faddfsf";
            list.Items.Add(listItem);
        }
        this.Controls.Add(list);
    }
}