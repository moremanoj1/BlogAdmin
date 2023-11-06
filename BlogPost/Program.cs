using BlogPost.Services.ControlPanelService;
using BlogPost.ServicesContracts.ControllPanelServiceContract;
using Entitys.BlogDbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BlogDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("GetConnectionString"));
});

builder.Services.AddScoped<IBlogsServiceContract, BlogService>();

var app = builder.Build();


if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Enable HSTS (HTTP Strict Transport Security)
app.UseHsts();

// Redirect HTTP requests to HTTPS
app.UseHttpsRedirection();

// Serve static files (CSS, JavaScript, images, etc.)
app.UseStaticFiles();

// Enable CORS (Cross-Origin Resource Sharing)
app.UseCors();

// Set up routing for the application
app.UseRouting();

// Map controllers as endpoints
app.MapControllers();

app.Run();



////app.UseExceptionHandler("/Error");
////app.UseHsts();
//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
////app.UseAuthentication();
////app.UseAuthorization();
//app.UseCors();
//app.MapControllers();
//app.Run();