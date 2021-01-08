using System;

abstract class Um{
    protected int num1;
    protected int num2;
    protected int num3;

    public Um(){
        num1=0;
        num2=0;
        num3=0;
    }

    public int pluss(int num1, int num2){
        return num1+num2;
    }

    abstract public void discoverPlus(int res, int num1);

}

class Dois:Um{
    override public void discoverPlus(int res, int num1){
        this.num1=num1;
        this.num3=res;
        this.num2=this.num3-this.num1;
        Console.WriteLine(this.num2);
    }
    
}
class MetA{
    static void Main(){
        Dois d1=new Dois();
        Console.WriteLine(d1.pluss(12,12));
        d1.discoverPlus(15,8);
    }
}