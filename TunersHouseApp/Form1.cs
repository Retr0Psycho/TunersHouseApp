namespace TunersHouseApp
{
    public partial class Form1 : Form
    {
        char[] symbols = { '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        List<string> datahiden = new(), dataSeen = new() { "companyID", "weekID", "value" };
        const string filePathData = @"Data.txt", filePathCompany = @"NameCompanyData.txt";
        string[] companyID;
        string revers = "";
        public Form1()
        {
            InitializeComponent();
            companyID = File.ReadAllLines(filePathCompany);
            foreach (string company in companyID) checkedListBox1.Items.Add(company);
            textBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            label1.Text = label2.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            revers = textBox1.Text;
            string[] contentSplit;
            int sum = 0;
            foreach (char letter in textBox1.Text)
            {
                if (!symbols.Contains(letter))
                {
                    MessageBox.Show("Podany znak nie jest obs�ugiwany ( " + letter + " )");
                    return;
                }
            }
            if (textBox1.Text.Contains("+"))
            {
                if (textBox1.Text.Contains("-"))
                {
                    MessageBox.Show("Mo�esz tylko dodawa� lub odejmowa� jednocze�nie, nie mo�esz miesza�.");
                    return;
                }
                contentSplit = textBox1.Text.Split('+');
                sum = int.Parse(contentSplit[0]);
                for (int i = 1; i < contentSplit.Count(); i++) sum += int.Parse(contentSplit[i]);
            }
            else if (textBox1.Text.Contains("-"))
            {
                if (textBox1.Text.Contains("+"))
                {
                    MessageBox.Show("Mo�esz tylko dodawa� lub odejmowa� jednocze�nie, nie mo�esz miesza�.");
                    return;
                }
                contentSplit = textBox1.Text.Split('-');
                sum = int.Parse(contentSplit[0]);
                for (int i = 1; i < contentSplit.Count(); i++) sum -= int.Parse(contentSplit[i]);
            }
            textBox1.Text = sum.ToString();
            MarginAndPercentage();
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(revers))
            {
                textBox1.Text = revers.ToString();
                label1.Text = label2.Text = revers = "";
                MessageBox.Show("Cofni�to dzia�nie popraw je albo wczytaj od nowa dane");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pubujesz wyczy�ci� dane czy jeste� pewien?", "Uwaga!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox1.Text = "0";
                MarginAndPercentage();
                save_Click(sender, e);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.SelectedIndex != -1)
            {
                List<string> dataLines = new();
                dataLines.Add( checkedListBox1.SelectedIndex.ToString() + "," + checkedListBox2.SelectedIndex.ToString() + "," + textBox1.Text );
                foreach (string row in datahiden) dataLines.Add(row);
                File.WriteAllLines(filePathData, dataLines.ToArray());
                Reset();
                LoadData();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            checkedListBox2.SelectedItem = null;
            textBox1.Enabled = false;
            textBox1.Text = "Wybierz frakcje oraz tydzie� aby zacz��.";
            label1.Text = "";
            label2.Text = "";
            for (int x = 0; x < count; x++) if (index != x) checkedListBox1.SetItemCheckState(x, CheckState.Unchecked);
            if (index == checkedListBox1.SelectedIndex) checkedListBox2.Enabled = true;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox2.SelectedIndex;
            int count = checkedListBox2.Items.Count;
            for (int x = 0; x < count; x++) if (index != x) checkedListBox2.SetItemCheckState(x, CheckState.Unchecked);
            textBox1.Enabled = true;
            LoadData();
        }

        void LoadData()
        {
            Reset();
            foreach (string dataLine in File.ReadAllLines(filePathData).ToList())
            {
                List<string> dataInRow = dataLine.Split(',').ToList();
                if (dataInRow[0] == checkedListBox1.SelectedIndex.ToString() && dataInRow[1] == checkedListBox2.SelectedIndex.ToString()) textBox1.Text = dataInRow[2];
                else datahiden.Add(string.Format("{0},{1},{2}", dataInRow[0], dataInRow[1], dataInRow[2]));
            }
            MarginAndPercentage();
        }

        void Reset()
        {
            textBox1.Text = "0";
            label1.Text = label2.Text = "";
            datahiden.Clear();
            dataSeen.Clear();
        }
        void MarginAndPercentage()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "Wybierz frakcje oraz tydzie� aby zacz��.")
            {
                double sum = double.Parse(textBox1.Text);
                double percent;
                sum *= 1.7;
                percent = sum * 0.3;
                label1.Text = sum.ToString();
                label2.Text = percent.ToString();
            }
            else textBox1.Text = "Error";
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.label1, label1.Text);
            toolTip1.SetToolTip(this.label2, label2.Text);
        }
    }
}