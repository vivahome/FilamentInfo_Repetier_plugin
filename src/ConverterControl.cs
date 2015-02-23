using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepetierHostExtender.utils;

namespace FilamentInfo
{
    public partial class ConverterControl : UserControl
    {
        public ConverterControl()
        {
            InitializeComponent();
        }

        private void ConverterControl_Load(object sender, EventArgs e)
        {
            load_Translations();
        }

        /// <summary>
        /// Add the given data in the convert contol
        /// diameter; density; cost
        /// </summary>
        /// <param name="data">Dictionary<name,value></param>
        public void addData(Dictionary<string,decimal> data)
        {

            foreach(KeyValuePair<string, decimal> item in data )
            {
                switch (item.Key)
                {
                    case "diameter":
                        numericUD_diameter.Value = item.Value;
                        break;
                    case "density":
                        numericUD_density.Value = item.Value;
                        break;
                    case "cost":
                        numericUD_cost.Value = item.Value;
                        break;
                }
            }

        }


        private void load_Translations()
        {
            // groupbox
            groupBox_converter.Text = Trans.T("FI_GB_CONVERTER");

            // label
            label_cost.Text = Trans.T("FI_L_COST");
            label_totalCost.Text = Trans.T("FI_L_TOTALCOST");
            label_density.Text = Trans.T("FI_L_DENSITY");
            label_diameter.Text = Trans.T("FI_L_DIAMETER");
            label_length.Text = Trans.T("FI_L_LENGTH");
            label_weight.Text = Trans.T("FI_L_WEIGHT");


            button_convert.Text = Trans.T("FI_B_CONVERT");


            // toolTip
            toolTip.SetToolTip(numericUD_length, Trans.T("FI_LENGTH_TOOL"));
            toolTip.SetToolTip(numericUD_density, Trans.T("FI_DENSITY_TOOL"));
            toolTip.SetToolTip(numericUD_diameter, Trans.T("FI_DIAMETER_TOOL"));
            toolTip.SetToolTip(numericUD_cost, Trans.T("FI_COST_TOOL"));
        }

        // Buttons event
        private void button_convert_Click(object sender, EventArgs e)
        {
            decimal radius = numericUD_diameter.Value / 2;
            //mm to cm... radius / 10
            radius = radius / 10;

            //length;  x to cm
            decimal length = numericUD_length.Value;
            switch (comboBox_unity.Text)
            {
                case "mm":
                    length = length / 10;
                    break;
                case "dm":
                    length = length * 10;
                    break;
                case "m":
                    length = length * 100;
                    break;
            }

            // calculate volume = (pi * r * r) * L
            decimal volume = (3.1416m * radius * radius) * length;

            // calculate weight, result in grams
            decimal weight = volume * numericUD_density.Value;


            if (weight > 1000)
                label_result.Text = Decimal.Round(weight / 1000, 2).ToString() + " kg";
            else
                label_result.Text = Decimal.Round(weight, 2).ToString() + " g";

            // calculate money for the model... cost * weight, weight is in grams...
            decimal cost = numericUD_cost.Value * (weight / 1000);
            label_resultCost.Text = Decimal.Round(cost, 2).ToString() + " $";
        }
        private void button_defaultDensity_Click(object sender, EventArgs e)
        {
            // open the contextMenu density
            if (!this.contextMenu_density.Visible)
                this.contextMenu_density.Show(numericUD_density, numericUD_density.Width, 0);
            else
                this.contextMenu_density.Hide();
        }
        // Insert the default density value for a given material in the NumericUpDown density
        private void MenuItems_density_Click(object sender, EventArgs e)
        {
            // find the sender item name
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item == null) return;

            // value to use, in decimal for the numericUpDown.value
            decimal density;

            switch (item.Text)
            {
                case "PLA":
                    density = 1.300m;
                    break;
                case "ABS":
                    density = 1.070m;
                    break;
                case "PET":
                    density = 1.380m;
                    break;
                case "PC":
                    density = 1.2m;
                    break;
                // if no match is found  return
                default:
                    return;
            }

            // set the selected value into the numericUpDown density
            numericUD_density.Value = density;
        }

        private void comboBox_unity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_unity.Text)
            {
                case "cm":
                    numericUD_length.DecimalPlaces = 1;
                    break;
                case "dm":
                case "m":
                    numericUD_length.DecimalPlaces = 2;
                    break;
                default:
                    numericUD_length.DecimalPlaces = 0;
                    break;
            }
        }

    }
}
