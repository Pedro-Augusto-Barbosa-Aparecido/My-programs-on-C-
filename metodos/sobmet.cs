using System;

class Calculator{
    private double num;
    public double exp(double numb, double exp){

        this.num=Math.Pow(numb,exp);
        return this.num;

    }
}

class Sob{
    static void Main(){
        Calculator c1=new Calculator();
        Console.WriteLine(c1.exp(5,4));

    }
}