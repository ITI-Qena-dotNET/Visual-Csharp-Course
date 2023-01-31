using System.Text.RegularExpressions;

namespace Lab7;

public partial class Form2 : Form
{
    [GeneratedRegex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$")]
    private static partial Regex _emailRegex();

    private bool IsNameValid, IsEmailValid, IsHobbyValid;

    public Form2()
    {
        InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (textBox1.Text.Length < 5)
            label5.Visible = true;
        else
            label5.Visible = false;

        IsNameValid = !label5.Visible;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (IsNameValid && IsEmailValid && IsHobbyValid)
            label8.Visible = true;
        else
        {
            label8.Visible = false;
            MessageBox.Show("Form not valid");
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        if (!_emailRegex().IsMatch(textBox2.Text))
            label6.Visible = true;
        else
            label6.Visible = false;

        IsEmailValid = !label6.Visible;
    }

    private void MeterCheckedChanged(object sender, EventArgs e)
    {
        bool hobby1Check = checkBox1.Checked;
        bool hobby2Check = checkBox2.Checked;
        bool hobby3Check = checkBox3.Checked;

        if (hobby1Check || hobby2Check || hobby3Check)
            label7.Visible = false;
        else
            label7.Visible = true;

        IsHobbyValid = !label7.Visible;
    }

}
