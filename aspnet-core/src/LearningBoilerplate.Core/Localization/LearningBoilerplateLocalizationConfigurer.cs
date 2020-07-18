using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LearningBoilerplate.Localization
{
    public static class LearningBoilerplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LearningBoilerplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LearningBoilerplateLocalizationConfigurer).GetAssembly(),
                        "LearningBoilerplate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
