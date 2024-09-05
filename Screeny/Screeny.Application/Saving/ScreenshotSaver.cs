using Screeny.Application.Saving.SavingStrategies;
using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using Screeny.Domain.ScreenshotStacks;
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

        public SavingResult Save(Screenshot screenshot, ImagePath path)
        {
            if (_savingStrategies.TryGetValue(screenshot.Format, out ISavingStrategy savingStrategy))
            {
                savingStrategy.Save(screenshot, path);

                return SavingResult.Success;    
            }

            return new SavingResult(false, "Unsupported format");
        }

        public SavingResult Save(ScreenshotSession screenshotStack, ImagePath path)
        {
            if(_savingStrategies.TryGetValue(screenshotStack.ScreenshotsFormat, out ISavingStrategy savingStrategy))
            {
                screenshotStack.SaveAll(savingStrategy, path);

                return SavingResult.Success;
            }

            return new SavingResult(false, "Unsupported format");
        }
    }
}
