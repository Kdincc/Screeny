using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving
{
    public interface IScreenshotSaver
    {
        public void Save(Screenshot screenshot, ScreenshotPath path);
    }
}
