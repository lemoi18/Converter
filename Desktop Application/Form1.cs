using Connector;
using Microsoft.VisualBasic;
using RequestLib;
using System;
using System.Runtime.CompilerServices;

namespace Desktop_Application
{
    public partial class Form1 : Form
    {

        IC converter;
        IRequests request;
        // Test is only mm to cm



        public Form1()
        {
            InitializeComponent();
            converter = ConnectorFactory.CreateConnectorFactory("Connector");
            request = RequestFactory.CreateRequestsFactory("Request");
            this.EditComboBox.Hide();
            this.label6.Hide();

        }

        private void Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnitFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnitTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConverterButton_Click(object sender, EventArgs e)
        {

            Tuple<double, string, string> Edited = converter.ConverterWrapper(Double.Parse(Value.Text), UnitFrom.Text, UnitTo.Text);
            string str = string.Format("{0}  {1} {2}", Edited.Item1.ToString(), Edited.Item2, Edited.Item3);

            OutputConsole.Items.Add(str);

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfimList_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == "unit dimensions")
            {
                OutputList.Items.Clear();

                foreach (var student in request.ListUnitdimentions())
                {

                    string str2 = string.Format("{0} {1} {2} {3} ", student[0], student[1], student[2], student[3]);
                    OutputList.Items.Add(str2);
                }
            }
            if (comboBox.Text == "quantity classes")
            {
                OutputList.Items.Clear();

                foreach (var quantity in request.ListQualityclass())
                {
                    string str2 = string.Format("{0}", quantity);
                    OutputList.Items.Add(str2);
                }
            }
            if (comboBox.Text == "aliases for a given uom ")
            {

                OutputList.Items.Clear();

                foreach (var aliases in request.ListAlias(textBox1.Text))
                {
                    string str2 = string.Format("{0}", aliases);
                    OutputList.Items.Add(str2);
                }
            }

            if (comboBox.Text == "uom for a given quantity class")
            {
                OutputList.Items.Clear();


                foreach (var student in request.GetQualityclass(textBox1.Text))
                {
                    string str2 = string.Format("{0}", student);
                    OutputList.Items.Add(str2);
                }
            }
            if (comboBox.Text == "uom for a given quantity class(detailed version)")
            {
                OutputList.Items.Clear();


                foreach (var student in request.ListUnits())
                {
                    string str2 = string.Format("{0}", student);
                    OutputList.Items.Add(str2);
                }
            }


        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditTextbox_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void EditButton_Click(object sender, EventArgs e)
        {


            if(EditWhat.Text == "UOM")
            {
                
                request.EditUOM(EditTextbox.Text, EditComboBox.Text, textBox2.Text);
            }

            if (EditWhat.Text == "QuantityType")
            {
                request.EditQualityclass(EditTextbox.Text, textBox2.Text);
                
            }

            EditTextbox.Clear();
            EditComboBox.Items.Clear();
            EditComboBox.Text = "";
            EditWhat.Text = "";
            textBox2.Clear();
            this.EditComboBox.Hide();
            this.label6.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EditWhat.Text == "UOM")
            {
                this.EditComboBox.Show();
                this.label6.Show();
            }

            foreach (var student in request.ListKeys(EditTextbox.Text))
            {
                string str2 = string.Format("{0}", student);
                EditComboBox.Items.Add(str2);
            }
        }

        private void CreateQTButton_Click(object sender, EventArgs e)
        {
            request.AddQualityclass(EditQTName.Text, QTNewName.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUOMConfirm_Click(object sender, EventArgs e)
        {
            //CreateUOMQT.Items.Add(CreateUOMQT.Text);
            //CreateUOMAlias.Items.Add(CreateUOMAlias.Text);





            if (CreateUOMCheckbox.Checked)

                request.CreateBaseUnit(CreateUOMID.Text, CreateUOMAnnotation.Text, CreateUOMName.Text, CreateUOMQT.Text, CreateUOMDimensional.Text,CreateUOM.Text,CreateUOMAlias.Text);
            else
            {
                request.CreateSecondaryUnit(CreateUOMID.Text, CreateUOMAnnotation.Text, CreateUOMName.Text, CreateUOMQT.Text, CreateUOMDimensional.Text, CreateUOM.Text, CreateUOMBaseUnit.Text, Double.Parse(CreateUOMA.Text), Double.Parse(CreateUOMB.Text), Double.Parse(CreateUOMC.Text), Double.Parse(CreateUOMD.Text), CreateUOMAlias.Text) ; 
            }        
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CreateUOMCheckbox.Checked)
            {
                
                this.CreateUOMA.Hide();
                this.CreateUOMB.Hide();
                this.CreateUOMC.Hide();
                this.CreateUOMD.Hide();

                this.label19.Hide();
                this.label20.Hide();
                this.label21.Hide();
                this.label22.Hide();
            }
            else
            {
                this.CreateUOMA.Show();
                this.CreateUOMB.Show();
                this.CreateUOMC.Show();
                this.CreateUOMD.Show();

                this.label19.Show();
                this.label20.Show();
                this.label21.Show();
                this.label22.Show();

                

            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            request.AddQualityclass(AddQTName.Text, AddRemoveQTValue.Text);
        }

        private void ConfirmRemove_Click(object sender, EventArgs e)
        {
            request.RemoveQualityclass(AddQTName.Text, AddRemoveQTValue.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmCreateType_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUnitButton_Click(object sender, EventArgs e)
        {
            request.DeleteUOM(DeleteUnitBox.Text);
            DeleteUnitBox.Clear();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUnitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void DeleteQTButton_Click(object sender, EventArgs e)
        {
            request.DeleteQualityclass(DeleteQT.Text);
            DeleteQT.Clear();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
    }

}