using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Restaurant_Menu_Organiser.Data;
using Restaurant_Menu_Organiser.Models.Approvals;
using Restaurant_Menu_Organiser.Models.Notifications;
using Restaurant_Menu_Organiser.Repositories;
using Restaurant_Menu_Organiser.Utilities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Restaurant_Menu_Organiser
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        ////called at runtime. ..... add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                          options.UseSqlServer(Configuration.GetConnectionString("RestaurantSalesDBConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                          options.UseSqlServer(Configuration.GetConnectionString("RestaurantItemDBConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                          options.UseSqlServer(Configuration.GetConnectionString("RestaurantEmployeeDBConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                          options.UseSqlServer(Configuration.GetConnectionString("RestaurantOrderDBConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                         options.UseSqlServer(Configuration.GetConnectionString("RestaurantOfficeApprovalDBConnection")));
            services.AddDbContextPool<ApplicationDbContext>(options =>
                         options.UseSqlServer(Configuration.GetConnectionString("RestaurantOfficeNotificationsDBConnection")));
            services.AddScoped<IEmployeeRepository, Models.Employees.DBEmployeeImplementations>();
            services.AddScoped<IItemsRepository, Models.Items.DbItemImplementations>();
            services.AddScoped<ISalesRepository, Models.Sales.DbSalesImplementations>();
            services.AddScoped<IOrderRepository, Models.Orders.DbOrderImplementations>();
            services.AddScoped<INotificationsService, NotificationServiceImplementations>();
            services.AddScoped<IUserPreferencesServices, UserPreferencesServices>();
            services.AddScoped<IApprovalsRepository, DBApprovalsImplementations>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
                       {
                           options.Password.RequiredLength = 5; options.Password.RequiredUniqueChars = 1;
                           options.SignIn.RequireConfirmedAccount = true;
                       }).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }
        // This method gets called at runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseFileServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }  
    }
}

//integrate continious integaration and continious deployment with code CI/CD FOR DEV OPS MANIPULATION
 //app.UseFileServer(new FileServerOptions
 //{
 // FileProvider = new PhysicalFileProvider("bb"),
 // RequestPath = new Microsoft.AspNetCore.Http.PathString("bb"),
 //    EnableDirectoryBrowsing = false
 //});

////////Create Update Module for mvc application.
///Integrate Bundling.
///Use Tool Tips.
///////Integrate Pagination.
///professional Invoice maker built with react native on android.
///create Payments Gateway to seamlessly deploy to applications.
///create an algorithim that depicts common actions by a user to appear on a menu
///create heirachy table.
///Implment a smart search query.
////////casaflo Integration.{ Colour skin definitions, Coporate booking and payments, payments Integration. Performance algorithm for apartments, Users, etc....Coupon Definitions.  }
/////VIRTUAL REALITY INTEGRATION WITH React Native on android.
///Integrate SWUP for client side rendering 
///////write program to record common actions.
//services.AddMvc(options => options.Filters.Add<ApprovalRequiredForAction>());
//services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
// .AddEntityFrameworkStores<ApplicationDbContext>();
//services.AddScoped<ApprovalRequiredForActionAttribute, ApprovalRequiredForActionFilter>();
