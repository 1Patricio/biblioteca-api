var builder = WebApplication.CreateBuilder(args);

// Registrar serviços no contêiner de DI
builder.Services.AddSingleton<ILivroService, LivroService>();
builder.Services.AddSingleton<IAutorService, AutorService>();

builder.Services.AddControllers();

// Swagger para documentação
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

// Registrar Controllers
app.MapControllers();

app.Run();