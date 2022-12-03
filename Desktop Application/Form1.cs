using Connector;
using System;
using RequestLib;


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
            converter = ConnectorFactory.CreateConnectorFactory("Test");
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
            
            Tuple<double, string, string> Edited = converter.ConverterWrapper(Convert.ToDouble(Value.Text), UnitFrom.Text, UnitTo.Text);
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
                
            foreach (var student in request.ListUnitdimentions())
            {
                string str2 = string.Format("{0}  {1} {2} {3} ", student[0], student[1], student[2], student[3]);
                OutputList.Items.Add(str2);
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}