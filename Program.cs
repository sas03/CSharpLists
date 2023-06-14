namespace Lists;
class Program
{
    public static void Display(List<string> liste){
        foreach(string s in liste){
            Console.WriteLine(s);
        }
    }
    static void Main(string[] args)
    {
        List<string> exemple = new List<string>();
        exemple.Add("Premier");
        exemple.Add("Deuxième");
        exemple.Add("Troisième");

        Console.WriteLine("First Round: ");
        Display(exemple);

        Console.WriteLine("Second Round: ");
        exemple.RemoveAt(0);
        Display(exemple);

        Console.WriteLine("Third Round: ");
        exemple.Remove("Troisième");
        Display(exemple);

        Console.WriteLine("Final Round: ");
        exemple[0] = "Modif";
        Display(exemple);
    }
}
