using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories.EntityFramework;

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
