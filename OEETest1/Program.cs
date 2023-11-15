using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using OEETest1.Data;
using OEETest1.Interface;
using OEETest1.Migrations;
using OEETest1.Repositry;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OEEDbContext>(option =>
{
	option.UseSqlServer(builder.Configuration.GetConnectionString("Contectdatabase"));
});

//builder.Services.AddScoped<IGenericRepo<machinelogs>, GenericRepo<machinelogs>>();
builder.Services.AddScoped<IMachineLogs, MachineLogsRepo>();
builder.Services.AddScoped<IProductionLogs , ProductionRepo>();
builder.Services.AddScoped<IShifts , ShiftRepo>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//////////////////////////////////  CROS  /////////////////////////////////////
builder.Services.AddCors(cors =>
{
	cors.AddPolicy("MyPolicy", corsPolicyBuilder =>
	{
		corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
	});

});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}


app.UseCors("MyPolicy");
//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
