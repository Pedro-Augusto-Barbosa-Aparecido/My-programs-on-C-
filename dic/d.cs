using System;
using System.Collections.Generic;

class Dic{
    static void Main(){
        Dictionary<int,string> dic=new Dictionary<int, string>();

        string[] palavras=new string[5]{"carro","porta","casa","dado","tatu"};

        for(int i=0;i<5;i++){
            dic.Add(i,palavras[i]);
        }

        Console.WriteLine(dic.Count);
    }
}