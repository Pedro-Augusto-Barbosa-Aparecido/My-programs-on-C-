using System;

class Um{
    private int num1;

    public int n1{
        get{
            return num1;
        }set{
            if((value >= 0)&&(value <= 15)){
                num1=value;
            }else{
                Console.WriteLine("Valor inavalido");
            }
        }
    }
    public Um(int num1){
        this.num1=num1;
    }
    
}

class Gs{
    static void Main(){
      
    }
}