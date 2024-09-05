using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Screeny
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddScreeny(this IServiceCollection services, ResourceDictionary appResources)
        {
            services.AddWpfBlazorWebView();
            appResources.Add("services", services.BuildServiceProvider());

            return services;
        }
    }
}
