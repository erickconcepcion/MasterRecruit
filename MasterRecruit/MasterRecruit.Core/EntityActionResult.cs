using System;
using System.Collections.Generic;

namespace MasterRecruit.Core
{
    public class EntityActionResult: IEntityActionResult
    {
        public int ErrorCode { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public Guid Id { get; set; }
    }
}