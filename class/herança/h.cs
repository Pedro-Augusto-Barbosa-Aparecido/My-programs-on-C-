using System;

class Pai{
    private string name="ricardo";

    public void changeName(string name){
        this.name=name;
    }

    public void getName(){
        Console.Write("\n{0}\n",this.name);
    }

}

class Filho:Pai{
    public void getname(){
        getName();
    }

    public void changename(string name){
        changeName(name);
    }
}
class H{
    static void Main(){
        Pai p=new Pai();
        Filho f=new Filho();
        p.changeName("gg");
        p.getName();
        f.changename("ff");
        f.getname();
        p.getName();
    }
}