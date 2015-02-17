using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;
using System.IO;
using System.Windows.Forms;

namespace FilamentInfo
{
    public class FilamentInfo : IHostPlugin
    {

        IHost host;


        /// Called first to allow filling some lists. Host is not fully set up at that moment.
        public void PreInitalize(IHost _host)
        {
            host = _host;
        }

        /// Called after everything is initalized to finish parts, that rely on other initializations.
        /// Here you must create and register new Controls and Windows.
        public void PostInitialize()
        {
            // load plugin translation file
            string langPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "translations");
            if ( Directory.Exists(langPath) )
                Trans.trans.AddFolder(langPath);

            // load plugin settings from windows registry
            Settings.load_Settings(host);

            
            // Add the settings tab in the repetier host configuration
            SettingsControl SettingsCon = new SettingsControl();
            SettingsCon.Connect(host);
            host.RegisterHostComponent(SettingsCon);


            // Add some info in the about dialog
            host.AboutDialog.RegisterThirdParty(
                "FilamentInfo", "\r\n\r\n FilamentInfo Plugin for Repetier-Host."
                + "\r\n Version: " + Settings.pluginVersion
                + "\r\n Homepage: " + Settings.homepage);


            // if external position is selected add a link in the menu and the event click
            if (Settings.filamentListPos == 2)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(Trans.T("FI_LINKMENU"));
                menuItem.Click += menuItem_Click;

                host.GetMenuFolder(MenuFolder.TOOLS_MENU).DropDownItems.Add(menuItem);
                return;
            }


            // Add the CoolControl to the right tab or in the main area
            FilamentControl cool = new FilamentControl();
            cool.Connect(host, Settings.filamentListPos);
            host.RegisterHostComponent(cool);

        }
        /// Last round of plugin calls. All controls exist, so now you may modify them to your wishes.
        public void FinializeInitialize()
        {
        }


        void menuItem_Click(object sender, System.EventArgs e)
        {
            // Create a new instance of the Form2 class
            External_form externalForm = new External_form(host);

            // Show the settings form
            externalForm.Show();
        }

    }
}
