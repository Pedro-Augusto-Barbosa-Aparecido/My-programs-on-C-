using System;
using System.Collections.Generic;

class Lista{
    static void Main(){

        List<string>names=new List<string>();
        List<string>names2=new List<string>();

        string[] name=new string[5]{"cal","bal","da","bos","ins"};
        string[] name2=new string[9];

        for(int i=0;i<5;i++){
            names.Add(name[i]);
        }

        foreach(string item in names){
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------------");

        names2.AddRange(names);

        foreach(string item in names2){
            Console.WriteLine(item);
        }

        Console.WriteLine(names.Contains("bos"));

        names2.Clear();

        names.CopyTo(name2,3);

        Console.WriteLine("------------------------------------");

        foreach (string item in name2){
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------------------");

        names.Insert(1,"gaga");

        foreach(string item in names){
            Console.WriteLine(item);
        }
        
        names.Clear();

        string[] letter=new string[6]{"a","f","r","e","k","p"};

        for(int i=0;i<letter.Length;i++){
            names.Add(letter[i]);
        }

        foreach(string item in names){
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------------");

        names.Sort();

        foreach(string item in names){
            Console.WriteLine(item);
        }
    }
}