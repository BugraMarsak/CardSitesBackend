using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Element : IEntity
    {
        public int ElementId { get; set; }
        public string ElementName { get; set; }
    }
}
