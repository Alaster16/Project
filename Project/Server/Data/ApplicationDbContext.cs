using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Shared.Domain;

namespace Project.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Event>Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet <Organizer>Oraganizers { get; set; }
        public DbSet<EventMember> EventMembers { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
