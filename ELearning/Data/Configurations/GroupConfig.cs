using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.subject)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.SubjectId);
        }
    }
}