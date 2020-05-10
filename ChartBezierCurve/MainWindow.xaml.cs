using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay;

namespace ChartBezierCurve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int N = 50;
        double[] x = new double[N];
        double[] y = new double[N];
        List<double> y1 = new List<double>();
        List<double> x1 = new List<double>();

        EnumerableDataSource<double> xDataSource;
        EnumerableDataSource<double> yDataSource;
        EnumerableDataSource<double> yDataSource1;
        EnumerableDataSource<double> xDataSource1;

        LineAndMarker<ElementMarkerPointsGraph> chart;
        IPointDataSource ds;
        IPointDataSource ds1;

        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            double min = double.NaN;
            double max = double.NaN;
            double tot = 0;
            double avg = double.NaN; 
            for (int i = 0; i < N; i++)
            {
                x[i] = i;
                if (i % 10 == 0)
                {
                    y[i] = rand.Next(-30, 40);
                }
                else
                {
                    y[i] = rand.Next(-2, 2);
                }
                tot = tot + y[i];
                if (double.IsNaN(min))
                {
                    min = y[i];
                    max = y[i];
                }
                else
                {
                    if (min > y[i])
                    {
                        min = y[i];
                    }

                    if (max < y[i])
                    {
                        max = y[i];
                    }
                }
            }

            avg = tot / N;
            for (int i = 0; i < N; i++)
            {
                if (Math.Abs(Math.Abs(avg) - Math.Abs(y[i])) > Math.Abs(avg))
                {
                    double temp = avg + y[i];
                    if (temp < 0 && temp < y[i])
                    {
                        temp = avg + y[i] / 2;
                    }

                    if (temp > 0 && temp > y[i])
                    {
                        temp = avg + y[i] / 2;
                    }

                    y1.Add(temp);
                    x1.Add(x[i]);
                }
            }

            // Add data sources:
            yDataSource = new EnumerableDataSource<double>(y);
            yDataSource.SetYMapping(Y => Y);
            yDataSource.AddMapping(ShapeElementPointMarker.ToolTipTextProperty,
                Y => String.Format("Value is {0}", Y));

            xDataSource = new EnumerableDataSource<double>(x);
            xDataSource.SetXMapping(X => X);


            ds = new CompositeDataSource(xDataSource, yDataSource);

            yDataSource1 = new EnumerableDataSource<double>(y1.ToArray());
            yDataSource1.SetYMapping(Y => Y);
            xDataSource1 = new EnumerableDataSource<double>(x1.ToArray());
            xDataSource1.SetXMapping(X => X);
            ds1 = new CompositeDataSource(xDataSource1, yDataSource1);
            
            //this.plygon.Points = new PointCollection();
            //this.plygon.Points.AddMany(ds.GetPoints());
            //this.polyLine.Points = new PointCollection();
            //this.polyLine.Points.AddMany(ds.GetPoints());

            this.bezierPoints.Points = new PointCollection();
            this.bezierPoints.Points.AddMany(ds1.GetPoints());

            chart = plotter.AddLineGraph(ds,
                new Pen(Brushes.LimeGreen, 1),
                new CustomPointMarker
                {
                    CustomSize = 80,
                    CustomBrush = Brushes.Red,
                    CustomFill = Brushes.Orange
                },

                new PenDescription("Nikhil"));

            //chart = plotter.AddLineGraph(ds,
            //    new Pen(Brushes.Blue, 1),
            //    new CircleElementPointMarker { Brush = Brushes.Blue, Fill = Brushes.Blue, Size = 10, ToolTipText = "Some text" },
            //    new PenDescription("Sleeve")
            //    );

            chart.MarkerGraph.Visibility = System.Windows.Visibility.Collapsed;
            //plotter.Children.Add(new CursorCoordinateGraph());

            // Force evertyhing plotted to be visible
            plotter.FitToView();
        }
    }
}
