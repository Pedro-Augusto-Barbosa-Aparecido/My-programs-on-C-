using System;

class MathOnlyTwoNumbers{
    public int num1;
    public int num2;

    public MathOnlyTwoNumbers(int num1, int num2){
        this.num1=num1;
        this.num2=num2;
    }
    public int somar(){
        return num1+num2;
    }
}
class This{
    static void Main(){
        MathOnlyTwoNumbers math=new MathOnlyTwoNumbers(8,8);
        Console.Write(math.somar());
    }
}