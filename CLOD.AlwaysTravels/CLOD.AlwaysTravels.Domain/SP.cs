using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Domain
{
    public class SP : EntityBase<int>
    {
        public int? StageId { get; set; }
        public int? PackageId { get; set; }

        public SP()
        {

        }
    }
}
