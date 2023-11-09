using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мебельная_фабрика
{
    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
    interface IChair
    {
        void BoughtChair();
    }
    interface ISofa
    {
        void BoughtSofa();
    }
    interface ITable
    {
        void BoughtTable();
    }
    
    class ArDecoFurnitureFactory: IFurnitureFactory // АрДеко мебель
    {
        public IChair CreateChair()
        {
            return new ArDecoChair();
        }
        public ISofa CreateSofa()
        {
            return new ArDecoSofa();
        }
        public ITable CreateTable()
        {
            return new ArDecoTable();
        }
    }
    class ArDecoChair: IChair
    {
        public void BoughtChair()
        {
            Console.WriteLine("Вы купили АрДеко стул");
        }
    }
    class ArDecoSofa : ISofa
    {
        public void BoughtSofa()
        {
            Console.WriteLine("Вы купили АрДеко диван");
        }
    }
    class ArDecoTable : ITable
    {
        public void BoughtTable()
        {
            Console.WriteLine("Вы купили АрДеко стол");
        }
    }

    class VictorFurnitureFactory : IFurnitureFactory // Викторианская мебель
    {
        public IChair CreateChair()
        {
            return new VictorChair();
        }
        public ISofa CreateSofa()
        {
            return new VictorSofa();
        }
        public ITable CreateTable()
        {
            return new VictorTable();
        }
    }
    class VictorChair : IChair
    {
        public void BoughtChair()
        {
            Console.WriteLine("Вы купили Викторианский стул");
        }
    }
    class VictorSofa : ISofa
    {
        public void BoughtSofa()
        {
            Console.WriteLine("Вы купили Викторианский диван");
        }
    }
    class VictorTable : ITable
    {
        public void BoughtTable()
        {
            Console.WriteLine("Вы купили Викторианский стол");
        }
    }

    class ModernFurnitureFactory : IFurnitureFactory // Модерн мебель
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
    class ModernChair : IChair
    {
        public void BoughtChair()
        {
            Console.WriteLine("Вы купили Модерн стул");
        }
    }
    class ModernSofa : ISofa
    {
        public void BoughtSofa()
        {
            Console.WriteLine("Вы купили Модерн диван");
        }
    }
    class ModernTable : ITable
    {
        public void BoughtTable()
        {
            Console.WriteLine("Вы купили Модерн стол");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory asd = new ArDecoFurnitureFactory();
            asd.CreateChair().BoughtChair();
            Console.ReadLine();
        }
    }
}
