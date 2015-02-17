namespace FilamentInfo
{
    partial class SettingsControl
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
            this.imageList_menuIcon = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_pos = new System.Windows.Forms.ComboBox();
            this.label_tabPos = new System.Windows.Forms.Label();
            this.numericUpDown_tabPos = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tabPos)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_menuIcon
            // 
            this.imageList_menuIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_menuIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_menuIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // linkLabel_version
            // 
            this.linkLabel_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_version.AutoSize = true;
            this.linkLabel_version.Location = new System.Drawing.Point(488, 23);
            this.linkLabel_version.Name = "linkLabel_version";
            this.linkLabel_version.Size = new System.Drawing.Size(48, 13);
            this.linkLabel_version.TabIndex = 12;
            this.linkLabel_version.TabStop = true;
            this.linkLabel_version.Text = "Version: ";
            this.linkLabel_version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_version_LinkClicked);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.18447F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_title.Location = new System.Drawing.Point(149, 52);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(247, 20);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "Filament Info plugin settings";
            // 
            // comboBox_pos
            // 
            this.comboBox_pos.FormattingEnabled = true;
            this.comboBox_pos.Items.AddRange(new object[] {
            "Tab",
            "Main",
            "External"});
            this.comboBox_pos.Location = new System.Drawing.Point(153, 191);
            this.comboBox_pos.Name = "comboBox_pos";
            this.comboBox_pos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pos.TabIndex = 14;
            // 
            // label_tabPos
            // 
            this.label_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_tabPos.Location = new System.Drawing.Point(55, 247);
            this.label_tabPos.Name = "label_tabPos";
            this.label_tabPos.Size = new System.Drawing.Size(83, 18);
            this.label_tabPos.TabIndex = 24;
            this.label_tabPos.Text = "Tab position:";
            this.label_tabPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_tabPos
            // 
            this.numericUpDown_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_tabPos.Location = new System.Drawing.Point(153, 247);
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
            this.numericUpDown_tabPos.TabIndex = 23;
            this.numericUpDown_tabPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(58, 194);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(76, 13);
            this.label_position.TabIndex = 25;
            this.label_position.Text = "Plugin Position";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_tabPos);
            this.Controls.Add(this.numericUpDown_tabPos);
            this.Controls.Add(this.comboBox_pos);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.linkLabel_version);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(605, 516);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tabPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList_menuIcon;
        private System.Windows.Forms.LinkLabel linkLabel_version;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBox_pos;
        private System.Windows.Forms.Label label_tabPos;
        private System.Windows.Forms.NumericUpDown numericUpDown_tabPos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_position;
    }
}
