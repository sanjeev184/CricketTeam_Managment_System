using CricketTeam_Managment_System.DbAccess;
using CricketTeam_Managment_System.Service_layer;
using Non_database_Project.Service_layer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IMyDependency, MyDependency>();
builder.Services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>();

builder.Services.AddScoped<ICricketTeamDataAccess,CricketTeamDataAccess>();
builder.Services.AddScoped<ICricketService, CricketService>();

//builder.Services.AddScoped<ICricketTeamDataAccess,CricketTeamDataAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
