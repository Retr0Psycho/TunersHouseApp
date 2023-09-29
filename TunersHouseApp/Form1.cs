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
            int weekID = checkedListBox2.SelectedIndex;
            companyID = File.ReadAllLines(filePathCompany);
            foreach (string company in companyID) checkedListBox1.Items.Add(company);
            textBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            label1.Text = "";
            label2.Text = "";
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
                    MessageBox.Show("Podany znak nie jest obs³ugiwany ( " + letter + " )");
                    return;
                }
            }
            if (textBox1.Text.Contains("+"))
            {
                if (textBox1.Text.Contains("-"))
                {
                    MessageBox.Show("Mo¿esz tylko dodawaæ lub odejmowaæ jednoczeœnie, nie mo¿esz mieszaæ.");
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
                    MessageBox.Show("Mo¿esz tylko dodawaæ lub odejmowaæ jednoczeœnie, nie mo¿esz mieszaæ.");
                    return;
                }
                contentSplit = textBox1.Text.Split('-');
                sum = int.Parse(contentSplit[0]);
                for (int i = 1; i < contentSplit.Count(); i++) sum -= int.Parse(contentSplit[i]);
            }
            textBox1.Text = sum.ToString();
            marginAndPercentage();
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(revers))
            {
                textBox1.Text = revers.ToString();
                label1.Text = "";
                label2.Text = "";
                MessageBox.Show("Cofniêto dzia³nie popraw je albo wczytaj od nowa dane");
                revers = "";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Pubujesz wyczyœciæ dane czy jesteœ pewien?", "Uwaga!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBox1.Text = "0";
                marginAndPercentage();
                save_Click(sender, e);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.SelectedIndex != null)
            {
                List<string> dataLines = new();
                string compliteRow;
                compliteRow = checkedListBox1.SelectedIndex.ToString() + "," + checkedListBox2.SelectedIndex.ToString() + "," + textBox1.Text;
                dataLines.Add(compliteRow);
                foreach (string row in datahiden) dataLines.Add(row);
                File.WriteAllLines(filePathData, dataLines.ToArray());
                Reset();
                load();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            checkedListBox2.SelectedItem = null;
            textBox1.Enabled = false;
            textBox1.Text = "Wybierz frakcje oraz tydzieñ aby zacz¹æ.";
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
            load();
        }

        void load()
        {
            Reset();
            List<string> dataLines = File.ReadAllLines(filePathData).ToList();
            foreach (string dataLine in dataLines)
            {
                List<string> dataInRow = dataLine.Split(',').ToList();
                string companyIndex = dataInRow[0], weekIndex = dataInRow[1], values = dataInRow[2];
                if (companyIndex == checkedListBox1.SelectedIndex.ToString() && weekIndex == checkedListBox2.SelectedIndex.ToString()) textBox1.Text = values;
                else datahiden.Add(string.Format("{0},{1},{2}", dataInRow[0], dataInRow[1], dataInRow[2]));
            }
            marginAndPercentage();
        }

        void Reset()
        {
            textBox1.Text = "0";
            label1.Text = "";
            label2.Text = "";
            datahiden.Clear();
            dataSeen.Clear();
        }
        void marginAndPercentage()
        {
            if (textBox1 != null && textBox1.Text != "Wybierz frakcje oraz tydzieñ aby zacz¹æ.")
            {
                double i = double.Parse(textBox1.Text);
                double o;
                i += i * 1.7;
                o = i * 0.3;
                label1.Text = i.ToString();
                label2.Text = o.ToString();
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