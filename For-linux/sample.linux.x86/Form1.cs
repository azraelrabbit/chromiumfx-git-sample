using System;
using System.Windows;
using System.Windows.Forms;
using ChromiumFX;
using ChromiumFX.Extension;
using Chromium.WebBrowser;

namespace ceftestf
{
    public class Form1:System.Windows.Forms.Form
    {

        ChromiumWebBrowser browser;

        public Form1()
        {
            this.Width = 900;
            this.Height = 700;
            this.InitLayout();

             
        }

           protected override void OnLoad(EventArgs e)
        {
            //base.OnLoad(e);

            browser = new ChromiumWebBrowser("https://www.baidu.com", this);

            browser.Dock = DockStyle.Fill;


            browser.LoadUrl("http://www.baidu.com/");
                                
        }
    }
}
