namespace COFHWorldJsonGen
{
    public partial class COFHWJsonGen : Form
    {
        List<TextBox> propertyFields = new List<TextBox>();
        CurrentProperty currentProperty = CurrentProperty.GetInstance();
        public COFHWJsonGen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            PropertyCreator creator = new PropertyCreator();
            creator.ShowDialog();

            string? nameValue = currentProperty.getNameValue();

            if (string.IsNullOrEmpty(nameValue))
                return;

            string[] result = nameValue.Split(new[] { ':' }, 2);
            if (result.Length < 2 || string.IsNullOrEmpty(result[0]) || string.IsNullOrEmpty(result[1]))
                return;

            Console.WriteLine($"Property Name: {result[0]}, Property Value: {result[1]}");
            string controlName = "textBox" + result[0];

            var tb = new TextBox
            {
                Name = controlName,
                Text = result[1],
                PlaceholderText = result[0],
                Location = new Point(buttonAddProperty.Location.X + 1, buttonAddProperty.Location.Y + (propertyFields.Count + 1) * (buttonAddProperty.Height + 3)),
                Size = buttonAddProperty.Size - new Size(2, 0),
                Visible = true,
            };

            panelProperties.Controls.Add(tb);
            propertyFields.Add(tb);
        }

        private void checkBoxAdvancedBlockProperties_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdvancedBlockProperties.Checked)
            {
                buttonAddProperty.Enabled = true;
            }
            else
            {
                buttonAddProperty.Enabled = false;
            }
        }

        private void panelEncompass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxBiomeEntries.Clear();
            richTextBoxDimensionEntries.Clear();
            richTextBoxResult.Clear();
            textBoxBlockName.Clear();
            textBoxEntryName.Clear();
            textBoxMaterial.Clear();
            numericClusterCount.Value = 0;
            numericClusterSize.Value = 0;
            numericMaxHeight.Value = 0;
            numericMinHeight.Value = 0;
            checkBoxAdvancedBlockProperties.Checked = false;
            checkBoxRestrictionBiome.Checked = true;
            checkBoxRestrictionDimension.Checked = false;
            comboBoxDistribution.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            var toRemove = panelProperties.Controls.OfType<TextBox>().ToArray();
            foreach (var textBox in toRemove)
            {
                panelProperties.Controls.Remove(textBox);
                textBox.Dispose();
            }
            propertyFields.Clear();
        }
    }
}
