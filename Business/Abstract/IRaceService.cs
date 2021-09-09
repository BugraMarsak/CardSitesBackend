﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRaceService
    {
        IDataResult<List<Race>> GetAll();
    }
}
