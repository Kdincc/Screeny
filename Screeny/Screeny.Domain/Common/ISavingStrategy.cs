using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screeny.Domain.Screenshots;

namespace Screeny.Domain.Common
{
    public interface ISavingStrategy
    {
        public void Save(Screenshot screenshot, ScreenshotPath path);
    }
}
