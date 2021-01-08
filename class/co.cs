using System;

public class Carro{

    public int fuel;
    public bool worked;
    public string name;
    public Carro(){
        fuel=100;
        worked=true;
        name="Celta";
    }
    public Carro(bool w){
        fuel=100;
        worked=w;
        name="Celta";
    }
    public Carro(int f){
        fuel=f;
        worked=true;
        name="Celta";
    }
    
    public Carro(string n){
        fuel=100;
        worked=true;
        name=n;
    }

    public void setName(ref string name, string nameIn){
        name=nameIn;
    }
    
}

class co{
    static void Main(){

        Carro carro=new Carro();
        Carro carro2=new Carro(45);
        Carro carro3=new Carro(false);
        Carro carro4=new Carro("FordiCar");
        /*
        Console.Write("Digite a marca do carro: ");
        string name=Console.ReadLine();
        carro.setName(ref carro.name,name);
        Console.Write("\nMarca escolhida: {0}",carro.name);
        */

        Console.WriteLine("Carro1: ");
        Console.WriteLine(carro.fuel);
        Console.WriteLine(carro.worked);
        Console.WriteLine(carro.name);
        Console.WriteLine("\n");

        Console.WriteLine("Carro2: ");
        Console.WriteLine(carro2.fuel);
        Console.WriteLine(carro2.worked);
        Console.WriteLine(carro2.name);
        Console.WriteLine("\n");

        Console.WriteLine("Carro3: ");
        Console.WriteLine(carro3.fuel);
        Console.WriteLine(carro3.worked);
        Console.WriteLine(carro3.name);
        Console.WriteLine("\n");

        Console.WriteLine("Carro4: ");
        Console.WriteLine(carro4.fuel);
        Console.WriteLine(carro4.worked);
        Console.WriteLine(carro4.name);
        Console.WriteLine("\n");

    }

}