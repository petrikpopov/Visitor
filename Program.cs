using System;
using System.Collections.Generic;

namespace Visitor_04._04._2023
{
    class Program
    {
        public abstract class AbstractDevice
        {
            public abstract void Insurance(IVisitor visitor);//страховка 
            
        }
        public class Car : AbstractDevice
        {
            public override void Insurance(IVisitor visitor)
            {
                visitor.VisitorCar(this);
            }
            public void InsuranceCar()
            {
                Console.WriteLine("Предложение о страховке машины");
            }
        }
        public class Home : AbstractDevice
        {
            public override void Insurance(IVisitor visitor)
            {
                visitor.VisitorHom(this);
            }
            public void InsuranceHome()
            {
                Console.WriteLine("Предложение о страховке дома");
            }
        }
        public class Banc : AbstractDevice
        {
            public override void Insurance(IVisitor visitor)
            {
                visitor.VisitorBanc(this);
            }
            public void InsuranceBanc()
            {
                Console.WriteLine("Предложение о страховке банка");
            }
        }
        public class Fabrica : AbstractDevice
        {
            public override void Insurance(IVisitor visitor)
            {
                visitor.VisitorFabrica(this);
            }
            public void InsuranceFabrica()
            {
                Console.WriteLine("Предложение о страховке фабрики");
            }
        }
        public class Bike : AbstractDevice
        {
            public override void Insurance(IVisitor visitor)
            {
                visitor.VisitorBike(this);
            }
            public void InsuranceBike()
            {
                Console.WriteLine("Предложение о страховке мотоцикла");
            }
        }
        ///  
        public abstract class IVisitor
        {
            public abstract void VisitorCar(Car car);
            public abstract void VisitorHom(Home home);
            public abstract void VisitorFabrica(Fabrica fabrica);
            public abstract void VisitorBike(Bike bike);
            public abstract void VisitorBanc(Banc banc);
        }
        public class Visitor : IVisitor
        {
            public override void VisitorCar(Car car)
            {
                car.InsuranceCar();
            }
            public override void VisitorHom(Home home)
            {
                home.InsuranceHome();
            }
            public override void VisitorFabrica(Fabrica fabrica)
            {
                fabrica.InsuranceFabrica();
            }
            public override void VisitorBike(Bike bike)
            {
                bike.InsuranceBike();
            }
            public override void VisitorBanc(Banc banc)
            {
                banc.InsuranceBanc();
            }
        }
        ///
        public class Person
        {
            List<AbstractDevice> visitors = new List<AbstractDevice>();

            public void Add(AbstractDevice abstractDevice)
            {
                visitors.Add(abstractDevice);
            }

            public void Rem(AbstractDevice abstractDevice)
            {
                visitors.Add(abstractDevice);
            }
            public void Accept(IVisitor visitor)
            {
                foreach (var device in visitors )
                {
                    device.Insurance(visitor);
                }
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Add(new Car());
            person.Add(new Home());
            person.Add(new Bike());
            person.Add(new Banc());
            person.Add(new Fabrica());
            person.Accept(new Visitor());
            
        }
    }
}
