namespace StringLibrary;

public interface IOne
{
    public int complexFunction(int x);
}

public class One : IOne
{
    public int complexFunction(int x)
    {
        return x;
    }
}

public class Two
{
    static public int f(int x, IOne a)
    {
        var b = a.complexFunction(x);
        return b;
    }
}