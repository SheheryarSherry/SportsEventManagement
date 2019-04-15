using Ninject;
using SportsEventManagement.Data.Infrastructure;
using SportsEventManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsEventManagement.NinjectResolver
{
    public class NinjectResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            // _kernel.Bind<To, From>(); // Registering Types  
            this._kernel.Bind<IUnitOfWork>().ToConstructor<UnitOfWork>(unit =>new UnitOfWork());
        }
    }
}