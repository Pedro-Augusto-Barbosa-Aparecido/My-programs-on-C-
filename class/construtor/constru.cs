using System;

class Pai{
    private string cor;

    public Pai(string cor){
        this.cor=cor;
    }

    public string getElements(){
        return cor;
    }
}

class Filho:Pai{
    private int tamanho;

    public Filho(int tamanho):base("Vermelho"){
        this.tamanho=tamanho;
    }

    public int getElement(){
        
        return tamanho;
        
    }
}

class Neto:Filho{

    private bool life;

    public Neto(bool life):base(56){
        this.life=life;
    }

    public void getInf(){
        Console.WriteLine("Cor: {0}\nTamanho: {1}\nVida: {2}\n          Fim....",getElements(),getElement(),life);
    }
}

class constru{
    static void Main(){
        Neto n1=new Neto(false);
        n1.getInf();
    }
}