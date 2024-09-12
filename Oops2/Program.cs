namespace Oops2;
using ClassLibrary1;
    internal class Program
    {
        static void Main(string[] args)
        {
        //GoldOrnament gold = new GoldOrnament();
        //IBill bill = new GoldOrnament();
        //bill.SetCount();

        //Bill b = new Bill();
        //Console.WriteLine(b.Amount);
        //b.Amount = 100;
        //OnChange(b);
        //Console.WriteLine(b.Amount);


        //int c;
        //Console.WriteLine(FunctionWithMoreReturns(4, 3, out c));

        //(int, string) c = FunctionWithMoreReturns(8, 9, out _);
        //Console.WriteLine(c.Item1 + " " + c.Item2);

        //(int age, string name) = FunctionWithMoreReturns(8, 9, out _);
        //Console.WriteLine(age + " " + name);

        //int age;
        //string name;
        //(age, name) = FunctionWithMoreReturns(4, 5, out _);
        //Console.WriteLine(age+" "+name);

        foreach (var arg in GetNames())
        {
            Console.WriteLine(arg);
        }

    }
    static void OnChange(Bill b)
    {
        b.Amount = 79;
    }

    static (int,string) FunctionWithMoreReturns(int a,int b, out int c)
    {
        c = a+b;
        return (1, "niketh");

    }

    static IEnumerable<string> GetNames()
    {
        yield return "anil";
        yield return "abid";
        yield return "satvik";
        yield break;
    }

 }
struct Bill
{
    public double Amount;
    public Bill(double a)
    {
        Amount = a;
    }
    public Bill()
    {
        Amount = 69;
    }
}
