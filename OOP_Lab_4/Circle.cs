using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab_4
{
    class Circle : Figure
    {
        private int radius;
        
        public Circle(int x, int y, int radius, Form form) : base(x, y, form)
        {
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics g = form.CreateGraphics();
            g.DrawEllipse(Pens.Black, x - radius, y - radius, radius * 2, radius * 2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics g = form.CreateGraphics();
            using (Pen p = new Pen(form.BackColor))
            {
                g.DrawEllipse(p, x - radius, y - radius, radius * 2, radius * 2);
            }
        }
    }
}