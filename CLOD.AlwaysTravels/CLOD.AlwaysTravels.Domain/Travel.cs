using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Domain
{
    [Map("Travels")]
    public class Travel : EntityBase<int>
    {
        public string Title { get; set; }
        [TypeMap(DbType.DateTime2)]
        public DateTime StartDate { get; set; }
        [TypeMap(DbType.DateTime2)]
        public DateTime EndDate { get; set; }
        public Travel()
        {

        }
    }
}
