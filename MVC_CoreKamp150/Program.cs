using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//46v...1.işlem
// Add Session
builder.Services.AddSession();  //48v kaldırabılırız dedık

//45v
// add services  ile Proje seviyesınde Authorize  Yapmak
builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser() // kullanıcının Sisteme giris yapması
					.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});

//47v 
// yetkilendirmeden kaynaklı hataları gormek yerıne 
// Kullanıcıları LOGİN/INDEX sayfasına yonlendirelim
builder.Services.AddMvc();
builder.Services.AddAuthentication( 
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x => { x.LoginPath = "/Login/Index"; }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// hatta kodu okuma i�lemleri i�in
//app.UseStatusCodePages();  // 40v

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}"); //40v

app.UseHttpsRedirection();
app.UseStaticFiles();

//48 
app.UseAuthentication();

// 46v...2.işlem
// Use Session Kullan

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
