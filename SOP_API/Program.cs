using SOP_API.DBClasses.Models;
using SOP_API.DBConnection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi(options =>
//{
//    // Specify the OpenAPI version to use
//    options.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_0;
//});

var app = builder.Build();
var x = new LabTest();
// ...

//if (app.Environment.IsDevelopment()) // by default enabled only for dev.
//{
//    app.MapOpenApi();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
SessionFactory.CreateSessionFactory();
app.Run();
