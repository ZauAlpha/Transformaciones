namespace Escalado
{
    public partial class Form1 : Form
    { 
        static Bitmap bmp;
        static Graphics graphics;
        static Point a, b, c, d;
        static int tx, ty;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics= Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;


            tx = pictureBox1.Width / 2;
            ty = pictureBox1.Height / 2;

            a = new Point(0, 0);
            b = new Point(0,100);
            c = new Point(100 ,100);
            d = new Point(100,0);
            
            graphics.DrawLine(Pens.Yellow, new Point(tx, 0), new Point(tx, pictureBox1.Width));
            graphics.DrawLine(Pens.Yellow, new Point(0, ty), new Point(pictureBox1.Width, ty));
            graphics.DrawLine(Pens.Gray, a, b);
            graphics.DrawLine(Pens.Gray, b, c);
            graphics.DrawLine(Pens.Gray, c, d);
            graphics.DrawLine(Pens.Gray, d, a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new Point(-50, 50);
            b = new Point(50, 50);
            c = new Point(50, -50);
            d = new Point(-50, -50);

            float angle = float.Parse(textBox1.Text);
            Render(a, b, angle);
            Render(b, c, angle);
            Render(c, d, angle);
            Render(d, a, angle);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx += 100;
            ty += 100;
            a = new Point(-50, 50);
            b = new Point(50, 50);
            c = new Point(50, -50);
            d = new Point(-50, -50);

            float angle = float.Parse(textBox1.Text);
            Render(a, b, angle);
            Render(b, c, angle);
            Render(c, d, angle);
            Render(d, a, angle);
            tx -= 100;
            ty -= 100;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float angle = float.Parse(textBox1.Text);
            
            a = new Point(0, 0);
            b = new Point(0, 100);
            c = new Point(100, 100);
            d = new Point(100, 0);
            Render(a, b, angle);
            Render(b,c,angle);
            Render(c,d, angle);
            Render(d, a, angle);

        }
        
        private PointF TranslateToCenter(PointF point)
        {
            return new PointF(tx+point.X,ty-point.Y);
        }
        private PointF Translate(PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }
       
       
       private void Render(Point a, Point b, float angle)
        {
            PointF a2, b2;

            a2 = new PointF(tx + a.X, ty - a.Y);
            b2 = new PointF(tx + b.X, ty - b.Y);
            double degrees = Math.PI * angle / 180.0;

            a2.X = tx + (float)((a.X * Math.Cos(degrees)) - (a.Y * Math.Sin(degrees)));
            a2.Y = ty - (float)((a.X * Math.Sin(degrees)) + (a.Y * Math.Cos(degrees)));
            b2.X = tx + (float)((b.X * Math.Cos(degrees)) - (b.Y * Math.Sin(degrees)));
            b2.Y = ty - (float)((b.X * Math.Sin(degrees)) + (b.Y * Math.Cos(degrees)));

            graphics.DrawLine(Pens.White, a2, b2);

            pictureBox1.Refresh();
        }
    }
}