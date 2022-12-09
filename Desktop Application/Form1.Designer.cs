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
            this.UnitFromText = new System.Windows.Forms.TextBox();
            this.ValueText = new System.Windows.Forms.TextBox();
            this.UnitToText = new System.Windows.Forms.TextBox();
            this.ConverterButton = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.UnitFromLabel = new System.Windows.Forms.Label();
            this.ConvertToLabel = new System.Windows.Forms.Label();
            this.OutputConsole = new System.Windows.Forms.ListBox();
            this.comboBoxList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfimListButton = new System.Windows.Forms.Button();
            this.OutputList = new System.Windows.Forms.ListBox();
            this.ListSpecifyText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.UnitToEditLabel = new System.Windows.Forms.Label();
            this.AttributeToEditLabel = new System.Windows.Forms.Label();
            this.EditValueText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.UnitToEditButton = new System.Windows.Forms.Button();
            this.CreateUOMID = new System.Windows.Forms.TextBox();
            this.CreateUOMName = new System.Windows.Forms.TextBox();
            this.CreateUOMAnnotation = new System.Windows.Forms.TextBox();
            this.CreateUOMDimensional = new System.Windows.Forms.TextBox();
            this.CreateUOMBaseUnit = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AnnotationLabel = new System.Windows.Forms.Label();
            this.QuantityTypeInCreateLabel = new System.Windows.Forms.Label();
            this.DimClassCreateLabel = new System.Windows.Forms.Label();
            this.BaseUnitLAbel = new System.Windows.Forms.Label();
            this.CreateUOMConfirm = new System.Windows.Forms.Button();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.QuantityTypeLabel = new System.Windows.Forms.Label();
            this.EditQTButton = new System.Windows.Forms.Button();
            this.EditQTName = new System.Windows.Forms.TextBox();
            this.QTNewName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CreateUOMA = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.CreateUOMB = new System.Windows.Forms.TextBox();
            this.CreateUOMC = new System.Windows.Forms.TextBox();
            this.CreateUOMD = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CreateUOMCheckbox = new System.Windows.Forms.CheckBox();
            this.AliasLabel = new System.Windows.Forms.Label();
            this.CreateUOMQT = new System.Windows.Forms.TextBox();
            this.CreateUOMAlias = new System.Windows.Forms.TextBox();
            this.AddQTName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.AddRemoveQTValue = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ConfirmAdd = new System.Windows.Forms.Button();
            this.ConfirmRemove = new System.Windows.Forms.Button();
            this.CreateUOM = new System.Windows.Forms.TextBox();
            this.EditQuantityTypeLabel = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.DeleteUnitBox = new System.Windows.Forms.TextBox();
            this.DeleteUnitButton = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.UOMlabel = new System.Windows.Forms.Label();
            this.EditTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UnitFromText
            // 
            this.UnitFromText.Location = new System.Drawing.Point(39, 62);
            this.UnitFromText.Name = "UnitFromText";
            this.UnitFromText.Size = new System.Drawing.Size(112, 23);
            this.UnitFromText.TabIndex = 0;
            // 
            // ValueText
            // 
            this.ValueText.Location = new System.Drawing.Point(109, 126);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(136, 23);
            this.ValueText.TabIndex = 1;
            // 
            // UnitToText
            // 
            this.UnitToText.Location = new System.Drawing.Point(199, 62);
            this.UnitToText.Name = "UnitToText";
            this.UnitToText.Size = new System.Drawing.Size(136, 23);
            this.UnitToText.TabIndex = 2;
            // 
            // ConverterButton
            // 
            this.ConverterButton.Location = new System.Drawing.Point(260, 125);
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
            this.ValueLabel.Location = new System.Drawing.Point(54, 129);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 15);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Value";
            // 
            // UnitFromLabel
            // 
            this.UnitFromLabel.AutoSize = true;
            this.UnitFromLabel.Location = new System.Drawing.Point(39, 44);
            this.UnitFromLabel.Name = "UnitFromLabel";
            this.UnitFromLabel.Size = new System.Drawing.Size(80, 15);
            this.UnitFromLabel.TabIndex = 5;
            this.UnitFromLabel.Text = "Convert From";
            // 
            // ConvertToLabel
            // 
            this.ConvertToLabel.AutoSize = true;
            this.ConvertToLabel.Location = new System.Drawing.Point(226, 44);
            this.ConvertToLabel.Name = "ConvertToLabel";
            this.ConvertToLabel.Size = new System.Drawing.Size(64, 15);
            this.ConvertToLabel.TabIndex = 6;
            this.ConvertToLabel.Text = "Convert To";
            // 
            // OutputConsole
            // 
            this.OutputConsole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputConsole.FormattingEnabled = true;
            this.OutputConsole.HorizontalScrollbar = true;
            this.OutputConsole.ItemHeight = 21;
            this.OutputConsole.Location = new System.Drawing.Point(39, 169);
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.Size = new System.Drawing.Size(296, 319);
            this.OutputConsole.TabIndex = 8;
            // 
            // comboBoxList
            // 
            this.comboBoxList.FormattingEnabled = true;
            this.comboBoxList.Items.AddRange(new object[] {
            "unit dimensions",
            "unit dimension",
            "quantity classes",
            "uom for a given quantity class",
            "aliases for a given uom",
            "names of every unit"});
            this.comboBoxList.Location = new System.Drawing.Point(428, 62);
            this.comboBoxList.Name = "comboBoxList";
            this.comboBoxList.Size = new System.Drawing.Size(243, 23);
            this.comboBoxList.TabIndex = 9;
            this.comboBoxList.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
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
            // ConfimListButton
            // 
            this.ConfimListButton.Location = new System.Drawing.Point(696, 62);
            this.ConfimListButton.Name = "ConfimListButton";
            this.ConfimListButton.Size = new System.Drawing.Size(75, 23);
            this.ConfimListButton.TabIndex = 11;
            this.ConfimListButton.Text = "Confirm";
            this.ConfimListButton.UseVisualStyleBackColor = true;
            this.ConfimListButton.Click += new System.EventHandler(this.ConfimList_Click);
            // 
            // OutputList
            // 
            this.OutputList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputList.FormattingEnabled = true;
            this.OutputList.HorizontalScrollbar = true;
            this.OutputList.ItemHeight = 21;
            this.OutputList.Location = new System.Drawing.Point(428, 169);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(317, 319);
            this.OutputList.TabIndex = 12;
            this.OutputList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            this.OutputList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OutputList_MouseDoubleClick);
            // 
            // ListSpecifyText
            // 
            this.ListSpecifyText.Location = new System.Drawing.Point(428, 108);
            this.ListSpecifyText.Name = "ListSpecifyText";
            this.ListSpecifyText.Size = new System.Drawing.Size(243, 23);
            this.ListSpecifyText.TabIndex = 14;
            this.ListSpecifyText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // UnitToEditLabel
            // 
            this.UnitToEditLabel.AutoSize = true;
            this.UnitToEditLabel.Location = new System.Drawing.Point(1101, 44);
            this.UnitToEditLabel.Name = "UnitToEditLabel";
            this.UnitToEditLabel.Size = new System.Drawing.Size(66, 15);
            this.UnitToEditLabel.TabIndex = 20;
            this.UnitToEditLabel.Text = "Unit to Edit";
            // 
            // AttributeToEditLabel
            // 
            this.AttributeToEditLabel.AutoSize = true;
            this.AttributeToEditLabel.Location = new System.Drawing.Point(1101, 113);
            this.AttributeToEditLabel.Name = "AttributeToEditLabel";
            this.AttributeToEditLabel.Size = new System.Drawing.Size(91, 15);
            this.AttributeToEditLabel.TabIndex = 21;
            this.AttributeToEditLabel.Text = "Attribute to edit";
            this.AttributeToEditLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // EditValueText
            // 
            this.EditValueText.Location = new System.Drawing.Point(1054, 189);
            this.EditValueText.Name = "EditValueText";
            this.EditValueText.Size = new System.Drawing.Size(201, 23);
            this.EditValueText.TabIndex = 22;
            this.EditValueText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Location = new System.Drawing.Point(1063, 249);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(85, 15);
            this.CreateLabel.TabIndex = 24;
            this.CreateLabel.Text = "Create Unit/QT";
            // 
            // UnitToEditButton
            // 
            this.UnitToEditButton.Location = new System.Drawing.Point(1290, 71);
            this.UnitToEditButton.Name = "UnitToEditButton";
            this.UnitToEditButton.Size = new System.Drawing.Size(37, 23);
            this.UnitToEditButton.TabIndex = 26;
            this.UnitToEditButton.Text = "Ok";
            this.UnitToEditButton.UseVisualStyleBackColor = true;
            this.UnitToEditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateUOMID
            // 
            this.CreateUOMID.Location = new System.Drawing.Point(934, 383);
            this.CreateUOMID.Name = "CreateUOMID";
            this.CreateUOMID.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMID.TabIndex = 27;
            this.CreateUOMID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CreateUOMName
            // 
            this.CreateUOMName.Location = new System.Drawing.Point(934, 412);
            this.CreateUOMName.Name = "CreateUOMName";
            this.CreateUOMName.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMName.TabIndex = 28;
            // 
            // CreateUOMAnnotation
            // 
            this.CreateUOMAnnotation.Location = new System.Drawing.Point(934, 441);
            this.CreateUOMAnnotation.Name = "CreateUOMAnnotation";
            this.CreateUOMAnnotation.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMAnnotation.TabIndex = 29;
            // 
            // CreateUOMDimensional
            // 
            this.CreateUOMDimensional.Location = new System.Drawing.Point(898, 499);
            this.CreateUOMDimensional.Name = "CreateUOMDimensional";
            this.CreateUOMDimensional.Size = new System.Drawing.Size(136, 23);
            this.CreateUOMDimensional.TabIndex = 30;
            // 
            // CreateUOMBaseUnit
            // 
            this.CreateUOMBaseUnit.Location = new System.Drawing.Point(934, 590);
            this.CreateUOMBaseUnit.Name = "CreateUOMBaseUnit";
            this.CreateUOMBaseUnit.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMBaseUnit.TabIndex = 32;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(881, 386);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 15);
            this.IdLabel.TabIndex = 35;
            this.IdLabel.Text = "ID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(860, 415);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 36;
            this.NameLabel.Text = "Name";
            // 
            // AnnotationLabel
            // 
            this.AnnotationLabel.AutoSize = true;
            this.AnnotationLabel.Location = new System.Drawing.Point(849, 444);
            this.AnnotationLabel.Name = "AnnotationLabel";
            this.AnnotationLabel.Size = new System.Drawing.Size(67, 15);
            this.AnnotationLabel.TabIndex = 37;
            this.AnnotationLabel.Text = "Annotation";
            // 
            // QuantityTypeInCreateLabel
            // 
            this.QuantityTypeInCreateLabel.AutoSize = true;
            this.QuantityTypeInCreateLabel.Location = new System.Drawing.Point(751, 470);
            this.QuantityTypeInCreateLabel.Name = "QuantityTypeInCreateLabel";
            this.QuantityTypeInCreateLabel.Size = new System.Drawing.Size(80, 15);
            this.QuantityTypeInCreateLabel.TabIndex = 38;
            this.QuantityTypeInCreateLabel.Text = "Quantity Type";
            // 
            // DimClassCreateLabel
            // 
            this.DimClassCreateLabel.AutoSize = true;
            this.DimClassCreateLabel.Location = new System.Drawing.Point(770, 507);
            this.DimClassCreateLabel.Name = "DimClassCreateLabel";
            this.DimClassCreateLabel.Size = new System.Drawing.Size(103, 15);
            this.DimClassCreateLabel.TabIndex = 39;
            this.DimClassCreateLabel.Text = "Dimensional Class";
            // 
            // BaseUnitLAbel
            // 
            this.BaseUnitLAbel.AutoSize = true;
            this.BaseUnitLAbel.Location = new System.Drawing.Point(858, 593);
            this.BaseUnitLAbel.Name = "BaseUnitLAbel";
            this.BaseUnitLAbel.Size = new System.Drawing.Size(56, 15);
            this.BaseUnitLAbel.TabIndex = 40;
            this.BaseUnitLAbel.Text = "Base Unit";
            // 
            // CreateUOMConfirm
            // 
            this.CreateUOMConfirm.Location = new System.Drawing.Point(930, 738);
            this.CreateUOMConfirm.Name = "CreateUOMConfirm";
            this.CreateUOMConfirm.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMConfirm.TabIndex = 41;
            this.CreateUOMConfirm.Text = "Create";
            this.CreateUOMConfirm.UseVisualStyleBackColor = true;
            this.CreateUOMConfirm.Click += new System.EventHandler(this.CreateUOMConfirm_Click);
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Location = new System.Drawing.Point(962, 315);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(29, 15);
            this.UnitLabel.TabIndex = 42;
            this.UnitLabel.Text = "Unit";
            // 
            // QuantityTypeLabel
            // 
            this.QuantityTypeLabel.AutoSize = true;
            this.QuantityTypeLabel.Location = new System.Drawing.Point(1237, 315);
            this.QuantityTypeLabel.Name = "QuantityTypeLabel";
            this.QuantityTypeLabel.Size = new System.Drawing.Size(80, 15);
            this.QuantityTypeLabel.TabIndex = 43;
            this.QuantityTypeLabel.Text = "Quantity Type";
            // 
            // EditQTButton
            // 
            this.EditQTButton.Location = new System.Drawing.Point(1252, 480);
            this.EditQTButton.Name = "EditQTButton";
            this.EditQTButton.Size = new System.Drawing.Size(75, 23);
            this.EditQTButton.TabIndex = 44;
            this.EditQTButton.Text = "Confirm";
            this.EditQTButton.UseVisualStyleBackColor = true;
            // 
            // EditQTName
            // 
            this.EditQTName.Location = new System.Drawing.Point(1242, 402);
            this.EditQTName.Name = "EditQTName";
            this.EditQTName.Size = new System.Drawing.Size(100, 23);
            this.EditQTName.TabIndex = 45;
            // 
            // QTNewName
            // 
            this.QTNewName.Location = new System.Drawing.Point(1242, 441);
            this.QTNewName.Name = "QTNewName";
            this.QTNewName.Size = new System.Drawing.Size(100, 23);
            this.QTNewName.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1174, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 47;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1166, 444);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 15);
            this.label18.TabIndex = 48;
            this.label18.Text = "New Name";
            // 
            // CreateUOMA
            // 
            this.CreateUOMA.Location = new System.Drawing.Point(934, 619);
            this.CreateUOMA.Name = "CreateUOMA";
            this.CreateUOMA.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMA.TabIndex = 49;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(881, 622);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(15, 15);
            this.ALabel.TabIndex = 50;
            this.ALabel.Text = "A";
            // 
            // CreateUOMB
            // 
            this.CreateUOMB.Location = new System.Drawing.Point(934, 648);
            this.CreateUOMB.Name = "CreateUOMB";
            this.CreateUOMB.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMB.TabIndex = 51;
            // 
            // CreateUOMC
            // 
            this.CreateUOMC.Location = new System.Drawing.Point(934, 677);
            this.CreateUOMC.Name = "CreateUOMC";
            this.CreateUOMC.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMC.TabIndex = 52;
            // 
            // CreateUOMD
            // 
            this.CreateUOMD.Location = new System.Drawing.Point(934, 706);
            this.CreateUOMD.Name = "CreateUOMD";
            this.CreateUOMD.Size = new System.Drawing.Size(100, 23);
            this.CreateUOMD.TabIndex = 53;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(799, 651);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(115, 15);
            this.BLabel.TabIndex = 54;
            this.BLabel.Text = "B/Factor/Numerator";
            this.BLabel.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(826, 677);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 55;
            this.label20.Text = "C/Denominator";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(881, 709);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 15);
            this.label21.TabIndex = 56;
            this.label21.Text = "D";
            // 
            // CreateUOMCheckbox
            // 
            this.CreateUOMCheckbox.AutoSize = true;
            this.CreateUOMCheckbox.Location = new System.Drawing.Point(918, 358);
            this.CreateUOMCheckbox.Name = "CreateUOMCheckbox";
            this.CreateUOMCheckbox.Size = new System.Drawing.Size(125, 19);
            this.CreateUOMCheckbox.TabIndex = 58;
            this.CreateUOMCheckbox.Text = "Create a base unit?";
            this.CreateUOMCheckbox.UseVisualStyleBackColor = true;
            this.CreateUOMCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(782, 536);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(32, 15);
            this.AliasLabel.TabIndex = 62;
            this.AliasLabel.Text = "Alias";
            // 
            // CreateUOMQT
            // 
            this.CreateUOMQT.Location = new System.Drawing.Point(837, 470);
            this.CreateUOMQT.Name = "CreateUOMQT";
            this.CreateUOMQT.PlaceholderText = "Commaseperated to add more";
            this.CreateUOMQT.Size = new System.Drawing.Size(195, 23);
            this.CreateUOMQT.TabIndex = 63;
            // 
            // CreateUOMAlias
            // 
            this.CreateUOMAlias.Location = new System.Drawing.Point(836, 528);
            this.CreateUOMAlias.Name = "CreateUOMAlias";
            this.CreateUOMAlias.PlaceholderText = "Commaseperated to add more";
            this.CreateUOMAlias.Size = new System.Drawing.Size(202, 23);
            this.CreateUOMAlias.TabIndex = 64;
            // 
            // AddQTName
            // 
            this.AddQTName.Location = new System.Drawing.Point(1275, 595);
            this.AddQTName.Name = "AddQTName";
            this.AddQTName.Size = new System.Drawing.Size(100, 23);
            this.AddQTName.TabIndex = 65;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1174, 561);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(212, 15);
            this.label23.TabIndex = 66;
            this.label23.Text = "Quantity Type Add/Remove from Units";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1174, 598);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 15);
            this.label24.TabIndex = 67;
            this.label24.Text = "Unit to change";
            // 
            // AddRemoveQTValue
            // 
            this.AddRemoveQTValue.Location = new System.Drawing.Point(1275, 634);
            this.AddRemoveQTValue.Name = "AddRemoveQTValue";
            this.AddRemoveQTValue.Size = new System.Drawing.Size(100, 23);
            this.AddRemoveQTValue.TabIndex = 68;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1147, 637);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(122, 15);
            this.label25.TabIndex = 69;
            this.label25.Text = "What to Add/Remove";
            // 
            // ConfirmAdd
            // 
            this.ConfirmAdd.Location = new System.Drawing.Point(1184, 685);
            this.ConfirmAdd.Name = "ConfirmAdd";
            this.ConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAdd.TabIndex = 70;
            this.ConfirmAdd.Text = "Add";
            this.ConfirmAdd.UseVisualStyleBackColor = true;
            this.ConfirmAdd.Click += new System.EventHandler(this.ConfirmAdd_Click);
            // 
            // ConfirmRemove
            // 
            this.ConfirmRemove.Location = new System.Drawing.Point(1288, 687);
            this.ConfirmRemove.Name = "ConfirmRemove";
            this.ConfirmRemove.Size = new System.Drawing.Size(75, 23);
            this.ConfirmRemove.TabIndex = 71;
            this.ConfirmRemove.Text = "Remove";
            this.ConfirmRemove.UseVisualStyleBackColor = true;
            this.ConfirmRemove.Click += new System.EventHandler(this.ConfirmRemove_Click);
            // 
            // CreateUOM
            // 
            this.CreateUOM.Location = new System.Drawing.Point(934, 561);
            this.CreateUOM.Name = "CreateUOM";
            this.CreateUOM.Size = new System.Drawing.Size(100, 23);
            this.CreateUOM.TabIndex = 72;
            // 
            // EditQuantityTypeLabel
            // 
            this.EditQuantityTypeLabel.AutoSize = true;
            this.EditQuantityTypeLabel.Location = new System.Drawing.Point(1239, 383);
            this.EditQuantityTypeLabel.Name = "EditQuantityTypeLabel";
            this.EditQuantityTypeLabel.Size = new System.Drawing.Size(103, 15);
            this.EditQuantityTypeLabel.TabIndex = 74;
            this.EditQuantityTypeLabel.Text = "Edit Quantity Type";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(636, 652);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 15);
            this.label30.TabIndex = 80;
            this.label30.Text = "Delete Unit";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // DeleteUnitBox
            // 
            this.DeleteUnitBox.Location = new System.Drawing.Point(625, 688);
            this.DeleteUnitBox.Name = "DeleteUnitBox";
            this.DeleteUnitBox.Size = new System.Drawing.Size(100, 23);
            this.DeleteUnitBox.TabIndex = 82;
            this.DeleteUnitBox.TextChanged += new System.EventHandler(this.DeleteUnitBox_TextChanged);
            // 
            // DeleteUnitButton
            // 
            this.DeleteUnitButton.Location = new System.Drawing.Point(625, 737);
            this.DeleteUnitButton.Name = "DeleteUnitButton";
            this.DeleteUnitButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteUnitButton.TabIndex = 84;
            this.DeleteUnitButton.Text = "Delete";
            this.DeleteUnitButton.UseVisualStyleBackColor = true;
            this.DeleteUnitButton.Click += new System.EventHandler(this.DeleteUnitButton_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(523, 691);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 15);
            this.label32.TabIndex = 86;
            this.label32.Text = "Name of Unit";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // UOMlabel
            // 
            this.UOMlabel.AutoSize = true;
            this.UOMlabel.Location = new System.Drawing.Point(860, 564);
            this.UOMlabel.Name = "UOMlabel";
            this.UOMlabel.Size = new System.Drawing.Size(32, 15);
            this.UOMlabel.TabIndex = 88;
            this.UOMlabel.Text = "uom";
            this.UOMlabel.Click += new System.EventHandler(this.label34_Click);
            // 
            // EditTextbox
            // 
            this.EditTextbox.Location = new System.Drawing.Point(1054, 71);
            this.EditTextbox.Name = "EditTextbox";
            this.EditTextbox.Size = new System.Drawing.Size(201, 23);
            this.EditTextbox.TabIndex = 18;
            this.EditTextbox.TextChanged += new System.EventHandler(this.EditTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 810);
            this.Controls.Add(this.EditQTButton);
            this.Controls.Add(this.UOMlabel);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.DeleteUnitButton);
            this.Controls.Add(this.DeleteUnitBox);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.EditQuantityTypeLabel);
            this.Controls.Add(this.CreateUOM);
            this.Controls.Add(this.ConfirmRemove);
            this.Controls.Add(this.ConfirmAdd);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.AddRemoveQTValue);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.AddQTName);
            this.Controls.Add(this.CreateUOMAlias);
            this.Controls.Add(this.CreateUOMQT);
            this.Controls.Add(this.AliasLabel);
            this.Controls.Add(this.CreateUOMCheckbox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.CreateUOMD);
            this.Controls.Add(this.CreateUOMC);
            this.Controls.Add(this.CreateUOMB);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.CreateUOMA);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.QTNewName);
            this.Controls.Add(this.EditQTName);
            this.Controls.Add(this.QuantityTypeLabel);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.CreateUOMConfirm);
            this.Controls.Add(this.BaseUnitLAbel);
            this.Controls.Add(this.DimClassCreateLabel);
            this.Controls.Add(this.QuantityTypeInCreateLabel);
            this.Controls.Add(this.AnnotationLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CreateUOMBaseUnit);
            this.Controls.Add(this.CreateUOMDimensional);
            this.Controls.Add(this.CreateUOMAnnotation);
            this.Controls.Add(this.CreateUOMName);
            this.Controls.Add(this.CreateUOMID);
            this.Controls.Add(this.UnitToEditButton);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditValueText);
            this.Controls.Add(this.AttributeToEditLabel);
            this.Controls.Add(this.UnitToEditLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.EditTextbox);
            this.Controls.Add(this.EditComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListSpecifyText);
            this.Controls.Add(this.OutputList);
            this.Controls.Add(this.ConfimListButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxList);
            this.Controls.Add(this.OutputConsole);
            this.Controls.Add(this.ConvertToLabel);
            this.Controls.Add(this.UnitFromLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ConverterButton);
            this.Controls.Add(this.UnitToText);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.UnitFromText);
            this.Name = "Form1";
            this.Text = "POSC CONVERTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UnitFromText;
        private TextBox ValueText;
        private TextBox UnitToText;
        private Button ConverterButton;
        private Label ValueLabel;
        private Label UnitFromLabel;
        private Label ConvertToLabel;
        private ListBox OutputConsole;
        private ComboBox comboBoxList;
        private Label label1;
        private Button ConfimListButton;
        private ListBox OutputList;
        private TextBox ListSpecifyText;
        private Label label2;
        private ComboBox EditComboBox;
        private Button EditButton;
        private Label UnitToEditLabel;
        private Label AttributeToEditLabel;
        private TextBox EditValueText;
        private Label label7;
        private Label CreateLabel;
        private Button UnitToEditButton;
        private TextBox CreateUOMID;
        private TextBox CreateUOMName;
        private TextBox CreateUOMAnnotation;
        private TextBox CreateUOMDimensional;
        private TextBox CreateUOMBaseUnit;
        private Label IdLabel;
        private Label NameLabel;
        private Label AnnotationLabel;
        private Label QuantityTypeInCreateLabel;
        private Label DimClassCreateLabel;
        private Label BaseUnitLAbel;
        private Button CreateUOMConfirm;
        private Label UnitLabel;
        private Label QuantityTypeLabel;
        private Button EditQTButton;
        private TextBox EditQTName;
        private TextBox QTNewName;
        private Label label17;
        private Label label18;
        private TextBox CreateUOMA;
        private Label ALabel;
        private TextBox CreateUOMB;
        private TextBox CreateUOMC;
        private TextBox CreateUOMD;
        private Label BLabel;
        private Label label20;
        private Label label21;
        private CheckBox CreateUOMCheckbox;
        private Label AliasLabel;
        private TextBox CreateUOMQT;
        private TextBox CreateUOMAlias;
        private TextBox AddQTName;
        private Label label23;
        private Label label24;
        private TextBox AddRemoveQTValue;
        private Label label25;
        private Button ConfirmAdd;
        private Button ConfirmRemove;
        private TextBox CreateUOM;
        private Label EditQuantityTypeLabel;
        private Label label30;
        private TextBox DeleteUnitBox;
        private Button DeleteUnitButton;
        private Label label32;
        private Label UOMlabel;
        private TextBox EditTextbox;
    }
}