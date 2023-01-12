using Microsoft.EntityFrameworkCore;
using Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class EventSeedConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Event> builder)
        {
            builder.HasData(
new Event
{
    
},


new Event
{
    Id = 2,
    Name = "Blue",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);
        }
    }
}
