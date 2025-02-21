// See https://aka.ms/new-console-template for more information
using System;

namespace firstProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input two numbers:");
REINPUT:
            string input1 = Console.ReadLine() ??string.Empty;
            string[] numsString = input1.Split(' ');
            if(numsString.Length ==0){
                Console.WriteLine("You didn't input any numbers, please try again");
                goto REINPUT;
            }else if(numsString.Length == 1){
                while(true){
                    Console.WriteLine("Only one number is input, we need another one:");
                    string another = Console.ReadLine() ??string.Empty;
                    if(another != string.Empty){
                        string[] anotherNum = another.Split(' ');
                        if(anotherNum.Length != 1){
                            Console.WriteLine("Sorry we only use the first two numbers");
                        }
                        //connect the numsString and anotherNum
                        int numsStringLength = numsString.Length;
                        Array.Resize<string>(ref numsString,numsStringLength+anotherNum.Length+1);
                        Array.Copy(anotherNum,0,numsString,numsStringLength,anotherNum.Length);
                        break;
                    }
                }
            }else{
                Console.WriteLine("Sorry we only use the first two numbers");
            }
            double num1 = double.Parse(numsString[0]);
            double num2 = double.Parse(numsString[1]);
            Console.WriteLine("Please input a symlbal as operator(in + - * / %):");
WRONGSYMBOL:
            string input2 = Console.ReadLine() ?? string.Empty;
            double result = 0.0;
            if( input2 == "+"){
                result = num1+num2;
            }else if(input2 == "-"){
                result = num1-num2;
            }else if(input2 == "*"){
                result = num1*num2;
            }else if(input2 == "/"){
                if(num2 != 0)
                    result = num1/num2;
                else{
                    Console.WriteLine("Illegal calculate: the divisor is zero");
                }
            }else if(input2 == "%"){
                if(num1%1==0 && num2%1==0)
                    result = num1%num2;
                else{
                    Console.WriteLine("Illegal calculate: only integers can use symbol '%'");
                }
            }else{
                Console.WriteLine("That is not an illegal operator symble, Please try + - * / %");
                goto WRONGSYMBOL;
            }
            Console.WriteLine("The result is {0}",result);
        }
    }
}