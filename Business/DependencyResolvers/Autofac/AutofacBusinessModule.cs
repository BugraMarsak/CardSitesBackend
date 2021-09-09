using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //using Autofac
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CardManager>().As<ICardService>().SingleInstance(); //singleinstance bir kere üretip herkese veriyor.
            builder.RegisterType<EfCardDal>().As<ICardDal>().SingleInstance();

            builder.RegisterType<LeafletManager>().As<ILeafletService>().SingleInstance(); //singleinstance bir kere üretip herkese veriyor.
            builder.RegisterType<EfLeafletDal>().As<ILeafletDal>().SingleInstance();

            builder.RegisterType<CardTypeManager>().As<ICardTypeService>();
            builder.RegisterType<EfCardTypeDal>().As<ICardTypeDal>();

            builder.RegisterType<RaceManager>().As<IRaceService>();
            builder.RegisterType<EfRaceDal>().As<IRaceDal>();

            builder.RegisterType<ElementManager>().As<IElementService>();
            builder.RegisterType<EfElementDal>().As<IElementDal>();

            builder.RegisterType<ArticleManager>().As<IArticleService>();
            builder.RegisterType<EfArticleDal>().As<IArticleDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();



            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
