using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ICategoryService, CategoryManager>();
builder.Services.AddTransient<ICategoryDal, EfCategoryRepository>();
builder.Services.AddTransient<ITrainerService, TrainerManager>();
builder.Services.AddTransient<ITrainerDal, EfTrainerRepository>();
builder.Services.AddTransient<IDescriptionService, DescriptionManager>();
builder.Services.AddTransient<IDescriptionDal, EfDescriptionRepository>();
builder.Services.AddTransient<IImageService, ImageManager>();
builder.Services.AddTransient<IImageDal, EfImageRepository>();
builder.Services.AddTransient<IContactService, ContactManager>();
builder.Services.AddTransient<IContactDal, EfContactRepository>();
builder.Services.AddTransient<IMemberService, MemberManager>();
builder.Services.AddTransient<IMemberDal, EfMemberRepository>();



//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//    .RequireAuthenticatedUser()
//    .Build();

//    config.Filters.Add(new AuthorizeFilter(policy));
//});

//// Authorization gereken sayfalara girmeye çalýþýnca kullanýcýyý login sayfasýna yönlendirecek.
//// Amaç kullanýcýnýn giriþ veya kayýt olmadan sayfalarý görmemesidir.
//builder.Services.AddMvc();
//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {
//        x.LoginPath = "/Login/Index";
//    });



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

app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
