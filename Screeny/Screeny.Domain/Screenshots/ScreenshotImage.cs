using Screeny.Domain.Common.Constants;

namespace Screeny.Domain.Screenshots
{
    public sealed class ScreenshotImage
    {
        private ScreenshotImage(byte[] image)
        {
            ImageData = image;
        }

        public IReadOnlyCollection<byte> ImageData { get; private set; }

        public static ScreenshotImage FromBytes(byte[] bytes)
        {
            ThrowIfIsNotCorrectImage(bytes);

            return new ScreenshotImage(bytes);
        }

        private static void ThrowIfIsNotCorrectImage(byte[] bytes)
        {
            if (!IsPng(bytes) && !IsJpeg(bytes) && !IsTiff(bytes))
            {
                throw new ArgumentException("The image is not in a correct format.");
            }
        }

        private static bool IsPng(byte[] bytes)
        {
            if (bytes.Length < ImageSignatures.Png.Length)
            {
                return false;
            }

            if (bytes.Take(ImageSignatures.Png.Length).SequenceEqual(ImageSignatures.Png))
            {
                return true;
            }

            return false;
        }

        private static bool IsJpeg(byte[] bytes)
        {
            if (bytes.Length < ImageSignatures.Jpeg.Length)
            {
                return false;
            }

            if (bytes.Take(ImageSignatures.Jpeg.Length).SequenceEqual(ImageSignatures.Jpeg))
            {
                return true;
            }

            return false;

        }

        private static bool IsTiff(byte[] bytes)
        {
            if (bytes.Length < ImageSignatures.Tiff.Length)
            {
                return false;
            }

            if (bytes.Take(ImageSignatures.Tiff.Length).SequenceEqual(ImageSignatures.Tiff))
            {
                return true;
            }

            return false;

        }
    }
}
