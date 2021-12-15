using Microsoft.EntityFrameworkCore;
namespace ContactApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var fakeData = Contact.FakeData.Generate(10).ToList();

        foreach (var fake in fakeData)
        {
            modelBuilder.Entity<Contact>().HasData(new Contact()
            {
                Id = Guid.NewGuid(),
                FirstName = fake.FirstName,
                LastName = fake.LastName,
                Email = fake.Email,
                DOB = fake.DOB,
                Gender = fake.Gender,
                MiddleName = fake.MiddleName,
                Phone = fake.Phone,
                SSN = fake.SSN,
                Suffix = fake.Suffix,
                Title = fake.Title
            });
        }
    }
}
