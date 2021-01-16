using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class InterfacesDemo
    {
        /*Bilgi; Bir class birden fazla interface implamente edebiliri. Bunu kullanma nedenimiz bazı classların bazı interface
         * araçlarına ihtiyaç duymamasıdır. Örneğin 1 robot yemek yiyemez.*/
        public static void InterfaceImplamente()
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
            new Worker(),
            new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();

            }
        }

    }
    interface IWorker
    {
        void Work();

    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, ISalary, IEat // Birden fazla interface i implament edebiliriz. // Kullanılacak alanlarına göre
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work");
        }
    }
    class Robot : IWorker // Robot sadece çalışır maaş almaz ve yemek yemez o sebeple sadece çalışma implamente edilir
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }

}
