using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyModelContainer db = new MyModelContainer())
            {
                db.NamesSet.Add(new Names { Name = "Alex", Age = 21});
                db.NamesSet.Add(new Names { Name = "Den", Age = 20});
                db.SaveChanges();

                var list = db.NamesSet.ToList();
                foreach (var name in list)
                {
                    Console.WriteLine("{0}. {1} {2}", name.Id, name.Name, name.Age);
                }
            }
        }
    }
}
