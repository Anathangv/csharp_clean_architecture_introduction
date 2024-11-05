using CleanArchitecture.Persistence;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);

//registrar serviços
builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//criar o banco e a tabela SQLite
CreateDataBase(app); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
//app.UseAuthorization();

app.MapControllers();

app.Run();

static void CreateDataBase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();// verificar se o banco associado ao contexto foi criado, se não existe cria baseado no modelo de dados definido nas entidades
}