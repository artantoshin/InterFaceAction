using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceAction
{
    // применение интерфейса в классе
    class Person : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Человек идет");
        }
    }
    // применение интерфейса в структуре
    struct Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
