using System;
using System.IO;
using System.Collections.Generic;

class Teste{
    static void Main(){
        StreamReader reader=new StreamReader(File.OpenRead(@"C:\Users\Familia_1235_4k\Desktop\Pastas\Programações\EXEL\test3.csv"));
       
        List<string> list1=new List<string>();
        List<string> list2=new List<string>();
        List<string> list3=new List<string>();
        List<string> list4=new List<string>();
        List<string> list5=new List<string>();

        bool translateWord=false, wordFinded=false;

        int length=0, index=0;

        while(!reader.EndOfStream){
            
            Increase(ref length);

            string line = reader.ReadLine();
            var value= line.Split(';');

            list1.Add(value[0]);
            list2.Add(value[1]);
            list3.Add(value[2]);
            list4.Add(value[3]);
            list5.Add(value[4]);

        }

        Console.Clear();

        Console.WriteLine("Fim da leitura, imprimindo resultados: \nNúmero de palavras existentes no arquivo: {0}\n ",length);

        for(int i=0;i<length;i++){
            //Console.Write("Palavra: {0}  Separação: {1}  Tradução: {2}  Exemplo: {3}  Referência: {4}\n",list1[i],list2[i],list3[i],list4[i],list5[i]);
            Console.Write("Palavras: {0}  Index: {1}\n",list1[i],i);
        }

        Console.Write("Fim do impressão!!");

        Console.Write("Deseja procurar uma palavra?\nDigite S/N: ");
        string trad=Console.ReadLine().ToLower();

        translator:

        switch(trad){
            case "s":
                translateWord=true;
                Console.Write("Digite uma palavra: ");
                break;
            case "n":
                Console.WriteLine("OK, fim de programa!");
                break;
            default:
                Console.WriteLine("O que você digitou não foi um valor valído!!");
                break;
        }

        index=0;

        wordFinded=false;

        if(translateWord==true){

            string word=Console.ReadLine().ToLower();

            foreach(string i in list1){

                if(i==word){
                    wordFinded=true;
                    Console.Clear();
                    Console.WriteLine("A tradução de {0} é {1}",word,list3[index]);
                    translateWord=false;
                    Console.Write(" Deseja proucurar outra?\nDigite S/N: ");
                    trad=Console.ReadLine().ToLower();
                    goto translator;
                }

                Increase(ref index);

            }

            if(!wordFinded){
                Console.Write("Infelizmente não achamos a palavra.");
                translateWord=false;
                Console.Write(" Deseja proucurar outra?\nDigite S/N: ");
                trad=Console.ReadLine().ToLower();
                goto translator;
            }

        }

    }

    static void Increase(ref int l){
        l++;
    }

}