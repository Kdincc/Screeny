using Microsoft.Extensions.Hosting;
using Screeny.Application;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Screeny
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly IHost _host;

        public App()
        {
            var hostBuilder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services
                    .AddApplication()
                    .AddScreeny();
                });

            _host = hostBuilder.Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _host.Start();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.Dispose();

            base.OnExit(e);
        }
    }

}
