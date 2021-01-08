using System;

class go{
    static void Main(){

        int tamanho=3;
        string[] history= new string[tamanho];
        int numLimit=tamanho, position=0;
        char decision='n';

        for(int i = 0; i < tamanho; i++){
            history[i]="Default";
        }

        startProgram:

        Console.Clear();

        Console.WriteLine("Escolha uma opção de transporte: ");
        Console.WriteLine("[Tempo de percurso: 25min]Bicicleta; \n[Tempo de percurso: 10min]Carro; \n[Tempo de percurso: 50min]Caminhão; ");
        string stringReceive=Console.ReadLine().ToUpper();
        switch(stringReceive){
            case "BICICLETA": 
                    Console.WriteLine("Você escolheu Tempo de percurso: 25min");
                    history[position]="Você escolheu Tempo de percurso: 25min, ou seja, Bicicleta";
                    break;
            case "CARRO": 
                    Console.WriteLine("Você escolheu Tempo de percurso: 10min");
                    history[position]="Você escolheu Tempo de percurso: 10min, ou seja, Carro";
                    break;
            case "CAMINHÃO": 
                    Console.WriteLine("Você escolheu Tempo de percurso: 50min");
                    history[position]="Você escolheu Tempo de percurso: 50min, ou seja, Caminhão";
                    break;
            default: 
                    Console.WriteLine("Você não escolheu nada ou escolheu um meio que não tem em nossa lista");
                    history[position]="Você não escolheu ou errou a digitação";
                    break;
        }

        if(numLimit>0){
            Console.Write("\nDeseja fazer mais uma escolha?\nVocê tem mais {0} escolhas, responda (s/n): ", numLimit);
            string receive=Console.ReadLine();
            decision=char.Parse(receive);
            switch(decision){
                case 's':
                    numLimit=numLimit-1;
                    position=position+1;
                    goto startProgram;
                case 'n':
                    foreach (var item in history){
                        Console.WriteLine("Sua escola: {0}",item);
                    }
                    Console.Write("\nFim do programa\n");
                    break;
            }
        }else{
            foreach (var item in history){
                        Console.WriteLine("Sua escola: {0}",item);
            }
            Console.Write("\nFim do programa\n");
        }
    }
}