using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSingletons
{
    public class LazySingleton
    {
        public string Name { get; private set; }

        private LazySingleton()
        {
            Name = Guid.NewGuid().ToString();
        }

        public static LazySingleton GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
