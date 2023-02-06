namespace Lab8;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DataGridViewRow newRow = new();
        newRow.CreateCells(dataGridView1, textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("g"));
        dataGridView1.Rows.Add(newRow);
    }

    private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
    }
}
