using AutoSmart.Application.AutoMapper;
using AutoSmart.Presentation.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace AutoSmart.Presentation.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            AutoMapperConfig.RegisterMappings();
        }
    }
}