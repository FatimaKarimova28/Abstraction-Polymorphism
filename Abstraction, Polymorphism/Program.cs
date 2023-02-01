namespace Abstraction__Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("**********************--------------------------------**********************");
            Console.WriteLine("                                 Calculation:                             ");
            Console.WriteLine("===============================================================================");


            Addition adition= new Addition();
            adition.Operate(15, 10);
            Substraction substraction= new Substraction();
            substraction.Operate(8, 6);
            Multiplication multiplication= new Multiplication();
            multiplication.Operate(9, 7);
            Division division= new Division();  
            division.Operate(1010, 10);
        }
    }
}
