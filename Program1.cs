class Program{
    public static void Main(string[] args){
        Console.WriteLine("Hello");
        Console.WriteLine("there");
        Console.WriteLine("Obi-Wan");
        Console.WriteLine("Kenobi");

        int [] tab = {0,2,8,1,6,14,27}
        Console.WriteLine(AverageNum(tab))
            Console.WriteLine(HighestNum(tab))


        

    }
     static int AverageNum(int [] num){

        int wynik = 0;
        int SumDidgits =0;
        foreach (int number in num){
        wynik+=number;
        SumDidgits+=1;
        }
        int result = wynik/SumDidgits;
        return result;
    }

    static int HighestNum(int [] nums){
        int bigNum = nums[0];
        foreach(int number in nums){
            if(number>bigNum)
            bigNum = number;
        }
        return bigNum;


    }
     
}