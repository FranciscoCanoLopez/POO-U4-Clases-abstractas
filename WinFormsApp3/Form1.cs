namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create objects of geometric shapes
            Circle circle = new Circle(50, new Point(100, 100));
            Rectangle rectangle = new Rectangle(100, 50, new Point(200, 200));

            // Draw the geometric shapes
            circle.Draw(e.Graphics);
            rectangle.Draw(e.Graphics);

            // Show the area of the geometric shapes
            MessageBox.Show("Area of circle: " + circle.CalculateArea());
            MessageBox.Show("Area of rectangle: " + rectangle.CalculateArea());
        }
    }
}
