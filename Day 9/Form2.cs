namespace Lab9;

public partial class Form2 : Form
{
    public TextProperties properties;
    Form1 parentForm;

    public event ChangeText OnApplyText;

    public Form2(Form1 form)
    {
        InitializeComponent();
        parentForm = form;
        properties = new();
        OnApplyText += form.ChangeTextFormat;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var fontItem = comboBox1.SelectedIndex;

        switch (fontItem)
        {
            case 0:
                properties.textFont = new("Broadway", (float)numericUpDown1.Value);
                break;
            case 1:
                properties.textFont = new(FontFamily.GenericSerif, (float)numericUpDown1.Value);
                break;
            case 2:
                properties.textFont = new(FontFamily.GenericMonospace, (float)numericUpDown1.Value);
                break;
            default:
                break;
        }

        if (checkBox1.Checked)
            properties.textFontStyle |= FontStyle.Bold;
        else
            properties.textFontStyle &= ~FontStyle.Bold;

        if (checkBox2.Checked)
            properties.textFontStyle |= FontStyle.Italic;
        else
            properties.textFontStyle &= ~FontStyle.Italic;

        if (checkBox3.Checked)
            properties.textFontStyle |= FontStyle.Underline;
        else
            properties.textFontStyle &= ~FontStyle.Underline;

        properties.textFont = new Font(properties.textFont, properties.textFontStyle);

        OnApplyText?.Invoke();
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        properties.textColor = Color.Red;
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        properties.textColor = Color.Blue;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        ColorDialog dialog = new();

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            properties.textColor = dialog.Color;
        }
    }
}

public class TextProperties
{
    public Font textFont;
    public FontStyle textFontStyle;
    public Color textColor;
}