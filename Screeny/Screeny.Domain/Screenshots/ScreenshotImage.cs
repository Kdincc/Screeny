using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.Screenshots
{
    public sealed class ScreenshotImage
    {
        private ScreenshotImage(byte[] image)
        {
            ImageData = image;
        }

        public byte[] ImageData { get; private set; }

        public static ScreenshotImage FromBytes(byte[] bytes)
        {

        }
    }
}
