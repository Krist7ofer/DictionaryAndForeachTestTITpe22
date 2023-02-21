namespace DictionaryAndForeachTestTITpe22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var koolid = new Dictionary<int, string>()
            {
                {1,"Tallinna Reaalkool" },
                {2,"Tallinna Tööstushariduskeskus" },
                {3,"Tallinna Ühisgümnaasium" }
            };
            foreach (var kool in koolid)
            {
                Console.WriteLine($"{kool.Key} - {kool.Value}");
            }
        }
    }
}