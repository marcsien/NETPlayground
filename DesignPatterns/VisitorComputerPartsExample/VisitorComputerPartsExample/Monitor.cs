using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorComputerPartsExample
{
    public class Monitor : IComputerPart
    {
        public void accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}
