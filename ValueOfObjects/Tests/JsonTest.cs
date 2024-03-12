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
    public void JsonDeserializerTest1()
    {
        string json = "{\"Name\":\"Test Name\",\"FieldValue\":10,\"IsEnabled\":true,\"IgnoreObject\":\"Test Object\"}";
        var jsonObject1 = JsonSerializer.Deserialize<JsonObject1>(json);

        Console.WriteLine(jsonObject1);
    }

    [Test]
    public void JsonDeserializerTest2()
    {
        using FileStream fs = new FileStream(@"Resources/testObject1.json", FileMode.Open);
        var jsonObject1 = JsonSerializer.Deserialize<JsonObject1>(fs);

        Console.WriteLine(jsonObject1);
    }
    
    [Test]
    public void JsonSerializerTest1()
    {
        var testObject1 = new JsonObject2
        {
            Name = "Test Name",
            FieldValue = 10,
            IsEnabled = false,
            IgnoreObject = new string("Test Object")
        };

        var jsonString = JsonSerializer.Serialize<JsonObject2>(testObject1);

        Console.WriteLine(jsonString);
    }

    [Test]
    public void JsonDeserializerTest3()
    {
        using FileStream fs = new FileStream(@"Resources/testObject2.json", FileMode.Open);
        var objectsList = JsonSerializer.Deserialize<List<JsonObject2>>(fs);

        objectsList!.ForEach(Console.WriteLine);
    }
}