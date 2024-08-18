using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screeny.Application.Saving
{
    public sealed class SavingResult
    {
        public static SavingResult Success => new(true, string.Empty);
        public string Message { get; }

        public bool IsSuccess { get; }

        public SavingResult(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
