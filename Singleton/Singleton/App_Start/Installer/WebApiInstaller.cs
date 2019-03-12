using Castle.MicroKernel.Registration;

using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Singleton.Models.Interface;
using Singleton.Business.Handlers;
using System.Configuration;
using System;
using System.Web.Http.Controllers;

namespace Singleton.App_Start.Installer
{
    public class WebApiInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                            Classes.FromThisAssembly()
                                    .BasedOn<IHttpController>()
                                    .LifestylePerWebRequest());

            bool isMock = Convert.ToBoolean(ConfigurationManager.AppSettings["IsMock"]);

            if(isMock)
            {
                container.Register(
                Component.For<IRequestHandler>()
                                        .ImplementedBy<MockRequestHandler>().LifestylePerWebRequest());
            }
            else
            {
                container.Register(
                Component.For<IRequestHandler>()
                                        .ImplementedBy<RequestHandler>().LifestylePerThread());
            }
        }
    }
}