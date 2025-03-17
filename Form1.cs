using System.Data;

namespace calculator__
{
    public partial class Form1 : Form
    {
        private string currentcalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            currentcalculation += (sender as Button).Text;
            txtOutput.Text = currentcalculation;
        }
        private void button_Equals_click(object sender, EventArgs e)
        {
            string formattedcalculation = currentcalculation.ToString();
            try
            {
                txtOutput.Text = new DataTable().Compute(formattedcalculation, null).ToString();
                currentcalculation = txtOutput.Text;
            }
            catch (Exception ex) 
            {
                txtOutput.Text = "ERROR";
                currentcalculation = "";    
            }
        }
        private void button_clear_click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            currentcalculation = "";

        }
        private void button_clearEntery_click(object sender, EventArgs e)
        {
            if (currentcalculation.Length > 0)
            {
                currentcalculation =currentcalculation.Remove(currentcalculation.Length - 1,1);
            }
            txtOutput.Text = currentcalculation;
        }
             
    }
}
