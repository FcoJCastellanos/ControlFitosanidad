using FitosanidadAgroberries.Connection;
using FitosanidadAgroberries.Views;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Application = Xamarin.Forms.Application;

namespace FitosanidadAgroberries
{
    public partial class App : Application
    {
        public string VG_usuario { get; set; }
        public string VG_nombreUsuario { get; set; }

        private static LocalDataBase localDB;
        public static LocalDataBase LocalDB
        {
            get
            {
                if (localDB == null)
                {
                    localDB = new LocalDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DBFITOSANIDADAGROBERRIES.db3"));
                }
                return localDB;
            }
        }

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY4ODc4NUAzMjMyMmUzMDJlMzBwRFV1MndCMGhTMWYrM0xSakRCelRGOVpFS0k5Vi9qVTJRRFBFd1RwcnhvPQ==");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjcxMjU0NUAzMjMzMmUzMDJlMzBjcVc4ZTd2SkNyaUYrZFhrcnR5czNMNEtSbHVCd25qZ1Nmc3J2dWMxNHE4PQ==");
            Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
            InitializeComponent();

            if (VersionTracking.IsFirstLaunchEver)
            {
                MainPage = new MensajePermisos();
            }
            else
            {
                MainPage = new LoginPage();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
