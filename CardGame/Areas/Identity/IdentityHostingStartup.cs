﻿using System;
using CardGame.Areas.Identity.Data;
using CardGame.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CardGame.Areas.Identity.IdentityHostingStartup))]
namespace CardGame.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CardGameContextConnection")));

                services.AddDefaultIdentity<CardGameUser>()
                    .AddEntityFrameworkStores<IdentityContext>();
            });
        }
    }
}