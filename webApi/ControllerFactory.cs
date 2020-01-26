using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Ninject;

namespace ShlyahApi.Client
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected IKernel kernel { get; set; }

        public ControllerFactory()
        {
            kernel = new StandardKernel();

        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType==null ? null: (IController)kernel.Get(controllerType);
        }
    }
}