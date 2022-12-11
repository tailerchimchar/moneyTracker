namespace MoneyGoByeBye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Equals("") == textBox2.Equals("") || textBox3.Equals(""))
            {
                MessageBox.Show("you did not fill it out");
            }
            else
            {
                DateTime date = dateTimePicker1.Value;
                string TotalSpent = textBox1.Text.ToString();
                string Category = textBox2.Text.ToString();
                string Description = textBox3.Text.ToString();

                dataGridView1.Rows.Add(date, TotalSpent, Category, Description);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}