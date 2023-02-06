namespace Lab8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = checkedListBox1.CheckedItems;
            List<int> indexes = new();

            foreach (string item in items)
            {
                checkedListBox2.Items.Add(item);
                indexes.Add(checkedListBox1.CheckedItems.IndexOf(item));
            }

            foreach (int item in indexes)
            {
                checkedListBox1.Items.RemoveAt(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var items = checkedListBox1.Items;
            List<int> indexes = new();

            foreach (string item in items)
            {
                checkedListBox2.Items.Add(item);
                indexes.Add(checkedListBox1.Items.IndexOf(item));
            }

            checkedListBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var items = checkedListBox2.CheckedItems;
            List<int> indexes = new();

            foreach (string item in items)
            {
                checkedListBox1.Items.Add(item);
                indexes.Add(checkedListBox2.CheckedItems.IndexOf(item));
            }

            foreach (int item in indexes)
            {
                checkedListBox2.Items.RemoveAt(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var items = checkedListBox2.Items;
            List<int> indexes = new();

            foreach (string item in items)
            {
                checkedListBox1.Items.Add(item);
                indexes.Add(checkedListBox2.Items.IndexOf(item));
            }
            
            checkedListBox2.Items.Clear();
        }
    }
}
