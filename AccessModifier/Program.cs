/*
 * Bir class, method, property veya değişkenin ulaşılma durumunu kontrol eden yapılardır
 * Metotlarda da değişkenlerde de kullanımı aynıdır
 
 Internal
 - Default verilen modifier
 - Sadece içind eolduğu projeden kullanılabilir
 
 Public 
 - Her yerden erişilebilmesine olanak sağlayan modifier
 
 
 Private 
 - Sadece yazıldığı sınıf içerisinde çağrılabilir ve kullanılabilir
 
 Protected
 - Sadece miras alınan sınıf içerisinde kullanılabilmektedir
 
 Protected Internal 
 - Ya miras alınacak ya da bulunduğu proje altında çalıştıralabilir metotlar
 */


using AccessModifier;

TestClass testClass = new TestClass();
testClass.Method();
testClass.InternalProtectedMethod();

TestClass2 testClass2 = new TestClass2();
testClass.Method();
testClass.InternalProtectedMethod();