using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DinnerPlanner.Domain.Repository;
using Raven.Client;
using Raven.Client.Document;

namespace DinnerPlanner.Domain.Installer
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var documentStore = new DocumentStore { Url = "http://localhost:8080" }.Initialize();

            container.Register(
                Classes.FromThisAssembly()
                    .Where(x => x.Name.EndsWith("Repository"))
                    .WithServiceDefaultInterfaces()
                    .LifestyleTransient(),

                Component.For<IDocumentStore>()
                    .Instance(documentStore)
                    .LifestyleSingleton(),

                Component.For<IDocumentSession>()
                    .UsingFactoryMethod(GetDocumentSesssion)
                    .LifestyleTransient()
                );
        }

        static IDocumentSession GetDocumentSesssion(IKernel kernel)
        {
            var store = kernel.Resolve<IDocumentStore>();
            return store.OpenSession();
        }
    }
}