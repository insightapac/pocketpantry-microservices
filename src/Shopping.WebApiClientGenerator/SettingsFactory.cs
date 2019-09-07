using NSwag.CodeGeneration.TypeScript;
using NSwag.Generation.WebApi;

namespace Shopping.WebApiClientGenerator
{
    public static class SettingsFactory
    {
        public static WebApiOpenApiDocumentGeneratorSettings WebApiOpenApiDocumentGeneratorSettings = new WebApiOpenApiDocumentGeneratorSettings
        {
            Title = "Shopping Api",
            Description = "Web API for the Shopping API",
            Version = "1",
            DefaultUrlTemplate = "api/{controller}/{action}/{id?}",
            IsAspNetCore = true,
            AddMissingPathParameters = true,
            FlattenInheritanceHierarchy = false,
        };

        public static TypeScriptClientGeneratorSettings TpeScripGeneratorSettings = new TypeScriptClientGeneratorSettings
        {
            ClassName = "{controller}Client",
            Template = TypeScriptTemplate.Angular,
            TypeScriptGeneratorSettings =
            {
                TypeScriptVersion = (decimal) 3.6
            },
            GenerateDtoTypes = true,
            HttpClass = HttpClass.HttpClient,
            InjectionTokenType = InjectionTokenType.InjectionToken,
            GenerateClientInterfaces = true
        };
    }
}