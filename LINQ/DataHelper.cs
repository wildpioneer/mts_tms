using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LINQ;

public class DataHelper
{
    private List<string> data = new List<string>() { "asd", "qwe", "zxc" };
    protected Dictionary<string, object> map = new Dictionary<string, object>();

    public void GetData()
    {
        IEnumerable<string> files = Directory.EnumerateFiles("data");
        string fileName = Directory.EnumerateFiles("data").First(p => p.EndsWith("Example1.json"));

        Console.WriteLine(fileName);

        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        map.Add("propery", data);
        var json = JsonSerializer.Serialize(map);
        Console.WriteLine(json);
    }

    public DataFile GetData(string filename)
    {
        var json = File.ReadAllText($"data{Path.DirectorySeparatorChar}{filename}");
        var data = JsonConvert.DeserializeObject<DataFile>(json);

        foreach (var item in data.Data)
            Console.WriteLine(item);
        
        return data;
    }

    public class DataFile
    {
        public List<string> Data { get; set; }
    }
}