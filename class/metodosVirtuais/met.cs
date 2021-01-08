using System;

class Um{
    virtual public void inf(){
        Console.WriteLine("gg");
    }
}
class Dois:Um{
    override public void inf(){
        Console.WriteLine("aa");
    }
}
class Met{
    static void Main(){
        Dois d1=new Dois();
        d1.inf();
    }
}