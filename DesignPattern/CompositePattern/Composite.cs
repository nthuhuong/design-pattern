using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();
        public Composite(string name)
            : base(name)
        {

        }
        public override void AddComp(Component c)
        {
            _children.Add(c);
        }
        public override void RemoveComp(Component c)
        {
            _children.Remove(c);
        }
        public override void DisplayComp(int depth)
        {
            
            Console.WriteLine(new String ('-',depth) + name);
            foreach (Component component in _children)
                component.DisplayComp(depth + 2);
        }
    }
}
