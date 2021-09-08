using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Leaflet : IEntity
    {
        public int LeafletId { get; set; }
        public int UserId { get; set; }
        public int CardId { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string Region { get; set; }
    }
}
