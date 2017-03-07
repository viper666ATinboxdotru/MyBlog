using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using MyBlog.Core.Abstract;
using MyBlog.Core.Concrete;

namespace WebUI.Infrastructure
{
    // реализация пользовательской фабрики контроллеров,
    // наследуясь от фабрики используемой по умолчанию
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера
            _ninjectKernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            _ninjectKernel.Bind<IBlogRepository>().To<BlogRepository>();


        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера
            // используя его тип
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);

        }


    }
}