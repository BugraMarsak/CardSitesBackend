﻿using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<UserDetailDto> GetByUserId(int userId);
    }
}
