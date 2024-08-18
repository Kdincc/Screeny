using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving
{
    public sealed class SavingResult
    {
        public bool Success { get; }
        public string Message { get; }

        public SavingResult(bool success, string message = "Success")
        {
            Success = success;
            Message = message;
        }
    }
}
