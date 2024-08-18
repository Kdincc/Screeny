using Screeny.Domain.Common;
using System.Drawing;

namespace Screeny.Domain.Screenshots
{
    public sealed class Screenshot
    {
        private readonly ScreenshotImage _image;

        public Screenshot(string title, ScreenshotImage image, Size size, ScreenshotFormat format)
        {
            Title = title;
            _image = image;
            Size = size;
            Format = format;
        }

        public ScreenshotImage Image => _image;

        public ScreenshotFormat Format { get; private set; }

        public string Title { get; private set; }

        public Size Size { get; private set; }

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void ChangeFormat(ScreenshotFormat newFormat)
        {
            Format = newFormat;
        }

        public void Save(ISavingStrategy savingStrategy, Path path)
        {
            savingStrategy.Save(this, path);
        }
    }
}
