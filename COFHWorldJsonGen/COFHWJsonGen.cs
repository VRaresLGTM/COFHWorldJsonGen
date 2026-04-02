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
                Location = new Point(buttonAddProperty.Location.X+1, buttonAddProperty.Location.Y + (propertyFields.Count + 1) * (buttonAddProperty.Height + 3)),
                Size = buttonAddProperty.Size - new Size(2,0),
                Visible = true,
            };

            flowLayoutPanelProperties.Controls.Add(tb);
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
    }
}
