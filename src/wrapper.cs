using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;

namespace FilamentInfo
{
    public partial class wrapper : UserControl, IHostComponent
    {
        IHost host;

        private int tabPos;

        private string tabName = Trans.T("FI_TABNAME");

        private PreferredComponentPositions _position = PreferredComponentPositions.SIDEBAR;
        

        private ConverterControl ConverteC;

        private FilamentControl filamentC;

        public wrapper()
        {
            InitializeComponent();

        }
        private void wrapper_Load(object sender, EventArgs e)
        {
   
            // Add the calculator control
            if (Settings.showCalculator == 1)
            {
                // Add filament control
                ConverteC = new ConverterControl();
                ConverteC.Location = new System.Drawing.Point(3, 3);
                ConverteC.Name = "ConverteC";
                ConverteC.Size = new System.Drawing.Size(427, 176);
                ConverteC.TabIndex = 0;
                this.Controls.Add(ConverteC);
            }


            // Add the filament contol
            filamentC = new FilamentControl();
            filamentC.Connect(host);
            filamentC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            if (Settings.showCalculator == 1)
            {
                // if calculator control is show sets the right height
                filamentC.Location = new System.Drawing.Point(3, 200);
                filamentC.Size = new System.Drawing.Size(this.Width -4, this.Height - 200);
                // Add a event for get data from listview and add to calculator control
                filamentC.listView_filament.MouseDoubleClick += listView_filament_MouseDoubleClick;
            }
            else
            {
                filamentC.Location = new System.Drawing.Point(3, 3);
                filamentC.Size = new System.Drawing.Size(this.Width -4, this.Height);
            }

            filamentC.Name = "filamentC";
            filamentC.TabIndex = 0;
            this.Controls.Add(filamentC);

        }

        /// <summary>
        /// Send the listview data to the calculator control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void listView_filament_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ConverteC == null)
                return;


            Dictionary<string,decimal> data = new Dictionary<string,decimal>();


            if (filamentC.listView_filament.SelectedItems.Count == 0)
                return;
            ListViewItem item = filamentC.listView_filament.SelectedItems[0];

            data.Add("diameter", Convert.ToDecimal(item.SubItems[1].Text) );
            data.Add("density", Convert.ToDecimal(item.SubItems[5].Text));
            data.Add("cost", Convert.ToDecimal(item.SubItems[4].Text));

            ConverteC.addData(data);
        }


        // IHostComponent implementation
        #region IHostComponent implementation

        public void Connect(IHost _host)
        {
            host = _host;

            tabPos = Settings.TabPos;

            if (Settings.filamentListPos == 1)
                _position = PreferredComponentPositions.MAIN_AREA;
        }

        //Gets called when the component comes into view. For tabs this means when the tab gets selected.
        public void ComponentActivated() { }
        //Associated ThreeDView object to show in the 3d view. Return null for no assiciation. 
        public RepetierHostExtender.geom.ThreeDView Associated3DView { get; set; }
        // Name inside component repository
        public string ComponentName { get { return "FilamentInfo"; } }
        // Name for tab
        public string ComponentDescription { get { return tabName; } }
        // Used for positioning the tab.
        public int ComponentOrder { get { return tabPos; } }
        // Where to add it.
        public PreferredComponentPositions PreferredPosition { get { return _position; } }
        // Return the UserControl.
        public Control ComponentControl { get { return this; } }

        #endregion

    }
}
