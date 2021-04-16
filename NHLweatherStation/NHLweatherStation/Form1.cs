using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Net;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.DataVisualization.Charting;


namespace NHLweatherStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            Thread thread = new Thread(new ThreadStart(Start));

            thread.Start();
            Thread.Sleep(3000);
            InitializeComponent();

            StartTime(60000);

            Notifications.Icon = SystemIcons.Application;

            thread.Abort();
        }
        //creating the
        private void StartTime(int time)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            timer.Tick += new EventHandler(timer1_Tick);
            timer.Enabled = true;
            timer.Interval = time;

            try
            {
                timer.Interval = time;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                timer.Interval = 60000;
            }

        }
        public void Start()
        {
            //Opening a splash screen
            Application.Run(new SpashScreen());

        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            MainPage();
            tabControl1.SelectedTab = Trend;
        }

        private void MainPage()
        {
            string TemperatureF;
            string Temperature;
            string tempString;
            string Humidity;
            string WindSpeed;
            string Country;
            string city;
            string units;
            string icons;
            int seconds = 60;
            string refresh;
            string date;
            city = TypeCity.Text;
            if (String.IsNullOrEmpty(TypeCity.Text))
            {
                city = "Emmen";
            }
            //setting up the api 
            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=YourKey&days=5&q=" + city);

            XDocument Document = XDocument.Load(url);

            WebClient webClient = new WebClient();

            Temperature = (string)Document.Descendants("temp_c").FirstOrDefault();

            TemperatureF = (string)Document.Descendants("temp_f").FirstOrDefault();

            Humidity = (string)Document.Descendants("humidity").FirstOrDefault() + " %";

            WindSpeed = (string)Document.Descendants("wind_kph").FirstOrDefault() + " kph";

            city = (string)Document.Descendants("name").FirstOrDefault();

            Country = (string)Document.Descendants("country").FirstOrDefault() + " ," + city;

            refresh = label8.Text = "Last refreshed on:" + DateTime.Now.ToString("HH:mm:ss");

            date = (string)Document.Descendants("localtime").FirstOrDefault();

            icons = (string)Document.Descendants("icon").FirstOrDefault();
            TypeDisplay.Text = Country;

            //setting up the icon 

            byte[] image = webClient.DownloadData("http:" + icons);

            MemoryStream stream = new MemoryStream(image);

            Bitmap bitmap = new Bitmap(stream);
            Bitmap icon = bitmap;

            picture.Image = icon;

            //changing the type of temperature depening on the selected radio button

            if (tempF.Checked)
            {

                string url2 = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=YourKey&days=5&q={0}", city);

                XDocument Document2 = XDocument.Load(url2);

                Temperature = (string)Document2.Descendants("temp_f").FirstOrDefault();

                temp.Text = Temperature + " F";
                units = "F";

            }
            else
            {
                string url2 = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=YourKey&days=5&q={0}", city);

                XDocument Document2 = XDocument.Load(url2);

                Temperature = (string)Document2.Descendants("temp_c").FirstOrDefault();

                temp.Text = Temperature + " C";
                units = "C";

            }

            toolStripMenuItem1.Text = "Current Temperature: " + TemperatureF + " F";
            toolStripMenuItem2.Text = "Current Temperature: " + Temperature + " C";


            txtHumidty.Text = Humidity;

            txtWind.Text = WindSpeed;
            string path = Path.GetFullPath("Database1.mdf");

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");

            SqlCommand sqlCommand = connection.CreateCommand();
            connection.Open();
            string query = "INSERT INTO Weather (location,Temperature,date,unitsTemperature) VALUES (@location,@Temperature,@date,@unitsTemperature)";

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;
            sqlCommand.Parameters.AddWithValue("@location", Country);
            sqlCommand.Parameters.AddWithValue("@Temperature", Temperature);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@unitsTemperature", units);

            sqlCommand.ExecuteNonQuery();

            connection.Close();


            SqlCommand Select = new SqlCommand("SELECT (avg(Temperature)) as Temperature,date FROM Weather WHERE location = '" + Country + "' group by date", connection);
            connection.Open();
            Series series = TrendGraph.Series["Temperature"];

            SqlDataReader sqlData = Select.ExecuteReader();



            while (sqlData.Read())
            {
                series.Points.AddXY(sqlData["date"].ToString(), sqlData["Temperature"]);
            }

            connection.Close();

            //calling the database method to store the values


            //  Database(Country, Temperature, units);
        }
        //creating notifications
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Notifications.Icon = SystemIcons.Application;
                Notifications.BalloonTipText = "Your application has been minimized";
                Notifications.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Notifications.BalloonTipText = "Your application has been Opened";
                Notifications.ShowBalloonTip(1000);
            }
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Option;

            tabControl1.SelectedTab.Show();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage about = new AboutPage();
            about.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainPage();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {



            MainPage();


            // TODO: This line of code loads data into the 'database1DataSet.Weather' table. You can move, or remove it, as needed.
            this.weatherTableAdapter.Fill(this.database1DataSet.Weather);

        }


    }


}

