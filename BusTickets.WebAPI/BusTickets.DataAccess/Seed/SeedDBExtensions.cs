using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace BusTickets.DataAccess.Seed
{
    public static class SeedDbExtensions
    {
        public static void SeedDb(this IBusTicketDbContext context)
        {
            using (context)
            {
                typeof(SeedDbExtensions).Assembly
                    .GetTypes()
                    .Where(s => !s.IsInterface && typeof(ISeed).IsAssignableFrom(s))
                    .ToList()
                    .ForEach(s =>
                     {
                         var obj = Activator.CreateInstance(s);
                         s.GetMethod(nameof(ISeed.Seed)).Invoke(obj, new[] { context });
                     });

                context
                    .SaveChanges();
            }
        }

        internal static TEntity AddOrUpdate<TEntity>(this DbSet<TEntity> dbSet, TEntity entity)
            where TEntity : class
        {
            var type = typeof(TEntity);
            var keyProp = type
                .GetProperties()
                .FirstOrDefault(s => s.GetCustomAttribute<KeyAttribute>() != null);

            if (keyProp != null)
            {
                var primaryKey = keyProp.GetValue(entity);
                var dbEntity = dbSet.Find(primaryKey);

                if (dbEntity != null)
                {
                    dbSet.Attach(dbEntity).State = EntityState.Detached;
                    dbSet.Update(entity);
                }
                else
                {
                    var prop = entity.GetType().GetProperty(keyProp.Name);
                    prop.SetValue(entity, Activator.CreateInstance(primaryKey.GetType()));

                    dbSet.Add(entity);
                }
            }

            return entity;
        }
    }
}
