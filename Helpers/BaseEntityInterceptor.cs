using md_notes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace md_notes.Helpers
{
    public class BaseEntityInterceptor : SaveChangesInterceptor
    {
        public BaseEntityInterceptor() { }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
        DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = default)
        {
            var context = eventData.Context;
            var dateTime = DateTime.UtcNow;

            context.ChangeTracker.DetectChanges();

            foreach (var entry in context.ChangeTracker.Entries())
            {
                var entryEntity = entry.Entity;
                IBaseEntity entity;
                if (entryEntity is not IBaseEntity)
                    continue;

                entity = (IBaseEntity)entryEntity;

                if (entry.State == EntityState.Modified || entry.State == EntityState.Added)
                {
                    entity.UpdatedAt = dateTime;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = dateTime;
                    }
                    else
                    {
                        entry.Property("CreatedAt").IsModified = false;
                    }
                }
            }

            return new(result);
        }
    }
}
