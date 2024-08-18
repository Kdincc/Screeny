using Screeny.Application.Saving.SavingStrategies;
using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving
{
    public sealed class ScreenshotSaver : IScreenshotSaver
    {
        private readonly Dictionary<ScreenshotFormat, ISavingStrategy> _savingStrategies;

        public ScreenshotSaver()
        {
            _savingStrategies = new()
            {
                { ScreenshotFormat.Tiff, new TiffSavingStrategy() },
                { ScreenshotFormat.Png, new PngSavingStrategy() },
                { ScreenshotFormat.Jpeg, new JpegSavingStrategy() }
            };
        }

        public void Save(Screenshot screenshot, ScreenshotPath path)
        {
            if (_savingStrategies.TryGetValue(screenshot.Format, out ISavingStrategy savingStrategy))
            {
                savingStrategy.Save(screenshot, path);
            }
        }
    }
}
