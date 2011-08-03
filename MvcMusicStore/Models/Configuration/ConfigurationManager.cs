using System;

namespace MvcMusicStore.Models.Configuration
{
    public interface IConfigurationManager
    {
        string GetProperty(string propertyName);
        T GetProperty<T>(string propertyName);
    }

    public class ConfigurationManager : IConfigurationManager
    {
        public string GetProperty(string propertyName)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(propertyName);
        }

        public T GetProperty<T>(string propertyName)
        {
            //work in here to get the Generic type written
            throw new NotImplementedException();
        }
    }
}