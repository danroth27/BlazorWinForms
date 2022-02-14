using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlazorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();

            var blazor = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };
            blazor.RootComponents.Add<Counter>("#app");
            Controls.Add(blazor);
        }

    }
}
