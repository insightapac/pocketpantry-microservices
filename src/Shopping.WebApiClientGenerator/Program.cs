using shopping;

namespace Shopping.WebApiClientGenerator
{
    class Program
    {
        public const string WebApiServiceFileLocation = @"..\..\..\..\..\..\pocketpantry-mobile\src\client\src\app\Clients\Shopping.client.ts";
        static void Main(string[] args)
        {
            WebApiClientGenerator.Generate(WebApiServiceFileLocation, typeof(Startup).Assembly);
        }
    }
}
