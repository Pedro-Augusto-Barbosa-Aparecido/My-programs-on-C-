using System;

public interface Soldier{
    void create(string name);

    void getInfOfSoldier();

}

class Soldiers:Soldier{

    private string name;
    private int life;
    private int power;
    public Soldiers(string n){
        create(n);
    }

    public void create(string name){
        this.name=name;
        this.power=50;
        this.life=200;
    }

    public void getInfOfSoldier(){
        Console.WriteLine("Nome: {0}\nLife: {1}\nForça: {2}",this.name,this.life,this.power);
    }

}

class Inter{
    static void Main(){
        Soldiers sd1=new Soldiers("STEVE");

        sd1.getInfOfSoldier();
    }
}