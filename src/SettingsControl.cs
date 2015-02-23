using System;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;

namespace FilamentInfo
{
    public partial class SettingsControl : UserControl, IHostComponent, IHostConfig
    {

        private IHost host;
        private bool _controlLoaded = false;


        public SettingsControl()
        {
            InitializeComponent();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {

            load_Translations();

            comboBox_pos.SelectedIndex = Settings.filamentListPos;

            linkLabel_version.Text += Settings.pluginVersion;

            numericUpDown_tabPos.Value = Convert.ToDecimal(Settings.TabPos / 1000 + 1);

            comboBox_showCalc.SelectedIndex = Settings.showCalculator;

            _controlLoaded = true;
        }


        #region IHostComponent implementation

        public void Connect(IHost _host) { host = _host; }

        // Name inside component repository
        public string ComponentName { get { return "FilamentInfoSettings"; } }
        // Name for tab
        public string ComponentDescription { get { return "Filament Info"; } }
        // Where to add it.
        public PreferredComponentPositions PreferredPosition
        {
            get { return PreferredComponentPositions.CONFIGURATION; }
        }

        //Gets called when the component comes into view. For tabs this means when the tab gets selected.
        // not called for PreferredComponentPositions.CONFIGURATION ?!?
        public void ComponentActivated() { }

        //Associated ThreeDView object to show in the 3d view. Return null for no assiciation. 
        public RepetierHostExtender.geom.ThreeDView Associated3DView { get; set; }

        // Used for positioning the tab.
        public int ComponentOrder { get { return 8000; } }

        // Return the UserControl.
        public Control ComponentControl { get { return this; } }

        #endregion

        #region IHostConfig  implementation

        //Gets called, when the configuration panel gets closed. Use this to store your configuration data. 
        // If preference form is closed befor the plugin tab is selected Connect() is not called.
        public void ComponentDeactivated()
        {
            saveSettings();
        }
        //Returns icon for the left list. Size should be 32x32 pixel. Can be null. 
        public ImageList ComponentIconList { get { return null; } }

        public bool CanClose { get { return true; } }

        #endregion

        private void saveSettings()
        {
            if (!_controlLoaded)
                return;

            IRegMemoryFolder Ireg = host.GetRegistryFolder("FilamentInfo_plugin");


            Ireg.SetInt("filamentListPos", comboBox_pos.SelectedIndex);

            int tabPos = (Convert.ToInt32(numericUpDown_tabPos.Value) - 1) * 1000;
            Ireg.SetInt("TabPos", tabPos);


            Ireg.SetInt("showCalculator", comboBox_showCalc.SelectedIndex);
        }

        // Open the plugin home page
        private void linkLabel_version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            host.OpenLink(Settings.homepage);
        }

        private void load_Translations()
        {


            label_tabPos.Text = Trans.T("FI_L_TABPOS");
            label_tabHelp .Text =  Trans.T("FI_L_TABHELP");


            label_position.Text = Trans.T("FI_L_PLUGINPOS");
            label_positionHelp.Text = Trans.T("FI_L_POSITIONHELP");

            label_showCalc.Text = Trans.T("FI_L_SHOWCALC");
            label_showCalcHelp.Text = Trans.T("FI_L_SHOWCALCHELP");
            //showCalcHelp

            label_restart.Text = Trans.T("FI_L_RESTART");

            toolTip.SetToolTip(numericUpDown_tabPos, Trans.T("FI_TABPOS_TOOL"));
            toolTip.SetToolTip(comboBox_pos, Trans.T("FI_PLUGINPOS_TOOL"));
        }
    }
}
