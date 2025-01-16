/*
 * Bir class'ın başka bir class'tan miras alınması
 * Interface ile karıştırılmamalı çünkü interface içerisine tanımlanan metotlarda kod yazılmasına izin vermez ve implamente olurlar
 * Class üzeirnden ise miras alınabilir, onun içinde metot koduyla beraber kullanılabilir
 * Bir class sadece bir base class ı olabilir
*/

using inheritances;

InheritedClass inheritedClass = new InheritedClass();

inheritedClass.Save();