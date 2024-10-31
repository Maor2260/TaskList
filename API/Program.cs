using API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddAuthentication();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataContext();
builder.Services.AddDependencyInjections();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.SetupSwagger();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();