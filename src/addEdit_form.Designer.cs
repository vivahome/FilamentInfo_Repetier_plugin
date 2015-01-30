namespace FilamentInfo
{
    partial class addEdit_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.numericUpDown_diameter = new System.Windows.Forms.NumericUpDown();
            this.label_diameter = new System.Windows.Forms.Label();
            this.label_multi = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.textBox_temp = new System.Windows.Forms.TextBox();
            this.label_cost = new System.Windows.Forms.Label();
            this.numericUpDown_cost = new System.Windows.Forms.NumericUpDown();
            this.label_density = new System.Windows.Forms.Label();
            this.numericUpDown_density = new System.Windows.Forms.NumericUpDown();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBox_group = new System.Windows.Forms.ComboBox();
            this.label_group = new System.Windows.Forms.Label();
            this.numericUpDown_ExMulti = new System.Windows.Forms.NumericUpDown();
            this.button_defaultDensity = new System.Windows.Forms.Button();
            this.contextMenu_density = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_pla = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_abs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pc = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExMulti)).BeginInit();
            this.contextMenu_density.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(26, 37);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(124, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(26, 18);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(174, 185);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(30, 13);
            this.label_note.TabIndex = 17;
            this.label_note.Text = "Note";
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(174, 204);
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(100, 20);
            this.textBox_note.TabIndex = 7;
            // 
            // numericUpDown_diameter
            // 
            this.numericUpDown_diameter.DecimalPlaces = 3;
            this.numericUpDown_diameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_diameter.Location = new System.Drawing.Point(26, 94);
            this.numericUpDown_diameter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_diameter.Name = "numericUpDown_diameter";
            this.numericUpDown_diameter.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_diameter.TabIndex = 2;
            this.numericUpDown_diameter.Value = new decimal(new int[] {
            175,
            0,
            0,
            131072});
            // 
            // label_diameter
            // 
            this.label_diameter.AutoSize = true;
            this.label_diameter.Location = new System.Drawing.Point(26, 75);
            this.label_diameter.Name = "label_diameter";
            this.label_diameter.Size = new System.Drawing.Size(49, 13);
            this.label_diameter.TabIndex = 12;
            this.label_diameter.Text = "Diameter";
            // 
            // label_multi
            // 
            this.label_multi.AutoSize = true;
            this.label_multi.Location = new System.Drawing.Point(171, 75);
            this.label_multi.Name = "label_multi";
            this.label_multi.Size = new System.Drawing.Size(88, 13);
            this.label_multi.TabIndex = 13;
            this.label_multi.Text = "extruder multiplier";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Location = new System.Drawing.Point(23, 132);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(67, 13);
            this.label_temp.TabIndex = 14;
            this.label_temp.Text = "Temperature";
            // 
            // textBox_temp
            // 
            this.textBox_temp.Location = new System.Drawing.Point(23, 151);
            this.textBox_temp.Name = "textBox_temp";
            this.textBox_temp.Size = new System.Drawing.Size(100, 20);
            this.textBox_temp.TabIndex = 4;
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(174, 132);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(67, 13);
            this.label_cost.TabIndex = 15;
            this.label_cost.Text = "Cost for 1 kg";
            // 
            // numericUpDown_cost
            // 
            this.numericUpDown_cost.DecimalPlaces = 2;
            this.numericUpDown_cost.Location = new System.Drawing.Point(174, 151);
            this.numericUpDown_cost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_cost.Name = "numericUpDown_cost";
            this.numericUpDown_cost.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_cost.TabIndex = 5;
            // 
            // label_density
            // 
            this.label_density.AutoSize = true;
            this.label_density.Location = new System.Drawing.Point(26, 185);
            this.label_density.Name = "label_density";
            this.label_density.Size = new System.Drawing.Size(76, 13);
            this.label_density.TabIndex = 16;
            this.label_density.Text = "Density g/cm3";
            // 
            // numericUpDown_density
            // 
            this.numericUpDown_density.DecimalPlaces = 3;
            this.numericUpDown_density.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_density.Location = new System.Drawing.Point(26, 204);
            this.numericUpDown_density.Name = "numericUpDown_density";
            this.numericUpDown_density.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_density.TabIndex = 6;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(48, 242);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(171, 242);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // comboBox_group
            // 
            this.comboBox_group.FormattingEnabled = true;
            this.comboBox_group.Location = new System.Drawing.Point(171, 36);
            this.comboBox_group.Name = "comboBox_group";
            this.comboBox_group.Size = new System.Drawing.Size(103, 21);
            this.comboBox_group.TabIndex = 1;
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Location = new System.Drawing.Point(177, 17);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(36, 13);
            this.label_group.TabIndex = 11;
            this.label_group.Text = "Group";
            // 
            // numericUpDown_ExMulti
            // 
            this.numericUpDown_ExMulti.DecimalPlaces = 3;
            this.numericUpDown_ExMulti.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_ExMulti.Location = new System.Drawing.Point(171, 94);
            this.numericUpDown_ExMulti.Name = "numericUpDown_ExMulti";
            this.numericUpDown_ExMulti.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_ExMulti.TabIndex = 3;
            this.numericUpDown_ExMulti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_defaultDensity
            // 
            this.button_defaultDensity.Location = new System.Drawing.Point(129, 202);
            this.button_defaultDensity.Name = "button_defaultDensity";
            this.button_defaultDensity.Size = new System.Drawing.Size(19, 23);
            this.button_defaultDensity.TabIndex = 20;
            this.button_defaultDensity.Text = "D";
            this.button_defaultDensity.UseVisualStyleBackColor = true;
            this.button_defaultDensity.Click += new System.EventHandler(this.button_defaultDensity_Click);
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
            // addEdit_form
            // 
            this.AcceptButton = this.button_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(303, 280);
            this.Controls.Add(this.button_defaultDensity);
            this.Controls.Add(this.numericUpDown_ExMulti);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.comboBox_group);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_density);
            this.Controls.Add(this.numericUpDown_density);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.numericUpDown_cost);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.textBox_temp);
            this.Controls.Add(this.label_multi);
            this.Controls.Add(this.label_diameter);
            this.Controls.Add(this.numericUpDown_diameter);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.textBox_note);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "addEdit_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add or Edit item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_diameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ExMulti)).EndInit();
            this.contextMenu_density.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.NumericUpDown numericUpDown_diameter;
        private System.Windows.Forms.Label label_diameter;
        private System.Windows.Forms.Label label_multi;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.TextBox textBox_temp;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.NumericUpDown numericUpDown_cost;
        private System.Windows.Forms.Label label_density;
        private System.Windows.Forms.NumericUpDown numericUpDown_density;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox comboBox_group;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.NumericUpDown numericUpDown_ExMulti;
        private System.Windows.Forms.Button button_defaultDensity;
        private System.Windows.Forms.ContextMenuStrip contextMenu_density;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pla;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_abs;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pet;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pc;
    }
}