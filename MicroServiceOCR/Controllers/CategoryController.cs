using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MicroServiceOCR.DBContexts;
using MicroServiceOCR.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace MicroServiceOCR.Controllers
{

    public class Family
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string LastName { get; set; }
        public bool IsRegistered { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // ADD THIS PART TO YOUR CODE
        private const string EndpointUri = "https://pocketpantry.documents.azure.com:443";
        private const string PrimaryKey = "LcsINk458SyVp9bESOoLSF9pqhXduM04wxcJSl14XKsEYXfz0ruS5GtnX8ccUuTASxJEgBC1PwntH83fkF4Ktg==";
        private DocumentClient client;

        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: api/Category
        [HttpGet]
        public IActionResult Get()
        {
            ExecuteSimpleQueryAsync("pocketpantrydb", "allcollections2");

            var categories = _categoryRepository.GetCategories();
            return new OkObjectResult(categories);

        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var category = _categoryRepository.GetCategory(id);
            return new OkObjectResult(category);
        }

        // POST: api/Category
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private async void ExecuteSimpleQueryAsync(string databaseName, string collectionName)
        {
            this.client = new DocumentClient(new Uri(EndpointUri), PrimaryKey);
            var queryOptions = new FeedOptions { MaxItemCount = -1 };

            var familyQuery = this.client.CreateDocumentQuery<Family>(
                   UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), queryOptions);

            foreach (Family family in familyQuery)
            {
                await DeleteFamilyDocument(databaseName, collectionName, family.Id);
                Console.WriteLine("\tRead {0}", family);
            }

            var wakefieldFamily = new Family
            {
                Id = new Guid().ToString(),
                LastName = "smith"
                 ,
                IsRegistered = true
            };

            await CreateFamilyDocumentIfNotExists("pocketpantrydb", "allcollections2", wakefieldFamily);
        }

        private async Task CreateFamilyDocumentIfNotExists(string databaseName, string collectionName, Family family)
        {
            try
            {
                var r = await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, family.Id));
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), family);
                }
                else
                {
                    throw;
                }
            }
        }
        private async Task DeleteFamilyDocument(string databaseName, string collectionName, string documentName)
        {
            await this.client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, documentName));
            Console.WriteLine("Deleted Family {0}", documentName);
        }
    }
}
