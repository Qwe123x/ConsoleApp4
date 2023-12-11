using System.Net;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            var articles = new List<string>
            {
                "6 SG HD Silver Grey 32 ЗАК/16/6 м1/16/6 ЗАК",
                "4/16/4",
                "4 TOP-N/14/6_м1",
                "4 ПлА2/16/4м1",
                "4 TOP-N/14ar/4 м1/14ar/4_StClBr",
                "10 м1/22/8 м1",
            };


            foreach (var art in articles)
            {
                GlassUnitTask(art);
                Console.WriteLine(" ");
            }
        }

        static void GlassUnitTask(string article)
        {
            var words = article.Split('/');
            var digits = new List<int>();

            foreach (var word in words)
            {
                var fs = new String(word.TakeWhile(Char.IsDigit).ToArray());
                digits.Add(Convert.ToInt32(fs));
            }

            Console.WriteLine(words.Length > 3 ? "Камерномь: 2" : "Камерность: 1");
            Console.WriteLine($"Толщина СП: {digits.Sum()}");

            Console.WriteLine(digits.Count > 3
                ? $"Толщина стекла {digits.First() + digits[digits.Count / 2] + digits.Last()}"
                : $"Толщина стекла {digits.First() + digits.Last()}");
        }



    }
}
