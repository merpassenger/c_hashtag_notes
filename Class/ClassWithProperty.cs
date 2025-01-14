namespace classes;

public class ClassWithProperty
{
    private int _num;
    
    public int Num
    {
        get { return _num;}
        set { _num = value * 2; }
    }
}