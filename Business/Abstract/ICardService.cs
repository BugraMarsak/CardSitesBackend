using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICardService
    {
        IDataResult<List<Card>> GetAll();
        IDataResult<List<Card>> GetAllByCardTypeId(int id);
        IDataResult<List<Card>> GetByUnitPrice(decimal min, decimal max);
        //IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Card> GetbyName(string cardName);
        IDataResult<Card> GetbyId(int cardId);
        IResult Add(Card card);
        IResult Update(Card card);
        IDataResult<List<CardDetailDto>> GetCardDetails();
    }
}
