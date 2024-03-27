using API;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.GetData().Wait();
        }
    }
}
