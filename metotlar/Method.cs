namespace metotlar;

public class Method
{
    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static int SumResult(int num1, int num2, string text = "Success")
    {
        Console.WriteLine(text);
        return num1 + num2;
    }
}