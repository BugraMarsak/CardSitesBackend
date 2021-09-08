using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardDal:EfEntityRepositoryBase<Card, YugiContext>, ICardDal
    {
        public List<CardDetailDto> GetCardDetails()
        {
            using (YugiContext context = new YugiContext())
            {
                var result = from c in context.Cards
                             join t in context.CardType
                             on c.CardTypeId equals t.CardTypeId
                             join r in context.Races
                             on c.Race equals r.RaceId
                             join e in context.Elements
                             on c.Attribute equals e.ElementId

                             select new CardDetailDto {
                                 CardId = c.CardId,
                                 Race = r.RaceName,
                                 Level = c.Level,
                                 Limit = c.Limit,
                                 AttackPoint = c.AttackPoint,
                                 DefensePoint = c.DefensePoint,
                                 Attribute = e.ElementName,
                                 CardName = c.CardName,
                                 CardTypeId = c.CardTypeId,
                                 CardTypeName = t.CardTypeName
                             };
//Attribute = c.Attribute, Race = c.Race, Level = c.Level, Limit = c.Limit, AttackPoint = c.AttackPoint, DefensePoint = c.DefensePoint
                return result.ToList();
            }
        }

       
    }
}
