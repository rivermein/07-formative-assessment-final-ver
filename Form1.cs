namespace FirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

            List<TextBox> textBoxes= new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            List<TextBox> textBoxes = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < textBoxes.Count; i++)
            {
                sum += Convert.ToInt32(textBoxes[i].Text);
            }
            textBox6.Text = Convert.ToString(sum);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonmaybe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            List<TextBox> textBoxes = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < textBoxes.Count; i++)
            {
                sum += Convert.ToInt32(textBoxes[i].Text);

            }
            int average;
            average = sum / textBoxes.Count;
            textBox7.Text = average.ToString();
        }
    }
}