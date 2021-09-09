using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        ILeafletService _leafletService;

        public OrderManager(IOrderDal orderDal, ILeafletService leafletService)
        {
            _orderDal = orderDal;
            _leafletService = leafletService;
        }
        //[ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {

            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderListed);
        }
        public IDataResult<List<Order>> GetOrdersByUserId(int userId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.UserId == userId));
        }
        //[ValidationAspect(typeof(OrderValidator))]

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }
        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }


    }
}
