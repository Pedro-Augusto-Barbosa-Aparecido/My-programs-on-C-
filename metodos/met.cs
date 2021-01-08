using System;

class met{
    static void Main(){
        int metodo=soma(12,soma(1,soma(0,0)));
        Console.Write(metodo);
    }
    static int soma(int a, int b){
        int c = a+b;
        return c;
    }
}