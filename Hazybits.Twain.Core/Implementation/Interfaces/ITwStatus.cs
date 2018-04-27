using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwStatus : ITwainStructure
    {
        ConditionCode ConditionCode { get; set; }
    }
}
