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
            this.label8 = new System.Windows.Forms.Label();
            this.EditWhat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ConfirmAddType = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ConfirmAdd = new System.Windows.Forms.Button();
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
            this.EditComboBox.SelectedIndexChanged += new System.EventHandler(this.EditComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1101, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edit";
            // 
            // EditTextbox
            // 
            this.EditTextbox.Location = new System.Drawing.Point(1212, 70);
            this.EditTextbox.Name = "EditTextbox";
            this.EditTextbox.Size = new System.Drawing.Size(146, 23);
            this.EditTextbox.TabIndex = 18;
            this.EditTextbox.TextChanged += new System.EventHandler(this.EditTextbox_TextChanged);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(1292, 188);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 19;
            this.EditButton.Text = "Confirm";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1251, 44);
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
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1063, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Add UOM/QT";
            // 
            // EditWhat
            // 
            this.EditWhat.FormattingEnabled = true;
            this.EditWhat.Items.AddRange(new object[] {
            "UOM",
            "QuantityType"});
            this.EditWhat.Location = new System.Drawing.Point(1069, 70);
            this.EditWhat.Name = "EditWhat";
            this.EditWhat.Size = new System.Drawing.Size(121, 23);
            this.EditWhat.TabIndex = 25;
            this.EditWhat.SelectedIndexChanged += new System.EventHandler(this.EditWhat_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1364, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1087, 343);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1087, 372);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 28;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1087, 401);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1087, 459);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 30;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1087, 430);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 31;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1087, 488);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1081, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 33;
            // 
            // ConfirmAddType
            // 
            this.ConfirmAddType.Location = new System.Drawing.Point(1212, 279);
            this.ConfirmAddType.Name = "ConfirmAddType";
            this.ConfirmAddType.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAddType.TabIndex = 34;
            this.ConfirmAddType.Text = "OK";
            this.ConfirmAddType.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1034, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1013, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1002, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Annotation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(989, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Quantity Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(966, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "Dimensional Class";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1011, 491);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 40;
            this.label14.Text = "Base Unit";
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Location = new System.Drawing.Point(1087, 528);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(100, 23);
            this.ConfirmAdd.TabIndex = 41;
            this.ConfirmAdd.Text = "Confirm";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 646);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConfirmAddType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditWhat);
            this.Controls.Add(this.label8);
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
            this.Text = "POSC CONVERTER";
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
        private Label label8;
        private ComboBox EditWhat;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private Button ConfirmAddType;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button ConfirmAdd;
    }
}