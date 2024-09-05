﻿using Screeny.Domain.Common;
using Screeny.Domain.Screenshots;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving.SavingStrategies
{
    public sealed class TiffSavingStrategy : ISavingStrategy
    {
        public void Save(Screenshot screenshot, ImagePath path)
        {
            using MemoryStream memoryStream = new([.. screenshot.Image.ImageData]);
            using Image image = Image.FromStream(memoryStream);

            image.Save(path, ImageFormat.Tiff);
        }
    }
}
