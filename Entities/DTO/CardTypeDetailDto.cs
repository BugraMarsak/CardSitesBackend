using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class CardTypeDetailDto:IDto
    {
        public int CardTypeId { get; set; }
        public string CardTypeName { get; set; }
    }
}
