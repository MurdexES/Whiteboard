using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Whiteboard.View
{
    /// <summary>
    /// Interaction logic for WhiteboardView.xaml
    /// </summary>
    public partial class WhiteboardView : UserControl
    {
        private enum DrawingTool { None, Rectangle, Ellipse, Line, Pen, Eraser}
        private DrawingTool currentTool = DrawingTool.None;
        private Point startPoint;
        private Shape drawingShape;
        private Brush pen = Brushes.Black;
        private double penThickness = 2;

        public WhiteboardView()
        {
            InitializeComponent();
            
        }

        private void SetDrawingTool(DrawingTool tool)
        {
            currentTool = tool;
        }

        private void Pic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (currentTool != DrawingTool.None)
            {
                startPoint = e.GetPosition(Pic);

                switch (currentTool)
                {
                    case DrawingTool.Rectangle:
                        drawingShape = new Rectangle
                        {
                            Stroke = Brushes.Black,
                            StrokeThickness = 2,
                            Fill = Brushes.Transparent
                        };

                        Canvas.SetLeft(drawingShape, startPoint.X);
                        Canvas.SetTop(drawingShape, startPoint.Y);

                        break;

                    case DrawingTool.Ellipse:
                        drawingShape = new Ellipse
                        {
                            Stroke = Brushes.Black,
                            StrokeThickness = 2,
                            Fill = Brushes.Transparent
                        };

                        Canvas.SetLeft(drawingShape, startPoint.X);
                        Canvas.SetTop(drawingShape, startPoint.Y);

                        break;

                    case DrawingTool.Line:
                        drawingShape = new Line
                        {
                            X1 = startPoint.X,
                            Y1 = startPoint.Y,
                            Stroke = Brushes.Black,
                            StrokeThickness = 2
                        };
                        break;
                }

                Pic.Children.Add(drawingShape);
            }
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentTool != DrawingTool.None && drawingShape != null && e.LeftButton == MouseButtonState.Pressed)
            {
                if (currentTool == DrawingTool.Line)
                {
                    Line line = drawingShape as Line;
                    if (line != null)
                    {
                        line.X2 = e.GetPosition(Pic).X;
                        line.Y2 = e.GetPosition(Pic).Y;
                    }
                }
                else
                {
                    double width = e.GetPosition(Pic).X - startPoint.X;
                    double height = e.GetPosition(Pic).Y - startPoint.Y;

                    if (width > 0 && height > 0)
                    {
                        drawingShape.Width = width;
                        drawingShape.Height = height;
                    }
                }     
            }
        }

        private void Pic_MouseUp(object sender, MouseButtonEventArgs e)
        {
            drawingShape = null;
        }

        private void EllipseBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDrawingTool(DrawingTool.Ellipse);
        }

        private void RectangleBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDrawingTool(DrawingTool.Rectangle);
        }

        private void LineBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDrawingTool(DrawingTool.Line);
        }

        private void EraserBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDrawingTool(DrawingTool.Eraser);
        }

        private void PencilBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDrawingTool(DrawingTool.Pen);
        }

        private void FillBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
