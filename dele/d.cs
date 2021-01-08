using System;

delegate int DOUBLE(int n1);
delegate double SOMA(params double[]n1);

class Calculator{
    
    public static double Soma(params double []num){
        
        double res=0.0;

        for(int i=0;i<num.Length;i++){
            res+=num[i];
        }

        return res;
    }

    public static int DoubleS(int n){
        return n*2;
    }
}

class DeleGate{
    static void Main(){
        DOUBLE d1=new DOUBLE(Calculator.DoubleS);
        SOMA s1=new SOMA(Calculator.Soma);

        Console.WriteLine("Soma: {0}\nDobro: {1}",s1(25,26,23),d1(5));
    }
}