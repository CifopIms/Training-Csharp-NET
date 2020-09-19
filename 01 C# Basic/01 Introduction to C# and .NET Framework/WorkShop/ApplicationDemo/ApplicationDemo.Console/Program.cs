using ApplicationDemo.Service;

namespace ApplicationDemo.Console
{
    class Program
    {
        // point d'entré
        static void Main(string[] args)
        {
            //Class1 class1 = new Class1();
            //System.Console.WriteLine("hello world");

            PaymentService paymentService = new PaymentService();
            double amount = paymentService.Calucalute(100);
            System.Console.WriteLine(amount);
            System.Console.Read();
        }
    }
}
