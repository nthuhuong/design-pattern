using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
            
        }
        public override void AddComp(Component c)
        {

            Console.WriteLine("Can't Add a Component");
        }
        public override void RemoveComp(Component c)
        {
            Console.WriteLine("Can't Remove a Component");
        }
        public override void DisplayComp(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
