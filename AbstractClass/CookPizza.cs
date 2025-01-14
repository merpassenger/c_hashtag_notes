namespace abstractClass;


public abstract class CookPizza
{
    public void AddStandardMaterial()
    {
        Console.WriteLine("Added Cheese");
        Console.WriteLine("Added Souce");
    }

    public abstract void ExtraMaterial();


}