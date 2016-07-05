using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;

namespace MemorableTime.Infrastructure
{
    public class NinjectBindings: NinjectModule
    {
        public override void Load()
        {
            //Bind<Interface>().To<Class>()
        }
    }
}