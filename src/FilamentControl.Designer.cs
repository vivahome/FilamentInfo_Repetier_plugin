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
            this.groupBox_filamentList = new System.Windows.Forms.GroupBox();
            this.button_backup = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.listView_filament = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Diameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_EMultiplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Density = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.contextMenu_backup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_listView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_filamentList.SuspendLayout();
            this.contextMenu_backup.SuspendLayout();
            this.contextMenu_listView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_filamentList
            // 
            this.groupBox_filamentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_filamentList.Controls.Add(this.button_backup);
            this.groupBox_filamentList.Controls.Add(this.button_add);
            this.groupBox_filamentList.Controls.Add(this.listView_filament);
            this.groupBox_filamentList.Controls.Add(this.button_edit);
            this.groupBox_filamentList.Controls.Add(this.button_delete);
            this.groupBox_filamentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_filamentList.Location = new System.Drawing.Point(3, 3);
            this.groupBox_filamentList.Name = "groupBox_filamentList";
            this.groupBox_filamentList.Size = new System.Drawing.Size(507, 366);
            this.groupBox_filamentList.TabIndex = 3;
            this.groupBox_filamentList.TabStop = false;
            this.groupBox_filamentList.Text = "Filaments rolls list";
            // 
            // button_backup
            // 
            this.button_backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_backup.Location = new System.Drawing.Point(419, 328);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(75, 23);
            this.button_backup.TabIndex = 6;
            this.button_backup.Text = "Backup";
            this.button_backup.UseVisualStyleBackColor = true;
            this.button_backup.Click += new System.EventHandler(this.button_backup_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_add.AutoSize = true;
            this.button_add.Location = new System.Drawing.Point(12, 324);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(60, 27);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.listView_filament.Location = new System.Drawing.Point(12, 30);
            this.listView_filament.MultiSelect = false;
            this.listView_filament.Name = "listView_filament";
            this.listView_filament.ShowItemToolTips = true;
            this.listView_filament.Size = new System.Drawing.Size(482, 288);
            this.listView_filament.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_edit.AutoSize = true;
            this.button_edit.Enabled = false;
            this.button_edit.Location = new System.Drawing.Point(125, 324);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(60, 27);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_delete.AutoSize = true;
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(252, 324);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(60, 27);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // contextMenu_backup
            // 
            this.contextMenu_backup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.contextMenu_backup.Name = "contextMenu_backup";
            this.contextMenu_backup.Size = new System.Drawing.Size(116, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.ToolTipText = "Export the filament list into file XML.";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.export_XML);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.ToolTipText = "Import the filament list from a existing file.";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.import_XML);
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
            this.toolStripMenuItem_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem_delete.Text = "Delete";
            this.toolStripMenuItem_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // FilamentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_filamentList);
            this.Name = "FilamentControl";
            this.Size = new System.Drawing.Size(513, 383);
            this.Load += new System.EventHandler(this.testControl_Load);
            this.groupBox_filamentList.ResumeLayout(false);
            this.groupBox_filamentList.PerformLayout();
            this.contextMenu_backup.ResumeLayout(false);
            this.contextMenu_listView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_filamentList;
        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Diameter;
        private System.Windows.Forms.ColumnHeader columnHeader_EMultiplier;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp;
        private System.Windows.Forms.ColumnHeader columnHeader_Cost;
        private System.Windows.Forms.ColumnHeader columnHeader_Density;
        private System.Windows.Forms.ColumnHeader columnHeader_Note;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ContextMenuStrip contextMenu_backup;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu_listView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.ListView listView_filament;
    }
}
