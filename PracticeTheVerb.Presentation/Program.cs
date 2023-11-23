using PracticeTheVerb.API.Services.Italian;
using PracticeTheVerb.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<ItalianVerbService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();
