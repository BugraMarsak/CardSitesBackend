using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CardType :IEntity
    {
        public int CardTypeId { get; set; }
        public string CardTypeName { get; set; }

    }
}
