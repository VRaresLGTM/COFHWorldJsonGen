namespace COFHWorldJsonGen
{
    partial class PropertyCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPropertyName = new TextBox();
            textBoxPropertyValue = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxPropertyName
            // 
            textBoxPropertyName.Location = new Point(12, 12);
            textBoxPropertyName.Name = "textBoxPropertyName";
            textBoxPropertyName.PlaceholderText = "PropertyName";
            textBoxPropertyName.Size = new Size(216, 23);
            textBoxPropertyName.TabIndex = 0;
            // 
            // textBoxPropertyValue
            // 
            textBoxPropertyValue.Location = new Point(12, 41);
            textBoxPropertyValue.Name = "textBoxPropertyValue";
            textBoxPropertyValue.PlaceholderText = "PropertyValue";
            textBoxPropertyValue.Size = new Size(216, 23);
            textBoxPropertyValue.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 70);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(123, 70);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PropertyCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 99);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxPropertyValue);
            Controls.Add(textBoxPropertyName);
            Name = "PropertyCreator";
            Text = "PropertyCreator";
            FormClosing += PropertyCreator_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPropertyName;
        private TextBox textBoxPropertyValue;
        private Button buttonSave;
        private Button buttonCancel;
    }
}