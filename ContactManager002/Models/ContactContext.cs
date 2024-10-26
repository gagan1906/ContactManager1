using ContactManager002.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


public class ContactContext : IdentityDbContext<IdentityUser> // Inherit from IdentityDbContext
{
    public ContactContext(DbContextOptions<ContactContext> options) : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; } // Your contact model
}
