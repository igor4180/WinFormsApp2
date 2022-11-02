using System.Drawing;
using System.Drawing.Drawing2D;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        Graphics g = e.Graphics;
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 400), new Point(400, 500));
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(360, 460));
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(440, 460));
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(360, 540));
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(440, 540));
        g.DrawEllipse(new Pen(Brushes.Blue, 5), 375, 350, 50, 50);
        g.DrawLine(new Pen(Brushes.Red, 5), new Point(440, 430), new Point(440, 490));
        g.DrawEllipse(new Pen(Brushes.Blue, 5), 430, 410, 20, 20);
        g.DrawEllipse(new Pen(Brushes.Blue, 2), 426, 403, 8, 8);
        g.DrawEllipse(new Pen(Brushes.Blue, 2), 437, 400, 8, 8);
        g.DrawEllipse(new Pen(Brushes.Blue, 2), 423, 410, 8, 8);
        g.DrawEllipse(new Pen(Brushes.Blue, 2), 448, 410, 8, 8);
        g.DrawEllipse(new Pen(Brushes.Blue, 2), 448, 403, 8, 8);
        g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(320, 310, 40, 40), 0, 180);
        g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 300, 40, 40), 30, 180);
        g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 280, 40, 40), 144, 180);
        g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(310, 280, 40, 40), 216, 135);
        g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(310, 295, 40, 40), 270, 150);
        g.Dispose();
        }
    }
  
}