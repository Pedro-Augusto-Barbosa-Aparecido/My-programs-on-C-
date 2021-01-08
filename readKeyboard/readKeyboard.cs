using System;

class readKeyboard{
    static void Main(){
        string age, weight, height;
        string name;

        Console.WriteLine("Type your name and age, weight, hight respectivamente: ");
        name = Console.ReadLine();
        age = Console.ReadLine();
        weight = Console.ReadLine();
        height = Console.ReadLine();

        Console.WriteLine("Name typed.........:"+name);
        Console.WriteLine("Age typed..........:"+age);
        Console.WriteLine("Weight typed.......:"+weight);
        Console.WriteLine("Height typed.......:"+height);


    }
}