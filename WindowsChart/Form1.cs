using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitChart();
        }

        private void InitChart()
        {
            Series serises = new Series();
            serises.ChartType = SeriesChartType.Line;
            ChartArea chartArea = new ChartArea();            
            
            this.chart1.Series.Add("Test");
        }
    }
}
