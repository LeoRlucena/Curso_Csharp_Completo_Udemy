namespace Modificador_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Calculator.Triple(ref a);            ref
            //Console.WriteLine(a);

            int a = 10;
            int triple;
            Calculator.Triplo(a, out triple);      // out
            Console.WriteLine(triple);
        }
    }
}
