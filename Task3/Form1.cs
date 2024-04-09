namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_a.Text, out double a) & double.TryParse(textBox_b.Text, out double b) &
             double.TryParse(textBox_c.Text, out double c) & double.TryParse(textBox_startx.Text, out double startx) &
             double.TryParse(textBox_endx.Text, out double endx) & double.TryParse(textBox_dX.Text, out double dX))
            {
                dataGridView1.Rows.Clear();
                for (double x = startx; x <= endx; x += dX)
                {
                    dataGridView1.Rows.Add(x, Functions.Function(x, a, b, c).ToString());
                }
            }
            else MessageBox.Show("Вы ввели неверные значения");
            
        }
    }
}
