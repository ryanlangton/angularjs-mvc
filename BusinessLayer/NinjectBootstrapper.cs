using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;

namespace BusinessLayer
{
    public class NinjectBootstrapper
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(x => x.FromThisAssembly().SelectAllClasses().BindDefaultInterfaces());
        }
    }
}
