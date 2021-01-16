using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class DecimalVeriTipi
    {
        public static void AnaKod()
        {
            //Decimal Veri tipi
            //Decimal double ondalık veri tipinden daha fazla sayı tutabiliyor.Virgülden sonda daha fazla sayı alabiliyor.
            //Virgüllü hesaplamalarda daha hassas konularda virgülden sonra daha fazla sayı gerektiren konularda kullanılıyor.
            decimal paraBirimi = 5.15686564m; //double dan farklı olarak sayıların sonuna 'm' harfi konulur.
            //m harfinin büyük veya küçük olması birşeyi değiştirmiyor.
            Console.WriteLine("decimal paraBirimi değişkeninin aldığı değer {0}", paraBirimi);
            Console.ReadLine();
        }
    }
}
