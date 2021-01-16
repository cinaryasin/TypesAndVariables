using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); 
            customerManager.Logger = new SmsLogger(); // bu şekilde sadece loglamak istediğimiz yeri (new den sonraki yeri) değiştirmemiz yeterli olacakır.
            customerManager.Add();
            
            
            Console.ReadLine();
        }
    }
    /*Yapmamız gerekenler
     * interface tanımlıyoruz
     daha sonra hangi yönetim panelini oluşturacaksak onu tanımlıyoruz.CustomerManager gibi daga sonra işlemi yapmak istediğimiz classları oluşturuyoruz ve 
    interface leri implement ediyoruz. Daha sonra yönetim paneli içerisinden interface i çağırıyoruz (Örnek : Public ILogger Logger{get; set;})
    Daha sonra tönetim paneli içerisindeki public coid içerisine atadığımız alandan çağırdığımız interface i aktif hale getiriyoruz.
    Kodları çalıştıracağımız main metoduna gidip yönetici panelini çağırıyoruz ve yönetici panelinden hangi işlemi yapmak istediğimiz class çağırıyoruz 
    ve o class aktif hale geliyor.*/
    interface ILogger 
    {
        void log();

    }
    class CustomerManager
    {
        public ILogger Logger { get; set; } // Interfaceleri çekmek için kullandığımız araç kodu.
        public void Add()
        {
            Logger.log(); // interface leri çektiğimiz kod, bunun sayesinde istediğimiz class ın void ini çağırabiliyoruz.
            
            Console.WriteLine("CustomerManager Added!");
        }
    }
    

    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }
}
