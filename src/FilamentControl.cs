﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;
using System.IO;
using System.Xml;
using System.Linq;

namespace FilamentInfo
{
    public partial class FilamentControl : UserControl
    {
        IHost host;
        //COSTRUCTOR
        public FilamentControl()
        {
            InitializeComponent();
        }
        // Get the IHost istance
        public void Connect(IHost _host)
        {
            host = _host;
        }
        // control load event
        private void testControl_Load(object sender, System.EventArgs e)
        {
            // translation
            load_Translations();
            host.languageChanged += load_Translations;

            // Read the filament list from the registry and load into listview
            IRegMemoryFolder Ireg = host.GetRegistryFolder("FilamentInfo_plugin");


            // items ar separed by "|" params by ";"
            string[] items = Ireg.GetString("filamentList", "").Split('|');
            string[] allParams;

            listView_filament.BeginUpdate();
            foreach (string item in items)
            {
                allParams = item.Split(';');
                if (allParams.Count() < 8) continue;

                createAddNewItem(allParams);
            }
            listView_filament.EndUpdate();
        }

        //Load translation
        private void load_Translations()
        {
            // groupbox
            groupBox_filamentList.Text = Trans.T("FI_GB_FILAMENTS");

            // listview colums
            listView_filament.Columns[0].Text = Trans.T("FI_COL_0");
            listView_filament.Columns[1].Text = Trans.T("FI_COL_1");
            listView_filament.Columns[2].Text = Trans.T("FI_COL_2");
            listView_filament.Columns[3].Text = Trans.T("FI_COL_3");
            listView_filament.Columns[4].Text = Trans.T("FI_COL_4");
            listView_filament.Columns[5].Text = Trans.T("FI_COL_5");
            listView_filament.Columns[6].Text = Trans.T("FI_COL_6");

            // Button
            button_add.Text = Trans.T("FI_B_ADD");
            toolTip.SetToolTip(button_add, Trans.T("FI_B_ADD_TOOL"));
            button_edit.Text = Trans.T("FI_B_EDIT");
            toolTip.SetToolTip(button_edit, Trans.T("FI_B_EDIT_TOOL"));
            button_delete.Text = Trans.T("FI_B_DELETE");
            toolTip.SetToolTip(button_delete, Trans.T("FI_B_DELETE_TOOL"));
            toolTip.SetToolTip(button_backup, Trans.T("FI_B_BACKUP_TOOL"));

            // backup
            contextMenu_backup.Items[0].Text = Trans.T("FI_B_EXPORT");
            contextMenu_backup.Items[0].ToolTipText = Trans.T("FI_B_EXPORT_TOOL");
            contextMenu_backup.Items[1].Text = Trans.T("FI_B_IMPORT");
            contextMenu_backup.Items[1].ToolTipText = Trans.T("FI_B_IMPORT_TOOL");

        }


        // BUTTONS EVENT
        private void button_add_Click(object sender, EventArgs e)
        {
            // creating an array for receive the settings from the new form
            string[] allParams = null;

            // build listview group for sending it to the new form
            List<string> allGroup = new List<string>();
            foreach (ListViewGroup group in listView_filament.Groups)
            {
                allGroup.Add(group.Header);
            }

            // Open the new form 
            using (addEdit_form OpenForm = new addEdit_form(host, allGroup))
            {
                OpenForm.ShowDialog();
                allParams = OpenForm.allParams;
            }
            if (allParams == null) return;

            // Creating the item and add into the listview
            createAddNewItem(allParams);

            // Save data in the registry 
            saveRegistry();
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            // if no item selected in the listview return
            if (listView_filament.SelectedItems.Count == 0)
                return;

            // build listview group for sending it to the new form
            List<string> allGroup = new List<string>();
            foreach (ListViewGroup group in listView_filament.Groups)
            {
                allGroup.Add(group.Header);
            }

            // build an array with all settings, for sending it to the new form
            // 0: Name; 1:diameter; 2:ExMulti; 3:temp; 4:coust; 5:density; 6:note; 7:group
            string[] allParams = new string[8];
            allParams[0] = listView_filament.SelectedItems[0].SubItems[0].Text;
            allParams[1] = listView_filament.SelectedItems[0].SubItems[1].Text;
            allParams[2] = listView_filament.SelectedItems[0].SubItems[2].Text;
            allParams[3] = listView_filament.SelectedItems[0].SubItems[3].Text;
            allParams[4] = listView_filament.SelectedItems[0].SubItems[4].Text;
            allParams[5] = listView_filament.SelectedItems[0].SubItems[5].Text;
            allParams[6] = listView_filament.SelectedItems[0].SubItems[6].Text;
            allParams[7] = listView_filament.SelectedItems[0].Group.Header;


            // Open the new form with the item editor
            using (addEdit_form OpenForm = new addEdit_form(host, allGroup, allParams))
            {
                OpenForm.ShowDialog();
                //copy the new settings in the array
                allParams = OpenForm.allParams;
            }

            if (allParams == null) return;

            // remove the old item from listview and add a new item with new params
            listView_filament.BeginUpdate();
            listView_filament.Items.Remove(listView_filament.SelectedItems[0]);
            createAddNewItem(allParams);
            listView_filament.EndUpdate();

            // Save data in the registry 
            saveRegistry();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            // if no item selected in the listview return
            if (listView_filament.SelectedItems.Count == 0)
                return;

            listView_filament.Items.Remove(listView_filament.SelectedItems[0]);

            // Save data in the registry 
            saveRegistry();
        }
        private void button_backup_Click(object sender, EventArgs e)
        {
            // open the contextMenu backup
            if (!this.contextMenu_backup.Visible)
               // this.contextMenu_backup.Show(button_backup, button_backup.Width, 0);
                this.contextMenu_backup.Show(Cursor.Position);
            else
                this.contextMenu_backup.Hide();
        }


