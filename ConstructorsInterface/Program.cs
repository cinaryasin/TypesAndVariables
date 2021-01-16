using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FileLogger()); // constructors kullanımında programcı burayı girmeyi unutmaz.
            //customerManager.Add = new DatabaseLogger(); normalde bu şekilde belirtmemiz gerekecekti.
            customerManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();
        }
    }
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logger");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logger");
        }
    }

    class CustomerManager
    {
        ILogger _Logger;
        public CustomerManager(ILogger logger)
        {
            _Logger = logger;
        }
        public void Add()
        {
            _Logger.Log();
            Console.WriteLine("Added");
        }
    }

    //******************************************************************************************

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
}
