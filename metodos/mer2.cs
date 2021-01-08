using System;

class Developer{
    private string Name;
    private int nAlm=0;
    public Developer(string Name){
        this.Name=Name;
    }

    public Almoco newAlm(){
        this.nAlm++;
        return new Almoco(this.nAlm);
    }
}

class Almoco{

    private int qtdeAlm=0;

    public Almoco(int qtdeAlm){
        this.qtdeAlm=qtdeAlm;
        Console.Write("Número de almoço: {0}\n",this.qtdeAlm);
    }
}

class Met{
    static void Main(){
        Developer d1=new Developer("Zé");
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();
        d1.newAlm();

    }
}