using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Azure.WebJobs.Host.Config;
using System;
using System.Threading.Tasks;

namespace AzureFunctions.Extensions.Settings
{
    public class SettingsExtensionConfig : IExtensionConfigProvider
    {
        void IExtensionConfigProvider.Initialize(ExtensionConfigContext context)
        {

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var rule = context.AddBindingRule<SettingAttribute>();
            rule.BindToInput(builderString);

        }

        private Task<string> builderString(SettingAttribute arg1, ValueBindingContext arg2)
        {
            return Task.FromResult(System.Environment.GetEnvironmentVariable(arg1.SettingKey, EnvironmentVariableTarget.Process));
        }

    }
}