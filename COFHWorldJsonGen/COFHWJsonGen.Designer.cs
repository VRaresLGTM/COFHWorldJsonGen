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
            comboBoxDistribution = new ComboBox();
            panelGenerator = new Panel();
            panelProperties = new Panel();
            buttonAddProperty = new Button();
            checkBoxAdvancedBlockProperties = new CheckBox();
            numericClusterSize = new NumericUpDown();
            labelClusterSize = new Label();
            textBoxMaterial = new TextBox();
            textBoxBlockName = new TextBox();
            labelGenerator = new Label();
            textBoxEntryName = new TextBox();
            richTextBoxResult = new RichTextBox();
            buttonClear = new Button();
            panelDetails = new Panel();
            panelDimension = new Panel();
            labelDimension = new Label();
            richTextBoxDimensionEntries = new RichTextBox();
            label1 = new Label();
            checkBoxRestrictionDimension = new CheckBox();
            panelBiome = new Panel();
            labelValueEntries = new Label();
            richTextBoxBiomeEntries = new RichTextBox();
            comboBoxType = new ComboBox();
            labelBiome = new Label();
            checkBoxRestrictionBiome = new CheckBox();
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
            panelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericClusterSize).BeginInit();
            panelDetails.SuspendLayout();
            panelDimension.SuspendLayout();
            panelBiome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaxHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericClusterCount).BeginInit();
            SuspendLayout();
            // 
            // comboBoxDistribution
            // 
            comboBoxDistribution.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxDistribution.FormattingEnabled = true;
            comboBoxDistribution.Items.AddRange(new object[] { "uniform", "gaussian", "surface", "fractal", "underwater", "underfluid", "cave", "sequential", "custom" });
            comboBoxDistribution.Location = new Point(190, 7);
            comboBoxDistribution.Name = "comboBoxDistribution";
            comboBoxDistribution.Size = new Size(165, 23);
            comboBoxDistribution.TabIndex = 1;
            comboBoxDistribution.Text = "Select Distribution Type";
            // 
            // panelGenerator
            // 
            panelGenerator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGenerator.BorderStyle = BorderStyle.FixedSingle;
            panelGenerator.Controls.Add(panelProperties);
            panelGenerator.Controls.Add(checkBoxAdvancedBlockProperties);
            panelGenerator.Controls.Add(numericClusterSize);
            panelGenerator.Controls.Add(labelClusterSize);
            panelGenerator.Controls.Add(textBoxMaterial);
            panelGenerator.Controls.Add(textBoxBlockName);
            panelGenerator.Controls.Add(labelGenerator);
            panelGenerator.Location = new Point(9, 36);
            panelGenerator.Name = "panelGenerator";
            panelGenerator.Size = new Size(347, 114);
            panelGenerator.TabIndex = 2;
            // 
            // panelProperties
            // 
            panelProperties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelProperties.AutoScroll = true;
            panelProperties.Controls.Add(buttonAddProperty);
            panelProperties.Location = new Point(145, 46);
            panelProperties.Name = "panelProperties";
            panelProperties.Size = new Size(197, 63);
            panelProperties.TabIndex = 18;
            // 
            // buttonAddProperty
            // 
            buttonAddProperty.Enabled = false;
            buttonAddProperty.Location = new Point(8, 5);
            buttonAddProperty.Name = "buttonAddProperty";
            buttonAddProperty.Size = new Size(168, 23);
            buttonAddProperty.TabIndex = 6;
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
            checkBoxAdvancedBlockProperties.TabIndex = 5;
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
            numericClusterSize.TabIndex = 3;
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
            textBoxMaterial.TabIndex = 2;
            // 
            // textBoxBlockName
            // 
            textBoxBlockName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBlockName.Location = new Point(4, 50);
            textBoxBlockName.Name = "textBoxBlockName";
            textBoxBlockName.PlaceholderText = "Block Name";
            textBoxBlockName.Size = new Size(135, 23);
            textBoxBlockName.TabIndex = 4;
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
            // textBoxEntryName
            // 
            textBoxEntryName.Location = new Point(10, 7);
            textBoxEntryName.Name = "textBoxEntryName";
            textBoxEntryName.PlaceholderText = "Entry Name";
            textBoxEntryName.Size = new Size(176, 23);
            textBoxEntryName.TabIndex = 0;
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxResult.Location = new Point(9, 533);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.Size = new Size(347, 113);
            richTextBoxResult.TabIndex = 16;
            richTextBoxResult.Text = "";
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
            buttonClear.Click += buttonClear_Click;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(panelDimension);
            panelDetails.Controls.Add(panelBiome);
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
            // panelDimension
            // 
            panelDimension.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDimension.BorderStyle = BorderStyle.FixedSingle;
            panelDimension.Controls.Add(labelDimension);
            panelDimension.Controls.Add(richTextBoxDimensionEntries);
            panelDimension.Controls.Add(label1);
            panelDimension.Controls.Add(checkBoxRestrictionDimension);
            panelDimension.Location = new Point(173, 78);
            panelDimension.Name = "panelDimension";
            panelDimension.Size = new Size(168, 258);
            panelDimension.TabIndex = 16;
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
            // checkBoxRestrictionDimension
            // 
            checkBoxRestrictionDimension.AutoSize = true;
            checkBoxRestrictionDimension.Location = new Point(2, 24);
            checkBoxRestrictionDimension.Name = "checkBoxRestrictionDimension";
            checkBoxRestrictionDimension.RightToLeft = RightToLeft.Yes;
            checkBoxRestrictionDimension.Size = new Size(72, 19);
            checkBoxRestrictionDimension.TabIndex = 13;
            checkBoxRestrictionDimension.Text = "Whitelist";
            checkBoxRestrictionDimension.UseVisualStyleBackColor = true;
            // 
            // panelBiome
            // 
            panelBiome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBiome.BorderStyle = BorderStyle.FixedSingle;
            panelBiome.Controls.Add(labelValueEntries);
            panelBiome.Controls.Add(richTextBoxBiomeEntries);
            panelBiome.Controls.Add(comboBoxType);
            panelBiome.Controls.Add(labelBiome);
            panelBiome.Controls.Add(checkBoxRestrictionBiome);
            panelBiome.Location = new Point(4, 78);
            panelBiome.Name = "panelBiome";
            panelBiome.Size = new Size(159, 258);
            panelBiome.TabIndex = 9;
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
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "dictionary", "temperature", "name", "id" });
            comboBoxType.Location = new Point(6, 26);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.RightToLeft = RightToLeft.No;
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 9;
            comboBoxType.Text = "Choose Type";
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
            // checkBoxRestrictionBiome
            // 
            checkBoxRestrictionBiome.AutoSize = true;
            checkBoxRestrictionBiome.Checked = true;
            checkBoxRestrictionBiome.CheckState = CheckState.Checked;
            checkBoxRestrictionBiome.Location = new Point(5, 55);
            checkBoxRestrictionBiome.Name = "checkBoxRestrictionBiome";
            checkBoxRestrictionBiome.RightToLeft = RightToLeft.Yes;
            checkBoxRestrictionBiome.Size = new Size(72, 19);
            checkBoxRestrictionBiome.TabIndex = 10;
            checkBoxRestrictionBiome.Text = "Whitelist";
            checkBoxRestrictionBiome.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetrogen
            // 
            checkBoxRetrogen.AutoSize = true;
            checkBoxRetrogen.Location = new Point(2, 53);
            checkBoxRetrogen.Name = "checkBoxRetrogen";
            checkBoxRetrogen.RightToLeft = RightToLeft.Yes;
            checkBoxRetrogen.Size = new Size(74, 19);
            checkBoxRetrogen.TabIndex = 6;
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
            numericMaxHeight.TabIndex = 8;
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
            numericMinHeight.TabIndex = 7;
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
            Controls.Add(textBoxEntryName);
            Controls.Add(panelDetails);
            Controls.Add(comboBoxDistribution);
            Controls.Add(richTextBoxResult);
            Controls.Add(panelGenerator);
            Controls.Add(buttonGenerate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(380, 697);
            Name = "COFHWJsonGen";
            Text = "COFH World Json Entry Generator";
            Load += Form1_Load;
            panelGenerator.ResumeLayout(false);
            panelGenerator.PerformLayout();
            panelProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericClusterSize).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panelDimension.ResumeLayout(false);
            panelDimension.PerformLayout();
            panelBiome.ResumeLayout(false);
            panelBiome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMaxHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericClusterCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDistribution;
        private Panel panelGenerator;
        private Label labelGenerator;
        private TextBox textBoxMaterial;
        private TextBox textBoxBlockName;
        private NumericUpDown numericClusterSize;
        private Label labelClusterSize;
        private TextBox textBoxEntryName;
        private RichTextBox richTextBoxResult;
        private CheckBox checkBoxAdvancedBlockProperties;
        private Button buttonAddProperty;
        private Panel panelProperties;
        private Button buttonClear;
        private Panel panelDetails;
        private Panel panelDimension;
        private Label labelDimension;
        private RichTextBox richTextBoxDimensionEntries;
        private Label label1;
        private CheckBox checkBoxRestrictionDimension;
        private Panel panelBiome;
        private Label labelValueEntries;
        private RichTextBox richTextBoxBiomeEntries;
        private ComboBox comboBoxType;
        private Label labelBiome;
        private CheckBox checkBoxRestrictionBiome;
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
