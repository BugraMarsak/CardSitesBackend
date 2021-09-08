using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int LeafletId { get; set; }
        public bool Active { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public string CardName { get; set; }

    }
}
