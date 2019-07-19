using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Common
{
    public abstract class Result
    {
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; private set; }
        public string Message { get; set; }
    }
}
