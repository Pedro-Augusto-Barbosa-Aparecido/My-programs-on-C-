using System;

class Calculator{
    public static double pi=3.143415;

    public static int doubleS(int n){
        return n*2;
    } 
}

class MSV{
    static void Main(){
        double vpi=Calculator.pi;
        Console.WriteLine("Valor de pi: {0}\nValor do dobro: {1}",vpi,Calculator.doubleS(5));
    }
}