﻿using Microsoft.Extensions.Logging;
using DeleeRefreshMonkey.Views;
using DeleeRefreshMonkey.ViewModels;
using DeleeRefreshMonkey.Services;

namespace DeleeRefreshMonkey
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterDataServices()
                .RegisterPages()
                .RegisterViewModels();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            //--------singleton Pages
            builder.Services.AddSingleton<MonkeyView>();

            //--------Transient pages

            builder.Services.AddTransient<MonkeyDetailView>();

            return builder;
        }

        public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MonkeyService>();
            return builder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<MonkeyViewModel>();

            //--------Transient ViewModels
            builder.Services.AddTransient<MonkeyDetailViewModel>();

            return builder;
        }
    }
}