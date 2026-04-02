using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COFHWorldJsonGen
{
    public partial class PropertyCreator : Form
    {
        CurrentProperty currentProperty = CurrentProperty.GetInstance();
        public PropertyCreator()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            currentProperty.setNameValue($"{textBoxPropertyName.Text}:{textBoxPropertyValue.Text}");
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PropertyCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
