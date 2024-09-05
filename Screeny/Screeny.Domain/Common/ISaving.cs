using Screeny.Domain.Screenshots;

namespace Screeny.Domain.Common
{
    public interface ISaving
    {
        public void Save(Screenshot screenshot, ImagePath path);
    }
}
