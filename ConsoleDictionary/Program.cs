namespace ConsoleDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("ConsoleDictionary");
            //generisches Dictiobnary anlegen
            //key Kenzeichnen, value Landkreis
            Dictionary<string , string> kennzeichnen = new Dictionary<string, string>();

            // Elemente hinzufügen(key -value-pair)
            kennzeichnen.Add("PF", "Pforzheim");
            kennzeichnen.Add("FN", "Friedrichshafen" );
            kennzeichnen.Add("RV", "Ravensburg");
            kennzeichnen.Add("CW", "Calw");
            kennzeichnen.Add("S", "Stuttgart");

            // Elemente ausgeben
            foreach (string key in kennzeichnen.Keys) { Console.WriteLine("Kennzeichnen: "+key.PadLeft(3)+" Landkreis: " + kennzeichnen[key]); }
            Console.ReadLine();
        }
    }
}
