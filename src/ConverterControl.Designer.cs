namespace FilamentInfo
{
    partial class ConverterControl
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
            this.groupBox_converter = new System.Windows.Forms.GroupBox();
            this.comboBox_unity = new System.Windows.Forms.ComboBox();
            this.button_defaultDensity = new System.Windows.Forms.Button();
            this.label_length = new System.Windows.Forms.Label();
            this.label_resultCost = new System.Windows.Forms.Label();
            this.numericUD_density = new System.Windows.Forms.NumericUpDown();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.label_density = new System.Windows.Forms.Label();
            this.numericUD_cost = new System.Windows.Forms.NumericUpDown();
            this.numericUD_length = new System.Windows.Forms.NumericUpDown();
            this.label_diameter = new System.Windows.Forms.Label();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_weight = new System.Windows.Forms.Label();
            this.numericUD_diameter = new System.Windows.Forms.NumericUpDown();
            this.label_result = new System.Windows.Forms.Label();
            this.contextMenu_density = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_pla = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_abs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_pc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_converter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_diameter)).BeginInit();
            this.contextMenu_density.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_converter
            // 
            this.groupBox_converter.Controls.Add(this.comboBox_unity);
            this.groupBox_converter.Controls.Add(this.button_defaultDensity);
            this.groupBox_converter.Controls.Add(this.label_length);
            this.groupBox_converter.Controls.Add(this.label_resultCost);
            this.groupBox_converter.Controls.Add(this.numericUD_density);
            this.groupBox_converter.Controls.Add(this.label_totalCost);
            this.groupBox_converter.Controls.Add(this.label_cost);
            this.groupBox_converter.Controls.Add(this.label_density);
            this.groupBox_converter.Controls.Add(this.numericUD_cost);
            this.groupBox_converter.Controls.Add(this.numericUD_length);
            this.groupBox_converter.Controls.Add(this.label_diameter);
            this.groupBox_converter.Controls.Add(this.button_convert);
            this.groupBox_converter.Controls.Add(this.label_weight);
            this.groupBox_converter.Controls.Add(this.numericUD_diameter);
            this.groupBox_converter.Controls.Add(this.label_result);
            this.groupBox_converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.786407F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_converter.Location = new System.Drawing.Point(0, 1);
            this.groupBox_converter.Name = "groupBox_converter";
            this.groupBox_converter.Size = new System.Drawing.Size(427, 176);
            this.groupBox_converter.TabIndex = 21;
            this.groupBox_converter.TabStop = false;
            this.groupBox_converter.Text = "Converter";
            // 
            // comboBox_unity
            // 
            this.comboBox_unity.FormattingEnabled = true;
            this.comboBox_unity.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.comboBox_unity.Location = new System.Drawing.Point(190, 39);
            this.comboBox_unity.Name = "comboBox_unity";
            this.comboBox_unity.Size = new System.Drawing.Size(47, 25);
            this.comboBox_unity.TabIndex = 20;
            this.comboBox_unity.Text = "mm";
            this.comboBox_unity.SelectedIndexChanged += new System.EventHandler(this.comboBox_unity_SelectedIndexChanged);
            // 
            // button_defaultDensity
            // 
            this.button_defaultDensity.Location = new System.Drawing.Point(152, 97);
            this.button_defaultDensity.Name = "button_defaultDensity";
            this.button_defaultDensity.Size = new System.Drawing.Size(19, 23);
            this.button_defaultDensity.TabIndex = 19;
            this.button_defaultDensity.Text = "D";
            this.button_defaultDensity.UseVisualStyleBackColor = true;
            this.button_defaultDensity.Click += new System.EventHandler(this.button_defaultDensity_Click);
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_length.Location = new System.Drawing.Point(38, 19);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(108, 17);
            this.label_length.TabIndex = 6;
            this.label_length.Text = "Filament length:";
            // 
            // label_resultCost
            // 
            this.label_resultCost.AutoSize = true;
            this.label_resultCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultCost.Location = new System.Drawing.Point(332, 154);
            this.label_resultCost.Name = "label_resultCost";
            this.label_resultCost.Size = new System.Drawing.Size(31, 17);
            this.label_resultCost.TabIndex = 18;
            this.label_resultCost.Text = "0 $";
            this.label_resultCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUD_density
            // 
            this.numericUD_density.DecimalPlaces = 3;
            this.numericUD_density.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUD_density.Location = new System.Drawing.Point(63, 98);
            this.numericUD_density.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUD_density.Name = "numericUD_density";
            this.numericUD_density.Size = new System.Drawing.Size(83, 23);
            this.numericUD_density.TabIndex = 1;
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalCost.Location = new System.Drawing.Point(272, 153);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(40, 17);
            this.label_totalCost.TabIndex = 17;
            this.label_totalCost.Text = "Cost:";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cost.Location = new System.Drawing.Point(279, 18);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(92, 17);
            this.label_cost.TabIndex = 16;
            this.label_cost.Text = "Cost for 1 kg:";
            // 
            // label_density
            // 
            this.label_density.AutoSize = true;
            this.label_density.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_density.Location = new System.Drawing.Point(60, 78);
            this.label_density.Name = "label_density";
            this.label_density.Size = new System.Drawing.Size(116, 17);
            this.label_density.TabIndex = 3;
            this.label_density.Text = "Density in g/cm3:";
            // 
            // numericUD_cost
            // 
            this.numericUD_cost.DecimalPlaces = 1;
            this.numericUD_cost.Location = new System.Drawing.Point(282, 39);
            this.numericUD_cost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUD_cost.Name = "numericUD_cost";
            this.numericUD_cost.Size = new System.Drawing.Size(76, 23);
            this.numericUD_cost.TabIndex = 14;
            // 
            // numericUD_length
            // 
            this.numericUD_length.Location = new System.Drawing.Point(30, 39);
            this.numericUD_length.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUD_length.Name = "numericUD_length";
            this.numericUD_length.Size = new System.Drawing.Size(154, 23);
            this.numericUD_length.TabIndex = 4;
            // 
            // label_diameter
            // 
            this.label_diameter.AutoSize = true;
            this.label_diameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diameter.Location = new System.Drawing.Point(279, 77);
            this.label_diameter.Name = "label_diameter";
            this.label_diameter.Size = new System.Drawing.Size(110, 17);
            this.label_diameter.TabIndex = 13;
            this.label_diameter.Text = "Diameter in mm:";
            // 
            // button_convert
            // 
            this.button_convert.AutoSize = true;
            this.button_convert.Location = new System.Drawing.Point(12, 140);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(75, 31);
            this.button_convert.TabIndex = 7;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weight.Location = new System.Drawing.Point(111, 153);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(56, 17);
            this.label_weight.TabIndex = 8;
            this.label_weight.Text = "Weight:";
            // 
            // numericUD_diameter
            // 
            this.numericUD_diameter.DecimalPlaces = 3;
            this.numericUD_diameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUD_diameter.Location = new System.Drawing.Point(282, 97);
            this.numericUD_diameter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUD_diameter.Name = "numericUD_diameter";
            this.numericUD_diameter.Size = new System.Drawing.Size(76, 23);
            this.numericUD_diameter.TabIndex = 11;
            this.numericUD_diameter.Value = new decimal(new int[] {
            175,
            0,
            0,
            131072});
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(171, 153);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(31, 17);
            this.label_result.TabIndex = 10;
            this.label_result.Text = "0 g";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // ConverterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_converter);
            this.Name = "ConverterControl";
            this.Size = new System.Drawing.Size(430, 180);
            this.Load += new System.EventHandler(this.ConverterControl_Load);
            this.groupBox_converter.ResumeLayout(false);
            this.groupBox_converter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_diameter)).EndInit();
            this.contextMenu_density.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_converter;
        private System.Windows.Forms.ComboBox comboBox_unity;
        private System.Windows.Forms.Button button_defaultDensity;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_resultCost;
        private System.Windows.Forms.NumericUpDown numericUD_density;
        private System.Windows.Forms.Label label_totalCost;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label_density;
        private System.Windows.Forms.NumericUpDown numericUD_cost;
        private System.Windows.Forms.NumericUpDown numericUD_length;
        private System.Windows.Forms.Label label_diameter;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.NumericUpDown numericUD_diameter;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.ContextMenuStrip contextMenu_density;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pla;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_abs;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pet;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_pc;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
