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
        [CacheRemoveAspect("IOrderService.GetAll")]
        public IResult Add(Order order)
        {

            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderListed);
        }
        [CacheAspect]
        public IDataResult<List<Order>> GetOrdersByUserId(int userId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(p => p.UserId == userId));
        }
        //[ValidationAspect(typeof(OrderValidator))]
        [CacheRemoveAspect("IOrderService.GetAll")]

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }
        [CacheRemoveAspect("IOrderService.GetAll")]
        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }


    }
}
