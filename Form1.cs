using Intruments11.Model;

namespace Intruments11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            dataGridView1.ColumnCount = (int)box.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            var box = (NumericUpDown)sender;
            dataGridView1.RowCount = (int)box.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information information = new Information(dataGridView1);

            textBox1.Text = information.PInfo;
            textBox2.Text = information.QInfo;
        }
    }
}