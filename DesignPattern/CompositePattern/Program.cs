using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.AddComp(new Leaf("LeafA"));
            root.AddComp(new Leaf("LeafB"));
            Composite comp = new Composite("Composite X");
            comp.AddComp(new Leaf("LeafXA"));
            comp.AddComp(new Leaf("LeafXB"));
            root.AddComp(comp);
            root.AddComp(new Leaf("LeafC"));
            Leaf leaf = new Leaf("LeafD");
            root.AddComp(leaf);
            root.DisplayComp(1);
        }
    }
}
