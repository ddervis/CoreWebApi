using System;
using Microsoft.Extensions.DependencyInjection;
using ApiRestClient.Services;

namespace ApiRestClient.Register
{
    public static class Bootstrapper
    {
        public static void UseServices(this IServiceCollection services)
        {
            services.AddHttpClient<ITodoService, TodoService>();
        }
    }
}