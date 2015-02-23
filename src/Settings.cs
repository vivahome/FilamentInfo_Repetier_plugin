using RepetierHostExtender.interfaces;

namespace FilamentInfo
{
    internal static class Settings
    {

        // plugin version
        public const string pluginVersion = "1.3";
        // Plugin home page
        public const string homepage = "https://github.com/BrOncOVu/FilamentInfo_Repetier_plugin";

        /// <summary>
        /// 0: sidebar 1: main 2: external
        /// </summary>
        public static int filamentListPos = 0;

        public static int TabPos = 8000;

        /// <summary>
        /// 0: none; 1: show; 2: Show external
        /// </summary>
        public static int showCalculator = 1;


        /// <summary>
        /// Load all settings from the registry
        /// </summary>
        /// <param name="_host">IHost</param>
        public static void load_Settings(IHost _host)
        {
            IRegMemoryFolder Ireg = _host.GetRegistryFolder("FilamentInfo_plugin");

            // Taskbar icon
            filamentListPos = Ireg.GetInt("filamentListPos", 0);

            TabPos = Ireg.GetInt("TabPos", 8000);

            showCalculator = Ireg.GetInt("showCalculator", 1);

        }

    }
}
