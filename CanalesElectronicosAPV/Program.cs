using CanalesElectronicosAPV.Domain.Configuration;
//using KeycloakTokenManager.Common;
//using NetCore.KeycloakTokenManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//keycloak
var KeyCloakConfigs = new KeyCloakConfigs();
IConfiguration configuration = builder.Configuration;
configuration.Bind("KeyCloakConfigs", KeyCloakConfigs);
//builder.Services.AddTokenManager(new KeycloakUrlOptions
//{
//    ClientId = KeyCloakConfigs.ClientId,
//    ClientSecret = KeyCloakConfigs.ClientSecret,
//    KeycloakUrl = KeyCloakConfigs.KeycloakUrl,
//    Realm = KeyCloakConfigs.Realm
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=VwLogin}/{id?}");
    //pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
