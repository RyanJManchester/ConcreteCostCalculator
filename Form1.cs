using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// name: Ryan Manchester
// student id: 1624649
namespace Concrete_Cost_Calculator
{
    public partial class concreteCostForm : Form
    {
        public concreteCostForm()
        {
            InitializeComponent();
        }

        //the depth of every Driveway
        const double DRIVEWAY_DEPTH = 0.5;
        //the amount of concrete created from 1kg of cement:
        const double CONCRETE_PER_KG = 1.5;
        //Weight of a bag of cement:
        const double BAG_WEIGHT = 2.0;
        //Cost of a bag of cement
        const decimal BAG_COST = 15.5m;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void volumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get the length of the driveway
                double length = double.Parse(lengthInputBox.Text);
                //get the width of the driveway
                double width = double.Parse(widthinputBox.Text);
                //Calculate the total volum of concrete required
                double volume = (length * width * DRIVEWAY_DEPTH);
                //calculate the number of kgs of cement required
                double kgsCement_Required = (volume / 1.5);
                //calculate the bags of cement needed - round up to 2
                //round up to 2
                double bagsOfCementRequired = (int)Math.Ceiling(kgsCement_Required / 2);// BAG_WEIGHT of a bag of cement);
                //Calculate the total cost of the cement
                decimal totalCostOfCement = (decimal)bagsOfCementRequired * BAG_COST;
                //DISPLAY the total cost as a currency
                TotalCostTextBox.Text = totalCostOfCement.ToString("c2");
                //DISPLAY the bags required
                bagsRequiredTextbox.Text = bagsOfCementRequired.ToString("n0");
                //Display the numbers of kgs of cement required to 3dp
                cementRequiredTotalTextbox.Text = kgsCement_Required.ToString("n3");
                //Display the total volume required to 3dp
                totalVolumeOfConcreteTextbox.Text = volume.ToString("n3") + "m³";

            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
                //clear all textboxes
                    //clear the input labels
                lengthInputBox.Text = "";
                widthinputBox.Text = "";
                     // clear the output labels
                TotalCostTextBox.Text = "";
                bagsRequiredTextbox.Text = "";
                cementRequiredTotalTextbox.Text = "";
                totalVolumeOfConcreteTextbox.Text = "";
                //set focus to first input text
                lengthInputBox.Focus();
                

            }
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the input labels
            lengthInputBox.Text = "";
            widthinputBox.Text = "";
            // clear the output labels
            TotalCostTextBox.Text = "";
            bagsRequiredTextbox.Text = "";
            cementRequiredTotalTextbox.Text = "";
            totalVolumeOfConcreteTextbox.Text = "";
            lengthInputBox.Focus();
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the application.
            Application.Exit();
        }


        private void concreteCostForm_Load(object sender, EventArgs e)
        {

        }

        private void totalCostTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cementRequiredTotalTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
