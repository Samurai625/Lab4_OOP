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

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                x += 5;
            }

            // залишаємо фігуру на кінцевій позиції
            DrawBlack();
        }
    }
}
