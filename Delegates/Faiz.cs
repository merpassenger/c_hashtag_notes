namespace Delegates;

public class Faiz
{
    public delegate void Hesapla(decimal Tutar, int Vade);

    public void FaizHesaplaDelegeCalistir(decimal Anapara, int Vade)
    {
        Hesapla hesapla;
        hesapla = YıllıkFaiz;
        hesapla += GunlukFaiz;
        hesapla(Anapara, Vade);
    }

    public void GunlukFaiz(decimal Anapara, int Vade)
    {
        Console.WriteLine($"Günlük Kazanç: {Anapara * 7 * Vade / 36500}");
    }
    
    public void AylıkFaiz(decimal Anapara, int Vade)
    {
        Console.WriteLine($"Aylık Kazanç: {Anapara * 10 * Vade / 1200}");
    }
    
    public void YıllıkFaiz(decimal Anapara, int Vade)
    {
        Console.WriteLine($"Yıllık Kazanç: {Anapara * 15 * Vade / 100}");
    }
}