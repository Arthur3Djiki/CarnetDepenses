// MauiProgram.cs : avant "return builder.Build();"
using CarnetDepenses;
using CarnetDepenses.Services;
using CarnetDepenses.ViewModels;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>();

        // en-tête : vos enregistrements de services
        builder.Services.AddSingleton<IDepenseRepository, JsonDepenseRepository>();
        builder.Services.AddSingleton<DepensesViewModel>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}