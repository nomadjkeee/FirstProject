using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace ConsoleApp3
{
    class UseG:NinjectModule
    {
        public override void Load()
        {
            this.Bind<IProduct>().To<ProductG>();        }
    }
}
