using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListRyberg.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Alex",
                    LastName = "Ryberg",
                    Email = "ashewerw@sefse.com",
                    PhoneNumber = 5555555555
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Ashley",
                    LastName = "Green",
                    Email = "alex@asdae.com",
                    PhoneNumber = 9999999999
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Olive",
                    LastName = "Green",
                    Email = "olive@green.com",
                    PhoneNumber = 3333333333
                }
                );
        }
    }
}
