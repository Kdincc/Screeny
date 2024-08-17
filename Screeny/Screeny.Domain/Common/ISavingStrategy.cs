using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screeny.Domain.Screenshot;

namespace Screeny.Domain.Common
{
    public interface ISavingStrategy
    {
        public void Save(Screenshot screenshot, string path);
    }
}
