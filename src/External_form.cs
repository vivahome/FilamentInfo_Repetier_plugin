using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;

namespace FilamentInfo
{
    public partial class External_form : Form
    {
        private wrapper wrapp;

        private ConverterControl ConverteC;

        /// <summary>
        /// COSTRUCTOR open only calculator
        /// </summary>
        public External_form()
        {

            InitializeComponent();

            this.Text = Trans.T("FI_FORMTITLECALC");
            // 430; 180
            this.Size = new System.Drawing.Size(460, 230);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;


            // Add converter control
            ConverteC = new ConverterControl();
            ConverteC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            // ConverteC.Associated3DView = null;
            ConverteC.Location = new System.Drawing.Point(3, 3);
            ConverteC.Name = "ConverteC";
            ConverteC.Size = new System.Drawing.Size(427, 176);
            ConverteC.TabIndex = 0;
            this.Controls.Add(ConverteC);

        }

        /// <summary>
        /// COSTRUCTOR open filaments list and calculator
        /// </summary>
        public External_form(IHost _host)
        {

            InitializeComponent();

            this.Text = Trans.T("FI_FORMTITLE");

            // Add filament control
            wrapp = new wrapper();
            wrapp.Connect(_host);
            wrapp.Associated3DView = null;
            wrapp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            wrapp.Location = new System.Drawing.Point(3, 3);
            wrapp.Name = "ConverteC";
            wrapp.Size = new System.Drawing.Size(this.Width - 22, this.Height - 35);
            wrapp.TabIndex = 0;
            this.Controls.Add(wrapp);

        }

    }
}
