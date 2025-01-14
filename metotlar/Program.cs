//Main metot -> Programın ilk çalıştığı metottur, diğer metotlardan farkı ise metotlar çağrılmadan çalışmazken main metodu buid alındığı anda çalıştırırlır 

/*
 * Kodların daha düzenli olmasını sağlar
 * Erişim Belirteci + Dönüş Tipi + Metot İsmi
 * Metotlar her zaman class'lar içerisinde yer alır
 * Metot içinde metot tanımlanamaz 
*/

using metotlar;

var sumResult = Method.Sum(2,4);
//Console.WriteLine(sumResult);


/*
 * Varsayılan parametre => Client ın vermediği ya da vermeyebileceği aalanda default bri değer eklenmesi
 *                         Varsayılan parametreler sonda olur, hepsine de default değer verilebilri
 */
var sumResultWitConsoleDefaultText = Method.SumResult(2, 5);
var sumResultWitConsoleText = Method.SumResult(2, 5, "Toplama İşlemi Başarılı");

//Console.WriteLine(sumResultWitConsoleDefaultText);
//Console.WriteLine(sumResultWitConsoleText);

/*
 6
 Success
 Toplama İşlemi Başarılı
 7
 7
 */

var sumResultArray = Method.ArraySum(new int[] { 1, 2, 3, 4 });
//Console.WriteLine(sumResultArray);

var sumResultParams = Method.ArrayParamsSum(1, 2, 3, 4, 5, 6, 7, 8, 9); //new ile yeni instance açmaya gerek yok
//Console.WriteLine(sumResultParams);


/*
 * Bir değer tipi referans tip olarak göstermek istiyorsak ref veya out kullanılır
 *
 * 1. ref Anahtar Sözcüğü
   Başlangıç Şartı: ref ile geçirilen değişkenin metoda gönderilmeden önce atanmış (initialize edilmiş) olması zorunludur.
   Amaç: Hem metoda girmeden önceki değeri okuyabilir hem de metottan sonra yeni değeri alabilirsiniz.
   Kullanım: Verinin metoda geçmeden önce kullanılması gerekiyorsa tercih edilir.
   
   2. out Anahtar Sözcüğü
   Başlangıç Şartı: out ile geçirilen değişkenin metoda gönderilmeden önce atanmış olması gerekmez.
   Amaç: Metodun dönüşünde değişkene mutlaka bir değer atanması garanti edilir.
   Kullanım: Değişkenin sadece metot içinde değer alması ve dışarıya bu değerle döndürülmesi isteniyorsa tercih edilir.
 */

string user = "Merve";

Method.Login(user);
Method.ChangeUsername(ref user);
Method.Login(user);

/*
   Merve sisteme giriş yaptı
   Kullanıcı adını giriniz.
   buse   
   buse sisteme giriş yaptı
   buse sisteme giriş yaptı

 */

/*
 * Method Overload -> Bir methodun birden fazla şekilde kullanılması olayıdır
 -> Parametre sayısına göre 
 -> Paramtre tiplerine göre 
 */


/*
 * Recursive metotlar
 */

int recursiveSum = Method.RecursiveSum(9);
Console.WriteLine(recursiveSum);


