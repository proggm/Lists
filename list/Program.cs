using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Phone> list = new List<Phone>();
            Phone phone = new Phone();

            Console.Write("Введите название модели: ");
            phone.model = Console.ReadLine();
            Console.Write("Введите кол-во памяти: ");
            phone.memory = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во мегапикселей: ");
            phone.camera = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название процессора: ");
            phone.proccesor = Console.ReadLine();

            list.Add(phone);
            foreach(var item in list)
            {
                Console.WriteLine("Model: "+item.model);
                Console.WriteLine("Memory: "+item.memory);
                Console.WriteLine("Camera: "+item.camera);
                Console.WriteLine("Proccesor: "+item.proccesor);
            }
            Console.ReadKey();
        }
    }

}
