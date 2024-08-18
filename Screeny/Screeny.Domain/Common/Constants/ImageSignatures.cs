namespace Screeny.Domain.Common.Constants
{
    public static class ImageSignatures
    {
        public static readonly byte[] Png = [0x89, 0x50, 0x4E, 0x47];
        public static readonly byte[] Jpeg = [0xFF, 0xD8, 0xFF];
        public static readonly byte[] Tiff = [0x49, 0x49, 0x2A, 0x00];
    }
}
