﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepetierHostExtender.utils;
using RepetierHostExtender.interfaces;

namespace FilamentInfo
{
    public partial class addEdit_form : Form
    {
        private IHost host;


        // array with al new params, public to pass it to the main form after closing this
        internal string[] allParams = null;

        // COSTRUCTORS
        //group = list of all listview groups, for populate the comboBox_group
        //Params = array string with all params ... 0: Name; 1:diameter; 2:ExMulti; 3:temp; 4:cost; 5:density; 6:note; 7:group
        public addEdit_form(IHost _host, List<string> group)
        {
            host = _host;

            InitializeComponent();
            comboBox_group.Items.AddRange(group.ToArray());
            comboBox_group.Text = "ABS";
        }
        public addEdit_form(IHost _host, List<string> group, string[] Params)
        {
            host = _host;

            InitializeComponent();


            comboBox_group.Items.AddRange(group.ToArray());

            // The array with all item data, string[] 8
            // 0: Name; 1:diameter; 2:ExMulti; 3:temp; 4:cost; 5:density; 6:note; 7:group
            textBox_name.Text = Params[0];
            numericUpDown_diameter.Value = Convert.ToDecimal(Params[1]);
            numericUpDown_ExMulti.Value = Convert.ToDecimal(Params[2]);
            textBox_temp.Text = Params[3];
            numericUpDown_cost.Value = Convert.ToDecimal(Params[4]);
            numericUpDown_density.Value = Convert.ToDecimal(Params[5]);
            textBox_note.Text = Params[6];
            comboBox_group.Text = Params[7];

        }
        private void addEdit_form_Load(object sender, EventArgs e)
        {
            loadLanguage();
        }

        // Insert the default density value for a given material in the NumericUpDown density
        private void button_defaultDensity_Click(object sender, EventArgs e)
        {
            // open the contextMenu density
            if (!this.contextMenu_density.Visible)
                this.contextMenu_density.Show(numericUpDown_density, numericUpDown_density.Width, 0);
            else
                this.contextMenu_density.Hide();
        }
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
            numericUpDown_density.Value = density;
        }

        // Button SAVE - CANCEL .... close the form
        private void button_save_Click(object sender, EventArgs e)
        {
            // This charset ar used in the registry for separate all items....
            
            allParams = new string[8];
            allParams[0] = textBox_name.Text;
            allParams[1] = numericUpDown_diameter.Value.ToString();
            allParams[2] = numericUpDown_ExMulti.Value.ToString();
            allParams[3] = textBox_temp.Text;
            allParams[4] = numericUpDown_cost.Value.ToString();
            allParams[5] = numericUpDown_density.Value.ToString();
            allParams[6] = textBox_note.Text;
            allParams[7] = comboBox_group.Text;

            // Delete all charset ( ; | ), this ar used for the registry string...
            for (int i = 0; i < 8;  i++)
            {
                char[] allCh = { '|', ';' };

                foreach (char ch in allCh)
                {
                    allParams[i] = allParams[i].Replace(ch, ' ');
                }

            }

            this.Close();
            
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loadLanguage()
        {
            this.Text = Trans.T("FI_AE_TITLE");


            label_cost.Text = Trans.T("FI_AE_COST");
            label_density.Text = Trans.T("FI_AE_DENSITY");
            label_diameter.Text = Trans.T("FI_AE_DIAMETER");
            label_group.Text = Trans.T("FI_AE_GROUP");
            label_multi.Text = Trans.T("FI_AE_MULTI");
            label_name.Text = Trans.T("FI_AE_NAME");
            label_note.Text = Trans.T("FI_AE_NOTE");
            label_temp.Text = Trans.T("FI_AE_TEMP");

            button_save.Text = Trans.T("FI_AE_SAVE");
            button_cancel.Text = Trans.T("FI_AE_CANCEL");

            toolTip1.SetToolTip(button_defaultDensity, Trans.T("FI_AE_DENSTOOL"));
            toolTip1.SetToolTip(textBox_temp, Trans.T("FI_AE_TEMPTOOL"));
            toolTip1.SetToolTip(comboBox_group, Trans.T("FI_AE_GROUPTOOL"));
        }

    }
}
