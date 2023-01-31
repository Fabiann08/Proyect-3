namespace RealExamen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double a, b, c;
            b = Double.Parse(BTextBox.Text);
            c = Double.Parse(CTextBox.Text);
            a = Math.Sqrt((c * c) - (b * b));
            ResultTextBox.Text = a.ToString("0.000000");
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the fruit selected: "+FruitListBox.Text);
        }

        private void TheShowBbutton_Click(object sender, EventArgs e)
        {                
            MessageBox.Show(NameTextBox.Text + " - " + LastNameTextBox.Text);
        }

        private void CheckIFNumber(object sender, EventArgs e)
        {
           
            try
            {
               
            }
            catch(ArithmeticException ex)
            { MessageBox.Show(ex.Message, "Error"); }

        }
    }
}