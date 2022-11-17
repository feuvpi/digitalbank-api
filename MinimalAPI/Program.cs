var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/user", () => new Cliente("Fred G", "fredg@fredg.com"));

app.UseSwaggerUI();


app.Run();

public record Cliente(string Name, string Email);
