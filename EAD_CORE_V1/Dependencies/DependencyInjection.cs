using AuthContext.Services;
using EAD_CORE.Infra.Context;
using EAD_CORE_V1.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_CORE_V1.Dependencies
{
    public static class DependencyInjection
    {
        public static void AddServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<TokenService>();
            services.AddTransient<Lesson>();
            services.AddScoped<PreventivaContext>();
        }
    }
}
