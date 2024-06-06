using LW1.Forms;
using LW1.Models.Service;
using LW1.Services.Interfaces;
using System.Threading;
namespace LW1;
/// <summary>
/// ������� ����� ����������
/// </summary>
public partial class Form1 : Form
{
    /// <summary>
    /// ����������� � ������� ��� ������ � ����� ������
    /// </summary>
    private ITransportService transportService;
    /// <summary>
    /// ������ ���������
    /// </summary>
    private List<Transport> transports = new();
    /// <summary>
    /// ��������� �������
    /// </summary>
    private int selectedTransport = 0;
    /// <summary>
    /// ���������� ���� ��������� � ���� ������
    /// </summary>
    private int ElemCount = 0;
    /// <summary>
    /// ����������� �����
    /// </summary>
    /// <param name="transportService"></param>
    public Form1(ITransportService transportService)
    {
        InitializeComponent();
        this.transportService = transportService;
        panel1.BackColor = Color.FromArgb(128, 0, 0, 0);
        panel2.BackColor = Color.FromArgb(128, 0, 0, 0);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        MoreLessBox.SelectedIndex = 0;
        TransportTable.Height = 50;
        this.Height = 477;

    }

    /// <summary>
    /// ����������� ��������������� ��������� ��� ������� ���������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e)
    {
        GreetingsPage greetingsPage = new GreetingsPage();
        greetingsPage.ShowDialog();

        updateData(sender, e);
    }

    /// <summary>
    /// ������ ���������� �� ���� ������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void updateData(object sender, EventArgs e)
    {
        transports = await transportService.GetAll();
        ElemCount = transports.Count;
        fillTable(transports);
        this.Show();
    }
    /// <summary>
    /// ������ ������ ����� ��� �������������� ���������� �� ��������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ItemEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= transports.Count || e.RowIndex < 0) { return; }
        TransportAddEdit transportAddEdit = new TransportAddEdit(transportService, transports[e.RowIndex]);
        this.Hide();
        transportAddEdit.FormClosed += new FormClosedEventHandler(updateData);
        transportAddEdit.Show();
    }
    /// <summary>
    /// ������ ������ ����� ��� ���������� ������ ��������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddNewTransport_Click(object sender, EventArgs e)
    {
        TransportAddEdit transportAddEdit = new TransportAddEdit(transportService);
        this.Hide();
        transportAddEdit.FormClosed += new FormClosedEventHandler(updateData);
        transportAddEdit.Show();
    }

    /// <summary>
    /// ��������� ������� �� ������ "�����"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ExitButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// ����������� ��������� ��� ������ ���������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FindBtn_Click(object sender, EventArgs e)
    {
        this.Height = 570;
        FindBtn.Enabled = false;

    }

    private void fillTable(List<Transport> transportList)
    {

        TransportTable.Rows.Clear();
        TransportTable.Height = 50;
        foreach (Transport transport in transportList)
        {
            TransportTable.Height += 25;
            TransportTable.Rows.Add(transport.Model, transport.Surname + " " + transport.Name + " " + transport.Patronymic,
                transport.Route, transport.Mileage);
        }
        ElementsShown.Text = transportList.Count.ToString() + " / " + ElemCount.ToString();
    }

    /// <summary>
    /// ����� ��������� �� ��������� ����������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ExecuteSearch_Click(object sender, EventArgs e)
    {
        this.Height = 477;
        FindBtn.Enabled = true;
        TransportTable.Rows.Clear();
        if (ModelSearchField.Text == "" && RouteSearchField.Text == "")
        {
            updateData(sender, e);
            return;
        }
        transports = await transportService.GetByParametrs(ModelSearchField.Text.ToUpper(), RouteSearchField.Text.ToUpper());
        fillTable(transports);
        ModelSearchField.Text = "";
        RouteSearchField.Text = "";
    }

    /// <summary>
    /// ������� �� ������ ������� ���� ������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ClearDB_Click(object sender, EventArgs e)
    {
        transportService.ClearDB();
        updateData(sender, e);
    }

    /// <summary>
    /// ������� �� ������ �������� ������ ��������
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FilterBtn_Click(object sender, EventArgs e)
    {
        Width = 1203;
        FilterBtn.Enabled = false;
    }

    private void CloseFilters_Click(object sender, EventArgs e)
    {
        Width = 837;
        FilterBtn.Enabled = true;
    }

    private void button_MouseEnter(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        btn.BackColor = Color.Yellow;
        btn.ForeColor = Color.Black;
    }

    private void button_MouseLeave(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        btn.BackColor = Color.Transparent;
        btn.ForeColor = Color.Yellow;
    }

    private List<Transport> MileageFiltration(List<Transport> buses)
    {
        List<Transport> result = new List<Transport>();
        for (int i = 0; i < buses.Count; i++) {
            if(MoreLessBox.SelectedIndex == 0 && buses[i].Mileage > MileageFilter.Value) { 
                result.Add(buses[i]);
            }
            else if (MoreLessBox.SelectedIndex == 1 && buses[i].Mileage < MileageFilter.Value)
            {
                result.Add(buses[i]);
            }
        }
        return result;
    }

    private List<Transport> DriversFiltration(List<Transport> buses)
    {
        List<Transport> result = new List<Transport>();
        for (int i = 0; i < buses.Count; i++)
        {
            if (buses[i].Name != "") result.Add(buses[i]);
        }
        return result;
    }

    private List<Transport> RouteFiltration(List<Transport> buses)
    {
        List<Transport> result = new List<Transport>();
        for (int i = 0; i < buses.Count; i++)
        {
            if (buses[i].Route != "") result.Add(buses[i]);
        }
        return result;
    }

    private void AcceptFilters_Click(object sender, EventArgs e)
    {
        List<Transport> result = new(transports);
        if(DriverExistBox.Checked) result = DriversFiltration(result);
        if(MileageBox.Checked) result = MileageFiltration(result);
        if (RouteBox.Checked) result = RouteFiltration(result);
        fillTable(result);
    }
}