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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.imageList_menuIcon = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel_version = new System.Windows.Forms.LinkLabel();
            this.label_title = new System.Windows.Forms.Label();
            this.comboBox_pos = new System.Windows.Forms.ComboBox();
            this.label_tabPos = new System.Windows.Forms.Label();
            this.numericUpDown_tabPos = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_position = new System.Windows.Forms.Label();
            this.label_positionHelp = new System.Windows.Forms.Label();
            this.label_tabHelp = new System.Windows.Forms.Label();
            this.label_restart = new System.Windows.Forms.Label();
            this.label_showCalc = new System.Windows.Forms.Label();
            this.comboBox_showCalc = new System.Windows.Forms.ComboBox();
            this.label_showCalcHelp = new System.Windows.Forms.Label();
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
            "Right",
            "Main",
            "External"});
            this.comboBox_pos.Location = new System.Drawing.Point(157, 102);
            this.comboBox_pos.Name = "comboBox_pos";
            this.comboBox_pos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pos.TabIndex = 14;
            // 
            // label_tabPos
            // 
            this.label_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_tabPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tabPos.Location = new System.Drawing.Point(3, 223);
            this.label_tabPos.Name = "label_tabPos";
            this.label_tabPos.Size = new System.Drawing.Size(135, 18);
            this.label_tabPos.TabIndex = 24;
            this.label_tabPos.Text = "Tab position:";
            this.label_tabPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_tabPos
            // 
            this.numericUpDown_tabPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_tabPos.Location = new System.Drawing.Point(153, 223);
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
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(6, 105);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(132, 18);
            this.label_position.TabIndex = 25;
            this.label_position.Text = "Plugin Position";
            this.label_position.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_positionHelp
            // 
            this.label_positionHelp.AutoSize = true;
            this.label_positionHelp.Location = new System.Drawing.Point(62, 135);
            this.label_positionHelp.Name = "label_positionHelp";
            this.label_positionHelp.Size = new System.Drawing.Size(337, 52);
            this.label_positionHelp.TabIndex = 26;
            this.label_positionHelp.Text = resources.GetString("label_positionHelp.Text");
            // 
            // label_tabHelp
            // 
            this.label_tabHelp.AutoSize = true;
            this.label_tabHelp.Location = new System.Drawing.Point(200, 230);
            this.label_tabHelp.Name = "label_tabHelp";
            this.label_tabHelp.Size = new System.Drawing.Size(265, 13);
            this.label_tabHelp.TabIndex = 27;
            this.label_tabHelp.Text = "Select the Tab position, 1 is the first tab on the left side";
            // 
            // label_restart
            // 
            this.label_restart.AutoSize = true;
            this.label_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_restart.Location = new System.Drawing.Point(62, 452);
            this.label_restart.Name = "label_restart";
            this.label_restart.Size = new System.Drawing.Size(374, 17);
            this.label_restart.TabIndex = 28;
            this.label_restart.Text = "*you must restart repetier host to see the changes";
            // 
            // label_showCalc
            // 
            this.label_showCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.087379F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_showCalc.Location = new System.Drawing.Point(6, 319);
            this.label_showCalc.Name = "label_showCalc";
            this.label_showCalc.Size = new System.Drawing.Size(132, 18);
            this.label_showCalc.TabIndex = 30;
            this.label_showCalc.Text = "Show Calculator";
            this.label_showCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_showCalc
            // 
            this.comboBox_showCalc.FormattingEnabled = true;
            this.comboBox_showCalc.Items.AddRange(new object[] {
            "None",
            "Show",
            "External form"});
            this.comboBox_showCalc.Location = new System.Drawing.Point(157, 316);
            this.comboBox_showCalc.Name = "comboBox_showCalc";
            this.comboBox_showCalc.Size = new System.Drawing.Size(121, 21);
            this.comboBox_showCalc.TabIndex = 29;
            // 
            // label_showCalcHelp
            // 
            this.label_showCalcHelp.AutoSize = true;
            this.label_showCalcHelp.Location = new System.Drawing.Point(62, 355);
            this.label_showCalcHelp.Name = "label_showCalcHelp";
            this.label_showCalcHelp.Size = new System.Drawing.Size(363, 52);
            this.label_showCalcHelp.TabIndex = 31;
            this.label_showCalcHelp.Text = resources.GetString("label_showCalcHelp.Text");
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_showCalcHelp);
            this.Controls.Add(this.label_showCalc);
            this.Controls.Add(this.comboBox_showCalc);
            this.Controls.Add(this.label_restart);
            this.Controls.Add(this.label_tabHelp);
            this.Controls.Add(this.label_positionHelp);
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
        private System.Windows.Forms.Label label_positionHelp;
        private System.Windows.Forms.Label label_tabHelp;
        private System.Windows.Forms.Label label_restart;
        private System.Windows.Forms.Label label_showCalc;
        private System.Windows.Forms.ComboBox comboBox_showCalc;
        private System.Windows.Forms.Label label_showCalcHelp;
    }
}
