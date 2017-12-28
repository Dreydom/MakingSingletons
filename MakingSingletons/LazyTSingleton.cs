using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSingletons
{
    public class LazyTSingleton
    {
        private static readonly Lazy<LazyTSingleton> lazy =
            new Lazy<LazyTSingleton>(() => new LazyTSingleton());

        public string Name { get; private set; }

        private LazyTSingleton()
        {
            Name = System.Guid.NewGuid().ToString();
        }

        public static LazyTSingleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
