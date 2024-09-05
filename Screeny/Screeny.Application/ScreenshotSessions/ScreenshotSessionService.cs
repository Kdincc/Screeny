using Microsoft.Extensions.Options;
using Screeny.Application.Saving;
using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
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
            _sessions.Add(new ScreenshotSession(name, ScreenshotFormat.Png));
        }

        public void RemoveSession(ScreenshotSession session)
        {
            _sessions.Remove(session);
        }

        public void SaveSession(ScreenshotSession session, ImagePath path)
        {
            _saver.Save(session, path);

            if (_options.AllowAutoDeletion)
            {
                RemoveSession(session);
            }
        }

        public void AddScreenshotToSession(ScreenshotSession session, Screenshot screenshot)
        {
            if(_options.AllowAutoNaming)
            {
                screenshot.ChangeTitle($"{session.Name} - {_sessions.Count}");
            }

            session.Add(screenshot);
        }
    }
}
