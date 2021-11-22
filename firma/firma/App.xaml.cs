using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using firma.Controller;
using firma.View;
using System.IO;

namespace firma
{
    public partial class App : Application
    {

        static BaseSQLite basedato;
        public static BaseSQLite Basedatos
        {
            get
            {

                if (basedato == null)
                {
                    basedato = new BaseSQLite(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "firma.db3"));
                }

                return basedato;

            }
            set { }

        }
       


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
