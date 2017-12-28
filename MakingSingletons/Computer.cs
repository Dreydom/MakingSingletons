using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSingletons
{
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
   
    class OS
    {
        private static OS instance;
        public string Name { get; private set; }

        private OS(string name)
        {
            Name = name;
        }
        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
