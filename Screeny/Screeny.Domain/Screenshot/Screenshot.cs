using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.Screenshot
{
    public sealed class Screenshot(string title, byte[] image, Size size, ScreenshotFormat format)
    {
        public ScreenshotFormat Format { get; private set; } = format;

        public byte[] Image { get; private set; } = image;

        public string Title { get; private set; } = title;

        public Size Size { get; private set; } = size;
    }
}
