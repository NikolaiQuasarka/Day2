namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int m) & int.TryParse(textBox2.Text, out int n)
                & m>0 & n>0)
            {
                NODCl res = NODCl.NODSearch(m, n);
                if(res.b*n>=0)
                textBox3.Text = $"{res.a}*{m}+{res.b}*{n}";
                else textBox3.Text = $"{res.a}*{m}{res.b}*{n}";
            }
        }
    }
}
