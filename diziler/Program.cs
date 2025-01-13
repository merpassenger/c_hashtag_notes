/*
 * Nedir ??
 Birden çok aynı tipte veriye ihtiyaç duyuyorsak eğer diziler kullanılır.
 
*/

int number1 = 22;
int number2 = 44;
int number3 = 43;


//1.kullanım
int[] numbers = new int[3]; 

//2.kullanım
int[] numbers2;
numbers2 = new int[3]; 

//3.kullanım 
int[] numbers3 = new [] {22,43,78};

//4.kullanım
int[] numbers4 = new int[]{22,45,78}; 

//5.kullanım
int[] numbers5 = {22,43,78}; 

numbers[0] = 22;
numbers[1] = 45;
numbers[2] = 78;

/*
Çok Boyutlu Diziler : kaç boyutlu olacak(n) n-1 virgül eklenmeli 

Çok boyutlu diziler belirli türdeki verileri mantıklı ve düzenli bir şekilde temsil etmek için kullanılır.
1. Veri Tablosu Temsili: 
        İki boyutlu diziler, satır ve sütunlarla ifade edilen tablo benzeri verileri saklamak için idealdir.
        
2. Matris İşlemleri:
       Matematiksel matris işlemleri (çarpma, toplama vb.) yapmak için kullanılır. Bilimsel hesaplamalar ve makine öğrenimi algoritmalarında matris işlemleri sıkça yer alır.
   
3. Koordinat Sistemi veya Harita

4. Görüntü İşleme:
    Görüntüler genellikle piksel değerlerini temsil eden iki boyutlu diziler olarak saklanır. Renkli görüntülerde ise üç boyutlu diziler (satır, sütun, renk kanalı) kullanılabilir.

5. Zaman Serisi veya Çoklu Veri Setleri
*/


int[,] multisize = new int[2,3];
int[,] multisize1 = {{ 1, 2, 3 }, { 4, 5, 6 }};

//Dizilerde ForEach kullanımı 

foreach (var i in numbers)
{
    Console.WriteLine(i);
}


//Dizilerde Yapılabilecek İşlemler

int[] dizi1 = { 1, 2, 3, 4 };
int[] dizi2 = new int[6]; //varsayılan değerleri vardır, burada dizi bir referans tiptir ama içerisinde depoladığı int bir değer tiptir, o yüzden dizinin içerisindeki değer tiplerin mutlaka bir value su olmak durumundadır

dizi1.CopyTo(dizi2, 2); //2.indeksten itibaren dizi1 'i içine kopyala

Array.Copy(dizi1, dizi2, 2); // Kaç eleman kopyalayacağını söylüyoruz 120000
Array.Copy(dizi1,0,dizi2,2,4); //001234

Array.Clear(dizi1); //Varsayılan değerlerine döndürür
Array.Clear(dizi1,1,2); //Varsayılan değerlerine döndürür //4002
Array.Sort(dizi2);
Array.Reverse(dizi1);
