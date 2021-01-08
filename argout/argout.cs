using System;

class varef{

    static void Main(){
        int num=3;
        mult(ref num,3);
        double c;
        double res=0;
        c=divide(3,8,out res);
        Console.WriteLine(num);
        Console.Write("teste retorno array: ");
        Console.Write("{0}, {1}",c,res);
    }

    static void mult(ref int a, int b){
        for(int i =0;i<b;i++){
            a=a*(i+1);
        }
    }

    static double divide(double div1,double div2,out double res){
        double varReturn=div1/div2;
        res=div1%div2;
        return (int)varReturn;
    }

}