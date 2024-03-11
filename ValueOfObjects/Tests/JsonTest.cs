using System.Text.Json;
using ValueOfObjects.Models;

namespace ValueOfObjects.Tests;

public class JsonTest
{
    [Test]
    public void JsonSerializerTest()
    {
        var testObject = new JsonObject1
        {
            Name = "Test Name",
            FieldValue = 10,
            IsEnabled = true,
            IgnoreObject = new string("Test Object")
        };

        var jsonString = JsonSerializer.Serialize<JsonObject1>(testObject);

        Console.WriteLine(jsonString);
    }

    [Test]
    public void JsonDeserializerTest()
    {
        string json = "{\"Name\":\"Test Name\",\"FieldValue\":10,\"IsEnabled\":true,\"IgnoreObject\":\"Test Object\"}";
        var jsonObject1 = JsonSerializer.Deserialize<JsonObject1>(json);

        Console.WriteLine(jsonObject1);
    }
    
    
}