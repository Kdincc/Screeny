using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;

namespace Screeny.Domain.ScreenshotStacks
{
    public sealed class ScreenshotSession
    {
        private readonly List<Screenshot> _screenshots = [];

        public ScreenshotSession(string name, ScreenshotFormat screenshotFormat)
        {
            Name = name;
            ScreenshotsFormat = screenshotFormat;
        }

        public string Name { get; private set; }

        public IReadOnlyList<Screenshot> Screenshots => _screenshots;

        public ScreenshotFormat ScreenshotsFormat { get; private set; }

        public void Add(Screenshot screenshot)
        {
            if (screenshot.Format != ScreenshotsFormat)
            {

               throw new InvalidOperationException("Screenshot format does not match the session format");
            }

            _screenshots.Add(screenshot);
        }

        public void Remove(Screenshot screenshot)
        {
            _screenshots.Remove(screenshot);
        }

        public void Clear()
        {
            _screenshots.Clear();
        }

        public void SaveAll(ISavingStrategy savingStrategy, Path path)
        {
            _screenshots.ForEach(screenshot => screenshot.Save(savingStrategy, path));
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
