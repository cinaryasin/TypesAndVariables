using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class VarKeyword
    {
        public static void AnaKod()
        {
            //Var Keyword 
            //Var Keyword bir değişken değildir fakat değişken tutmak için kullanılır.

            var number = 18; // var otamatik olarak integer olarak algılar
            Console.WriteLine("var number değişkenine biz 18 değeri verdik {0}", number);
            number = 'a'; // number'a daha sonra char atarsak bunu var tekrardan yine int olarak değerlendirir.
            //Çünkü ilk başta number ' a biz int değeri verdik. Bu her durumda aynı olur. ilk str. verirsek öyle devam eder.
            Console.WriteLine("var number değişkenine daha sonra 'a' char atadık ama int olarak okumaya devam ediyor {0}", number);
            Console.ReadLine();



        }
    }
}
