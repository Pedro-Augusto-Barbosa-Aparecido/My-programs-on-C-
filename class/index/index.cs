using System;

class Indx{
    private int[] array=new int[3]{1,2,3};

    public int this[int i]{
        get{
            return array[i];
        }
    }
}
class Index{
    static void Main(){
        Indx index=new Indx();
        Console.Write(index[2]);
    }
}