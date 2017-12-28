using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingSingletons
{
    class TSComputer
    {
        public TSOS TSOS { get; set; }
        public void Launch(string TSOSName)
        {
            TSOS = TSOS.getInstance(TSOSName);
        }
    }
    class TSOS
    {
        private static TSOS instance;

        public string Name { get; private set; }
        private static object syncRoot = new Object();
        protected TSOS(string name)
        {
            this.Name = name;
        }

        public static TSOS getInstance(string name)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new TSOS(name);
                }
            }
            return instance;
        }
    }
}
