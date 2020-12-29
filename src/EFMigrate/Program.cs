namespace EFMigrate
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    internal static class Program
    {
        private static int Main()
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length != 2)
            {
                Console.Error.WriteLine("usage: {0} ASSEMBLY", args[0]);
                return 1;
            }

            var assembly = Assembly.LoadFrom(args[1]);
            var factoryType = assembly.ExportedTypes.Single(typeof(IDesignTimeDbContextFactory<DbContext>).IsAssignableFrom);
            var factory = (IDesignTimeDbContextFactory<DbContext>?)Activator.CreateInstance(factoryType);
            using var context = factory!.CreateDbContext(new string[0]);

            context.Database.Migrate();

            return 0;
        }
    }
}
