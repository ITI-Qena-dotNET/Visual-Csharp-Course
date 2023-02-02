namespace Lab9;

public partial class Form1 : Form
{
    Form2 formatForm;

    public Form1()
    {
        InitializeComponent();
        formatForm = new(this);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formatForm.Show();
    }

    public void ChangeTextFormat()
    {
        textBox1.ForeColor = formatForm.properties.textColor;
        textBox1.Font = formatForm.properties.textFont;
    }
}

public delegate void ChangeText();