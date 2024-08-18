using Microsoft.Extensions.DependencyInjection;
using Screeny.Application.Saving;

namespace Screeny.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IScreenshotSaver, ScreenshotSaver>();

            return services;
        }
    }
}
