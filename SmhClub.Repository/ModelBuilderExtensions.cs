using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SmhClub.Repository
{
    internal static class ModelBuilderExtensions
    {
        public static void ApplyConfigurations(this ModelBuilder builder)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces()
                .Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
                .ToList();

      
            foreach (Type type in types)
            {
                dynamic? config = Activator.CreateInstance(type);
                builder.ApplyConfiguration(config);
            }            
        }
    }
}
