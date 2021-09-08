using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<List<Article>> GetAll();
        IDataResult<Article> GetbyArticleId(int articleId);
        IResult Add(Article article);
        IResult Update(Article article);
    }
}
