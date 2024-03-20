namespace RestSharpApi.Tests.Api;

public class HttpClientTest
{
    [Test]
    public async Task SimpleHttpClientTest()
    {
        const string restUrl = "https://reqres.in";

        // Создаем экземпляр HttpClient
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Выполняем GET-запрос к указанному URL
                //HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
                HttpResponseMessage response = await client.GetAsync(restUrl);

                // Проверяем успешность запроса
                if (response.IsSuccessStatusCode)
                {
                    // Читаем содержимое ответа как строку
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Ошибка: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка HTTP: {e.Message}");
            }
        }
    }
}