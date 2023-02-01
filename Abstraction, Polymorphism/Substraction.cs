using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__Polymorphism
{
    internal class Substraction : Calculation
    {
        public sealed override void Operate(int numberX, int numberY)
        {
            int result = numberX - numberY;
            Console.WriteLine($"Substraction: first number = {numberX}, second number = {numberY}. Result = {result}");
        }
    }
}
