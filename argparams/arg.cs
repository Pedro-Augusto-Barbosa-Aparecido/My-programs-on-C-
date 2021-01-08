using System;

class arg{
    static void Main(){
        plus(2,2,2,2,2);
    }

    static void plus(params int[]n){
        int r=0;
        switch(n.Length){
            case 0:
                Console.WriteLine("Não foi passado nenhum parâmetro");
                break;

            case 1:
                Console.WriteLine("Foi passado apenas um parâmetro, impossível completar a soma");
                break;

            default:
                for(int i=0;i<n.Length;i++){
                    r=r+n[i];
                }
                break;
        }
        Console.WriteLine("Valor de soma: {0}",r);
    }
}