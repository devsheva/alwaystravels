using RepoDb.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Domain
{
    public class EntityBase<T>
    {
        [Identity]
        public T Id { get; set; }
    }
}
