using System;

class TFC{
    static void Main(){

        int n1=10,n2=2;
        int resp=0;

        try{
            resp=n1/n2;
            Console.WriteLine(resp);
            throw new Exception("Teste");
        }catch(Exception e){
            Console.WriteLine("Erro de divisão por 0!! {0}",e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }
    }
}