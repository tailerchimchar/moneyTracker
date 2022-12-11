using LiveCharts;
using LiveCharts.Wpf;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyGoByeBye
{
    public partial class Form1 : Form
    {
        private int numRows;
        public Form1()
        {
            InitializeComponent();
            numRows = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals("") == textBox2.Equals("") || textBox3.Equals(""))
            {
                MessageBox.Show("you did not fill it out");
            }
            DateTime date = dateTimePicker1.Value;
            string TotalSpent = textBox1.Text.ToString();
            string Category = textBox2.Text.ToString();
            string Description = textBox3.Text.ToString();

            dataGridView1.Rows.Add(date, TotalSpent, Category, Description);
            numRows++;

            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart();
            pieChart.InnerRadius = 25;
            pieChart.Width = 400;
            pieChart.Height = 400;

            /*
            Random rnd = new Random();
            SeriesCollection sers = new SeriesCollection();
            for(int n = 0; n < 5; n++)
            {
                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<double> { Math.Round(rnd.NextDouble(), 2) };
                ser.Title = "ID" + (n + 1).ToString();
                ser.DataLabels = true;
                sers.Add(ser);
            }
            pieChart.LegendLocation = LegendLocation.Bottom;
            pieChart.Series = sers;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(pieChart);
            */

            SeriesCollection sers1 = new SeriesCollection();
            for (int i = 0; i < numRows; i++)
            {
                //PieSeries ser = new PieSeries();
                //total expenses
                int totalExpenses = (int)Convert.ToInt64(dataGridView1.Rows[i].Cells[1].Value.ToString());
                string category = dataGridView1.Rows[i].Cells[2].Value.ToString();

                PieSeries ser = new PieSeries();
                ser.Values = new ChartValues<int> { totalExpenses };
                ser.Title = category;
                ser.DataLabels = true;
                sers1.Add(ser);

                MessageBox.Show("total expenses: " + totalExpenses.ToString());
                MessageBox.Show("category: " + category);
            }
            pieChart.LegendLocation = LegendLocation.Bottom;
            pieChart.Series = sers1;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(pieChart);


            /*
            MessageBox.Show("value at (0,0): " + dataGridView1.Rows[0].Cells[0].Value.ToString());
            MessageBox.Show("value at (0,1): " + dataGridView1.Rows[0].Cells[1].Value.ToString());
            MessageBox.Show("value at (0,2): " + dataGridView1.Rows[0].Cells[2].Value.ToString());
            MessageBox.Show("value at (0,3): " + dataGridView1.Rows[0].Cells[3].Value.ToString());
            */

        }
    }
}
