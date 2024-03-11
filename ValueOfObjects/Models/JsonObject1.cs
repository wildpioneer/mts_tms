namespace ValueOfObjects.Models;

public class JsonObject1
{
    public string Name { get; set; }
    public int FieldValue { get; set; }
    public bool IsEnabled { get; set; }
    public object IgnoreObject { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(FieldValue)}: {FieldValue}, {nameof(IsEnabled)}: {IsEnabled}, {nameof(IgnoreObject)}: {IgnoreObject}";
    }
}