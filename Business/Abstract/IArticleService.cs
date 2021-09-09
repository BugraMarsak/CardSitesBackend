using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

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
