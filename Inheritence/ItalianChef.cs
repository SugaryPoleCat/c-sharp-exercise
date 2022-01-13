using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    /// <summary>
    /// Italian chef inherits abilites of normal chef, but also does italian cuisine.
    /// This is done without copy/pasting code, but with inheritence.
    /// So we INHERIT all the functions and functionallity and methods, but we can also extend the subclass furhter.
    /// </summary>
    class ItalianChef : Chef
    {
        /// <summary>
        /// Only italian chef can do this. If you tell CHEF to do it, he can't.
        /// </summary>
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }

        /// <summary>
        /// This is the overriden method from CHEF super class
        /// VIRTUAL methods that are overriden, should be called: public OVERRIDE void/int/string etc.
        /// </summary>
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes spaghetti.");
        }
    }
}
