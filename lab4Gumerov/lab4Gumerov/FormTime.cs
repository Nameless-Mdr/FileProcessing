using Domain.Collections;

namespace lab4Gumerov;

public partial class FormTime : Form
{

    private readonly Form1 _form1;
    private readonly DictTimer _timer;

    public FormTime(Form1 form1)
    {
        InitializeComponent();
        _form1 = form1;
        _timer = _form1.InfoTimer;

        FormClosing += CloseForm;
    }

    private void FormTime_Load(object sender, EventArgs e)
    {
        _form1.PathChanged += UpdateChartM1!;
        _form1.PathChanged += UpdateChartM2!;
        _form1.PathChanged += UpdateChartM3!;
        _form1.PathChanged += UpdateChartM4!;

        _form1.NChanged += UpdateChartM2!;
        _form1.MChanged += UpdateChartM3!;

        _form1.DateStartChanged += UpdateChartM4!;
        _form1.DateEndChanged += UpdateChartM4!;
        _form1.KChanged += UpdateChartM4!;

        UpdateChartM1(sender, e);
        UpdateChartM2(sender, e);
        UpdateChartM3(sender, e);
        UpdateChartM4(sender, e);
    }

    private void CloseForm(object? sender, FormClosingEventArgs e)
    {
        _form1.PathChanged -= UpdateChartM1!;
        _form1.PathChanged -= UpdateChartM2!;
        _form1.PathChanged -= UpdateChartM3!;
        _form1.PathChanged -= UpdateChartM4!;

        _form1.NChanged -= UpdateChartM2!;
        _form1.MChanged -= UpdateChartM3!;

        _form1.DateStartChanged -= UpdateChartM4!;
        _form1.DateEndChanged -= UpdateChartM4!;
        _form1.KChanged -= UpdateChartM4!;

        _form1.IsOpenFromTime = false;
    }

    private void UpdateChartM1(object sender, EventArgs e)
    {
        // сортировка по пути, по имени класса и группировка по имени класса
        var list = _timer.TimeM1.GroupBy(x => x.Key.Item1);

        foreach (var group in list)
        {
            chartM1.Series[group.Key].Points.Clear();
            chartM1.Series[group.Key].IsValueShownAsLabel = true;

            foreach (var item in group)
            {
                chartM1.Series[item.Key.Item1].Points.AddXY(item.Key.Item2, item.Value);
            }
        }
    }

    private void UpdateChartM2(object sender, EventArgs e)
    {
        // сортировка по пути, по кол-ву файлов, по имени класса и группировка по имени класса
        var list = _timer.TimeM2.GroupBy(x => x.Key.Item1);

        foreach (var group in list)
        {
            chartM2.Series[group.Key].Points.Clear();
            chartM2.Series[group.Key].IsValueShownAsLabel = true;

            foreach (var item in group)
            {
                chartM2.Series[item.Key.Item1].Points.AddXY($"{item.Key.Item2} - {item.Key.Item3}", item.Value);
            }
        }
    }

    private void UpdateChartM3(object sender, EventArgs e)
    {
        // сортировка по пути, проценту, по имени класса и группировка по имени класса
        var list = _timer.TimeM3.GroupBy(x => x.Key.Item1);

        foreach (var group in list)
        {
            chartM3.Series[group.Key].Points.Clear();
            chartM3.Series[group.Key].IsValueShownAsLabel = true;

            foreach (var item in group)
            {
                chartM3.Series[item.Key.Item1].Points.AddXY($"{item.Key.Item2} - {item.Key.Item3}", item.Value);
            }
        }
    }

    private void UpdateChartM4(object sender, EventArgs e)
    {
        // сортировка по пути, дате старта, по имени класса и группировка по имени класса
        var list = _timer.TimeM4.GroupBy(x => x.Key.Item1);

        foreach (var group in list)
        {
            chartM4.Series[group.Key].Points.Clear();
            chartM4.Series[group.Key].IsValueShownAsLabel = true;

            foreach (var item in group)
            {
                chartM4.Series[item.Key.Item1].Points.AddXY($"{item.Key.Item2} - {item.Key.Item3:dd:MM:yy}", item.Value);
            }
        }
    }

    public void ClearCharts()
    {
        foreach (var item in _timer.TimeM1.Select(x => x.Key.Item1))
        {
            chartM1.Series[item].Points.Clear();
        }

        foreach (var item in _timer.TimeM2.Select(x => x.Key.Item1))
        {
            chartM2.Series[item].Points.Clear();
        }

        foreach (var item in _timer.TimeM3.Select(x => x.Key.Item1))
        {
            chartM3.Series[item].Points.Clear();
        }

        foreach (var item in _timer.TimeM4.Select(x => x.Key.Item1))
        {
            chartM4.Series[item].Points.Clear();
        }
    }
}