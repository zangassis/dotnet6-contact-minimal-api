using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        options.UseSqlite("Data Source=contacts.db");
    });

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Contacts API",
        Description = "Storing and sharing contacts for my DEVintersection friends",
        Version = "v1"
    });
});

var app = builder.Build();
var ctx = app.Services.CreateScope().ServiceProvider.GetService<AppDbContext>();
ctx.Database.EnsureCreated();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/contacts", (AppDbContext ctx) => ctx.Contacts);

app.MapGet("/contacts/{id}", (AppDbContext ctx, Guid id) => ctx.Contacts.Find(id));

app.MapPost("/contacts", async (AppDbContext ctx, CreateContactViewModel newContact) =>
{
    var contact = new Contact()
    {
        Id = Guid.NewGuid(),
        FirstName = newContact.FirstName,
        MiddleName = newContact.MiddleName,
        LastName = newContact.LastName,
        Email = newContact.Email,
        Phone = newContact.Phone,
        Title = newContact.Title,
        Suffix = newContact.Suffix,
        SSN = newContact.SSN,
        Gender = newContact.Gender,
        DOB = newContact.DOB
    };

    await ctx.Contacts.AddAsync(contact);
    await ctx.SaveChangesAsync();

    return Results.Created($"/contact/{contact.Id}", contact);

}).Produces<Contact>(StatusCodes.Status201Created);

app.MapPut("/contacts/{id}", async (AppDbContext ctx, UpdateContactViewModel updateContactView, Guid id) =>
{
    var contact = await ctx.Contacts.FindAsync(id);

    if (contact is null) return Results.NotFound();

    var updateContact = new Contact
    {
        Id = contact.Id,
        FirstName = updateContactView.FirstName,
        MiddleName = updateContactView.MiddleName,
        LastName = updateContactView.LastName,
        Email = updateContactView.Email,
        Phone = updateContactView.Phone,
        Title = updateContactView.Title,
        Suffix = updateContactView.Suffix,
        SSN = updateContactView.SSN,
        Gender = updateContactView.Gender,
        DOB = updateContactView.DOB
    };

    ctx.Entry(contact).CurrentValues.SetValues(updateContact);

    await ctx.SaveChangesAsync();

    return Results.NoContent();

}).Produces(StatusCodes.Status404NotFound).Produces(StatusCodes.Status204NoContent);

app.MapDelete("/contacts/{id}", async (AppDbContext ctx, Guid id) =>
{
    var contact = await ctx.Contacts.FindAsync(id);

    if (contact is null) return Results.NotFound();

    ctx.Contacts.Remove(contact);

    await ctx.SaveChangesAsync();

    return Results.NoContent();

}).Produces(StatusCodes.Status204NoContent);

app.Run();
