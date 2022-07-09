using System.Data.Entity;
using System.Security.AccessControl;
using InvoiceManager.Models.Domains;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InvoiceManager.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Invoices)
                .WithRequired(i => i.User)
                .HasForeignKey(i => i.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Clients)
                .WithRequired(i => i.User)
                .HasForeignKey(i => i.UserId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}