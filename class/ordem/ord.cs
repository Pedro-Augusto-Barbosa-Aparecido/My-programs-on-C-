using System;

class Um{
    public Um(){
        Console.WriteLine("1");
    }
}

class Dois:Um{
    public Dois(){
        Console.WriteLine("2");
    }
}

class Tres:Dois{
    public Tres(){
        Console.WriteLine("3");
    }
}
class Ord{
    static void Main(){
        Tres t=new Tres();
    }
}