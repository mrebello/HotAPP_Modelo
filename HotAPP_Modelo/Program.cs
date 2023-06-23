using HotAPP_Modelo.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HotAPP_Modelo;

internal class Program : HotAPP<App> {
    [STAThread]
    private static int Main(string[] args) {
        return MainService<Program>();
    }

    public override void Config_Services(IServiceCollection services) {
        base.Config_Services(services);

        services.AddSingleton<WeatherForecastService>();
    }
}