using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using NSwag;
using NSwag.CodeGeneration.TypeScript;
using NSwag.Generation.WebApi;

namespace Shopping.WebApiClientGenerator
{
    public class WebApiClientGenerator
    {
        public static void Generate(string fileLocation, params Assembly[] assemblies)
        {
            var document = CreateDocument(assemblies);
            var generator = CreateGenerator(document);
            File.WriteAllText(fileLocation, generator.GenerateFile());
            Console.WriteLine(@"Services have been generated");
        }
        public static string Generate(params Assembly[] assemblies)
        {
            var generator = CreateGenerator(CreateDocument(assemblies));
            return generator.GenerateFile();
        }
        private static OpenApiDocument CreateDocument(params Assembly[] assemblies)
        {
            var swaggerGenerator = new WebApiOpenApiDocumentGenerator(SettingsFactory.WebApiOpenApiDocumentGeneratorSettings);
            var controllers = assemblies.SelectMany(x => x.GetTypes().Where(c => typeof(ControllerBase).IsAssignableFrom(c)));
            return swaggerGenerator.GenerateForControllersAsync(controllers).Result;
        }
        private static TypeScriptClientGenerator CreateGenerator(OpenApiDocument document)
        {
           
            return new TypeScriptClientGenerator(document, SettingsFactory.TpeScripGeneratorSettings);
        }
    }
}