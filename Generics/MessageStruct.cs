namespace Generics;

public struct MessageStruct
{
    public string Text { get; }

    public MessageStruct(string text)
    {
        Text = text;
    }

    public override string ToString()
    {
        return $"{nameof(Text)}: {Text}";
    }
}