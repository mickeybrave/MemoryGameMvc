using System;
using MemoryGameMvc.Areas.Identity.Data;
using MemoryGameMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(MemoryGameMvc.Areas.Identity.IdentityHostingStartup))]
namespace MemoryGameMvc.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MemoryGameMvcContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MemoryGameMvcContextConnection")));

                services.AddDefaultIdentity<User>()
                    .AddEntityFrameworkStores<MemoryGameMvcContext>();
            });
        }
    }
}