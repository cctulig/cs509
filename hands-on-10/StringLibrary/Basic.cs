namespace StringLibrary;

public class Basic
{
    static public double add(double x, double y)
    {
        var a = someOtherFunction(x);
        return a + y;
    }

    static private double someOtherFunction(double a)
    {
        return a;
    }
}
