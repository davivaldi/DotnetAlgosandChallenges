using System;
using System.Collections.Generic;

namespace fund1
{
    class Program
    {
        public static int [] RandomArray()
        {
            int[] arr3;
            int sum = 0;
            arr3 = new int[] {3,23,25,34,15,7,19,20,4};
            int min=arr3[0];
            int max=arr3[0];
            for(int i =1; i<arr3.Length; i++){
                sum+=arr3[i];
            if(arr3[i]> max){
                int temp = max;
                max =arr3[i];
                arr3[i]= temp;

            }
            else if(arr3[i]< max){
                int temp = min;
                min = arr3[i];
                arr3[i]=temp;
            }
           
         }
            Console.WriteLine("The max is "+max+ " The min is "+min+ " The sum of the array is "+ sum);
            return arr3;
        }

        public static string TossCoin(){
            System.Console.WriteLine("Tossing a Coin!.....");
            string coin = " ";
            Random rand = new Random();
            int side = rand.Next(1,3);
            if( side ==1){
                coin = "Heads";
                System.Console.WriteLine("Heads");
            }
            else{
                coin = "Tails";
                System.Console.WriteLine("Tails");
            }
            return coin;
        }

        public static double TossMulipleCoins(int num){
            int x =1;
            int tails =0;
            int heads =0;
            double tailsWin =0;
            double headsWin = 0;
            double tie=0;
            
            while(x<=num){
            
            string result = TossCoin();
            if(result == "Heads"){
                heads+=1;
            }
            else if (result ==" Tails"){
                tails+=1;
            }
              x++; 
            }
            if( tails >heads ){
                tailsWin = tails - heads;
            System.Console.WriteLine("There were "+tailsWin+" more than heads!"); 
            return tailsWin;
            }
            else if(heads > tails){
                headsWin = heads - tails;
            System.Console.WriteLine("There were "+headsWin+" more than tails!"); 
            return headsWin;
            }
            else if (heads == tails){
                System.Console.WriteLine("There was a tie!!");
                return tie;
            }
            return tie;  
        }
        // ******* names broken function
        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Geneva");
            names.Add("Sydney");
            for (var idx = 0; idx < names.Count; idx++){
            Random rand = new Random();
            int mix = rand.Next(0,names.Count-1);
                int temp = idx;
                names[idx] =names[mix];
                names[mix]= names[temp];

            }

            Console.WriteLine(names);
            return names;

        }

        static void Main(string[] args)
        {
        //  for(int i =1; i<+255; i++){
        //       Console.WriteLine(i);
           
        //  }


        // for(int i=1; i<101; i++){
        //     if(i%3==0 || i%5==0){
        //         Console.WriteLine(i);
        //     }
        // }

        // for(int i=1; i<101; i++){
        //     if(i%5==0 && i%3==0){
        //         Console.WriteLine("FizzBuzz");
        //     }
        //     else if(i%3==0 ){
        //         Console.WriteLine("Buzz");
        //     }
        //     else if(i%5==0){
        //         Console.WriteLine("Fizz");
        //     }
        // }

        // RandomArray();
        // TossCoin();
        // TossMulipleCoins(4);
        Names();


        }


        
    }
}
