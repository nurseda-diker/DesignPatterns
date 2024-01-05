using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee monica = new Employee { Name="Monica Geller"};
            Employee rachel = new Employee { Name="Rachel Green"};
            Employee chandler = new Employee { Name="Chandler Bing"};
            monica.AddSubordinate(rachel);
            monica.AddSubordinate(chandler);
            Employee ross = new Employee { Name = "Ross Geller" };
            rachel.AddSubordinate(ross);

            Console.WriteLine(monica.Name);
            foreach (Employee manager in monica)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (Employee employee in manager)
                {
                    Console.WriteLine("    {0}",employee.Name);
                }
          
            }

            Console.ReadLine();

        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        public string Name { get; set; }
        List<IPerson> _subordinates =new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach(var person in _subordinates)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
