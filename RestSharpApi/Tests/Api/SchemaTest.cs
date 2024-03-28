using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpApi.Models;

namespace RestSharpApi.Tests;

public class SchemaTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://aqa2504.testrail.io/";

    [Test]
    public void JsonSchemaTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";

        Project expectedProject = new Project
        {
            Name = "WP Project 2",
            Announcement = "Test project description",
            IsShowAnnouncement = true,
            SuiteMode = 2
        };

        // Загрузка JSON-схемы из файла
        string schemaJson = File.ReadAllText(@"Resources/schema.json");

        // Создем экземпляр JSON-схемы
        JSchema schema = JSchema.Parse(schemaJson);

        var options = new RestClientOptions(BaseRestUri)
        {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        // Setup Rest Client
        var client = new RestClient(options);

        // Setup Request
        var request = new RestRequest(endpoint).AddJsonBody(expectedProject);

        // Execute Request
        var response = client.ExecutePost(request);

        // Проверяем статус ответа
        if (response.StatusCode == HttpStatusCode.OK)
        {
            // Получаем тело ответа в виде JObject
            JObject responseData = JObject.Parse(response.Content);

            // Проверка соответствия ответа JSON-схеме
            Assert.That(responseData.IsValid(schema));
        }
    }

    [Test]
    public void SchemaTest1()
    {
        string schemaJson = @"{
            'description': 'A person',
            'type': 'object',
            'properties':
                {
                    'name': {'type':'string'},
                    'hobbies': {
                        'type': 'array',
                        'items': {'type':'string'}
                    }
                }
        }";

        JsonSchema schema = JsonSchema.Parse(schemaJson);

        JObject person = JObject.Parse(@"{'name': 'James','hobbies': ['.NET', 'Blogging', 'Reading', 'Xbox', 'LOLCATS']}");
        Assert.That(person.IsValid(schema));
    }
}