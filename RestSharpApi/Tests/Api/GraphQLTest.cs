using System.Net;
using System.Text.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpApi.Models;

namespace RestSharpApi.Tests.Api;

public class GraphQLTest
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    private const string BaseRestUri = "https://graphqlzero.almansi.me/api";

    [Test]
    public async Task SimpleGetTest()
    {
        const string endpoint = "";

        var client = new RestClient(BaseRestUri);
        var request = new RestRequest(endpoint, Method.Post);
        request.AddJsonBody(new
        {
            query = @"
            query {
                user(id: 1) {
                    id
                    name
                    email
                }
            }"
        });

        var response = await client.ExecuteAsync(request);

        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public async Task SimpleGetTest1()
    {
        const string endpoint = "";

        var client = new RestClient(BaseRestUri);
        var request = new RestRequest(endpoint, Method.Post);

        // Динамический GraphQL-запрос с переменной $id
        var graphqlQuery = new
        {
            query = @"
            query GetUser($id: ID!) {
                user(id: $id) {
                    id
                    name
                    email
                }
            }",
            variables = new { id = 1 } // Передаем id динамически
        };

        request.AddJsonBody(graphqlQuery);

        var response = await client.ExecuteAsync(request);

        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

    [Test]
    public async Task SimpleGetTest2()
    {
        const string endpoint = "";

        var client = new RestClient(BaseRestUri);
        var request = new RestRequest(endpoint, Method.Post);

        // Динамически формируем список полей
        var fields = new string[] { "id", "name", "email" };
        var fieldQuery = string.Join("\n", fields);
        
        // Динамический GraphQL-запрос с переменной $id
        var graphqlQuery = new
        {
            query = $@"
            query GetUser($id: ID!) {{
                user(id: $id) {{
                    {fieldQuery}
                }}
            }}",
            variables = new { id = 1 } // Передаем id динамически
        };

        request.AddJsonBody(graphqlQuery);

        var response = await client.ExecuteAsync(request);

        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }
    
    [Test]
    public async Task SimplePostTest()
    {
        const string endpoint = "";

        var client = new RestClient(BaseRestUri);
        var request = new RestRequest(endpoint, Method.Post);

        var query = new
        {
            query = @"
            mutation (
                $input: CreatePostInput!
            ) {
                createPost(input: $input) {
                    id
                    title
                    body
                }
            }",
            variables = new
            {
                input = new
                {
                    title = "My title",
                    body = "My body"
                }
            }
        };
        
        request.AddJsonBody(query);

        var response = await client.ExecuteAsync(request);

        Logger.Debug(response.Content);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    }

}