using InterfaceApp.Interfaces;

namespace InterfaceApp
{
    public class Program1 : IProgram, IProgramExt
    {
        //public void Run()
        //{
        //    Console.WriteLine("Nu kör vi Program1!");
        //}

        public void Start()
        {
            Console.WriteLine("Program1.Start");
        }

        public void Extend()
        {
            Console.WriteLine("Program1.Extend");
        }
    }
}
