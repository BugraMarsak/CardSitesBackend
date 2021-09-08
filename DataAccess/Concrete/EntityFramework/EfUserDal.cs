using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, YugiContext>, IUserDal
    {
        public List<UserDetailDto> GetByUserId(int userId)
        {
            using (var context = new YugiContext())
            {
                var result = from u in context.Users
                             where u.Id ==  userId
                             select new UserDetailDto { Id = u.Id, FirstName=u.FirstName,LastName= u.LastName,Email=u.Email };
                return result.ToList();

            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new YugiContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

       
    }
}
