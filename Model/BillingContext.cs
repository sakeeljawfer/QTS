using Microsoft.EntityFrameworkCore;
namespace QTS_SimpleBilling.Model
{
    internal class BillingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=DESKTOP-HGKFMEC\SQLEXPRESS;database=QtSBill;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
         }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ReceiptBody> ReceiptBodies { get; set; }
        public DbSet<ReceiptHeader> ReceiptHeaders { get; set; }

	public DbSet<Catagory> catagories { get; set; }
            public DbSet<Cost> costs { get; set; }
            public DbSet<Items> itemes { get; set; }
            public DbSet<Shelf> shelves { get; set; }
            public DbSet<Unit> units { get; set; }
            public DbSet<SellingPrice> sellingPrices { get; set; }
        public object Catagory { get; internal set; }
    }
}
