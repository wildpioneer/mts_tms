using RestSharp.Authenticators;
using RestSharpApi.Models;

namespace RestSharpApi.Tests.Api;

using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json.Schema;

public class SchemaTest
{
    private const string BaseRestUri = "https://aqa2504.testrail.io/";
    
    [Test]
    public void JsonSchemaTest()
    {
        // Загрузка JSON-схемы из файла
        string schemaJson = File.ReadAllText(@"Resources/schema.json");

        // Создание экземпляра JSON-схемы
        JSchema schema = JSchema.Parse(schemaJson);

        // Создание JSON-объекта для отправки запроса
        const string endpoint = "index.php?/api/v2/add_project";
        
        Project testProject = new Project
        {
            Name = "WP Project 1",
            Announcement = "Test project's description",
            ShowAnnouncement = true,
            SuiteMode = 1
        };
        
        var options = new RestClientOptions(BaseRestUri) {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };
        /*
         * Content-Type
         * RestSharp will use the correct content type by default. Avoid adding the Content-Type header manually
         * to your requests unless you are absolutely sure it is required. You can add a custom content type to the body parameter itself.
         */
        
        var client = new RestClient(options);
        
        var request = new RestRequest(endpoint)
            .AddJsonBody(testProject);
        
        var response = client.ExecutePost(request);

        // Проверка статуса ответа
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            // Получение тела ответа в виде JSON-объекта
            JObject responseData = JObject.Parse(response.Content);

            // Проверка соответствия ответа JSON-схеме
            if (responseData.IsValid(schema))
            {
                Console.WriteLine("Ответ соответствует JSON-схеме.");
            }
            else
            {
                Console.WriteLine("Ответ не соответствует JSON-схеме:");
            }
        }
        else
        {
            Console.WriteLine($"Ошибка запроса: {response.ErrorMessage}");
        }
    }
}
