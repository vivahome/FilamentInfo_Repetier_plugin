using RepetierHostExtender.interfaces;
using RepetierHostExtender.utils;
using System.IO;


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


            // Add the CoolControl to the right tab
            FilamentControl cool = new FilamentControl();
            cool.Connect(host);
            host.RegisterHostComponent(cool);

            // Add some info in the about dialog
            host.AboutDialog.RegisterThirdParty(
                "FilamentInfo Plugin", "\r\n\r\n FilamentInfo Plugin for Repetier-Host. "
                + "Version: 1.2"
                );

        }
        /// Last round of plugin calls. All controls exist, so now you may modify them to your wishes.
        public void FinializeInitialize()
        {
        }


    }
}
