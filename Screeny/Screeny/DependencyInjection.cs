using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddScreeny(this IServiceCollection services)
        {
            return services;
        }
    }
}
