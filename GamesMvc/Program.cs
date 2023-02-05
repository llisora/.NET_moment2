var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  //Aktiverar mvc

var app = builder.Build();

app.UseStaticFiles();                       //wwwroot
app.UseRouting();

//Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
);

app.Run();
