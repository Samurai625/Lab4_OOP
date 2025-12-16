namespace OOP_Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Circle circle = new Circle(50, 100, 20, this);
            Square square = new Square(50, 200, 40, this);
            Rhomb rhomb = new Rhomb(50, 300, 60, 40, this);

            circle.MoveRight(50);
            square.MoveRight(50);
            rhomb.MoveRight(50);
        }
    }
}
