using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using Domain.Collections;
using Domain.Models;
using Service.Implements;
using Service.Interfaces;

namespace lab4Gumerov;

public partial class Form1 : Form
{
    private ISearch _search;

    private string _path = @"";
    private int _n = 5;
    private short _m = 50;
    private DateTime _dateStart = DateTime.Now.AddDays(-1).Date;
    private DateTime _dateEnd = DateTime.Now.Date;
    private int _k = 30;
    
    public FormTime FormTime;
    public bool IsOpenFromTime;

    public DictTimer InfoTimer = new DictTimer();

    public string Path
    {
        get => _path;
        set
        {
            if (_path == value) return;
            _path = value;
            PathChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler PathChanged;

    public int N
    {
        get => _n;
        set
        {
            if(_n == value) return;
            _n = value;
            NChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler NChanged;

    public short M
    {
        get => _m;
        set
        {
            if (_m == value) return;
            _m = value;
            MChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler MChanged;

    public DateTime DateStart
    {
        get => _dateStart;
        set
        {
            if(value == _dateStart) return;
            _dateStart = value.Date;
            DateStartChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler DateStartChanged;

    public DateTime DateEnd
    {
        get => _dateEnd;
        set
        {
            if(value == _dateEnd) return;
            _dateEnd = value.Date;
            DateEndChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler DateEndChanged;

    public int K
    {
        get => _k;
        set
        {
            if(_k == value) return;
            _k = value;
            KChanged.Invoke(this, EventArgs.Empty);
        }
    }
    public event EventHandler KChanged;

    private readonly BindingSource _sfBinding = new BindingSource();
    private readonly BindingSource _mFBinding = new BindingSource();
    private readonly BindingSource _fBinding = new BindingSource();
    private readonly BindingSource _fRBinding = new BindingSource();

    public Form1(ISearch search)
    {
        InitializeComponent();
        _search = search;
        
        PathChanged += UpdateGVSubfolder!;
        PathChanged += UpdateGVMinFiles!;
        PathChanged += UpdateGVFilesRange!;
        PathChanged += UpdateGVSpecFolder!;

        NChanged += UpdateGVMinFiles!;
        MChanged += UpdateGVSpecFolder!;

        DateStartChanged += UpdateGVFilesRange!;
        DateEndChanged += UpdateGVFilesRange!;
        KChanged += UpdateGVFilesRange!;

        PathBox.DataBindings.Add(nameof(PathBox.Text), this, nameof(Path));
        PathBox.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        numericUpDownN.DataBindings.Add(nameof(numericUpDownN.Text), this, nameof(N));
        numericUpDownN.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        numericUpDownM.DataBindings.Add(nameof(numericUpDownM.Text), this, nameof(M));
        numericUpDownM.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        numericUpDownK.DataBindings.Add(nameof(numericUpDownK.Text), this, nameof(K));
        numericUpDownK.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        DateStartPicker.DataBindings.Add(nameof(DateStartPicker.Text), this, nameof(DateStart));
        DateStartPicker.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;

        DateEndPicker.DataBindings.Add(nameof(DateEndPicker.Text), this, nameof(DateEnd));
        DateEndPicker.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
    }

    private void UpdateGVSubfolder(object sender, EventArgs e)
    {
        var stopwatch = Stopwatch.StartNew();
        var subfolder = _search.SubfolderWithLargestCountFiles(Path);
        stopwatch.Stop();

        _sfBinding.DataSource = new List<Subfolder> { subfolder };

        GVSubfolder.AllowUserToAddRows = false;
        GVSubfolder.ReadOnly = true;
        GVSubfolder.DataSource = _sfBinding;
        GVSubfolder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        if (subfolder.CountFile == 0) return;

        var times = Math.Round(stopwatch.Elapsed.TotalMilliseconds / 1000, 3);
        var key = _search.GetType().Name;

        LblExexTime1.Text = $@"Время выполнения функции: {times} c";

        if (InfoTimer.TimeM1.ContainsKey((key, Path)))
            InfoTimer.TimeM1[(key, Path)] = times;
        else
        {
            var otherKey = key == nameof(SearchNoLinq) ? nameof(SearchLinq) : nameof(SearchNoLinq);

            InfoTimer.TimeM1.Add((key, Path), times);
            InfoTimer.TimeM1.Add((otherKey, Path), 0);
        }
    }

    private void UpdateGVMinFiles(object sender, EventArgs e)
    {
        var stopwatch = Stopwatch.StartNew();
        var files = _search.FilesWithSmallestSize(Path, _n);
        stopwatch.Stop();
        var count = files.Count();

        _mFBinding.DataSource = files;

        GVMinFiles.AllowUserToAddRows = false;
        GVMinFiles.ReadOnly = true;
        GVMinFiles.DataSource = _mFBinding;
        GVMinFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        ChartFiles.DataSource = files.GroupBy(x => x.Extension).Select(x => new { Extension = x.Key, Count = x.Count() });
        
        ChartFiles.Series["Series1"].ChartType = SeriesChartType.Pie;

        ChartFiles.Series[0].XValueMember = "Extension";
        ChartFiles.Series[0].YValueMembers = "Count";
        ChartFiles.Series[0].IsValueShownAsLabel = true;
        if (count == 0) return;

        var times = Math.Round(stopwatch.Elapsed.TotalMilliseconds / 1000, 3);
        var key = _search.GetType().Name;

        TopNFiles.Text = $@"{count} файлов с наименьшим размером";
        LblExexTime2.Text = $@"Время выполнения функции: {times} c";

        if (InfoTimer.TimeM2.ContainsKey((key, Path, count)))
            InfoTimer.TimeM2[(key, Path, count)] = times;
        else
        {
            var otherKey = key == nameof(SearchNoLinq) ? nameof(SearchLinq) : nameof(SearchNoLinq);

            InfoTimer.TimeM2.Add((key, Path, count), times);
            InfoTimer.TimeM2.Add((otherKey, Path, count), 0);
        }
    }

    private void UpdateGVSpecFolder(object sender, EventArgs e)
    {
        var stopwatch = Stopwatch.StartNew();
        var folders = _search.SubfoldersWithFilesSameExtension(Path, _m);
        stopwatch.Stop();
        var count = folders.Count();

        _fBinding.DataSource = folders;

        GVSpecFolder.AllowUserToAddRows = false;
        GVSpecFolder.ReadOnly = true;
        GVSpecFolder.DataSource = _fBinding;
        GVSpecFolder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        ChartFolders.DataSource = folders.GroupBy(x => x.ExtensionFile)
            .Select(x => new { Extension = x.Key, Count = x.Count() });

        ChartFolders.Series["Series1"].ChartType = SeriesChartType.Column;

        ChartFolders.Series[0].XValueMember = "Extension";
        ChartFolders.Series[0].YValueMembers = "Count";
        if (count == 0) return;

        var times = Math.Round(stopwatch.Elapsed.TotalMilliseconds / 1000, 3);
        var key = _search.GetType().Name;

        FolderSameEx.Text = $@"{count} папок, которые содержат более {M}% файлов с одним расширением";
        LblExexTime3.Text = $@"Время выполнения функции: {times} c";

        if (InfoTimer.TimeM3.ContainsKey((key, Path, M)))
            InfoTimer.TimeM3[(key, Path, M)] = times;
        else
        {
            var otherKey = key == nameof(SearchNoLinq) ? nameof(SearchLinq) : nameof(SearchNoLinq);

            InfoTimer.TimeM3.Add((key, Path, M), times);
            InfoTimer.TimeM3.Add((otherKey, Path, M), 0);
        }
    }

    private void UpdateGVFilesRange(object sender, EventArgs e)
    {
        var stopwatch = Stopwatch.StartNew();
        var files = _search.FilesCreatedInCertainInterval(Path, DateStart, DateEnd, K);
        stopwatch.Stop();
        var count = files.Count();

        _fRBinding.DataSource = files.Select(x => new { x.Name, x.DateCreated, x.LeftDate, x.RightDate })
            .OrderBy(x => x.DateCreated);

        GVFilesRange.AllowUserToAddRows = false;
        GVFilesRange.ReadOnly = true;
        GVFilesRange.DataSource = _fRBinding;
        if (count > 0)
        {
            GVFilesRange.Columns[nameof(FileDate.LeftDate)]!.DefaultCellStyle.Format = "HH:mm";
            GVFilesRange.Columns[nameof(FileDate.RightDate)]!.DefaultCellStyle.Format = "HH:mm";
        }

        GVFilesRange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        ChartFileRange.DataSource = files
            .OrderBy(x => x.DateCreated)
            .GroupBy(x => new { x.LeftDate, x.RightDate })
            .Select(x => new
                { DateRange = $"{x.Key.LeftDate:HH:mm}-{x.Key.RightDate:HH:mm}", Count = x.Count() });
        ChartFileRange.Series["Series1"].ChartType = SeriesChartType.Line;

        ChartFileRange.Series[0].XValueMember = "DateRange";
        ChartFileRange.Series[0].YValueMembers = "Count";
        ChartFileRange.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
        if (count == 0) return;

        var times = Math.Round(stopwatch.Elapsed.TotalMilliseconds / 1000, 3);
        var key = _search.GetType().Name;

        LblFilesRange.Text = $@"{count} файлов, созданные с {DateStart:d} по {DateEnd:d}";
        LblExexTime4.Text = $@"Время выполнения функции: {times} c";

        if (InfoTimer.TimeM4.ContainsKey((key, Path, DateStart, DateEnd, K)))
            InfoTimer.TimeM4[(key, Path, DateStart, DateEnd, K)] = times;
        else
        {
            var otherKey = key == nameof(SearchNoLinq) ? nameof(SearchLinq) : nameof(SearchNoLinq);

            InfoTimer.TimeM4.Add((key, Path, DateStart, DateEnd, K), times);
            InfoTimer.TimeM4.Add((otherKey, Path, DateStart, DateEnd, K), 0);
        }
    }

    private void btnDefault_Click(object sender, EventArgs e)
    {
        Path = "";
        N = 5;
        M = 50;
        K = 30;
        DateStart = DateTime.Now.AddDays(-1).Date;
        DateEnd = DateTime.Now.Date;

        if(IsOpenFromTime)
            FormTime.ClearCharts();
        InfoTimer.Clear();

        GVSubfolder.Rows.Clear();
        GVMinFiles.Rows.Clear();
        GVSpecFolder.Rows.Clear();
        GVFilesRange.Rows.Clear();

        ChartFiles.Series[0].Points.Clear();
        ChartFolders.Series[0].Points.Clear();
        ChartFileRange.Series[0].Points.Clear();

        LblExexTime1.Text = "Время выполнения функции: S,M с";
        LblExexTime2.Text = "Время выполнения функции: S,M с";
        LblExexTime3.Text = "Время выполнения функции: S,M с";
        LblExexTime4.Text = "Время выполнения функции: S,M с";
        LblFilesRange.Text = "X файлов, созданные с Date1 по Date2";
        FolderSameEx.Text = "X папок, которые содержат более M% файлов с одним расширением";
        TopNFiles.Text = "N файлов с наименьшим размером";
    }

    private void rBtnLinq_CheckedChanged(object sender, EventArgs e)
    {
        _search = new SearchLinq();
        PathChanged.Invoke(sender, e);
    }

    private void rBtnNoLinq_CheckedChanged(object sender, EventArgs e)
    {
        _search = new SearchNoLinq();
        PathChanged.Invoke(sender, e);
    }

    private void btnTimers_Click(object sender, EventArgs e)
    {
        if(IsOpenFromTime) return;

        FormTime = new FormTime(this);
        FormTime.Show();
        IsOpenFromTime = true;
    }
}