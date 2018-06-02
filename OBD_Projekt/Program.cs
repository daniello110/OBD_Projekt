using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.CS;
using Db4objects.Db4o.Linq;
using Db4objects.Db4o.NativeQueries;
using Db4objects.Db4o.Instrumentation;

namespace OBD_Projekt
{
    class Program
    {
        public static void ListResult(IObjectSet result)
        {
            Console.WriteLine(result.Count);
            foreach (object item in result)
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), "PojazdyDB");
            try
            {

            }
            finally
            {
                db.Close();
            }

        }
    }
}
