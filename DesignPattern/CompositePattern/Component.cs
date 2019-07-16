using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void AddComp(Component c);
        public abstract void RemoveComp(Component c);
        public abstract void DisplayComp(int depth);
    }
}
