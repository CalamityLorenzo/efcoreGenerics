using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyDbApp
{
    public class CoreBuilder<T, S1, S2> : IEntityTypeConfiguration<T>
                where T : BaseCore<S1, S2>
                where S1 : BaseSubOne, IHasHost<T>
                where S2 : BaseSubTwo, IHasHost<T>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            // define sub relationships through rthe hierarchy
            // Tables higher define down
            builder.HasMany(o => o.SubsONe)
                    .WithOne(p => p.Host).OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(o => o.SubsTwo)
                    .WithOne(p => p.Host).OnDelete(DeleteBehavior.Cascade);

        }
    }
}