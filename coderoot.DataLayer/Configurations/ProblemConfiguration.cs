using coderoot.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coderoot.DataLayer.Configurations
{
    public class ProblemConfiguration : IEntityTypeConfiguration<Problem>
    {
        public void Configure(EntityTypeBuilder<Problem> builder)
        {
            builder.ToTable("Problems");
            
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.ProblemId).IsRequired();
            builder.HasIndex(x => x.ProblemId).IsUnique();

            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Difficulty).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.HasOne(p => p.Topic).WithOne().HasForeignKey<Topic>(x => x.TopicId);
        }
    }
}
