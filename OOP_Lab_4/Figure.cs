using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace OOP_Lab_4
{
    abstract class Figure
    {
        protected int x;
        protected int y;
        protected Form form;

        protected Figure(int x, int y, Form form)
        {
            this.x = x;
            this.y = y;
            this.form = form;
        }

        public abstract void Draw();

        public abstract void HideDrawingBackGround();

        public void MoveRight(int step)
        {
            for(int i = 0; i < step; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                x += 5;
            }
        }
    }
}