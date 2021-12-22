using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Extension
{
    public abstract class SlightModuleConfigure
    {
        protected virtual void Load(IServiceCollection services) { }
    }
}
