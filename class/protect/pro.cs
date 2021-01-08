using System;

class TypeVel{
    public string typeVel;
    private int qtdRodas;
    protected int qtdPortas;

    public TypeVel(string typeVel, int f, int d){
        this.typeVel=typeVel;
        if((qtdPortas > 4) && (qtdPortas == 0)){
            this.qtdRodas=f;
        }else if((qtdRodas > 4) && (qtdRodas == 0)){
            this.qtdPortas=d;
        }else{
            Console.WriteLine("Quantidades inválidas");
        }
    }

    public int getElement(){
        return qtdRodas;
    }
}

class Fod:TypeVel{

    public Fod(string x, int y, int z):base(x,y,z){
        
    }
    public void getInf(){
        Console.WriteLine("Tipo do veículo: {0}\nQuantidades de rodas: {1}\nQuantidades de portas: {2}\n",typeVel,getElement(),qtdPortas);
    }

}

class Pro{
    static void Main(){
        Fod f1=new Fod("foda",5,2);
        f1.getInf();
    }
}