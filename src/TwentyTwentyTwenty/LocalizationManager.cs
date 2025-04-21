using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace TwentyTwentyTwenty
{
    public static class LocalizationManager
    {
        private static readonly ResourceManager resourceManager = Strings.ResourceManager;
        private static CultureInfo currentCulture = Strings.Culture ?? CultureInfo.CurrentCulture;

        // Gets a string from the resources using the provided key. Throws ArgumentException if not found.
        public static string GetString(string name)
        {
            // Get the resource string based on the current culture
            string? value = resourceManager.GetString(name, currentCulture);

            if (value == null)
                throw new ArgumentException($"Resource key '{name}' not found.");

            return value;
        }

        // Gets a string from the resources using the provided key and formats it using named placeholders. Throws ArgumentException if not found.
        public static string GetFormattedString(string name, Dictionary<string, object> values)
        {
            string template = GetString(name);

            // Replace placeholders with provided values
            foreach (var pair in values)
            {
                template = template.Replace("{" + pair.Key + "}", pair.Value?.ToString());
            }

            return template;
        }
    }
}
