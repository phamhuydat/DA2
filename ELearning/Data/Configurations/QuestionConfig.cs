using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.chapter)
                .WithMany(x => x.questions)
                .HasForeignKey(x => x.ChapterId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.subject)
              .WithMany(x => x.Questions)
              .HasForeignKey(x => x.SubjectId)
              .OnDelete(DeleteBehavior.NoAction);
        }
    }
}