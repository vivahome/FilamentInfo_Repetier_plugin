namespace FilamentInfo
{
    partial class FilamentControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ABS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("PLA", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("PET", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("NYLON", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("OTHER", System.Windows.Forms.HorizontalAlignment.Left);
            this.button_defaultDensity = new System.Windows.Forms.Button();
            this.label_resultCost = new System.Windows.Forms.Label();
            this.label_cost2 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.textBox_cost = new System.Windows.Forms.NumericUpDown();
            this.label_diameter = new System.Windows.Forms.Label();
            this.label_mmDensity = new System.Windows.Forms.Label();
            this.textBox_diameter = new System.Windows.Forms.NumericUpDown();
            this.label_result = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_length = new System.Windows.Forms.Label();
            this.textBox_length = new System.Windows.Forms.NumericUpDown();
            this.label_density = new System.Windows.Forms.Label();
            this.label_gcm3 = new System.Windows.Forms.Label();
            this.textBox_density = new System.Windows.Forms.NumericUpDown();
            this.button_export = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.listView_filament = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Diameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_EMultiplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Density = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown_tabPos = new System.Windows.Forms.NumericUpDown();
            this.contextMenu_density = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_pla = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_abs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_listView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_converter = new System.Windows.Forms.GroupBox();
            this.groupBox_filamentList = new System.Windows.Forms.GroupBox();
            this.label_tabPos = new System.Windows.Forms.Label();
            this.comboBox_unity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_diameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tabPos)).BeginInit();
            this.contextMenu_density.SuspendLayout();
            this.contextMenu_listView.SuspendLayout();
            this.groupBox_converter.SuspendLayout();
            this.groupBox_filamentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_defaultDensity
            // 
            this.button_defaultDensity.Location = new System.Drawing.Point(171, 65);
            this.button_defaultDensity.Name = "button_defaultDensity";
            this.button_defaultDensity.Size = new System.Drawing.Size(19, 23);
            this.button_defaultDensity.TabIndex = 19;
            this.button_defaultDensity.Text = "D";
            this.toolTip.SetToolTip(this.button_defaultDensity, "Default density for different material");
            this.button_defaultDensity.UseVisualStyleBackColor = true;
            this.button_defaultDensity.Click += new System.EventHandler(this.button_defaultDensity_Click);
            // 
            // label_resultCost
            // 
            this.label_resultCost.AutoSize = true;
            this.label_resultCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultCost.Location = new System.Drawing.Point(244, 134);
            this.label_resultCost.Name = "label_resultCost";
            this.label_resultCost.Size = new System.Drawing.Size(31, 17);
            this.label_resultCost.TabIndex = 18;
            this.label_resultCost.Text = "0 $";
            this.label_resultCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_cost2
            // 
            this.label_cost2.AutoSize = true;
            this.label_cost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost2.Location = new System.Drawing.Point(190, 133);
            this.label_cost2.Name = "label_cost2";
            this.label_cost2.Size = new System.Drawing.Size(40, 17);
            this.label_cost2.TabIndex = 17;
            this.label_cost2.Text = "Cost:";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(249, 69);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(40, 17);
            this.label_cost.TabIndex = 16;
            this.label_cost.Text = "Cost:";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_money.Location = new System.Drawing.Point(382, 69);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(35, 17);
            this.label_money.TabIndex = 15;
            this.label_money.Text = "$/kg";
            this.label_money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_cost
            // 
            this.textBox_cost.DecimalPlaces = 1;
            this.textBox_cost.Location = new System.Drawing.Point(300, 69);
            this.textBox_cost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(76, 23);
            this.textBox_cost.TabIndex = 14;
            this.toolTip.SetToolTip(this.textBox_cost, "Insert the filament coust, currency for 1 kg");
            // 
            // label_diameter
            // 
            this.label_diameter.AutoSize = true;
            this.label_diameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diameter.Location = new System.Drawing.Point(241, 28);
            this.label_diameter.Name = "label_diameter";
            this.label_diameter.Size = new System.Drawing.Size(69, 17);
            this.label_diameter.TabIndex = 13;
            this.label_diameter.Text = "Diameter:";
            // 
            // label_mmDensity
            // 
            this.label_mmDensity.AutoSize = true;
            this.label_mmDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mmDensity.Location = new System.Drawing.Point(381, 28);
            this.label_mmDensity.Name = "label_mmDensity";
            this.label_mmDensity.Size = new System.Drawing.Size(30, 17);
            this.label_mmDensity.TabIndex = 12;
            this.label_mmDensity.Text = "mm";
            this.label_mmDensity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_diameter
            // 
            this.textBox_diameter.DecimalPlaces = 3;
            this.textBox_diameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.textBox_diameter.Location = new System.Drawing.Point(316, 28);
            this.textBox_diameter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textBox_diameter.Name = "textBox_diameter";
            this.textBox_diameter.Size = new System.Drawing.Size(59, 23);
            this.textBox_diameter.TabIndex = 11;
            this.toolTip.SetToolTip(this.textBox_diameter, "Insert the filament diameter in mm\r\n\r\n");
            this.textBox_diameter.Value = new decimal(new int[] {
            175,
            0,
            0,
            131072});
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(244, 107);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(66, 17);
            this.label_result.TabIndex = 10;
            this.label_result.Text = "0 grams";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weight.Location = new System.Drawing.Point(184, 107);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(56, 17);
            this.label_weight.TabIndex = 8;
            this.label_weight.Text = "Weight:";
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(68, 104);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 46);
            this.button_convert.TabIndex = 7;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.converter);
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_length.Location = new System.Drawing.Point(6, 28);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(51, 17);
            this.label_length.TabIndex = 6;
            this.label_length.Text = "length:";
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(57, 28);
            this.textBox_length.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(96, 23);
            this.textBox_length.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBox_length, "Insert the filament length used for the model.");
            // 
            // label_density
            // 
            this.label_density.AutoSize = true;
            this.label_density.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_density.Location = new System.Drawing.Point(-1, 66);
            this.label_density.Name = "label_density";
            this.label_density.Size = new System.Drawing.Size(59, 17);
            this.label_density.TabIndex = 3;
            this.label_density.Text = "Density:";
            // 
            // label_gcm3
            // 
            this.label_gcm3.AutoSize = true;
            this.label_gcm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gcm3.Location = new System.Drawing.Point(122, 66);
            this.label_gcm3.Name = "label_gcm3";
            this.label_gcm3.Size = new System.Drawing.Size(46, 17);
            this.label_gcm3.TabIndex = 2;
            this.label_gcm3.Text = "g/cm3";
            this.label_gcm3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_density
            // 
            this.textBox_density.DecimalPlaces = 3;
            this.textBox_density.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.textBox_density.Location = new System.Drawing.Point(57, 66);
            this.textBox_density.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.textBox_density.Name = "textBox_density";
            this.textBox_density.Size = new System.Drawing.Size(59, 23);
            this.textBox_density.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBox_density, "Insert the material density in g/cm3\r\nExample:\r\nPLA: 1.210–1.430 g/cm3\r\nABS: 1.06" +
        "0-1.080 g/cm3\r\nPET: 1.380 g/cm3\r\nPC:  1.200–1.220 g/cm3");
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_export.Location = new System.Drawing.Point(349, 360);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(61, 23);
            this.button_export.TabIndex = 5;
            this.button_export.Text = "Export";
            this.toolTip.SetToolTip(this.button_export, "Export the filament list into file XML.");
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.export_XML);
            // 
            // button_import
            // 
            this.button_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_import.Location = new System.Drawing.Point(287, 360);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(56, 23);
            this.button_import.TabIndex = 4;
            this.button_import.Text = "Import";
            this.toolTip.SetToolTip(this.button_import, "Import the filament list from a existing file.");
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.import_XML);
            // 
            // button_edit
            // 
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(131, 29);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(58, 23);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.toolTip.SetToolTip(this.button_edit, "Edit the selected filament");
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.editListViewItem);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(335, 29);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(57, 23);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.toolTip.SetToolTip(this.button_delete, "Delete the selected filament");
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.deleteListViewItem);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(35, 29);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add filament";
            this.toolTip.SetToolTip(this.button_add, "Add a new filament into the list");
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.addListViewItem);
            // 
            // listView_filament
            // 
            this.listView_filament.AllowColumnReorder = true;
            this.listView_filament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_filament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Diameter,
            this.columnHeader_EMultiplier,
            this.columnHeader_Temp,
            this.columnHeader_Cost,
            this.columnHeader_Density,
            this.columnHeader_Note});
            this.listView_filament.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.68932F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_filament.FullRowSelect = true;
            this.listView_filament.GridLines = true;
            listViewGroup1.Header = "ABS";
            listViewGroup1.Name = "listViewGroup_ABS";
            listViewGroup2.Header = "PLA";
            listViewGroup2.Name = "listViewGroup_PLA";
            listViewGroup3.Header = "PET";
            listViewGroup3.Name = "listViewGroup_PET";
            listViewGroup4.Header = "NYLON";
            listViewGroup4.Name = "listViewGroup_NYLON";
            listViewGroup5.Header = "OTHER";
            listViewGroup5.Name = "listViewGroup_OTHER";
            this.listView_filament.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.listView_filament.HideSelection = false;
            this.listView_filament.Location = new System.Drawing.Point(12, 67);
            this.listView_filament.MultiSelect = false;
            this.listView_filament.Name = "listView_filament";
            this.listView_filament.ShowItemToolTips = true;
            this.listView_filament.Size = new System.Drawing.Size(402, 287);
            this.listView_filament.TabIndex = 0;
            this.listView_filament.UseCompatibleStateImageBehavior = false;
            this.listView_filament.View = System.Windows.Forms.View.Details;
            this.listView_filament.SelectedIndexChanged += new System.EventHandler(this.listView_filament_SelectedIndexChanged);
            this.listView_filament.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_filament_MouseClick);
            this.listView_filament.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_filament_MouseDoubleClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 93;
            // 
            // columnHeader_Diameter
            // 
            this.columnHeader_Diameter.Text = "Diameter";
            // 
            // columnHeader_EMultiplier
            // 
            this.columnHeader_EMultiplier.Text = "Ex. multiplier";
            this.columnHeader_EMultiplier.Width = 70;
            // 
            // columnHeader_Temp
            // 
            this.columnHeader_Temp.Text = "Temperature";
            this.columnHeader_Temp.Width = 78;
            // 
            // columnHeader_Cost
            // 
            this.columnHeader_Cost.Text = "Cost";
            this.columnHeader_Cost.Width = 51;
            // 
            // columnHeader_Density
            // 
            this.columnHeader_Density.Text = "Density";
            // 
            // columnHeader_Note
            // 
            this.columnHeader_Note.Text = "Note";
            this.columnHeader_Note.Width = 133;
            // 
            // numericUpDown_tabPos
            // 
            this.numericUpDown_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_tabPos.Location = new System.Drawing.Point(95, 560);
            this.numericUpDown_tabPos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_tabPos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_tabPos.Name = "numericUpDown_tabPos";
            this.numericUpDown_tabPos.ReadOnly = true;
            this.numericUpDown_tabPos.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_tabPos.TabIndex = 21;
            this.toolTip.SetToolTip(this.numericUpDown_tabPos, "Set the Filament Tab position, 1 is first left.\r\n*RESTART REPETIER HOST AFTER CHA" +
        "NGE*");
            this.numericUpDown_tabPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_tabPos.ValueChanged += new System.EventHandler(this.numericUpDown_tabPos_ValueChanged);
            // 
            // contextMenu_density
            // 
            this.contextMenu_density.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_pla,
            this.MenuItem_abs,
            this.MenuItem_pet,
            this.MenuItem_pc});
            this.contextMenu_density.Name = "contextMenu_density";
            this.contextMenu_density.ShowImageMargin = false;
            this.contextMenu_density.Size = new System.Drawing.Size(74, 92);
            // 
            // MenuItem_pla
            // 
            this.MenuItem_pla.Name = "MenuItem_pla";
            this.MenuItem_pla.Size = new System.Drawing.Size(73, 22);
            this.MenuItem_pla.Text = "PLA";
            this.MenuItem_pla.Click += new System.EventHandler(this.MenuItems_density_Click);
            // 
            // MenuItem_abs
            // 
            this.MenuItem_abs.Name = "MenuItem_abs";
            this.MenuItem_abs.Size = new System.Drawing.Size(73, 22);
            this.MenuItem_abs.Text = "ABS";
            this.MenuItem_abs.Click += new System.EventHandler(this.MenuItems_density_Click);
            // 
            // MenuItem_pet
            // 
            this.MenuItem_pet.Name = "MenuItem_pet";
            this.MenuItem_pet.Size = new System.Drawing.Size(73, 22);
            this.MenuItem_pet.Text = "PET";
            this.MenuItem_pet.Click += new System.EventHandler(this.MenuItems_density_Click);
            // 
            // MenuItem_pc
            // 
            this.MenuItem_pc.Name = "MenuItem_pc";
            this.MenuItem_pc.Size = new System.Drawing.Size(73, 22);
            this.MenuItem_pc.Text = "PC";
            this.MenuItem_pc.Click += new System.EventHandler(this.MenuItems_density_Click);
            // 
            // contextMenu_listView
            // 
            this.contextMenu_listView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_edit,
            this.toolStripMenuItem_delete});
            this.contextMenu_listView.Name = "contextMenu_listView";
            this.contextMenu_listView.ShowImageMargin = false;
            this.contextMenu_listView.Size = new System.Drawing.Size(124, 48);
            // 
            // toolStripMenuItem_edit
            // 
            this.toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            this.toolStripMenuItem_edit.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem_edit.Text = "Edit filament";
            this.toolStripMenuItem_edit.Click += new System.EventHandler(this.editListViewItem);
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem_delete.Text = "Delete";
            this.toolStripMenuItem_delete.Click += new System.EventHandler(this.deleteListViewItem);
            // 
            // groupBox_converter
            // 
            this.groupBox_converter.Controls.Add(this.comboBox_unity);
            this.groupBox_converter.Controls.Add(this.button_defaultDensity);
            this.groupBox_converter.Controls.Add(this.label_length);
            this.groupBox_converter.Controls.Add(this.label_resultCost);
            this.groupBox_converter.Controls.Add(this.textBox_density);
            this.groupBox_converter.Controls.Add(this.label_cost2);
            this.groupBox_converter.Controls.Add(this.label_gcm3);
            this.groupBox_converter.Controls.Add(this.label_cost);
            this.groupBox_converter.Controls.Add(this.label_density);
            this.groupBox_converter.Controls.Add(this.textBox_cost);
            this.groupBox_converter.Controls.Add(this.label_money);
            this.groupBox_converter.Controls.Add(this.textBox_length);
            this.groupBox_converter.Controls.Add(this.label_diameter);
            this.groupBox_converter.Controls.Add(this.button_convert);
            this.groupBox_converter.Controls.Add(this.label_mmDensity);
            this.groupBox_converter.Controls.Add(this.label_weight);
            this.groupBox_converter.Controls.Add(this.textBox_diameter);
            this.groupBox_converter.Controls.Add(this.label_result);
            this.groupBox_converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_converter.Location = new System.Drawing.Point(3, 3);
            this.groupBox_converter.Name = "groupBox_converter";
            this.groupBox_converter.Size = new System.Drawing.Size(427, 157);
            this.groupBox_converter.TabIndex = 20;
            this.groupBox_converter.TabStop = false;
            this.groupBox_converter.Text = "Converter";
            // 
            // groupBox_filamentList
            // 
            this.groupBox_filamentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_filamentList.Controls.Add(this.button_export);
            this.groupBox_filamentList.Controls.Add(this.button_add);
            this.groupBox_filamentList.Controls.Add(this.button_import);
            this.groupBox_filamentList.Controls.Add(this.listView_filament);
            this.groupBox_filamentList.Controls.Add(this.button_edit);
            this.groupBox_filamentList.Controls.Add(this.button_delete);
            this.groupBox_filamentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_filamentList.Location = new System.Drawing.Point(3, 166);
            this.groupBox_filamentList.Name = "groupBox_filamentList";
            this.groupBox_filamentList.Size = new System.Drawing.Size(427, 389);
            this.groupBox_filamentList.TabIndex = 2;
            this.groupBox_filamentList.TabStop = false;
            this.groupBox_filamentList.Text = "Filaments rolls list";
            // 
            // label_tabPos
            // 
            this.label_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_tabPos.Location = new System.Drawing.Point(4, 560);
            this.label_tabPos.Name = "label_tabPos";
            this.label_tabPos.Size = new System.Drawing.Size(83, 18);
            this.label_tabPos.TabIndex = 22;
            this.label_tabPos.Text = "Tab position:";
            this.label_tabPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_unity
            // 
            this.comboBox_unity.FormattingEnabled = true;
            this.comboBox_unity.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.comboBox_unity.Location = new System.Drawing.Point(160, 28);
            this.comboBox_unity.Name = "comboBox_unity";
            this.comboBox_unity.Size = new System.Drawing.Size(47, 25);
            this.comboBox_unity.TabIndex = 20;
            this.comboBox_unity.Text = "mm";
            // 
            // FilamentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_tabPos);
            this.Controls.Add(this.numericUpDown_tabPos);
            this.Controls.Add(this.groupBox_converter);
            this.Controls.Add(this.groupBox_filamentList);
            this.Name = "FilamentControl";
            this.Size = new System.Drawing.Size(433, 581);
            this.Load += new System.EventHandler(this.FilamentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_diameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tabPos)).EndInit();
            this.contextMenu_density.ResumeLayout(false);
            this.contextMenu_listView.ResumeLayout(false);
            this.groupBox_converter.ResumeLayout(false);
            this.groupBox_converter.PerformLayout();
            this.groupBox_filamentList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.NumericUpDown textBox_length;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_density;
        private System.Windows.Forms.Label label_gcm3;
        private System.Windows.Forms.NumericUpDown textBox_density;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_diameter;
        private System.Windows.Forms.Label label_mmDensity;
        private System.Windows.Forms.NumericUpDown textBox_diameter;
        private System.Windows.Forms.Label label_resultCost;
        private System.Windows.Forms.Label label_cost2;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.NumericUpDown textBox_cost;
        private System.Windows.Forms.ListView listView_filament;
        private System.Windows.Forms.ContextMenuStrip contextMenu_density;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pla;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_abs;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pet;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pc;
        private System.Windows.Forms.Button button_defaultDensity;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Diameter;
        private System.Windows.Forms.ColumnHeader columnHeader_EMultiplier;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp;
        private System.Windows.Forms.ColumnHeader columnHeader_Cost;
        private System.Windows.Forms.ColumnHeader columnHeader_Density;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ContextMenuStrip contextMenu_listView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.ColumnHeader columnHeader_Note;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.GroupBox groupBox_converter;
        private System.Windows.Forms.GroupBox groupBox_filamentList;
        private System.Windows.Forms.NumericUpDown numericUpDown_tabPos;
        private System.Windows.Forms.Label label_tabPos;
        private System.Windows.Forms.ComboBox comboBox_unity;

    }
}
