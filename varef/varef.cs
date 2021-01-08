using System;

class varef{

    static void Main(){
        int num=3;
        mult(ref num,3);
        Console.Write(num);
    }

    static void mult(ref int a, int b){
        for(int i =0;i<b;i++){
            a=a*(i+1);
        }
    }

}