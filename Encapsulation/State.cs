namespace Encapsulation;

class State
{
    // все равно, что private string defaultVar;
    string defaultVar = "default";

    // поле доступно только из текущего класса
    private string privateVar = "private";

    // доступно в любом месте программы, а также для других программ и сборок
    public string publicVar = "public";

    // доступно из текущего класса и производных классов
    protected string protectedVar = "protected";

    // доступно в любом месте текущего проекта
    internal string internalVar = "internal";

    // доступно в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal string protectedInternalVar = "protected internal";

    // доступно из текущего класса и производных классов, которые определены в этом же проекте
    private protected string protectedPrivateVar = "protected private";


    // доступен в любом месте программы, а также для других программ и сборок
    public void PrintPublic() => Console.WriteLine(publicVar);

    // по умолчанию имеет модификатор private
    void Print() => Console.WriteLine(defaultVar);
    
    // доступен в любом месте текущего проекта
    internal void PrintInternal() => Console.WriteLine(internalVar);
    
    // доступен из текущего класса и производных классов
    protected void PrintProtected() => Console.WriteLine(protectedVar);
    
    // доступен в любом месте текущего проекта и из классов-наследников в других проектах
    protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);
    
    // доступен из текущего класса и производных классов, которые определены в этом же проекте
    protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

}