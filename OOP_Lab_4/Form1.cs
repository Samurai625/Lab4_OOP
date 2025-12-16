namespace OOP_Lab_4
{
    public partial class Form1 : Form
    {

        private Circle circle;
        private Square square;
        private Rhomb rhomb;

        public Form1()
        {
            InitializeComponent();

            circle = new Circle(50, 100, 20, this);
            square = new Square(50, 200, 40, this);
            rhomb = new Rhomb(50, 300, 40, 40, this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            circle.MoveRight(50);
            square.MoveRight(50);
            rhomb.MoveRight(50);
        }
    }
}
