using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class LeafletDetailDto : IDto
    {
        public int LeafletId { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardName { get; set; }
        public string CardTypeName { get; set; }
        public string Region { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string Attribute { get; set; }
        public int CardTypeId { get; set; } 
        public string Race { get; set; }
        public int Limit { get; set; }
        public int AttackPoint { get; set; }
        public int DefensePoint { get; set; }
        public int Level { get; set; }
    }
}
