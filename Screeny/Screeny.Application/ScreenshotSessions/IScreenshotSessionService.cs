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
    public interface IScreenshotSessionService
    {
        public void CreateSession(string name);

        public void RemoveSession(ScreenshotSession session);

        public void SaveSession(ScreenshotSession session, ImagePath path);

        public void AddScreenshotToSession(ScreenshotSession session, Screenshot screenshot);
    }
}
