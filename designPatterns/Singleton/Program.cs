using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        static object _lockObject=new object();

        //sınıfın tek bir örneğinin olması için constructor,sınıfın dışarıdan new anahtar kelimesi ile oluşturulmasını engeller
        private CustomerManager()
        {

        }

        //singleton örneğini oluşturan ve mevcut bir örneğin olup olmadığını kontrol eden metot
        //lock sayesinde bu metot aynı anda sadece bir iş parçacığı tarafından çağrılabilir.
        public static CustomerManager CreateAsSingleton()
        {
            //lock ile iş parçacığı güvenliği sağlanır
            lock (_lockObject)
            {
                //_customerManager örneği null ise yeni örnek oluşturulur
                if(_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                    Console.WriteLine("Yeni örnek oluşturuldu");
                }
            }
            //kilit açılır ve oluşturulan veya mevcut olan _customerManager nesnesi geri döndürülür
            return _customerManager;

        }



    }
}
