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
    }
}
