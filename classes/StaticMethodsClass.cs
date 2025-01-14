namespace classes;

public class StaticMethodsClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("Worked Static Method");
    }
    
    public  void NonStaticMethod()
    {
        Console.WriteLine("Worked Nonstatic Method");
    }

    public static int Variable = 0;
}