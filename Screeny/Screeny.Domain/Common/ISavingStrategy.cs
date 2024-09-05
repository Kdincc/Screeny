using Screeny.Domain.Screenshots;

namespace Screeny.Domain.Common
{
    public interface ISavingStrategy
    {
        public void Save(Screenshot screenshot, ImagePath path);
    }
}
