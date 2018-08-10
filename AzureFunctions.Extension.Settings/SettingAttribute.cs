﻿using Microsoft.Azure.WebJobs.Description;
using System;

namespace AzureFunctions.Extensions.Settings
{
    [Binding]
    public class SettingAttribute: Attribute
    {
        public SettingAttribute(string settingKey)
        {
            SettingKey = settingKey;
        }

        public string SettingKey { get; }

    }
}
