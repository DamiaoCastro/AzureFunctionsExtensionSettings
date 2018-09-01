using AzureFunctions.Extensions.Settings;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(AzureFunctions.Extension.Settings.SettingsWebJobsStartup))]
namespace AzureFunctions.Extension.Settings
{
    public class SettingsWebJobsStartup : IWebJobsStartup
    {
        void IWebJobsStartup.Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension(new SettingsExtensionConfig());
        }

    }
}