        // LISTVIEW EVENT
        // Insert the data in the filament calculator from the selected listview item
        private void listView_filament_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            /*
            if (listView_filament.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = listView_filament.SelectedItems[0];
            
            // subitem array positions
            // 0: Name; 1:diameter; 2:ExMulti; 3:temp; 4:coust; 5:density; 6:note
            textBox_cost.Value = Convert.ToDecimal(item.SubItems[4].Text);
            textBox_density.Value = Convert.ToDecimal(item.SubItems[5].Text);
            textBox_diameter.Value = Convert.ToDecimal(item.SubItems[1].Text);
            */

        }
        // Open context menu if right click over a listview item
        private void listView_filament_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_filament.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenu_listView.Show(Cursor.Position);
                }
            }
        }

        private void listView_filament_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Enable or disable buttons Edit, Delete if item in the listview is selected or not
            if (listView_filament.SelectedItems.Count == 0)
            {
                if (button_delete.Enabled) button_delete.Enabled = false;
                if (button_edit.Enabled) button_edit.Enabled = false;
                return;
            }
            if (!button_delete.Enabled) button_delete.Enabled = true;
            if (!button_edit.Enabled) button_edit.Enabled = true;
        }



        //Create an item from given params and add it into the listview
        private void createAddNewItem(string[] allParams)
        {
            ListViewItem item = new ListViewItem(allParams[0]);
            string[] subItems = 
            { 
                allParams[1], 
                allParams[2], 
                allParams[3], 
                allParams[4], 
                allParams[5], 
                allParams[6] 
            };
            item.SubItems.AddRange(subItems);
            // change the item group
            foreach (ListViewGroup group in listView_filament.Groups)
            {
                if (group.Header == allParams[7])
                {
                    item.Group = group;
                    break;
                }
            }

            item.ToolTipText = buildItemToolTips(item);

            listView_filament.Items.Add(item);
        }
        //Create the Toolstrip string for the listview item
        private string buildItemToolTips(ListViewItem item)
        {
            string toolTips;

            toolTips = listView_filament.Columns[0].Text + ": " + item.SubItems[0].Text;
            toolTips += "\r\n" + listView_filament.Columns[1].Text + ": " + item.SubItems[1].Text;
            toolTips += "\r\n" + listView_filament.Columns[2].Text + ": " + item.SubItems[2].Text;
            toolTips += "\r\n" + listView_filament.Columns[3].Text + ": " + item.SubItems[3].Text;
            toolTips += "\r\n" + listView_filament.Columns[4].Text + ": " + item.SubItems[4].Text + " $";
            toolTips += "\r\n" + listView_filament.Columns[5].Text + ": " + item.SubItems[5].Text + " gr/cm3";
            toolTips += "\r\n" + listView_filament.Columns[6].Text + ": " + item.SubItems[6].Text;

            return toolTips;
        }
        // Save the list in the registry
        private void saveRegistry()
        {
            IRegMemoryFolder Ireg = host.GetRegistryFolder("FilamentInfo_plugin");

            // if no items in the list delete all registry value
            if (listView_filament.Items.Count == 0)
            {
                Ireg.DeleteValue("filamentList");
                return;
            }

            // all items ar saved into single string, items ar separed by "|", subitems by ";"
            string regString = "";

            foreach (ListViewItem item in listView_filament.Items)
            {
                regString += "|" + item.SubItems[0].Text;
                regString += ";" + item.SubItems[1].Text;
                regString += ";" + item.SubItems[2].Text;
                regString += ";" + item.SubItems[3].Text;
                regString += ";" + item.SubItems[4].Text;
                regString += ";" + item.SubItems[5].Text;
                regString += ";" + item.SubItems[6].Text;
                regString += ";" + item.Group.Header;
            }

            Ireg.SetString("filamentList", regString.TrimStart('|'));
        }


        // BACKUP XML
        private void import_XML(object sender, EventArgs e)
        {
            string filePath;
            ListViewItem item;
            string[] subItems;

            // Find the file path
            using (OpenFileDialog OP = new OpenFileDialog())
            {
                OP.Title = "Select the file XML";
                OP.Filter = "XML file|*.xml";
                if (OP.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                filePath = OP.FileName;
            }

            // Open the xml file
            XmlDocument doc = new XmlDocument();
            try
            {
                using (XmlTextReader reader = new XmlTextReader(filePath))
                {
                    doc.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error open the file xml!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("//FilamentInfo/Item");
            if (nodeList.Count == 0)
            {
                MessageBox.Show("No item found in the xml file, the file appears empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Block the listview and delete old items
            listView_filament.BeginUpdate();
            listView_filament.Items.Clear();

            foreach (XmlNode node in nodeList)
            {
                if (node.Attributes.Count < 7)
                    continue;


                item = new ListViewItem();
                subItems = new string[7];

                for (int i = 0; i < node.Attributes.Count; i++)
                {

                    switch (node.Attributes[i].Name)
                    {
                        // 0: Name; 1:diameter; 2:exMulti; 3:temp; 4:coust; 5:density; 6:note; 7:group
                        case "name":
                            item.Text = node.Attributes[i].Value;
                            break;
                        case "diameter":
                            subItems[0] = node.Attributes[i].Value;
                            break;
                        case "exMulti":
                            subItems[1] = node.Attributes[i].Value;
                            break;
                        case "temp":
                            subItems[2] = node.Attributes[i].Value;
                            break;
                        case "coust":
                            subItems[3] = node.Attributes[i].Value;
                            break;
                        case "density":
                            subItems[4] = node.Attributes[i].Value;
                            break;
                        case "note":
                            subItems[5] = node.Attributes[i].Value;
                            break;
                        case "group":
                            foreach (ListViewGroup group in listView_filament.Groups)
                            {
                                if (group.Header == node.Attributes[i].Value)
                                {
                                    item.Group = group;
                                    break;
                                }
                            }
                            break;
                    }// end switch

                }

                //Add the item into listview
                item.SubItems.AddRange(subItems);
                item.ToolTipText = buildItemToolTips(item);
                listView_filament.Items.Add(item);

            }

            //unblock the listview
            listView_filament.EndUpdate();

            // Save data in the registry 
            saveRegistry();

        }
        private void export_XML(object sender, EventArgs e)
        {

            if (listView_filament.Items.Count == 0)
            {
                MessageBox.Show("No filament item to save is present in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "XML file|*.xml";
            saveFile.Title = "Save an XML File";

            if (saveFile.ShowDialog() != DialogResult.OK || saveFile.FileName == "")
            {
                return;
            }

            XmlTextWriter xmlWriter;
            try
            {

                FileStream fS = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter sWriter = new StreamWriter(fS);
                xmlWriter = new XmlTextWriter(sWriter);
                xmlWriter.Formatting = Formatting.Indented;

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("FilamentInfo");

                foreach (ListViewItem item in listView_filament.Items)
                {
                    // 0: Name; 1:diameter; 2:exMulti; 3:temp; 4:coust; 5:density; 6:note
                    if (item.SubItems.Count < 7)
                        continue;

                    xmlWriter.WriteStartElement("Item");
                    xmlWriter.WriteAttributeString("name", item.SubItems[0].Text);
                    xmlWriter.WriteAttributeString("diameter", item.SubItems[1].Text);
                    xmlWriter.WriteAttributeString("exMulti", item.SubItems[2].Text);
                    xmlWriter.WriteAttributeString("temp", item.SubItems[3].Text);
                    xmlWriter.WriteAttributeString("coust", item.SubItems[4].Text);
                    xmlWriter.WriteAttributeString("density", item.SubItems[5].Text);
                    xmlWriter.WriteAttributeString("note", item.SubItems[6].Text);
                    xmlWriter.WriteAttributeString("group", item.Group.Header);
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();

                MessageBox.Show("The XML files is saved correctly", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error saving xml file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
