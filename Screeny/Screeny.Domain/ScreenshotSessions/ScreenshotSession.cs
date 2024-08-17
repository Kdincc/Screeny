using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.ScreenshotStacks
{
    public sealed class ScreenshotSession
    {
        private readonly List<Screenshot> _screenshots = [];

        public ScreenshotSession(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void Add(Screenshot screenshot)
        {
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

        public void SaveAll(ISavingStrategy savingStrategy, ScreenshotPath path)
        {
            _screenshots.ForEach(screenshot => screenshot.Save(savingStrategy, path));
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
