using System;
using System.Collections.Generic;

class LisLis{
    
    static void Main(){

        LinkedList<string> names=new LinkedList<string>();
        for(int i=0;i<4;i++){
            names.AddFirst("legal");
        }
        foreach(string item in names){
            Console.WriteLine(item);
        }
    }

}