using System.Web.Mvc;
using MvcMusicStore.Models.Configuration;

namespace MvcMusicStore.Models
{
    public static class ExtensionMethods
    {
        public static bool FeatureSwitch(this HtmlHelper helper, string featureName)
        {
            var featureManager = new FeatureManager();

            return featureManager.GetSwitchSetting<bool>(featureName);
        }
    }
}