using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLeafletDal : EfEntityRepositoryBase<Leaflet, YugiContext>, ILeafletDal
    {
        public List<LeafletDetailDto> GetLeafletDetails()
        {
            
                using (YugiContext context = new YugiContext())
                {
                    var result = from c in context.Cards
                                 join r in context.Races
                                 on c.Race equals r.RaceId
                                 join e in context.Elements
                                 on c.Attribute equals e.ElementId
                                 join l in context.Leaflet
                                 on c.CardId equals l.CardId
                                 join t in context.CardType
                                 on c.CardTypeId equals t.CardTypeId
                                 join u in context.Users
                                 on l.UserId equals u.Id
                                 
                                 select new LeafletDetailDto { 
                                     LeafletId=l.LeafletId,
                                     CardId = c.CardId ,
                                     UnitInStock= l.UnitInStock,
                                     Region = l.Region,
                                     Race = r.RaceName,
                                     UserId =l.UserId,
                                     FirstName = u.FirstName,
                                     LastName = u.LastName,
                                     Level = c.Level,
                                     Limit = c.Limit,
                                     UnitPrice = l.UnitPrice , 
                                     AttackPoint =c.AttackPoint ,
                                     DefensePoint= c.DefensePoint, 
                                     Attribute = e.ElementName,
                                     CardName=c.CardName ,
                                     CardTypeId = c.CardTypeId,
                                     CardTypeName = t.CardTypeName , 
                                      };
                    return result.ToList();
                }
            
        }

        public List<LeafletDetailDto> GetByLeafletId(int leafletId)
        {
            using (YugiContext context = new YugiContext())
            {
                var result = from c in context.Cards
                             join r in context.Races
                             on c.Race equals r.RaceId
                             join e in context.Elements
                             on c.Attribute equals e.ElementId
                             join l in context.Leaflet
                             on c.CardId equals l.CardId
                             join t in context.CardType
                             on c.CardTypeId equals t.CardTypeId
                             join u in context.Users
                             on l.UserId equals u.Id
                             where l.LeafletId == leafletId
                             select new LeafletDetailDto
                             {
                                 LeafletId = l.LeafletId,
                                 CardId = c.CardId,
                                 UnitInStock = l.UnitInStock,
                                 Region = l.Region,
                                 Race = r.RaceName,
                                 UserId = l.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Level = c.Level,
                                 Limit = c.Limit,
                                 UnitPrice = l.UnitPrice,
                                 AttackPoint = c.AttackPoint,
                                 DefensePoint = c.DefensePoint,
                                 Attribute = e.ElementName,
                                 CardName = c.CardName,
                                 CardTypeId = c.CardTypeId,
                                 CardTypeName = t.CardTypeName,
                             };

                return result.ToList();
            }


        }
    }
}
