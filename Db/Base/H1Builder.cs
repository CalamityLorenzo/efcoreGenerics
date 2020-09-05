using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyDbApp
{
    public class H1Builder : IEntityTypeConfiguration<HostOne>
    {
        public void Configure(EntityTypeBuilder<HostOne> builder)
        {
            builder.HasMany(p => p.CoreCollection)
                    .WithOne(p => p.Host);
        }
    }

    public class H2Builder : IEntityTypeConfiguration<HostTwo>
    {
        public void Configure(EntityTypeBuilder<HostTwo> builder)
        {
            builder.HasMany(p => p.CoreCollection)
                    .WithOne(p => p.Host);
        }
    }
}