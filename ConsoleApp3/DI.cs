using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DI
    {
        public static void Main223(String[] args)
        {

            
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICAR, BMW>();
            Driver objDrv = container.Resolve<Driver>();
            objDrv.RunCar();


        }

       
    }

    public interface ICAR
    {
         int run();
    }

    public class BMW : ICAR
    {
        private int miles = 0;
        public int run()
        {
            return ++miles;
        }
    }

    public class Ford : ICAR
    {
        private int miles = 0;
        public int run()
        {
            return ++miles;
        }
    }
    
    public class AUDI : ICAR
    {
        private int miles = 0;

        public int run()
        {
            return ++miles;
        }

    }

    public class Driver
    {
        private ICAR _car = null;
        public Driver(ICAR car)
        {
            _car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.run());
        }
    }

    
    
}
