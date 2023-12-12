public class Game{
    platser test= new platser();
    
    public Game(){
        Console.WriteLine("hej");
        
        Console.WriteLine(test.GetPlats());
        test.SetPlats(4);
        Console.WriteLine(test.GetPlats());
    }
}