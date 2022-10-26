using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatternDemo
{
    public class FileLogger : AbstractLogger
    {

   public FileLogger(int level)
    {
        this.level = level;
    }

   protected override void write(String message)
    {
        Console.WriteLine("File::Logger: " + message);
    }
    }
}
