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
                var resultList =  request.Convert(double.Parse(Value.Text), UnitFrom.Text, UnitTo.Text);
                string resultString = string.Join(" ", resultList);

                OutputConsole.Items.Add(resultString);
            }
            catch (System.FormatException)
            {
                OutputConsole.Items.Add("Input is not correct format");
            }
            finally
            {
                Value.ResetText();
                UnitFrom.ResetText();
                UnitTo.ResetText();
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
            if (comboBox.Text == "unit dimensions")
            {
                OutputList.Items.Clear();
                this.textBox1.ResetText();


                foreach (var student in request.ListUnitdimentions())
                {

                
                    string str2 = string.Format("{0} {1} {2} ", student[0], student[1], student[2]);
                    OutputList.Items.Add(str2);
                    
                }
            }
            if (comboBox.Text == "unit dimension")
            {
                
                OutputList.Items.Clear();



                var resultList = request.GetUnitdimension(textBox1.Text);
                string resultString = string.Join(" ", resultList);

                OutputList.Items.Add(resultString);
                this.textBox1.ResetText();
            }
            if (comboBox.Text == "quantity classes")
            {
                OutputList.Items.Clear();
                this.textBox1.ResetText();


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
                this.textBox1.ResetText();

            }

            if (comboBox.Text == "uom for a given quantity class")
            {
                OutputList.Items.Clear();



                foreach (var student in request.GetQualityclass(textBox1.Text))
                {
                    string str2 = string.Format("{0}", student);
                    OutputList.Items.Add(str2);
                }
                this.textBox1.ResetText();

            }

            if (comboBox.Text == "names of every unit")
            {
                OutputList.Items.Clear();



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


            
                
           request.EditUOM(EditTextbox.Text, EditComboBox.Text, textBox2.Text);
            

            
                
 
            EditTextbox.Clear();
            EditComboBox.Items.Clear();
            EditComboBox.Text = "";
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
          
            foreach (var student in request.ReadProp(EditTextbox.Text))
            {
                string str2 = string.Format("{0}", student);
                EditComboBox.Items.Add(str2);
            }
        }

        private void CreateQTButton_Click(object sender, EventArgs e)
        {
            request.EditQualityclass(EditQTName.Text, QTNewName.Text);
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
            
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void OutputList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = OutputList.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}