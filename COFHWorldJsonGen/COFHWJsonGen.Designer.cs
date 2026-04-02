namespace COFHWorldJsonGen
{
    partial class COFHWJsonGen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COFHWJsonGen));
            comboBox1 = new ComboBox();
            panelGenerator = new Panel();
            flowLayoutPanelProperties = new Panel();
            buttonAddProperty = new Button();
            checkBoxAdvancedBlockProperties = new CheckBox();
            numericClusterSize = new NumericUpDown();
            labelClusterSize = new Label();
            textBoxMaterial = new TextBox();
            textBoxBlock = new TextBox();
            labelGenerator = new Label();
            textBox3 = new TextBox();
            richTextBox3 = new RichTextBox();
            buttonClear = new Button();
            panelDetails = new Panel();
            panel2 = new Panel();
            labelDimension = new Label();
            richTextBoxDimensionEntries = new RichTextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            labelValueEntries = new Label();
            richTextBoxBiomeEntries = new RichTextBox();
            comboBox2 = new ComboBox();
            labelBiome = new Label();
            checkBoxRestriction = new CheckBox();
            checkBoxRetrogen = new CheckBox();
            numericMaxHeight = new NumericUpDown();
            label3 = new Label();
            numericMinHeight = new NumericUpDown();
            labelMinHeight = new Label();
            numericClusterCount = new NumericUpDown();
            labelClusterCount = new Label();
            labelDetails = new Label();
            buttonGenerate = new Button();
            panelGenerator.SuspendLayout();
            flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericClusterSize).BeginInit();
            panelDetails.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaxHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericClusterCount).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "uniform", "gaussian", "surface", "fractal", "underwater", "underfluid", "cave", "sequential", "custom" });
            comboBox1.Location = new Point(190, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select Distribution Type";
            // 
            // panelGenerator
            // 
            panelGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGenerator.BorderStyle = BorderStyle.FixedSingle;
            panelGenerator.Controls.Add(flowLayoutPanelProperties);
            panelGenerator.Controls.Add(checkBoxAdvancedBlockProperties);
            panelGenerator.Controls.Add(numericClusterSize);
            panelGenerator.Controls.Add(labelClusterSize);
            panelGenerator.Controls.Add(textBoxMaterial);
            panelGenerator.Controls.Add(textBoxBlock);
            panelGenerator.Controls.Add(labelGenerator);
            panelGenerator.Location = new Point(9, 36);
            panelGenerator.Name = "panelGenerator";
            panelGenerator.Size = new Size(347, 114);
            panelGenerator.TabIndex = 2;
            // 
            // flowLayoutPanelProperties
            // 
            flowLayoutPanelProperties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanelProperties.AutoScroll = true;
            flowLayoutPanelProperties.Controls.Add(buttonAddProperty);
            flowLayoutPanelProperties.Location = new Point(145, 46);
            flowLayoutPanelProperties.Name = "flowLayoutPanelProperties";
            flowLayoutPanelProperties.Size = new Size(197, 63);
            flowLayoutPanelProperties.TabIndex = 18;
            // 
            // buttonAddProperty
            // 
            buttonAddProperty.Enabled = false;
            buttonAddProperty.Location = new Point(8, 5);
            buttonAddProperty.Name = "buttonAddProperty";
            buttonAddProperty.Size = new Size(168, 23);
            buttonAddProperty.TabIndex = 0;
            buttonAddProperty.Text = "Add Property";
            buttonAddProperty.UseVisualStyleBackColor = true;
            buttonAddProperty.Click += buttonAddProperty_Click;
            // 
            // checkBoxAdvancedBlockProperties
            // 
            checkBoxAdvancedBlockProperties.AutoSize = true;
            checkBoxAdvancedBlockProperties.Location = new Point(4, 81);
            checkBoxAdvancedBlockProperties.Name = "checkBoxAdvancedBlockProperties";
            checkBoxAdvancedBlockProperties.RightToLeft = RightToLeft.Yes;
            checkBoxAdvancedBlockProperties.Size = new Size(135, 19);
            checkBoxAdvancedBlockProperties.TabIndex = 17;
            checkBoxAdvancedBlockProperties.Text = "Advanced Properties";
            checkBoxAdvancedBlockProperties.UseVisualStyleBackColor = true;
            checkBoxAdvancedBlockProperties.CheckedChanged += checkBoxAdvancedBlockProperties_CheckedChanged;
            // 
            // numericClusterSize
            // 
            numericClusterSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericClusterSize.Location = new Point(263, 17);
            numericClusterSize.Name = "numericClusterSize";
            numericClusterSize.Size = new Size(69, 23);
            numericClusterSize.TabIndex = 4;
            // 
            // labelClusterSize
            // 
            labelClusterSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelClusterSize.AutoSize = true;
            labelClusterSize.Location = new Point(187, 20);
            labelClusterSize.Name = "labelClusterSize";
            labelClusterSize.Size = new Size(72, 15);
            labelClusterSize.TabIndex = 5;
            labelClusterSize.Text = "Cluster-Size:";
            // 
            // textBoxMaterial
            // 
            textBoxMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMaterial.Location = new Point(4, 17);
            textBoxMaterial.Name = "textBoxMaterial";
            textBoxMaterial.PlaceholderText = "Material";
            textBoxMaterial.Size = new Size(177, 23);
            textBoxMaterial.TabIndex = 3;
            // 
            // textBoxBlock
            // 
            textBoxBlock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBlock.Location = new Point(4, 50);
            textBoxBlock.Name = "textBoxBlock";
            textBoxBlock.PlaceholderText = "Block Name";
            textBoxBlock.Size = new Size(135, 23);
            textBoxBlock.TabIndex = 2;
            // 
            // labelGenerator
            // 
            labelGenerator.AutoSize = true;
            labelGenerator.Location = new Point(0, 0);
            labelGenerator.Name = "labelGenerator";
            labelGenerator.Size = new Size(62, 15);
            labelGenerator.TabIndex = 2;
            labelGenerator.Text = "Generator:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 7);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Entry Name";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 0;
            // 
            // richTextBox3
            // 
            richTextBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox3.Location = new Point(9, 533);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(347, 113);
            richTextBox3.TabIndex = 16;
            richTextBox3.Text = "";
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(182, 505);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(173, 23);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear Boxes";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(panel2);
            panelDetails.Controls.Add(panel1);
            panelDetails.Controls.Add(checkBoxRetrogen);
            panelDetails.Controls.Add(numericMaxHeight);
            panelDetails.Controls.Add(label3);
            panelDetails.Controls.Add(numericMinHeight);
            panelDetails.Controls.Add(labelMinHeight);
            panelDetails.Controls.Add(numericClusterCount);
            panelDetails.Controls.Add(labelClusterCount);
            panelDetails.Controls.Add(labelDetails);
            panelDetails.Location = new Point(9, 156);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(346, 343);
            panelDetails.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelDimension);
            panel2.Controls.Add(richTextBoxDimensionEntries);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(173, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 258);
            panel2.TabIndex = 16;
            // 
            // labelDimension
            // 
            labelDimension.AutoSize = true;
            labelDimension.Location = new Point(-1, 1);
            labelDimension.Name = "labelDimension";
            labelDimension.Size = new Size(67, 15);
            labelDimension.TabIndex = 16;
            labelDimension.Text = "Dimension:";
            // 
            // richTextBoxDimensionEntries
            // 
            richTextBoxDimensionEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxDimensionEntries.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxDimensionEntries.Location = new Point(3, 42);
            richTextBoxDimensionEntries.Name = "richTextBoxDimensionEntries";
            richTextBoxDimensionEntries.Size = new Size(161, 211);
            richTextBoxDimensionEntries.TabIndex = 14;
            richTextBoxDimensionEntries.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 15;
            label1.Text = "Value Entries:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(2, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(72, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Whitelist";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelValueEntries);
            panel1.Controls.Add(richTextBoxBiomeEntries);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(labelBiome);
            panel1.Controls.Add(checkBoxRestriction);
            panel1.Location = new Point(4, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 258);
            panel1.TabIndex = 9;
            // 
            // labelValueEntries
            // 
            labelValueEntries.AutoSize = true;
            labelValueEntries.Location = new Point(6, 74);
            labelValueEntries.Name = "labelValueEntries";
            labelValueEntries.Size = new Size(76, 15);
            labelValueEntries.TabIndex = 12;
            labelValueEntries.Text = "Value Entries:";
            // 
            // richTextBoxBiomeEntries
            // 
            richTextBoxBiomeEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxBiomeEntries.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxBiomeEntries.Location = new Point(6, 92);
            richTextBoxBiomeEntries.Name = "richTextBoxBiomeEntries";
            richTextBoxBiomeEntries.Size = new Size(148, 161);
            richTextBoxBiomeEntries.TabIndex = 11;
            richTextBoxBiomeEntries.Text = "";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "dictionary", "temperature", "name", "id" });
            comboBox2.Location = new Point(6, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "Choose Type";
            // 
            // labelBiome
            // 
            labelBiome.AutoSize = true;
            labelBiome.Location = new Point(-1, 1);
            labelBiome.Name = "labelBiome";
            labelBiome.Size = new Size(44, 15);
            labelBiome.TabIndex = 1;
            labelBiome.Text = "Biome:";
            // 
            // checkBoxRestriction
            // 
            checkBoxRestriction.AutoSize = true;
            checkBoxRestriction.Checked = true;
            checkBoxRestriction.CheckState = CheckState.Checked;
            checkBoxRestriction.Location = new Point(5, 55);
            checkBoxRestriction.Name = "checkBoxRestriction";
            checkBoxRestriction.RightToLeft = RightToLeft.Yes;
            checkBoxRestriction.Size = new Size(72, 19);
            checkBoxRestriction.TabIndex = 10;
            checkBoxRestriction.Text = "Whitelist";
            checkBoxRestriction.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetrogen
            // 
            checkBoxRetrogen.AutoSize = true;
            checkBoxRetrogen.Location = new Point(2, 53);
            checkBoxRetrogen.Name = "checkBoxRetrogen";
            checkBoxRetrogen.RightToLeft = RightToLeft.Yes;
            checkBoxRetrogen.Size = new Size(74, 19);
            checkBoxRetrogen.TabIndex = 8;
            checkBoxRetrogen.Text = "Retrogen";
            checkBoxRetrogen.UseVisualStyleBackColor = true;
            // 
            // numericMaxHeight
            // 
            numericMaxHeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericMaxHeight.Location = new Point(283, 50);
            numericMaxHeight.MaximumSize = new Size(54, 0);
            numericMaxHeight.Name = "numericMaxHeight";
            numericMaxHeight.Size = new Size(54, 23);
            numericMaxHeight.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(172, 54);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 11;
            label3.Text = "Maximum Height:";
            // 
            // numericMinHeight
            // 
            numericMinHeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericMinHeight.Location = new Point(283, 19);
            numericMinHeight.MaximumSize = new Size(54, 0);
            numericMinHeight.Name = "numericMinHeight";
            numericMinHeight.Size = new Size(54, 23);
            numericMinHeight.TabIndex = 6;
            // 
            // labelMinHeight
            // 
            labelMinHeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelMinHeight.AutoSize = true;
            labelMinHeight.Location = new Point(172, 22);
            labelMinHeight.Name = "labelMinHeight";
            labelMinHeight.Size = new Size(102, 15);
            labelMinHeight.TabIndex = 9;
            labelMinHeight.Text = "Minimum Height:";
            // 
            // numericClusterCount
            // 
            numericClusterCount.Location = new Point(94, 19);
            numericClusterCount.MaximumSize = new Size(54, 0);
            numericClusterCount.Name = "numericClusterCount";
            numericClusterCount.Size = new Size(54, 23);
            numericClusterCount.TabIndex = 5;
            // 
            // labelClusterCount
            // 
            labelClusterCount.AutoSize = true;
            labelClusterCount.Location = new Point(3, 22);
            labelClusterCount.Name = "labelClusterCount";
            labelClusterCount.Size = new Size(85, 15);
            labelClusterCount.TabIndex = 7;
            labelClusterCount.Text = "Cluster-Count:";
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Location = new Point(-1, 0);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(45, 15);
            labelDetails.TabIndex = 6;
            labelDetails.Text = "Details:";
            // 
            // buttonGenerate
            // 
            buttonGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGenerate.Location = new Point(8, 505);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(165, 23);
            buttonGenerate.TabIndex = 15;
            buttonGenerate.Text = "Generate JSON Block";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // COFHWJsonGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 658);
            Controls.Add(buttonClear);
            Controls.Add(textBox3);
            Controls.Add(panelDetails);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox3);
            Controls.Add(panelGenerator);
            Controls.Add(buttonGenerate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(380, 697);
            Name = "COFHWJsonGen";
            Text = "COFH World Json Entry Generator";
            Load += Form1_Load;
            panelGenerator.ResumeLayout(false);
            panelGenerator.PerformLayout();
            flowLayoutPanelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericClusterSize).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaxHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericClusterCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Panel panelGenerator;
        private Label labelGenerator;
        private TextBox textBoxMaterial;
        private TextBox textBoxBlock;
        private NumericUpDown numericClusterSize;
        private Label labelClusterSize;
        private TextBox textBox3;
        private RichTextBox richTextBox3;
        private CheckBox checkBoxAdvancedBlockProperties;
        private Button buttonAddProperty;
        private Panel flowLayoutPanelProperties;
        private Button buttonClear;
        private Panel panelDetails;
        private Panel panel2;
        private Label labelDimension;
        private RichTextBox richTextBoxDimensionEntries;
        private Label label1;
        private CheckBox checkBox1;
        private Panel panel1;
        private Label labelValueEntries;
        private RichTextBox richTextBoxBiomeEntries;
        private ComboBox comboBox2;
        private Label labelBiome;
        private CheckBox checkBoxRestriction;
        private CheckBox checkBoxRetrogen;
        private NumericUpDown numericMaxHeight;
        private Label label3;
        private NumericUpDown numericMinHeight;
        private Label labelMinHeight;
        private NumericUpDown numericClusterCount;
        private Label labelClusterCount;
        private Label labelDetails;
        private Button buttonGenerate;
    }
}
