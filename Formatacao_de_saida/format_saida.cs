using System;

class format_saida{
    static void Main(){
        int num = 63, num2 = 7;
        int res = num + num2;

        Console.Write("O resultado de res = "+res+"\n");

        string produto = "Pastel";
        double price = 3.50, qtde = 5, count = price * qtde;  
        Console.WriteLine("Produto......:{0,15}",produto);
        Console.WriteLine("Preço........:{0,15:c}",price);
        Console.WriteLine("Quantidade...:{0,15}",qtde);
        Console.WriteLine("Preço a pagar:{0,15:c}",count);
    }
}