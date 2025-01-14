namespace AccessModifier;

public class Methods
{
    public void PublicMethod()
    {
        Console.WriteLine("Public method");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected Method");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal Method");
    }

    internal protected void InternalProtectedMethod()
    {
        Console.WriteLine("Protected Internal Method");
    }
}