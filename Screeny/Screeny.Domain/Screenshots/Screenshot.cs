using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.Screenshots
{
    public sealed class Screenshot
    {
        private readonly byte[] _image;

        public Screenshot(string title, byte[] image, Size size, ScreenshotFormat format)
        {
            Title = title;
            _image = image;
            Size = size;
            Format = format;
        }

        public IReadOnlyCollection<byte> Image => _image;

        public ScreenshotFormat Format { get; private set; }

        public string Title { get; private set; } 

        public Size Size { get; private set; }
    }
}
