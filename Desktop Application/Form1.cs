using Connector;
using Microsoft.VisualBasic;
using RequestLib;
using System;


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
            request = RequestFactory.CreateRequestsFactory("Test");

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

            Tuple<double, string, string> Edited = converter.ConverterWrapper(Convert.ToDouble(Value.Text), UnitFrom.Text.ToLower(), UnitTo.Text.ToLower());
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
                OutputList.Items.Clear();

            foreach (var student in request.ListUnitdimentions())
                {

                    string str2 = string.Format("{0} {1} {2} {3} ", student[0], student[1], student[2], student[3]);
                    OutputList.Items.Add(str2);
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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditWhat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var student in request.ListKeys(EditTextbox.Text))
            {
                string str2 = string.Format("{0}", student);
                EditComboBox.Items.Add(str2);
            }
        }
    }

}