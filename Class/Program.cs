/*
 * Sınıflar içlerinde metotlar, propertys ve değişkenleri barındırırlar
 *
 * Class içerisinde class oluşturulabilir ve bu class a ulaşılabilir
 *
 * Class bir ref tiptir ve ref olan bir tipi kullanabilmek için instance ini oluşturmalıyız ve içindekiler kullanabilmekteyiz
 *
 */


/* Class içerisinde olan metotlara ulaşmak için sürekli instance mı almak durumundayız ?
 - STATIC
 - Main metodu aslında static bir metottur 
 - Static method oluşturursak ilgili class'tan instance oluşturmadan metoda erişebilmekteyiz 
 - Static methodlar instance alınan class içerisinde görünmemektedir
 
 NEDEN ??
 - Uygulamanın her yerinde kullanılan bir metot var, her yapı içerisinde instance edip ulşamak yerine kullanmaktayız
 -Metotlar gibi, variables da static olabilir
 
 -Class ın kendisi de static olabilir ama static bir class altında olan her method ve değişken de static olmak zorundadır

*/

using classes;
StaticMethodsClass.StaticMethod();

StaticMethodsClass staticMethodsClass = new StaticMethodsClass();
//staticMethodsClass. -> StaticMethod() yok
staticMethodsClass.NonStaticMethod();


/*
 * CONSTRUCTOR
 *
 * Bir sınıf new ile instance oluşturulduğu anda yapılması gereken veya beklenen bir işlem varsa bu constructor
 metot içerisinde aktarılır ve yeni örneği alındığı anda constructor çalıştırılır
 * 
 */

ClassWithConstructor classWithConstructor = new ClassWithConstructor(); //-> constructor metot çalıştırılır 

/*
 * PROPERTY NEDİR??
 -Class içerisinde doğrudan erişilmesini istemediğimiz değişkenler olabilir, bu değişkeni bir özellikten okuyabilir veya değiştirebiliriz
*/

ClassWithProperty classWithProperty = new ClassWithProperty();
classWithProperty.Num = 4;
Console.WriteLine(classWithProperty.Num);

/*
 Const ve readonly 
 */





