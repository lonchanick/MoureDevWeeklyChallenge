namespace MoureDevWeeklyChallenge.Challenges;


/*
 * Reto #7
 * CONTANDO PALABRAS
 * Fecha publicación enunciado: 14/02/22
 * Fecha publicación resolución: 21/02/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que cuente cuantas veces se repite cada palabra y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan automáticamente.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */
public class WordStruct
{
    public string Word { get; set; }
    public int Count { get; set; }
    public WordStruct(string w)
    {
        Word = w;
        Count = 1;
    }
}

public class wordsList
{
    public List<WordStruct> words = new();

    public bool Contains(string paramWord)
    {
        foreach (var word in words) 
        {
            if (word.Word.Equals(paramWord))
                return true;
        }
        return false;
    }

    public void PlusOne(string paramWord)
    {
        foreach(var word in words) 
        {
            if (word.Word.Equals(paramWord))
            {
                word.Count ++;
                return;
            }
        }
    }

    internal void Add(string word)
    {
        words.Add(new WordStruct(word));
    }

    internal void ShowContent()
    {
        Console.WriteLine("\tResults");
        foreach(var x in words) 
            Console.WriteLine($"{x.Word} ({x.Count})");
    }
}

public class Challenge7
{

    public static void exe()
    {
        Console.WriteLine("Escribe algo cctm :@ !! ");
        string rawString = Console.ReadLine();
        var words = rawString.Split(" ");
        var wordsAmount = new wordsList();

        if (words!=null) 
        {
            foreach (var word in words) 
            {
                if (!wordsAmount.Contains(word))
                    wordsAmount.Add(word);
                else
                    wordsAmount.PlusOne(word);
            }

        }
        else { Console.WriteLine("Cadena vacia"); }

        wordsAmount.ShowContent();

    }
}
