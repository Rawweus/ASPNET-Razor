var builder = WebApplication.CreateBuilder(args); // Denna bygger en webserver
builder.Services.AddRazorPages(); //F�r att den ska veta hur den ska hantera sidorna
builder.Services.AddRouting(x => x.LowercaseUrls = true);




var app = builder.Build(); // Den ska trigga och bygga Build-delen i "app" s� det blir en web application
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();