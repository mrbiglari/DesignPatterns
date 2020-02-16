using DesignPatterns;
using DesignPatterns.Creational.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string [] args)
        {
            args = new string[10];
            //BuilderProgram.MainMethod(args);
            MediatorProgram.MediatorMain(args);
        }
    }
}
