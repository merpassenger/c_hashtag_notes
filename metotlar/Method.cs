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

    public static int ArraySum(int[] nums)
    {
        int sum = 0;
        foreach (var i in nums)
        {
            sum += i;
        }

        return sum;
    }
    
    public static int ArrayParamsSum(params int[] nums)
    {
        int sum = 0;
        foreach (var i in nums)
        {
            sum += i;
        }

        return sum;
    }

    public static void ChangeUsername(ref string username)
    {
        Console.WriteLine("Kullanıcı adını giriniz.");
        username = Console.ReadLine();
        Console.WriteLine(username + " sisteme giriş yaptı");
    }
    
    public static void Login(string username)
    {
        Console.WriteLine(username + " sisteme giriş yaptı");
    }

    public static int RecursiveSum(int num)
    {
        if (num == 0) return 0;
        return num + RecursiveSum(num - 1);
    }
    
}