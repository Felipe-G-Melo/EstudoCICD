using Api.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/user", (UserInput input) =>
{
    var user = new User(input.Nome, input.Email, input.Senha);
    return user;
});

app.MapGet("/users", () =>
{
    var user = new User("Felipe", "felipe@gmail.com", "123456");
    return user;
});

app.Run();