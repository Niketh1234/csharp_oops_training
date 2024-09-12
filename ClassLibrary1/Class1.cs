namespace ClassLibrary1
{
    public class Class1
    {
        int[] Arr;
        int N;
        public Class1(int[]Arr,int N)
        {
            this.Arr = Arr;
            this.N = N;
        }
        public void ShowDetails()
        {
            int FirstNumber = Arr[0];
            int Highest = FirstNumber;
            int Lowest = FirstNumber;
            int Sum = FirstNumber;
            for(int i = 1; i < N; i++)
            {
                Sum += Arr[i];
                if (Highest < Arr[i])
                    Highest = Arr[i];
                if (Lowest > Arr[i])
                    Lowest = Arr[i];
            }
            Console.WriteLine($"Sum : {Sum}\nAverage : {Sum/N}\nHighest : {Highest}\nLowest : {Lowest} ");
        }
    }
}
