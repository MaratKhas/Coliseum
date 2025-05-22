using Coliseum.Modules.Coliseums.Application.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddColiseumApplication();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("client", policy =>
    {
        policy.WithOrigins("http://localhost:3000") 
              .AllowAnyHeader()                  
              .AllowAnyMethod()                   
              .AllowCredentials();                
    });
}); var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("client");

app.MapControllers();

app.Run();
