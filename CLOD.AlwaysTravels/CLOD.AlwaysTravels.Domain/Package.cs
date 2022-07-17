using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Domain
{
    [Map("Packages")]
    public class Package : EntityBase<int>
    {
        public string Description { get; set; }

        public Package()
        {

        }
    }
}
