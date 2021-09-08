using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Card : IEntity
    {
        public  int CardId { get; set; }
        public string CardName { get; set; }
        public int Attribute { get; set; }//
        public int CardTypeId { get; set; } // monster , trap ,spell//
        public int Race { get; set; }//
        public int Limit { get; set; }//ban durumu//
        public int AttackPoint { get; set; }//ATK
        public int DefensePoint { get; set; }//DEF
        public int Level { get; set; } // level//

    }
}
