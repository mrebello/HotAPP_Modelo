using HotAPP_Modelo.Data;
using Microsoft.FluentUI.AspNetCore.Components;

namespace HotAPP_Modelo;


/// <summary>
/// ATENÇÃO: Os assets não são copiados automaticamente.
/// Para gerar os assets atualizados e copiar, realizar uma publicação e copiar a pasta wwwroot.
/// </summary>


internal class Program : HotAPP<App> {
    [STAThread]
    private static int Main(string[] args) {
        return MainService<Program>();
    }

    public override void Config_Services(IServiceCollection services) {
        base.Config_Services(services);

        services.AddFluentUIComponents();

        services.AddSingleton<WeatherForecastService>();
    }
}