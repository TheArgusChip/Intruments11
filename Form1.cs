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
            button1.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 3;
            numericUpDown2.Value = 3;

            dataGridView1[0, 0].Value = 8;
            dataGridView1[1, 0].Value = 3;
            dataGridView1[2, 0].Value = 4;

            dataGridView1[0, 1].Value = -3;
            dataGridView1[1, 1].Value = 4;
            dataGridView1[2, 1].Value = 5;

            dataGridView1[0, 2].Value = -4;
            dataGridView1[1, 2].Value = -5;
            dataGridView1[2, 2].Value = 6;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}