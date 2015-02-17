using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;

namespace FilamentInfo
{
    public partial class External_form : Form
    {


        private FilamentControl FControl;


        public External_form(IHost _host)
        {


            InitializeComponent();

            this.Text = Trans.T("FI_FORMTITLE");

            // Add filament control
            FControl = new FilamentControl();
            FControl.Connect(_host);
            FControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            FControl.Associated3DView = null;
            FControl.Location = new System.Drawing.Point(1, 1);
            FControl.Name = "FControl";
            FControl.Size = new System.Drawing.Size(513, 592);
            FControl.TabIndex = 0;
            this.Controls.Add(FControl);

        }
    }
}
