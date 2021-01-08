using System;

namespace Calc1{
    class Calc{
        private int n1, n2;

        public int Soma(int n1, int n2){
            this.n1=n1;
            this.n2=n2;
            return this.n1+this.n2;
        }

    }

}

namespace Calc2{
    class Calc{
        private int n1, n2;

        public int Soma(int n1, int n2){
            this.n1=n1;
            this.n2=n2;
            return this.n1+this.n2;
        }
        
    }

}

class Name{
    static void Main(){
        Calc1.Calc c1=new Calc1.Calc();
        Console.Write(c1.Soma(5,5));
    }

}