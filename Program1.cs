class Program{
    public static void Main(string[] args){
        Console.WriteLine("Hello");
        Console.WriteLine("there");
        Console.WriteLine("Obi-Wan");
        Console.WriteLine("Kenobi");


        

    }
     static int AverageNum(int [] num){

        int sum = 0;
        int SumDidgits =0;
        foreach (int number in num){
        sum+=number;
        SumDidgits+=1;
        }
        int result = sum/SumDidgits;
        return result;








    }
}