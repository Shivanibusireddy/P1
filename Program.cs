﻿using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Welcome to Haguar  Car Company");
// Declare and use a bool, int, double, char, string, and decimal type.
bool buyNow = false;
string[] carmodel = {"X8","F-Type","X9","P-Type"};
double[]  price = {25000,38000,78000,98000};
double discount = 8.55;
char quit = 'q';
Console.WriteLine("Please enter your name");
var name = Console.ReadLine();
//Console.WriteLine($"your name is {name}");
Console.WriteLine("Please enter your age");
var age = Console.ReadLine();
Console.WriteLine("Please enter your Phone number eg:+1-838-844-090");
string phonenum = Console.ReadLine();
do{
    Console.WriteLine("These are the different models available now");
    for (int i =0;i<carmodel.Length;i
    ++){
        Console.WriteLine($" Car Model Name: {carmodel[i]}");
    }
    Console.WriteLine("Do you want to buy the car within 30 days please enter true or false");
    buyNow = Convert.ToBoolean(Console.ReadLine());
    if(buyNow == true){
        // Console.WriteLine("Please the model name which you are willing to buy");
        // string modelname = Console.ReadLine();
         decimal newCost(double oldPrice){

            decimal newPrice;
            newPrice = (decimal)(oldPrice - (oldPrice*discount)/100);
             return newPrice;
            //  var newPrice[];
            //  for (int j=0; j< price.Length;j++){
            //      newPrice[i] = price[i] - (price[i] * discount)/100;
            //  }
             
            
        }
         Console.WriteLine("Now the price of all the cars differ as follows");
        for (int i =0;i<price.Length;i++)
             {
                 
                  Console.WriteLine($"{carmodel[i]} : {newCost(price[i])}");

             }
    }
        else{
            Console.WriteLine("Prices of the different models without discount are as follows");
            for(int x=0;x<price.Length;x++){
                Console.WriteLine($"{carmodel[i]} : {price[x]}");
            }
        }

    


Console.WriteLine("Do you want to quit, please enter  q to exit");
quit = Convert.ToChar(Console.ReadLine());

}while (quit != 'q');
 


// Implement at least one loop

// Implement at least one if or if-else branch with conditions
// Implement a switch statement
// Implement a simple function calculation (e.g. totalCost or hasEnough)
// Use Console.WriteLine and Console.ReadLine
// Use string interpolation ($"") and \n or \t
        }
    }
}
