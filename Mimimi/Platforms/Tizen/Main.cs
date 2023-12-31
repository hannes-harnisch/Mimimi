using Microsoft.Maui;
using Microsoft.Maui.Hosting;

using System;

namespace Mimimi.Tizen {

    internal class Program : MauiApplication {
        protected override MauiApp CreateMauiApp() {
            return MauiProgram.CreateMauiApp();
        }

        static void Main(string[] args) {
            var app = new Program();
            app.Run(args);
        }
    }

}
