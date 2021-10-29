using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    /// <summary>
    /// This is what we call a SUPER class, as it's used as a ground for other classes.
    /// </summary>
    class Chef
    {
        /// <summary>
        /// Tell the chef to make a chicken.
        /// </summary>
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        /// <summary>
        /// Tell the chef to make a salad
        /// </summary>
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        /// <summary>
        /// Tell teh chef to make a special dish.
        /// This is a virtual method, this means that we can OVERRIDE in subclasses, like Italian Chef.
        /// </summary>
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes BBQ ribs");
        }
    }
}
