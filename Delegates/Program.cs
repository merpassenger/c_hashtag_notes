/*
 * Bir metodu bizim adımıza  çağıran yapılardır
 * Oluşturulan delegenin dönüş türü çağrılacak methodun dönüş tipinde olmak zorundadır
 * Delege dönüş tipi aynı olan birden fazla metotu içinde bulundurabilir, zaten kullanma amacı budur
 *
 */

using Delegates;

Faiz faiz = new Faiz();

//Faiz.Hesapla faizhesapla;
//faizhesapla = faiz.YıllıkFaiz;
//faizhesapla(10000, 12);

faiz.FaizHesaplaDelegeCalistir(10000,12);