using Flog.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var configuration = app.Configuration;

builder.Services.ConfigureCors();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigurePostgresContext(configuration);
builder.Services.ConfigureRepositoryManager();

builder.Services.RegisterMediatR();
builder.Services.RegisterAutoMapper();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();