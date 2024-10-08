﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Domain.Common
{
    public readonly struct ScreenshotPath
    {
        private readonly string _path;

        private ScreenshotPath(string path)
        {
            _path = path;
        }

        public string Value => _path;

        public static ScreenshotPath Create(string path)
        {
            char[] invalidChars = Path.GetInvalidPathChars();

            ThrowIfContainsInvalidChars(path);
            ThrowIfIsNullOrWhitespace(path);
            ThrowIfPathIsTooLong(path);
            ThrowIfPathIsNotRooted(path);

            return new ScreenshotPath(path);
        }

        public static void ThrowIfIsNullOrWhitespace(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be null or whitespace", nameof(path));
            }
        }

        public static void ThrowIfContainsInvalidChars(string path)
        {
            char[] invalidChars = Path.GetInvalidPathChars();

            if (path.Any(c => invalidChars.Contains(c)))
            {
                throw new ArgumentException("Path contains invalid characters", nameof(path));
            }
        }

        public static void ThrowIfPathIsTooLong(string path)
        {
            if (path.Length > 260)
            {
                throw new ArgumentException("Path is too long", nameof(path));
            }
        }

        public static void ThrowIfPathIsNotRooted(string path)
        {
            if (!Path.IsPathRooted(path))
            {
                throw new ArgumentException("The path format is invalid", nameof(path));
            }
        }


    }
}
