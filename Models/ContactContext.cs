using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneContacts.Models
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
                    Name = "Devin Baack",
                    PhoneNumber = "712-210-5392",
                    Address = "Ames, IA",
                    Note = "Me"
                },

                new Contact
                {
                    ContactId = 2,
                    Name = "Bob Sanders",
                    PhoneNumber = "232-430-3392",
                    Address = "Des Moines, IA",
                    Note = "Coworker"
                },

                new Contact
                {
                    ContactId = 3,
                    Name = "Chuck Jones",
                    PhoneNumber = "332-123-8923",
                    Address = "Ames, IA",
                    Note = "Roommate"
                }
                );
        }
    }
}
