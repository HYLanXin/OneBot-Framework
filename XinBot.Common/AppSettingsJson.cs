using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace XinBot.PublicCommon
{
    public class AppSettingsJson
    {
        public static IConfiguration Configuration { get; set; }

         static AppSettingsJson()
        {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载            
            Configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            .Build();
        }
    }
}
