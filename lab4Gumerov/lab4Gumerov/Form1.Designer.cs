namespace lab4Gumerov
{
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GVSpecFolder = new System.Windows.Forms.DataGridView();
            this.GVSubfolder = new System.Windows.Forms.DataGridView();
            this.GVMinFiles = new System.Windows.Forms.DataGridView();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.SubfolderMaxFiles = new System.Windows.Forms.Label();
            this.TopNFiles = new System.Windows.Forms.Label();
            this.FolderSameEx = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.labelM = new System.Windows.Forms.Label();
            this.ChartFiles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartFolders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartFileRange = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblFilesRange = new System.Windows.Forms.Label();
            this.GVFilesRange = new System.Windows.Forms.DataGridView();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.lbInterval = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.DateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.LblExexTime1 = new System.Windows.Forms.Label();
            this.LblExexTime3 = new System.Windows.Forms.Label();
            this.LblExexTime2 = new System.Windows.Forms.Label();
            this.LblExexTime4 = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.rBtnLinq = new System.Windows.Forms.RadioButton();
            this.rBtnNoLinq = new System.Windows.Forms.RadioButton();
            this.btnTimers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVSpecFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSubfolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMinFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFileRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVFilesRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // GVSpecFolder
            // 
            this.GVSpecFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSpecFolder.Location = new System.Drawing.Point(2, 388);
            this.GVSpecFolder.Name = "GVSpecFolder";
            this.GVSpecFolder.RowTemplate.Height = 25;
            this.GVSpecFolder.Size = new System.Drawing.Size(500, 274);
            this.GVSpecFolder.TabIndex = 0;
            // 
            // GVSubfolder
            // 
            this.GVSubfolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSubfolder.Location = new System.Drawing.Point(2, 178);
            this.GVSubfolder.Name = "GVSubfolder";
            this.GVSubfolder.RowTemplate.Height = 25;
            this.GVSubfolder.Size = new System.Drawing.Size(502, 149);
            this.GVSubfolder.TabIndex = 1;
            // 
            // GVMinFiles
            // 
            this.GVMinFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMinFiles.Location = new System.Drawing.Point(866, 68);
            this.GVMinFiles.Name = "GVMinFiles";
            this.GVMinFiles.RowTemplate.Height = 25;
            this.GVMinFiles.Size = new System.Drawing.Size(500, 259);
            this.GVMinFiles.TabIndex = 2;
            // 
            // PathBox
            // 
            this.PathBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathBox.Location = new System.Drawing.Point(51, 6);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(451, 34);
            this.PathBox.TabIndex = 3;
            // 
            // SubfolderMaxFiles
            // 
            this.SubfolderMaxFiles.AutoSize = true;
            this.SubfolderMaxFiles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SubfolderMaxFiles.Location = new System.Drawing.Point(2, 154);
            this.SubfolderMaxFiles.Name = "SubfolderMaxFiles";
            this.SubfolderMaxFiles.Size = new System.Drawing.Size(410, 19);
            this.SubfolderMaxFiles.TabIndex = 5;
            this.SubfolderMaxFiles.Text = "Самая большая по количеству файлов вложенная папка";
            // 
            // TopNFiles
            // 
            this.TopNFiles.AutoSize = true;
            this.TopNFiles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopNFiles.Location = new System.Drawing.Point(866, 46);
            this.TopNFiles.Name = "TopNFiles";
            this.TopNFiles.Size = new System.Drawing.Size(262, 19);
            this.TopNFiles.TabIndex = 6;
            this.TopNFiles.Text = "N файлов с наименьшим размером";
            // 
            // FolderSameEx
            // 
            this.FolderSameEx.AutoSize = true;
            this.FolderSameEx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FolderSameEx.Location = new System.Drawing.Point(2, 366);
            this.FolderSameEx.Name = "FolderSameEx";
            this.FolderSameEx.Size = new System.Drawing.Size(502, 19);
            this.FolderSameEx.TabIndex = 7;
            this.FolderSameEx.Text = "X папок, которые содержат более M% файлов с одним расширением";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPath.Location = new System.Drawing.Point(2, 14);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(43, 19);
            this.labelPath.TabIndex = 8;
            this.labelPath.Text = "Path:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelN.Location = new System.Drawing.Point(527, 68);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(119, 19);
            this.labelN.TabIndex = 9;
            this.labelN.Text = "Кол-во файлов:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(714, 68);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownN.TabIndex = 10;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(714, 94);
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownM.TabIndex = 12;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelM.Location = new System.Drawing.Point(527, 94);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(167, 19);
            this.labelM.TabIndex = 11;
            this.labelM.Text = "Процент расширений:";
            // 
            // ChartFiles
            // 
            chartArea4.Name = "ChartArea1";
            this.ChartFiles.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.ChartFiles.Legends.Add(legend2);
            this.ChartFiles.Location = new System.Drawing.Point(1387, 68);
            this.ChartFiles.Name = "ChartFiles";
            this.ChartFiles.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChartFiles.Series.Add(series4);
            this.ChartFiles.Size = new System.Drawing.Size(319, 259);
            this.ChartFiles.TabIndex = 13;
            this.ChartFiles.Text = "chart1";
            // 
            // ChartFolders
            // 
            chartArea5.Name = "ChartArea1";
            this.ChartFolders.ChartAreas.Add(chartArea5);
            this.ChartFolders.Location = new System.Drawing.Point(527, 388);
            this.ChartFolders.Name = "ChartFolders";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.ChartFolders.Series.Add(series5);
            this.ChartFolders.Size = new System.Drawing.Size(319, 274);
            this.ChartFolders.TabIndex = 14;
            this.ChartFolders.Text = "chart1";
            // 
            // ChartFileRange
            // 
            chartArea6.Name = "ChartArea1";
            this.ChartFileRange.ChartAreas.Add(chartArea6);
            this.ChartFileRange.Location = new System.Drawing.Point(1391, 388);
            this.ChartFileRange.Name = "ChartFileRange";
            this.ChartFileRange.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.ChartFileRange.Series.Add(series6);
            this.ChartFileRange.Size = new System.Drawing.Size(319, 274);
            this.ChartFileRange.TabIndex = 17;
            this.ChartFileRange.Text = "chart1";
            // 
            // LblFilesRange
            // 
            this.LblFilesRange.AutoSize = true;
            this.LblFilesRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFilesRange.Location = new System.Drawing.Point(866, 366);
            this.LblFilesRange.Name = "LblFilesRange";
            this.LblFilesRange.Size = new System.Drawing.Size(279, 19);
            this.LblFilesRange.TabIndex = 16;
            this.LblFilesRange.Text = "X файлов, созданные с Date1 по Date2";
            // 
            // GVFilesRange
            // 
            this.GVFilesRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVFilesRange.Location = new System.Drawing.Point(866, 388);
            this.GVFilesRange.Name = "GVFilesRange";
            this.GVFilesRange.RowTemplate.Height = 25;
            this.GVFilesRange.Size = new System.Drawing.Size(500, 274);
            this.GVFilesRange.TabIndex = 15;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(714, 197);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownK.TabIndex = 21;
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInterval.Location = new System.Drawing.Point(527, 197);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(146, 19);
            this.lbInterval.TabIndex = 20;
            this.lbInterval.Text = "Интервал времени:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(527, 130);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(189, 19);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "Стартовая дата создания:";
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartPicker.Location = new System.Drawing.Point(714, 130);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(124, 23);
            this.DateStartPicker.TabIndex = 22;
            // 
            // DateEndPicker
            // 
            this.DateEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEndPicker.Location = new System.Drawing.Point(714, 163);
            this.DateEndPicker.Name = "DateEndPicker";
            this.DateEndPicker.Size = new System.Drawing.Size(124, 23);
            this.DateEndPicker.TabIndex = 24;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.Location = new System.Drawing.Point(527, 163);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(186, 19);
            this.lblEndDate.TabIndex = 23;
            this.lblEndDate.Text = "Конечная дата создания:";
            // 
            // LblExexTime1
            // 
            this.LblExexTime1.AutoSize = true;
            this.LblExexTime1.Location = new System.Drawing.Point(161, 330);
            this.LblExexTime1.Name = "LblExexTime1";
            this.LblExexTime1.Size = new System.Drawing.Size(201, 15);
            this.LblExexTime1.TabIndex = 25;
            this.LblExexTime1.Text = "Время выполнения функции: S,M с";
            // 
            // LblExexTime3
            // 
            this.LblExexTime3.AutoSize = true;
            this.LblExexTime3.Location = new System.Drawing.Point(161, 665);
            this.LblExexTime3.Name = "LblExexTime3";
            this.LblExexTime3.Size = new System.Drawing.Size(201, 15);
            this.LblExexTime3.TabIndex = 26;
            this.LblExexTime3.Text = "Время выполнения функции: S,M с";
            // 
            // LblExexTime2
            // 
            this.LblExexTime2.AutoSize = true;
            this.LblExexTime2.Location = new System.Drawing.Point(1052, 330);
            this.LblExexTime2.Name = "LblExexTime2";
            this.LblExexTime2.Size = new System.Drawing.Size(201, 15);
            this.LblExexTime2.TabIndex = 27;
            this.LblExexTime2.Text = "Время выполнения функции: S,M с";
            // 
            // LblExexTime4
            // 
            this.LblExexTime4.AutoSize = true;
            this.LblExexTime4.Location = new System.Drawing.Point(1052, 665);
            this.LblExexTime4.Name = "LblExexTime4";
            this.LblExexTime4.Size = new System.Drawing.Size(201, 15);
            this.LblExexTime4.TabIndex = 28;
            this.LblExexTime4.Text = "Время выполнения функции: S,M с";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(527, 259);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(109, 23);
            this.btnDefault.TabIndex = 31;
            this.btnDefault.Text = "Reset values";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // rBtnLinq
            // 
            this.rBtnLinq.AutoSize = true;
            this.rBtnLinq.Checked = true;
            this.rBtnLinq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtnLinq.Location = new System.Drawing.Point(193, 67);
            this.rBtnLinq.Name = "rBtnLinq";
            this.rBtnLinq.Size = new System.Drawing.Size(55, 24);
            this.rBtnLinq.TabIndex = 32;
            this.rBtnLinq.TabStop = true;
            this.rBtnLinq.Text = "Linq";
            this.rBtnLinq.UseVisualStyleBackColor = true;
            this.rBtnLinq.CheckedChanged += new System.EventHandler(this.rBtnLinq_CheckedChanged);
            // 
            // rBtnNoLinq
            // 
            this.rBtnNoLinq.AutoSize = true;
            this.rBtnNoLinq.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtnNoLinq.Location = new System.Drawing.Point(270, 67);
            this.rBtnNoLinq.Name = "rBtnNoLinq";
            this.rBtnNoLinq.Size = new System.Drawing.Size(75, 24);
            this.rBtnNoLinq.TabIndex = 33;
            this.rBtnNoLinq.TabStop = true;
            this.rBtnNoLinq.Text = "NoLinq";
            this.rBtnNoLinq.UseVisualStyleBackColor = true;
            this.rBtnNoLinq.CheckedChanged += new System.EventHandler(this.rBtnNoLinq_CheckedChanged);
            // 
            // btnTimers
            // 
            this.btnTimers.Location = new System.Drawing.Point(193, 97);
            this.btnTimers.Name = "btnTimers";
            this.btnTimers.Size = new System.Drawing.Size(152, 23);
            this.btnTimers.TabIndex = 34;
            this.btnTimers.Text = "Диаграмма выполнения";
            this.btnTimers.UseVisualStyleBackColor = true;
            this.btnTimers.Click += new System.EventHandler(this.btnTimers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 727);
            this.Controls.Add(this.btnTimers);
            this.Controls.Add(this.rBtnNoLinq);
            this.Controls.Add(this.rBtnLinq);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.LblExexTime4);
            this.Controls.Add(this.LblExexTime2);
            this.Controls.Add(this.LblExexTime3);
            this.Controls.Add(this.LblExexTime1);
            this.Controls.Add(this.DateEndPicker);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.DateStartPicker);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.lbInterval);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.ChartFileRange);
            this.Controls.Add(this.LblFilesRange);
            this.Controls.Add(this.GVFilesRange);
            this.Controls.Add(this.ChartFolders);
            this.Controls.Add(this.ChartFiles);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.FolderSameEx);
            this.Controls.Add(this.TopNFiles);
            this.Controls.Add(this.SubfolderMaxFiles);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.GVMinFiles);
            this.Controls.Add(this.GVSubfolder);
            this.Controls.Add(this.GVSpecFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GVSpecFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVSubfolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMinFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartFileRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVFilesRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GVSpecFolder;
        private DataGridView GVSubfolder;
        private DataGridView GVMinFiles;
        private TextBox PathBox;
        private Label SubfolderMaxFiles;
        private Label TopNFiles;
        private Label FolderSameEx;
        private Label labelPath;
        private Label labelN;
        private NumericUpDown numericUpDownN;
        private NumericUpDown numericUpDownM;
        private Label labelM;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFiles;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFolders;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFileRange;
        private Label LblFilesRange;
        private DataGridView GVFilesRange;
        private NumericUpDown numericUpDownK;
        private Label lbInterval;
        private Label lblStartDate;
        private DateTimePicker DateStartPicker;
        private DateTimePicker DateEndPicker;
        private Label lblEndDate;
        private Label LblExexTime1;
        private Label LblExexTime3;
        private Label LblExexTime2;
        private Label LblExexTime4;
        private Button btnDefault;
        private RadioButton rBtnLinq;
        private RadioButton rBtnNoLinq;
        private Button btnTimers;
    }
}