using Microsoft.VisualBasic;
using RequestLib;
using System;
using System.Runtime.CompilerServices;

namespace Desktop_Application
{
    public partial class Form1 : Form
    {

        IRequests request;



        public Form1()
        {
            InitializeComponent();
            request = RequestFactory.CreateRequestsFactory("Request");
            

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

       

        private  void ConverterButton_Click(object sender, EventArgs e)
        {

            
            try
            {
                // Use the "await" keyword to wait for the task to complete
                var resultList =  request.Convert(double.Parse(ValueText.Text), UnitFromText.Text, UnitToText.Text);
                string resultString = string.Join(" ", resultList);

                OutputConsole.Items.Add(resultString);
            }
            catch (System.FormatException)
            {
                OutputConsole.Items.Add("Input is not correct format");
            }
            finally
            {
                ValueText.ResetText();
                UnitFromText.ResetText();
                UnitToText.ResetText();
            }
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfimList_Click(object sender, EventArgs e)
        {
            if (comboBoxList.Text == "unit dimensions")
            {
                OutputList.Items.Clear();
                this.ListSpecifyText.ResetText();


                foreach (var student in request.ListUnitdimentions())
                {

                
                    string str2 = string.Format("{0} {1} {2} ", student[0], student[1], student[2]);
                    OutputList.Items.Add(str2);
                    
                }
            }
            if (comboBoxList.Text == "unit dimension")
            {
                
                OutputList.Items.Clear();



                var resultList = request.GetUnitdimension(ListSpecifyText.Text);
                string resultString = string.Join(" ", resultList);

                OutputList.Items.Add(resultString);
                this.ListSpecifyText.ResetText();
            }
            if (comboBoxList.Text == "quantity classes")
            {
                OutputList.Items.Clear();
                this.ListSpecifyText.ResetText();


                foreach (var quantity in request.ListQualityclass())
                {
                    string str2 = string.Format("{0}", quantity);
                    OutputList.Items.Add(str2);
                }
            }
            if (comboBoxList.Text == "aliases for a given uom ")
            {

                OutputList.Items.Clear();


                foreach (var aliases in request.ListAlias(ListSpecifyText.Text))
                {
                    string str2 = string.Format("{0}", aliases);
                    OutputList.Items.Add(str2);
                }
                this.ListSpecifyText.ResetText();

            }

            if (comboBoxList.Text == "uom for a given quantity class")
            {
                OutputList.Items.Clear();



                foreach (var student in request.GetQualityclass(ListSpecifyText.Text))
                {
                    string str2 = string.Format("{0}", student);
                    OutputList.Items.Add(str2);
                }
                this.ListSpecifyText.ResetText();

            }

            if (comboBoxList.Text == "names of every unit")
            {

                foreach (var student in request.ListNames())
                {


                    string str2 = string.Format("{0}", student);
                    OutputList.Items.Add(str2);

                }





              //  foreach (var student in request.ListUnits())
              //  {
              //      string str2 = string.Format("{0}", student);
              //      OutputList.Items.Add(str2);
              //  }
              //  this.textBox1.ResetText();
              //
            }

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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


            
                
           request.EditUOM(EditTextbox.Text, EditComboBox.Text, EditValueText.Text);
            

            
                
 
            EditTextbox.Clear();
            EditComboBox.Items.Clear();
            EditComboBox.Text = "";
            EditValueText.Clear();
            this.EditComboBox.Hide();
            this.AttributeToEditLabel.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            foreach (var student in request.ReadProp(EditTextbox.Text))
            {
                string str2 = string.Format("{0}", student);
                EditComboBox.Items.Add(str2);
            }
        }

        private void CreateQTButton_Click(object sender, EventArgs e)
        {
            //request.EditQualityclass(EditQTName.Text, QTNewName.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUOMConfirm_Click(object sender, EventArgs e)
        {
            //CreateUOMQT.Items.Add(CreateUOMQT.Text);
            //CreateUOMAlias.Items.Add(CreateUOMAlias.Text);




            try
            {
                if (CreateUOMCheckbox.Checked)
                    try
                    {

                        request.CreateBaseUnit(CreateUOMID.Text, CreateUOMAnnotation.Text, CreateUOMName.Text, CreateUOMQT.Text, CreateUOMDimensional.Text, CreateUOM.Text, CreateUOMAlias.Text);
                    }
                    catch { }

                else
                {
                    try
                    {
                        request.CreateSecondaryUnit(CreateUOMID.Text, CreateUOMAnnotation.Text, CreateUOMName.Text, CreateUOMQT.Text, CreateUOMDimensional.Text, CreateUOM.Text, CreateUOMBaseUnit.Text, Double.Parse(CreateUOMA.Text), Double.Parse(CreateUOMB.Text), Double.Parse(CreateUOMC.Text), Double.Parse(CreateUOMD.Text), CreateUOMAlias.Text);
                    }
                    catch { }



                   
                }
            }
            finally
            {
                CreateUOMID.ResetText();
                CreateUOMAnnotation.ResetText();
                CreateUOMName.ResetText();
                CreateUOMQT.ResetText();
                CreateUOMDimensional.ResetText();
                CreateUOM.ResetText();
                CreateUOMBaseUnit.ResetText();
                CreateUOMA.ResetText();
                CreateUOMB.ResetText();
                CreateUOMC.ResetText();
                CreateUOMD.ResetText();
                CreateUOMAlias.ResetText();
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

                this.BLabel.Hide();
                this.label20.Hide();
                this.label21.Hide();
                this.ALabel.Hide();
            }
            else
            {
                this.CreateUOMA.Show();
                this.CreateUOMB.Show();
                this.CreateUOMC.Show();
                this.CreateUOMD.Show();

                this.BLabel.Show();
                this.label20.Show();
                this.label21.Show();
                this.ALabel.Show();

                

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
            
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void OutputList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListSpecifyText.Text = OutputList.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}