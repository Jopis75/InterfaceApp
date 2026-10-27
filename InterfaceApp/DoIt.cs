using InterfaceApp.Interfaces;

namespace InterfaceApp
{
    public class DoIt : IRunner1, IRunner2
    {
        void IRunner1.Run()
        {
            Console.WriteLine("IRunner1.Run");
        }

        int IRunner2.Run()
        {
            Console.WriteLine("IRunner2.Run");

            return 7;
        }
    }
}
