using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 1
        /*string names = "Лена Вера Соня Женя Яна Арина";
        string[] container = names.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < container.Length; i++)
        {
            if (string.Compare("Маша", container[i]) > 0)
            {
                Console.WriteLine(container[i]);
            }
        }*/

        // Task 2
        /*string words = "самый лучший день который мог бы быть это среда";
        string[] container = words.Split(new char[] { ' ', '.', '?', ',', '!', ':', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < container.Length; i++)
        {
            if (container[i].Length == 4)
            {
                container[i] = "love_is";
            }
        }

        string output = string.Join(" ", container);
        Console.WriteLine(output);*/

        // Task 3 ☻
        /*int n = int.Parse(Console.ReadLine());
        string s = "kak dela chto delaesh?";
        string output = "";
        for (int i = 0; i < s.Length; i++)
        {
            output += s[i];
            if ((i + 1) % n == 0)
            {
                output += "☻";
            }
        }
        Console.WriteLine(output);*/

        // Task 4
        /*string s = "Вы бравые солдаты, вы заслужили, мое уважение!";
        string min_S = "";
        string max_S = "";
        int max_lenght = -1;
        int min_lenght = 1000000;
        string[] container = s.Split(new char[] {' ', ',', '.', '!', '?', ':', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < container.Length; i++)
        {
            if (container[i].Length < min_lenght)
            {
                min_lenght = container[i].Length;
                min_S = container[i];
            }
            else if (container[i].Length > max_lenght)
            {
                max_lenght = container[i].Length;
                max_S = container[i];
            }
            
        }
        string output = "";
        for (int i = 0; i < min_S.Length; i++)
        {
            output += min_S;
            output += ", ";
        }        
        for (int i = 0; i < max_S.Length; i++)
        {
            output += max_S;
            output += ", ";
        }
        output = output.TrimEnd(' ');
        output = output.TrimEnd(',');
        Console.WriteLine(output);*/

        // Task 5        
       /* string input = "Быть или не быть вот в чем вопрос или не быть или быть";

        string[] words = input.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        string[] uniqueWords = new string[words.Length];
        int index = 0;

        foreach (string word in words)
        {
            if (Array.IndexOf(uniqueWords, word) == -1)
            {
                uniqueWords[index++] = word;
            }
        }

        string result = string.Join(" ", uniqueWords, 0, index);
        Console.WriteLine(result);*/

        // Task 6
        /*StringBuilder sb = new StringBuilder();
        string input = "";
        while (true)
        {
            input = Console.ReadLine();
            if (input == null || input == "")
            {
                break;
            }
            string[] words = input.Split(new char[] {' ', ',', '.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if ((i + 1) % 3 == 1)
                {
                    sb.Append(words[i] + " ");
                }
                else if ((i + 1) % 3 == 2)
                {
                    sb.Append(new string(words[i].Reverse().ToArray()) + " ");
                }
            }
            sb.Append(". ");
            sb = sb.Replace(" .", ".");
        }

        Console.WriteLine(sb.ToString());*/


    }
}
