using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IResult Add(Article article)
        {
            _articleDal.Add(article);
            return new SuccessResult(Messages.ArticleAdded);
        }
        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetAll(), Messages.ProductsListed);
        }
        
        public IDataResult<Article> GetbyArticleId(int articleId)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(p => p.ArticleId == articleId));
        }
        public IResult Update(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
