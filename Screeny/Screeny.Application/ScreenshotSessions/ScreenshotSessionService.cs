using Microsoft.Extensions.Options;
using Screeny.Application.Saving;
using Screeny.Domain.Common;
using Screeny.Domain.ScreenshotStacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.ScreenshotSessions
{
    public sealed class ScreenshotSessionService : IScreenshotSessionService
    {
        private readonly List<ScreenshotSession> _sessions = [];
        private readonly ScreenshotSessionServiceOptions _options;
        private readonly IScreenshotSaver _saver;

        public ScreenshotSessionService(IOptions<ScreenshotSessionServiceOptions> options, IScreenshotSaver saver)
        {
            _saver = saver;
            _options = options.Value;
        }

        public void CreateSession(string name)
        {
            _sessions.Add(new ScreenshotSession(name));
        }

        public void RemoveSession(ScreenshotSession session)
        {
            _sessions.Remove(session);
        }

        public void SaveSession(ScreenshotSession session, Path path)
        {
        }
    }
}
