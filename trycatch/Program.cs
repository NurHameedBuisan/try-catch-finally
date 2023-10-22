using System;

public class BuisanException : Exception
{
    public BuisanException(string message) : base(message){
    }
}

class Program
{
    static void Main(){
        for (int i = 0; i < 10; i++){
            try{
                int num = ReadNumber(1, 100);
                Console.WriteLine("Square root of the number is: " + Math.Sqrt(num));}
            catch (BuisanException cx){
                Console.WriteLine("Negative Integer Exception: " + cx.Message);}
            catch (Exception x){
                Console.WriteLine("Non-Integer Exception: " + x.Message);}
            finally{
                Console.WriteLine("Goodbye!!");}
        }
    }

    static int ReadNumber(int start, int end){
        int num;
        Console.Write($"Enter an integer between {start} and {end}: ");
        if (int.TryParse(Console.ReadLine(), out num)){
            if (num >= start && num <= end){
                return num;}
            else{
                throw new BuisanException("Invalid number");}
        }
        else{
            throw new FormatException("Invalid input. Please enter a valid integer.");}
    }
}
