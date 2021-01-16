using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        /* Private erişim bildirgeci : sadece tanımlandığı blok içerisinde çağırılabilir. Sadece kendi sınıfı içerisinde kullanılabilir.
        int, string default değişkeni private dir.*/
        /* Protected erişim bildirgeci : private bildirgecinin yaptığı herşeyi yapar fakat Sadece kendi sınıfı değil diğer sınıflardada kullanılır.
        Diğer sınıfta kullanılması için tanımlandığı sınıfın diğer sınıfa referans edilmesi gerekir. */
        /* Internal erişim bildirgeci : Class ların default özelliği internal dır. Bağlı olduğu proje içerisinde referans olmadan kullanılabilir.
        Aynı proje içerisinde yeni bir class sayfası oluştursakta o sayfa içerisinden çağırabiliriz. */
        /* Public erişim bildirgeci : Farklı bir projedende çağırılabilir ve kullanılabilir. Projeler arasında referans oluşturulur. */
    }
}
