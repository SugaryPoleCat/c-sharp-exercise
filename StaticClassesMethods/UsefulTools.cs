using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesMethods
{
    /// <summary>
    /// This is a static class. Means you can not initialise it like so: UsefulTools tools = new UsefulTools();
    /// Static classes are useful, if you need something like this.
    /// </summary>
    static class UsefulTools
    {
        /// <summary>
        /// Gets name and returns "Hello {name}"
        /// </summary>
        /// <param name="name">The name of hte user</param>
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
