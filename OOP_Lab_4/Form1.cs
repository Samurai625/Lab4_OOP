namespace OOP_Lab_4
{
    public partial class Form1 : Form
    {

        List<Figure> figures = new List<Figure>();

        public Form1()
        {
            InitializeComponent();

            figures.Add(new Circle(50, 100, 20, this));
            figures.Add(new Square(50, 200, 40, this));
            figures.Add(new Rhomb(50, 300, 40, 40, this));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach(var Shape in figures)
            {
                Shape.MoveRight(50);
            }
        }
    }
}
