using Microsoft.EntityFrameworkCore;
using MottuSmartPatio.Data;
using MottuSmartPatio.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuração do EF Core com Oracle
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDb")));

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Rota base
app.MapGet("/", () => "Mottu Smart Pátio API rodando!");

// CRUD: GET - Lista todas
app.MapGet("/motos", async (AppDbContext db) => await db.Motos.ToListAsync());

// GET - Busca por ID
app.MapGet("/motos/{id}", async (int id, AppDbContext db) =>
    await db.Motos.FindAsync(id) is Moto moto ? Results.Ok(moto) : Results.NotFound());

// GET - Busca por Status
app.MapGet("/motos/status/{status}", async (string status, AppDbContext db) =>
    await db.Motos.Where(m => m.Status == status).ToListAsync());

// POST - Cadastrar
app.MapPost("/motos", async (Moto moto, AppDbContext db) =>
{
    db.Motos.Add(moto);
    await db.SaveChangesAsync();
    return Results.Created($"/motos/{moto.Id}", moto);
});

// PUT - Atualizar
app.MapPut("/motos/{id}", async (int id, Moto inputMoto, AppDbContext db) =>
{
    var moto = await db.Motos.FindAsync(id);
    if (moto is null) return Results.NotFound();

    moto.Placa = inputMoto.Placa;
    moto.Modelo = inputMoto.Modelo;
    moto.Status = inputMoto.Status;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

// DELETE - Remover
app.MapDelete("/motos/{id}", async (int id, AppDbContext db) =>
{
    var moto = await db.Motos.FindAsync(id);
    if (moto is null) return Results.NotFound();

    db.Motos.Remove(moto);
    await db.SaveChangesAsync();
    return Results.Ok(moto);
});

app.Run();
