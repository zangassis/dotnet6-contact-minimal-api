namespace ContactApi.Models;

public record class Contact
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string SSN { get; set; }
    public string Suffix { get; set; }
    public string Phone { get; set; }

    public static Faker<Contact> FakeData { get; } =
        new Faker<Contact>()
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.MiddleName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Title, f => f.Name.Prefix(f.Person.Gender))
                .RuleFor(c => c.Suffix, f => f.Name.Suffix())
                .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
                .RuleFor(c => c.DOB, f => f.Date.Past(18))
                .RuleFor(c => c.Gender, f => f.PickRandom<Gender>())
                .RuleFor(c => c.SSN, f => f.Random.Replace("###-##-####"))
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("(###)-###-####"));
}

public enum Gender
{
    Male,
    Female
}