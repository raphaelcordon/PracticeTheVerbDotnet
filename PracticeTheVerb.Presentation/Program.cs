using PracticeTheVerb.API.Services.Italian;
using PracticeTheVerb.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews()
	.ConfigureApiBehaviorOptions(options => options.SuppressMapClientErrors = false);
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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "ItalianVerbConjugation",
        pattern: "italian/VerbConjugation/{verb}",
        defaults: new { controller = "Italian", action = "VerbConjugation" }
    );

    // Add other routes if needed

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
