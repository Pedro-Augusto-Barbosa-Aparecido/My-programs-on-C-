using System;

class Heroi{
    private string name;
    private string power;
    private int qtdePower=0;
    private int nOnceDefeat=0;
    public Heroi(string name, string power){

        this.name=name;
        this.power=power;
        
    }

    public void getInfHero(string choise){

        switch(choise){
            case "name":
                Console.WriteLine("Nome..............: {0}",name);
                break;
            case "power":
                Console.WriteLine("Poder.............: {0}",power);
                break;
            case "level":
                Console.WriteLine("Nivel do poder....: {0}",qtdePower);
                break;
            case "derrotas":
                Console.WriteLine("Número de derrotas: {0}",nOnceDefeat);
                break;
            default:
                Console.Write("Não temos esta características");
                break;
        }
        
    }

    public void setProperies(string props, int powers=0, string names=" "){
        switch(props){
            case "name":
                this.name=names;
                break;
            case "power":
                this.power=names;
                break;
            case "level":
                this.qtdePower=powers;
                break;
            case "derrotas":
                this.nOnceDefeat=powers;
                break;
            default:
                Console.Write("Não temos esta características");
                break;
        }
    }

}
class Pp{
    static void Main(){
        Heroi h=new Heroi("Flash","Raio-X");
        h.setProperies("level",500);
        h.setProperies("derrotas",5);
        h.getInfHero("name");
        h.getInfHero("power");
        h.getInfHero("level");
        h.getInfHero("derrotas");
        h.getInfHero("speed");
    }
}