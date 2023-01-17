using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorComputerPartsExample
{
    public class Computer : IComputerPart
    {
        IComputerPart[] parts;
        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(computerPartVisitor);
            }
            computerPartVisitor.visit(this);
        }
    }
}