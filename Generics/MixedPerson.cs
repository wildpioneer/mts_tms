namespace Generics;

public class MixedPerson<T, K> : GenericPerson<T>
    where K : struct
{
    public K Code { get; set; }

    public MixedPerson(T id, string name) : base(id, name)
    {
    }
}