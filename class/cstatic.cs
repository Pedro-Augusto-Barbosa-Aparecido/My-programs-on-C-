using System;

static public class Carro{
    static int fuel;
    static string marca;
    static bool verf=false;
    static public void iniciar(string nameMarca, int qtdeFuel){
        
        marca=nameMarca;

        if((qtdeFuel>100)||(qtdeFuel<0)){
            Console.Write("Parâmetro inválido!\n");
            verf=true;
        }else{
            fuel=qtdeFuel;
        }

    }

    static public void showInf(string thingToShow){

        if(!verf){
            switch(thingToShow){
                case "fuel":
                    Console.WriteLine("A quantidade de combustivel do carro é {0}",fuel);
                    break;
                case "marca":
                    Console.WriteLine("A marca do carro é {0}",marca);
                    break;
                default:
                    Console.WriteLine("O carro não tem esta característica");
                    break;
            }
        }

    }

    static public void tryAgain(){
        verf=false;
    }

}
class Cstatic{
    static void Main(){
        //implementar a função de tentar até dar certo
        Carro.iniciar("Celta", 150);
        Carro.showInf("fuel");
        Carro.showInf("marca");
    }
}