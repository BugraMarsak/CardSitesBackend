using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTO;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        IDataResult<List<UserDetailDto>> GetbyId(int userId);
    }
}
