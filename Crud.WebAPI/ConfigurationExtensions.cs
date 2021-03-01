using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.WebAPI
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder AddFirstAvailableJsonFile(this IConfigurationBuilder builder,params string[] filePaths)
        {
            var fileProvider = builder.GetFileProvider();
            var firstAvailableFile = filePaths.FirstOrDefault(path => fileProvider.GetFileInfo(path).Exists);

            return firstAvailableFile != null ? builder.AddJsonFile(firstAvailableFile, optional: true, reloadOnChange: true) : builder;
        }
    }
}
