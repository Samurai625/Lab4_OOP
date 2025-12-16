using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab_4
{
    class Square : Figure
    {
        private int sideLength;

        public Square(int x, int y, int sideLength, Form form) : base(x, y, form)
        {
            this.sideLength = sideLength;
        }

        public override void DrawBlack()
        {
            Graphics g = form.CreateGraphics();
            g.DrawRectangle(Pens.Black, x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
        }

        public override void HideDrawingBackGround()
        {
            Graphics g = form.CreateGraphics();
            using (Pen p = new Pen(form.BackColor))
            {
                g.DrawRectangle(p, x - sideLength / 2, y - sideLength / 2, sideLength, sideLength);
            }
        }
    }
}