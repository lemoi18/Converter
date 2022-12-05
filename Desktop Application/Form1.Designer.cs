namespace Desktop_Application
{
    partial class Form1
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
            this.UnitFrom = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.UnitTo = new System.Windows.Forms.TextBox();
            this.ConverterButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.UnitFromLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputConsole = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfimList = new System.Windows.Forms.Button();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditTextbox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnitFrom
            // 
            this.UnitFrom.Location = new System.Drawing.Point(39, 62);
            this.UnitFrom.Name = "UnitFrom";
            this.UnitFrom.Size = new System.Drawing.Size(112, 23);
            this.UnitFrom.TabIndex = 0;
            this.UnitFrom.TextChanged += new System.EventHandler(this.UnitFrom_TextChanged);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(199, 126);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(136, 23);
            this.Value.TabIndex = 1;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // UnitTo
            // 
            this.UnitTo.Location = new System.Drawing.Point(199, 62);
            this.UnitTo.Name = "UnitTo";
            this.UnitTo.Size = new System.Drawing.Size(136, 23);
            this.UnitTo.TabIndex = 2;
            this.UnitTo.TextChanged += new System.EventHandler(this.UnitTo_TextChanged);
            // 
            // ConverterButton
            // 
            this.ConverterButton.Location = new System.Drawing.Point(76, 126);
            this.ConverterButton.Name = "ConverterButton";
            this.ConverterButton.Size = new System.Drawing.Size(75, 23);
            this.ConverterButton.TabIndex = 3;
            this.ConverterButton.Text = "Convert";
            this.ConverterButton.UseVisualStyleBackColor = true;
            this.ConverterButton.Click += new System.EventHandler(this.ConverterButton_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(210, 108);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 15);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Value";
            // 
            // UnitFromLabel
            // 
            this.UnitFromLabel.AutoSize = true;
            this.UnitFromLabel.Location = new System.Drawing.Point(94, 44);
            this.UnitFromLabel.Name = "UnitFromLabel";
            this.UnitFromLabel.Size = new System.Drawing.Size(35, 15);
            this.UnitFromLabel.TabIndex = 5;
            this.UnitFromLabel.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // OutputConsole
            // 
            this.OutputConsole.FormattingEnabled = true;
            this.OutputConsole.ItemHeight = 15;
            this.OutputConsole.Location = new System.Drawing.Point(39, 169);
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.Size = new System.Drawing.Size(296, 319);
            this.OutputConsole.TabIndex = 8;
            this.OutputConsole.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "unit dimensions",
            "quantity classes",
            "uom for a given quantity class",
            "aliases for a given uom "});
            this.comboBox.Location = new System.Drawing.Point(428, 62);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(243, 23);
            this.comboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "What to List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfimList
            // 
            this.ConfimList.Location = new System.Drawing.Point(696, 62);
            this.ConfimList.Name = "ConfimList";
            this.ConfimList.Size = new System.Drawing.Size(75, 23);
            this.ConfimList.TabIndex = 11;
            this.ConfimList.Text = "Confirm";
            this.ConfimList.UseVisualStyleBackColor = true;
            this.ConfimList.Click += new System.EventHandler(this.ConfimList_Click);
            // 
            // OutputList
            // 
            this.OutputList.FormattingEnabled = true;
            this.OutputList.ItemHeight = 15;
            this.OutputList.Location = new System.Drawing.Point(428, 169);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(243, 319);
            this.OutputList.TabIndex = 12;
            this.OutputList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Specify ";
            // 
            // EditComboBox
            // 
            this.EditComboBox.FormattingEnabled = true;
            this.EditComboBox.Location = new System.Drawing.Point(1054, 139);
            this.EditComboBox.Name = "EditComboBox";
            this.EditComboBox.Size = new System.Drawing.Size(201, 23);
            this.EditComboBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1101, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edit";
            // 
            // EditTextbox
            // 
            this.EditTextbox.Location = new System.Drawing.Point(867, 139);
            this.EditTextbox.Name = "EditTextbox";
            this.EditTextbox.Size = new System.Drawing.Size(146, 23);
            this.EditTextbox.TabIndex = 18;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1292, 138);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Confirm";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Unit to Edit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1101, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Attribute to edit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1054, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 23);
            this.textBox2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1125, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Edit value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.EditTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.ConfimList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.OutputConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitFromLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ConverterButton);
            this.Controls.Add(this.UnitTo);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.UnitFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UnitFrom;
        private TextBox Value;
        private TextBox UnitTo;
        private Button ConverterButton;
        private Label ValueLabel;
        private Label UnitFromLabel;
        private Label label3;
        private ListBox OutputConsole;
        private ComboBox comboBox;
        private Label label1;
        private Button ConfimList;
        private ListBox OutputList;
        private TextBox textBox1;
        private Label label2;
        private ComboBox EditComboBox;
        private Label label4;
        private TextBox EditTextbox;
        private Button EditButton;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
    }
}