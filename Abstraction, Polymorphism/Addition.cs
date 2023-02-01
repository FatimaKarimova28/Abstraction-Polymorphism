using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Polymorphism
{
    internal class Addition : Calculation
    {
        public sealed override void Operate(int numberX, int numberY)
        {
            int result = numberX + numberY;
            Console.WriteLine($"Addition: first number = {numberX}, second number = {numberY}. Result = {result}");
        }

    }
}
