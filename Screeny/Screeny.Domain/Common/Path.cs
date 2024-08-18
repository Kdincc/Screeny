using System.IO;

namespace Screeny.Domain.Common
{
    public readonly struct Path
    {
        private readonly string _path;

        private Path(string path)
        {
            _path = path;
        }

        public string Value => _path;

        public static Path Create(string path)
        {
            ThrowIfContainsInvalidChars(path);
            ThrowIfIsNullOrWhitespace(path);
            ThrowIfPathIsTooLong(path);
            ThrowIfPathIsNotRooted(path);

            return new Path(path);
        }

        private static void ThrowIfIsNullOrWhitespace(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("Path cannot be null or whitespace", nameof(path));
            }
        }

        private static void ThrowIfContainsInvalidChars(string path)
        {
            char[] invalidChars = System.IO.Path.GetInvalidPathChars();

            if (path.Any(c => invalidChars.Contains(c)))
            {
                throw new ArgumentException("Path contains invalid characters", nameof(path));
            }
        }

        private static void ThrowIfPathIsTooLong(string path)
        {
            if (path.Length > 260)
            {
                throw new ArgumentException("Path is too long", nameof(path));
            }
        }

        private static void ThrowIfPathIsNotRooted(string path)
        {
            if (!System.IO.Path.IsPathRooted(path))
            {
                throw new ArgumentException("The path format is invalid", nameof(path));
            }
        }

        public static implicit operator string(Path path) => path.Value;

        public static implicit operator Path(string path) => Create(path);
    }
}
