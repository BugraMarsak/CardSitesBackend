using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<List<Card>> GetAllByCardTypeId(int id);
        IDataResult<Card> GetbyName(string cardName);
        IResult Add(Card card);
        IDataResult<List<CardDetailDto>> GetCardDetails();
    }
}
