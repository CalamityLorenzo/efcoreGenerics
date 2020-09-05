using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyDbApp
{
    public class P1Builder: IEntityTypeConfiguration<ParentOne>
    {
        public void Configure(EntityTypeBuilder<ParentOne> builder)
        {
            builder.HasMany(p => p.CoreCollection)
                    .WithOne(p => p.Host);
        }
    }

    public class P2Builder : IEntityTypeConfiguration<ParentTwo>
    {
        public void Configure(EntityTypeBuilder<ParentTwo> builder)
        {
            builder.HasMany(p => p.CoreCollection)
                    .WithOne(p => p.Host);
        }
    }
}