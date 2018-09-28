using System;
using System.Collections.Generic;

namespace MasterRecruit.Core
{
    public interface IEntityActionResult
    {
        int ErrorCode { get; set; }
        bool Success { get; set; }
        IEnumerable<string> Messages { get; set; }
        Guid Id { get; set; }
    }
}