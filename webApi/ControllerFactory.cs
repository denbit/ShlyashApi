using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Ninject;
using ShlyahApi.Client.Repo;
using Moq;
using ShlyahApi.UserStore.Entity;

namespace ShlyahApi.Client
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected IKernel kernel { get; set; }

        public ControllerFactory()
        { 
            kernel = new StandardKernel();

            Mock<ICommonUserRepo> mock = new Mock<ICommonUserRepo>();
            mock.Setup(m => m.Users).Returns(new List<User> {
            new User{
            Id=1,
            Email="INFO@langivi.technology"
            }
            }.AsQueryable());
            

            kernel.Bind<ICommonUserRepo>().ToConstant(mock.Object);
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType==null ? null: (IController)kernel.Get(controllerType);
        }
    }
}