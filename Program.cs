using Beast;
using StaticClass;
class Syntaxz{    
    public struct Person{
    //Declaring different data type which is a strut type
    public string Name;
    public int Age;
    public int weight;

    public
     void Hinata(){
        Console.WriteLine("Hinata had a son called Boruto, who in the end became a versel for the Otususke!");
    }
}


    static void Main(string[] args){

    //Declare p1 of type Person 
    Person P1;
    //assign P1's data
    P1.Name= "Hinata";
    P1.Age= 37;
    P1.weight = 23;

    P1.Hinata();

    //Displaying the Values
    
    Console.WriteLine("Data stored for P1 is "+ P1.Name + ", Age is "+ P1.Age + ", and the weight is " + P1.weight);
    var bish = new Bishel();
    Mprogram mp = new Mprogram();
    bish.Prank();
    mp.Return();

    // adding borutos details, also i will be mixing it with hinata's Struct

    Boruto.details();
    Console.WriteLine("Character Name: {0}",Boruto.A_name);
    Console.WriteLine("Character Language: {0}", Boruto.L_name);
    Console.WriteLine("Charater Age: {0}", Boruto.Age);
    Console.WriteLine("Character Family: {0}", P1.Name);

    sharinganA sha = new sharinganA();
    sha.Add(5, 23);
    sha.Subtract(34, 45);
        
    }
}