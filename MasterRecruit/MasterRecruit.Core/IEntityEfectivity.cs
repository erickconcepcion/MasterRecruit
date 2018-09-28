using System;
using System.Collections.Generic;
using System.Text;

namespace MasterRecruit.Core
{
    interface IEntityEfectivity
    {
        DateTime StartDate { get; set; }
        DateTime? EndDate { get; set; }
    }
}
