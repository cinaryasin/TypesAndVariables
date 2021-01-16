using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();

            sqlServer.Add();
            sqlServer.Delete();

            Console.WriteLine("Yukarı Sql ************************ Aşağı MySql");

            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
            mySqlServer.Delete();

            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() //virtual kullandığımızda ortak kullanım alanı olmayan classlarda override yazdığımız zaman bu metodu orada değiştirebiliyoruz.
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete() //virtual
        {
            Console.WriteLine("Deleted by default");
        }

    }

    class SqlServer : Database
    {
        public override void Add()
        {//Biz farklı bir kod yazdırmak istersek override içerisinde istediğimiz metodu değiştirip farklı yazılmasını sağlayabiliriz.

            Console.WriteLine("SqlServer'da Codu değiştirdik ve bu kod sadece SqlServer'a ait oldu");
            //base.Add();// bu yine aynı codu getirir.
        }
    }

    class MySqlServer : Database
    {
        //My sql den ise delete komutunu değiştirelim
        public override void Delete()
        {
            Console.WriteLine("MySqlServer'da delete kodunu değiştirdik ve bu koda artık sadece MySql'e ait oldu");
            base.Delete();
        }
    }
}
