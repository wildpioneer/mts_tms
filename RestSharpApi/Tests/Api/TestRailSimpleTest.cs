using System.Net;
using System.Text.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace RestSharpApi.Tests.Api;

public class TestRailSimpleTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://aqa2504.testrail.io/";

    [Test]
    public void SimpleGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/1";
        
        var options = new RestClientOptions(BaseRestUri) {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        var client = new RestClient(options);
        
        var request = new RestRequest(endpoint);
        
        var response = client.ExecuteGet(request);
        
        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public void AdvancedGetTest()
    {
        const string endpoint = "index.php?/api/v2/get_user/{user_id}";
        
        var options = new RestClientOptions(BaseRestUri) {
            Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
        };

        var client = new RestClient(options);
        
        var request = new RestRequest(endpoint)
            .AddUrlSegment("user_id", 1);
        
        var response = client.ExecuteGet(request);
        
        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }    
    
    [Test]
    public void AdvancedPostTest()
    {
        const string endpoint = "index.php?/api/v2/add_project";
        
        Dictionary<string, object> json = new Dictionary<string, object>();
        json.Add("name", "WP Project 1");
        json.Add("announcement", "Test project's description");
        json.Add("show_announcement", true);
        json.Add("suite_mode", 1);
        
        
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
            .AddJsonBody(JsonSerializer.Serialize(json));
        
        var response = client.ExecutePost(request);
        Logger.Debug(response.Content);
        
        // Преобразуем тело ответа в объект JSON
        dynamic responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content);
        
        // Получаем значение поля "id"
        int id = responseObject.id;

        // Используем значение "id" по своему усмотрению
        Console.WriteLine($"Значение поля 'id': {id}");
        
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
}