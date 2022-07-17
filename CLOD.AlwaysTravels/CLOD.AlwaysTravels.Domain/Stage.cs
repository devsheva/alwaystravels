using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Domain
{
    [Map("Stages")]
    public class Stage : EntityBase<int>
    {
        public string Title { get; set; }
        [TypeMap(DbType.DateTime2)]
        public DateTime Date { get; set; }
        public int? TravelId { get; set; }

        public Stage()
        {

        }
    }
}
