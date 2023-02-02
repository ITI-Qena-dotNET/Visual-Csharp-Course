namespace Lab8;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox1.SelectedIndex)
        {
            case 0:
                textBox1.ForeColor = Color.Red;
                break;
            case 1:
                textBox1.ForeColor = Color.Green;
                break;
            case 2:
                textBox1.ForeColor = Color.Blue;
                break;
            case 3:
                textBox1.ForeColor = Color.Yellow;
                break;
            default:
                break;
        }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox2.SelectedIndex)
        {
            case 0:
                textBox1.Font = new("Broadway", 10);
                break;
            case 1:
                textBox1.Font = new(FontFamily.GenericSerif, 10);
                break;
            case 2:
                textBox1.Font = new(FontFamily.GenericMonospace, 10);
                break;
            default:
                break;
        }
    }
}