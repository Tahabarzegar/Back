using System.Linq;
using First.API.Data;
using First.API.Entities;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FirstDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
}
);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// app.UseHttpsRedirection();
app.MapPost("/members/add", (FirstDB db, Member member) =>
{
    db.Members.Add(member);
    db.SaveChanges();
}
);
app.MapPost("/members/remove", (FirstDB db, Member member) =>
{
    db.Members.Remove(member);
    db.SaveChanges();
}
);
app.MapGet("/members/list", (FirstDB db) =>
{
    return db.Members.ToList();
}
);
app.MapPost("/members/update", (FirstDB db, Member member) =>
{
    db.Members.Update(member);
    db.SaveChanges();
}
);
app.MapPost("/books/add", (FirstDB db, Book book) =>
{
    db.Books.Add(book);
    db.SaveChanges();
}
);
app.MapPost("/books/remove", (FirstDB db, Book book) =>
{
    db.Books.Remove(book);
    db.SaveChanges();
}
);
app.MapGet("/books/list", (FirstDB db) =>
{
    return db.Books.ToList();
}
);
app.MapPost("/books/update", (FirstDB db, Book book) =>
{
    db.Books.Update(book);
    db.SaveChanges();
}
);
app.MapPost("/borrows/add", (FirstDB db, Borrow borrow) =>
{
    db.Borrows.Update(borrow);
    db.SaveChanges();
}
);
app.MapPost("/borrows/remove", (FirstDB db, Borrow borrow) =>
{
    db.Borrows.Update(borrow);
    db.SaveChanges();
}
);
app.MapGet("/borrows/list", (FirstDB db) =>
{
    return db.Borrows.Include(b=>b.Book).Include(m=>m.Member).ToList();

}
);
app.MapPost("/borrows/update", (FirstDB db, Borrow borrow) =>
{
    db.Borrows.Update(borrow);
    db.SaveChanges();
}
);
app.Run();

