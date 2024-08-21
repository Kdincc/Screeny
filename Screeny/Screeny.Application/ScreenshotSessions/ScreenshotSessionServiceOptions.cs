using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Screeny.Application.ScreenshotSessions
{
    public sealed class ScreenshotSessionServiceOptions
    {
        public bool AllowAutoNaming { get; set; }

        public bool AllowAutoDeletion { get; set; }
    }
}
