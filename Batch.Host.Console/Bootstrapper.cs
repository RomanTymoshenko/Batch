using Autofac;

namespace Batch.Host.Console
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            var container = BuildContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<FileProcessor>().RunProcessing();
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FileProcessor>();

            return builder.Build();
        }
    }


}
