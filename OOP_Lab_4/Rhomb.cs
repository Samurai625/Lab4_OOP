using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab_4
{
    class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;

        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen, Form form) : base(x, y, form)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        public override void DrawBlack()
        {
            Graphics g = form.CreateGraphics();

            Point[] points =
            {
                new Point(x, y - vertDiagLen / 2),
                new Point(x + horDiagLen / 2, y),
                new Point(x, y + vertDiagLen / 2),
                new Point(x - horDiagLen / 2, y)
            };

            g.DrawPolygon(Pens.Black, points);
        }

        public override void HideDrawingBackGround()
        {
            Graphics g = form.CreateGraphics();
            using (Pen p = new Pen(form.BackColor))
            {
                Point[] points =
                {
                    new Point(x, y - vertDiagLen / 2),
                    new Point(x + horDiagLen / 2, y),
                    new Point(x, y + vertDiagLen / 2),
                    new Point(x - horDiagLen / 2, y)
                };

                g.DrawPolygon(p, points);
            }
        }
    }
}