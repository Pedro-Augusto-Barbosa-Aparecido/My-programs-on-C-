using System;

struct Soldeir{
    private string name;
    private int life;
    public int life2;
    public int force;

    public void setSoldeir(string name, int force){
        this.name=name;

        if((force>0)&&(force<90)){
            this.force=force;
        }else{
            this.force=15;
        }

        this.life=200;
        this.life2=10;
    }

    public void getInf(){
        Console.Write("Nome: {0}\nVida: {1}\nForça: {2}\n",this.name,this.life,this.force);
    }
}

class Str{
    static void Main(){
        Soldeir[] sd1=new Soldeir[5];
        string[] names=new string[5]{"STEVE","MAN","GUGUS","TATU","SURFISTA"};
        int[] forces=new int[5]{80,65,95,45,89};   

        for(int i=0;i<5;i++){
            sd1[i].setSoldeir(names[i],forces[i]);
        }

        for (int i = 0; i < 5; i++){
            sd1[i].getInf();
            Console.Write("-------------------------------------------\n");
        }   

    }
}