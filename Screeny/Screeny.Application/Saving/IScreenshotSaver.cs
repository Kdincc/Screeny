using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using Screeny.Domain.ScreenshotStacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving
{
    public interface IScreenshotSaver
    {
        public SavingResult Save(Screenshot screenshot, Path path);

        public SavingResult Save(ScreenshotSession screenshotStack, Path path);
    }
}
