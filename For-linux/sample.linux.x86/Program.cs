using System;
using System.Windows;
using System.Windows.Forms;
using ChromiumFX;
using ChromiumFX.Extension;
using Chromium;
using Chromium.WebBrowser;
using System.IO;

namespace ceftestf
{
    class MainClass
    {
        public static void Main(string[] args){

 
            var basepath = Environment.CurrentDirectory;
 

   //         var cefPath = System.IO.Path.Combine(basepath, "mycef");
   //         var cfxPath = System.IO.Path.Combine(basepath, "mycef");

   //         ChromiumStartup.LibCefPath = cefPath;
   //         ChromiumStartup.LibCfxPath = cfxPath;

			//ChromiumStartup.CefResourcePath = Path.Combine(basepath, "mycef");// or Path.Combine(basePath, "cef","Resource");

			ChromiumStartup.Initialize();


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
        }
    }
}
