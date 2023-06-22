using HotAPP_Modelo.Data;

namespace HotAPP_Modelo;

internal class Program : HotAPP<App>{
    [STAThread]
    private static int Main(string[] args) {
        return MainService<Program>();
    }

    public override void Config_Builder(WebApplicationBuilder builder) {
        base.Config_Builder(builder);

        builder.Services.AddSingleton<WeatherForecastService>();

        //builder.WebHost.UseStaticWebAssets();
    }
}
