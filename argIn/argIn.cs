using System;

class ArgIn{
    static void Main(string[] args){

        Console.WriteLine("Tamanho do args: {0}\n",args.Length);

        if(args.Length>0){

            int num=0;

            foreach (var item in args){
                Console.WriteLine(num+=Int32.Parse(item));
            }

        }else{

            Console.WriteLine("Zero argumentos passados");

        }

    }

}