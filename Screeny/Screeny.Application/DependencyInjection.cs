using Microsoft.Extensions.DependencyInjection;
using Screeny.Application.Saving;
using Screeny.Application.ScreenshotSessions;

namespace Screeny.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IScreenshotSaver, ScreenshotSaver>();
            services.AddTransient<IScreenshotSessionService, ScreenshotSessionService>();

            return services;
        }
    }
}
