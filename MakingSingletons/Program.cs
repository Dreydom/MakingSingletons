using System;
using System.Threading;

namespace MakingSingletons
{
    class Program
    {
        static void Main(string[] args)
        {
            //НЕБЕЗОПАСНАЯ РЕАЛИЗАЦИЯ
            (new Thread(() =>
            {
                Computer comp2 = new Computer();
                comp2.OS = OS.getInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);

            })).Start();

            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            //LOCK-РЕАЛИЗАЦИЯ
            (new Thread(() =>
            {
                TSComputer comp4 = new TSComputer();
                comp4.TSOS = TSOS.getInstance("Windows 10 (TS)");
                Console.WriteLine(comp4.TSOS.Name);

            })).Start();

            TSComputer comp3 = new TSComputer();
            comp3.Launch("Windows 8.1 (TS)");
            Console.WriteLine(comp3.TSOS.Name);

            //LAZY SINGLETON
            (new Thread(() =>
            {
                LazySingleton lazySingleton = LazySingleton.GetInstance();
                Console.WriteLine(lazySingleton.Name);

            })).Start();
            LazySingleton lazySingleton2 = LazySingleton.GetInstance();
            Console.WriteLine(lazySingleton2.Name);

            //LAZY T SINGLETON
            (new Thread(() =>
            {
                LazyTSingleton lazyTSingleton = LazyTSingleton.GetInstance();
                Console.WriteLine(lazyTSingleton.Name);

            })).Start();
            LazyTSingleton lazyTSingleton2 = LazyTSingleton.GetInstance();
            Console.WriteLine(lazyTSingleton2.Name);

            Console.ReadLine();
        }
    }
}
