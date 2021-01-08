using System;
using System.IO;
using System.Collections.Generic;

class Teste{
    static void Main(){
        var reader=new StreamReader(File.OpenRead(@"C:\Users\Familia_1235_4k\Desktop\Pastas\Programações\C#\teste_de_csv\testecsharp.csv"));
        List<string> listA=new List<string>();
        List<string> listB=new List<string>();
        //List<string> listC=new List<string>();

        while(re){
            var line=reader.ReadLine();
            var values=line.Split();

            listA.Add(values[0]);
            listB.Add(values[1]);
           // listC.Add(values[2]);
        }

        Console.WriteLine("Conteudo do arquivo:");

        foreach(var i in listA){
            Console.WriteLine("Conteúdo: {0}",i);
        }
        foreach(var i in listB){
            Console.WriteLine("Conteúdo: {0}",i);
        }

        Console.Write("\nFIM!!\n");

    }
}