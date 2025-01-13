//Main metot -> Programın ilk çalıştığı metottur, diğer metotlardan farkı ise metotlar çağrılmadan çalışmazken main metodu buid alındığı anda çalıştırırlır 

/*
 * Kodların daha düzenli olmasını sağlar
 * Erişim Belirteci + Dönüş Tipi + Metot İsmi
 * Metotlar her zaman class'lar içerisinde yer alır
*/

using metotlar;

var sumResult = Method.Sum(2,4);
Console.WriteLine(sumResult);


/*
 * Varsayılan parametre => Client ın vermediği ya da vermeyebileceği aalanda default bri değer eklenmesi
 *                         Varsayılan parametreler sonda olur, hepsine de default değer verilebilri
 */
var sumResultWitConsoleDefaultText = Method.SumResult(2, 5);
var sumResultWitConsoleText = Method.SumResult(2, 5, "Toplama İşlemi Başarılı");

Console.WriteLine(sumResultWitConsoleDefaultText);
Console.WriteLine(sumResultWitConsoleText);

/*
 6
 Success
 Toplama İşlemi Başarılı
 7
 7
 */







