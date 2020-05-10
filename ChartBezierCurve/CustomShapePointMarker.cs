using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using System.Windows.Shapes;

namespace ChartBezierCurve
{
    //public class CustomShapePointMarker : ShapePointMarker
    //{
    //    public override System.Windows.UIElement CreateMarker()
    //    {
    //        Rectangle result = new Rectangle();

    //        result.Height = CustomSize;
    //        result.Width = CustomSize;
    //        ImageBrush imgBrush = new ImageBrush();
    //        imgBrush.ImageSource = new BitmapImage(new Uri(@"DSC09045.JPG", UriKind.Relative));
    //        result.Fill = imgBrush;

    //        return result;
    //    }

    //    public override void SetMarkerProperties(System.Windows.UIElement marker)
    //    {
    //        Rectangle rectangle = (Rectangle)marker;

    //        rectangle.Width = Size;
    //        rectangle.Height = Size;
    //        rectangle.Stroke = Brush;
    //        rectangle.Fill = Fill;

    //        if (!String.IsNullOrEmpty(ToolTipText))
    //        {
    //            ToolTip tt = new ToolTip();
    //            tt.Content = ToolTipText;
    //            rectangle.ToolTip = tt;
    //        }
    //    }

    //    public override void SetPosition(System.Windows.UIElement marker, System.Windows.Point screenPoint)
    //    {
    //        Canvas.SetLeft(marker, screenPoint.X - Size / 2);
    //        Canvas.SetTop(marker, screenPoint.Y - Size / 2);
    //    }

    //    public override void Render(System.Windows.Media.DrawingContext dc, System.Windows.Point screenPoint)
    //    {
    //        dc.DrawRectangle(Fill, Pen, new System.Windows.Rect() { Height = 50, Width = 50 });
    //    }
    //}
}
