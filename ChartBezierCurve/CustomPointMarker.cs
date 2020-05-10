using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ChartBezierCurve
{
    public class CustomPointMarker : ElementPointMarker
    {
        public double CustomSize
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(
              "CustomSize",
              typeof(double),
              typeof(ShapeElementPointMarker),
              new FrameworkPropertyMetadata(5.0));

        public Brush CustomBrush
        {
            get { return (Brush)GetValue(BrushProperty); }
            set { SetValue(BrushProperty, value); }
        }

        public static readonly DependencyProperty BrushProperty =
            DependencyProperty.Register(
              "CustomBrush",
              typeof(Brush),
              typeof(ShapeElementPointMarker),
              new FrameworkPropertyMetadata(Brushes.Red));

        public Brush CustomFill
        {
            get { return (Brush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(
              "CustomFill",
              typeof(Brush),
              typeof(ShapeElementPointMarker),
              new FrameworkPropertyMetadata(Brushes.Red));

        public override System.Windows.UIElement CreateMarker()
        {
            Rectangle result = new Rectangle();

            result.Height = CustomSize;
            result.Width = CustomSize;
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(@"DSC09045.JPG", UriKind.Relative));
            result.Fill = imgBrush;

            //Ellipse result = new Ellipse();
            //result.Width = CustomSize;
            //result.Height = CustomSize;
            //result.Stroke = CustomBrush;
            //result.Fill = CustomFill;
            //if (!String.IsNullOrEmpty(ToolTipText))
            //{
            //    ToolTip tt = new ToolTip();
            //    tt.Content = ToolTipText;
            //    result.ToolTip = tt;
            //}

            return result;
        }

        public override void SetMarkerProperties(System.Windows.UIElement marker)
        {
            Rectangle result = (Rectangle)marker;

            result.Width = CustomSize;
            result.Height = CustomSize;
            result.Stroke = CustomBrush;
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(@"DSC09045.JPG", UriKind.Relative));
            result.Fill = imgBrush;
            //result.Fill = CustomFill;

            if (!String.IsNullOrEmpty(ToolTipText))
            {
                ToolTip tt = new ToolTip();
                tt.Content = ToolTipText;
                result.ToolTip = tt;
            }
        }

        public override void SetPosition(System.Windows.UIElement marker, System.Windows.Point screenPoint)
        {
            Canvas.SetLeft(marker, screenPoint.X - CustomSize / 2);
            Canvas.SetTop(marker, screenPoint.Y - CustomSize / 2);
        }

        public string ToolTipText { get; set; }
    }
}
