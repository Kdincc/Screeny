using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.ScreenshotStacks
{
    public sealed class ScreenshotSession
    {
        private readonly List<Screenshot> _screenshots = new();

        public ScreenshotSession(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Add(Screenshot screenshot)
        {
            _screenshots.Add(screenshot);
        }

        public void Remove(Screenshot screenshot)
        {
            _screenshots.Remove(screenshot);
        }

        public void SaveAll(ISavingStrategy savingStrategy, string path)
        {
            _screenshots.ForEach(screenshot => savingStrategy.Save(screenshot, path));
        }
    }
}
