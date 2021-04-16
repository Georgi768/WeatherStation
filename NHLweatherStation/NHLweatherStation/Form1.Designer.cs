namespace NHLweatherStation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Trend = new System.Windows.Forms.TabPage();
            this.TypeDisplay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWind = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHumidty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Graph = new System.Windows.Forms.TabPage();
            this.TrendGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Option = new System.Windows.Forms.TabPage();
            this.interval = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.tempC = new System.Windows.Forms.RadioButton();
            this.tempF = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.database1DataSet = new NHLweatherStation.Database1DataSet();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherTableAdapter = new NHLweatherStation.Database1DataSetTableAdapters.WeatherTableAdapter();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Trend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrendGraph)).BeginInit();
            this.Option.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Trend);
            this.tabControl1.Controls.Add(this.Graph);
            this.tabControl1.Controls.Add(this.Option);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Trend
            // 
            this.Trend.BackgroundImage = global::NHLweatherStation.Properties.Resources._102471858_261539758400374_1048870286864154624_n;
            this.Trend.Controls.Add(this.TypeDisplay);
            this.Trend.Controls.Add(this.label8);
            this.Trend.Controls.Add(this.txtWind);
            this.Trend.Controls.Add(this.label7);
            this.Trend.Controls.Add(this.txtHumidty);
            this.Trend.Controls.Add(this.label6);
            this.Trend.Controls.Add(this.temp);
            this.Trend.Controls.Add(this.label5);
            this.Trend.Controls.Add(this.cityDisplay);
            this.Trend.Controls.Add(this.label4);
            this.Trend.Controls.Add(this.picture);
            this.Trend.Location = new System.Drawing.Point(4, 25);
            this.Trend.Name = "Trend";
            this.Trend.Padding = new System.Windows.Forms.Padding(3);
            this.Trend.Size = new System.Drawing.Size(768, 397);
            this.Trend.TabIndex = 0;
            this.Trend.Text = "Current";
            this.Trend.UseVisualStyleBackColor = true;
            // 
            // TypeDisplay
            // 
            this.TypeDisplay.AutoSize = true;
            this.TypeDisplay.Location = new System.Drawing.Point(215, 143);
            this.TypeDisplay.Name = "TypeDisplay";
            this.TypeDisplay.Size = new System.Drawing.Size(45, 16);
            this.TypeDisplay.TabIndex = 10;
            this.TypeDisplay.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Last refreshed on";
            // 
            // txtWind
            // 
            this.txtWind.AutoSize = true;
            this.txtWind.Location = new System.Drawing.Point(130, 315);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(35, 16);
            this.txtWind.TabIndex = 8;
            this.txtWind.Text = "wind";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Wind speed";
            // 
            // txtHumidty
            // 
            this.txtHumidty.AutoSize = true;
            this.txtHumidty.Location = new System.Drawing.Point(130, 272);
            this.txtHumidty.Name = "txtHumidty";
            this.txtHumidty.Size = new System.Drawing.Size(39, 16);
            this.txtHumidty.TabIndex = 6;
            this.txtHumidty.Text = "Humi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Humidity";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(130, 225);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(38, 16);
            this.temp.TabIndex = 4;
            this.temp.Text = "temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Temperature";
            // 
            // cityDisplay
            // 
            this.cityDisplay.AutoSize = true;
            this.cityDisplay.Location = new System.Drawing.Point(212, 143);
            this.cityDisplay.Name = "cityDisplay";
            this.cityDisplay.Size = new System.Drawing.Size(0, 16);
            this.cityDisplay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "City,Country";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(9, 109);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(112, 91);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // Graph
            // 
            this.Graph.BackgroundImage = global::NHLweatherStation.Properties.Resources._102471858_261539758400374_1048870286864154624_n;
            this.Graph.Controls.Add(this.TrendGraph);
            this.Graph.Location = new System.Drawing.Point(4, 25);
            this.Graph.Name = "Graph";
            this.Graph.Padding = new System.Windows.Forms.Padding(3);
            this.Graph.Size = new System.Drawing.Size(768, 397);
            this.Graph.TabIndex = 1;
            this.Graph.Text = "Trend";
            this.Graph.UseVisualStyleBackColor = true;
            // 
            // TrendGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.TrendGraph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.TrendGraph.Legends.Add(legend5);
            this.TrendGraph.Location = new System.Drawing.Point(53, 36);
            this.TrendGraph.Name = "TrendGraph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Temperature";
            this.TrendGraph.Series.Add(series5);
            this.TrendGraph.Size = new System.Drawing.Size(664, 300);
            this.TrendGraph.TabIndex = 0;
            this.TrendGraph.Text = "chart1";
            // 
            // Option
            // 
            this.Option.BackgroundImage = global::NHLweatherStation.Properties.Resources._102471858_261539758400374_1048870286864154624_n;
            this.Option.Controls.Add(this.interval);
            this.Option.Controls.Add(this.ShowButton);
            this.Option.Controls.Add(this.tempC);
            this.Option.Controls.Add(this.tempF);
            this.Option.Controls.Add(this.label3);
            this.Option.Controls.Add(this.label2);
            this.Option.Controls.Add(this.TypeCity);
            this.Option.Controls.Add(this.label1);
            this.Option.Location = new System.Drawing.Point(4, 25);
            this.Option.Name = "Option";
            this.Option.Padding = new System.Windows.Forms.Padding(3);
            this.Option.Size = new System.Drawing.Size(768, 397);
            this.Option.TabIndex = 2;
            this.Option.Text = "Options";
            this.Option.UseVisualStyleBackColor = true;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(176, 163);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(100, 22);
            this.interval.TabIndex = 8;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(9, 307);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(246, 33);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show Weather";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // tempC
            // 
            this.tempC.AutoSize = true;
            this.tempC.Location = new System.Drawing.Point(217, 247);
            this.tempC.Name = "tempC";
            this.tempC.Size = new System.Drawing.Size(38, 20);
            this.tempC.TabIndex = 6;
            this.tempC.TabStop = true;
            this.tempC.Text = "C";
            this.tempC.UseVisualStyleBackColor = true;
            // 
            // tempF
            // 
            this.tempF.AutoSize = true;
            this.tempF.Location = new System.Drawing.Point(174, 247);
            this.tempF.Name = "tempF";
            this.tempF.Size = new System.Drawing.Size(37, 20);
            this.tempF.TabIndex = 5;
            this.tempF.TabStop = true;
            this.tempF.Text = "F";
            this.tempF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select type of temperature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interval";
            // 
            // TypeCity
            // 
            this.TypeCity.Location = new System.Drawing.Point(176, 78);
            this.TypeCity.Name = "TypeCity";
            this.TypeCity.Size = new System.Drawing.Size(100, 22);
            this.TypeCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select City,Country";
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.openToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(229, 231);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Notifications
            // 
            this.Notifications.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notifications.BalloonTipTitle = "Notification";
            this.Notifications.ContextMenuStrip = this.ContextMenu;
            this.Notifications.Text = "MyApplication";
            this.Notifications.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataMember = "Weather";
            this.weatherBindingSource.DataSource = this.database1DataSet;
            // 
            // weatherTableAdapter
            // 
            this.weatherTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 28);
            this.toolStripMenuItem1.Text = "CurrentTemp";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(248, 28);
            this.toolStripMenuItem2.Text = "CurrentTemp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.Trend.ResumeLayout(false);
            this.Trend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrendGraph)).EndInit();
            this.Option.ResumeLayout(false);
            this.Option.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Trend;
        private System.Windows.Forms.TabPage Graph;
        private System.Windows.Forms.TabPage Option;
        private System.Windows.Forms.RadioButton tempC;
        private System.Windows.Forms.RadioButton tempF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TypeCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label txtHumidty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cityDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label txtWind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Notifications;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label TypeDisplay;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource weatherBindingSource;
        private Database1DataSetTableAdapters.WeatherTableAdapter weatherTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart TrendGraph;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

