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
        public override void Add(Component c)
        {
            _children.Add(c);
        }
        public override void Remove(Component c)
        {
            _children.Remove(c);
        }
        public override void Display(int depth)
        {
            for (int i = 0; i < depth;i++ )
            {
                Console.WriteLine('-');
            }
            Console.WriteLine(name);
            foreach (Component component in _children)
                component.Desplay(depth + 2);
        }
    }
}
