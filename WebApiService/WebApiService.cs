using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WebApiService
{
    public partial class WebApiService : ServiceBase
    {
        public WebApiService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            WebApp.Start<OwinSelfhostSample.Startup>(url: baseAddress);
        }

        protected override void OnStop()
        {
        }
    }
}
