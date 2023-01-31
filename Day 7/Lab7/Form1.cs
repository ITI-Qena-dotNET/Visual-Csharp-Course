namespace Lab7;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void MeterCheckedChanged(object sender, EventArgs e)
    {
        if (double.TryParse(textBox1.Text, out double value))
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = (value / 1000).ToString();
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = (value * 1000 * 1.6).ToString();
            }
            else if (radioButton3.Checked)
            {
                textBox2.Text = (value / 1000 / 1.6).ToString();
            }
        }

    }
}