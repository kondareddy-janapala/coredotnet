using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeEvaluationTest.Data;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CodeEvaluationTestContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CodeEvaluationTestContext") ?? throw new InvalidOperationException("Connection string 'CodeEvaluationTestContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory())),
    RequestPath = "/page",
    EnableDefaultFiles = true
});
app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.Run();
