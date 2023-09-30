using Biblioteca.Persistence;
// referenciando a nossa classe de contexto de dados.

var builder = WebApplication.CreateBuilder(args);

// 
builder.Services.AddSingleton<BibliotecaDbContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
