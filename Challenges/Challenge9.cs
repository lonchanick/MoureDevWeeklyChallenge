namespace MoureDevWeeklyChallenge.Challenges;
/*
 * Reto #9
 * CÓDIGO MORSE
 * Fecha publicación enunciado: 02/03/22
 * Fecha publicación resolución: 07/03/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que sea capaz de transformar texto natural a código morse y viceversa.
 * - Debe detectar automáticamente de qué tipo se trata y realizar la conversión.
 * - En morse se soporta raya "—", punto ".", un espacio " " entre letras o símbolos y dos espacios entre palabras "  ".
 * - El alfabeto morse soportado será el mostrado en https://es.wikipedia.org/wiki/Código_morse.
 * NO SOPORTA NUMEROS NI CARACTERES ESPECIALES Y 
 * "—" (ALT+0151) no es lo mismo que "-"(ALT+Sabrá Dios) y
 * "·" (ALT+NO SÉ) no es lo mismo que "." (Ojo con el piojo)
 */

public class Challenge9
{
    public static void exe()
    {
        Dictionary<string, string> dict = new()
        { { "· —", "A" },
          { "— · · ·", "B" },
          { "— · — ·", "C" },
          { "— · ·", "D" },
          { "·", "E" },
          { "· · — ·", "F" },
          { "— — ·", "G" },
          { "· · · ·", "H" },
          { "· ·", "I" },
          { "· — — —", "J" },
          { "— · —", "K" },
          { "· — · ·", "L" },
          { "— —", "M" },
          { "— ·", "N" },
          { "— — · — —", "Ñ" },
          { "— — —", "O" },
          { "· — — ·", "P" },
          { "— — · —", "Q" },
          { "· — ·", "R" },
          { "· · ·", "S" },
          { "—", "T" },
          { "· · —", "U" },
          { "· · · —", "V" },
          { "· — —", "W" },
          { "— · · —", "X" },
          { "— · — —", "Y" },
          { "— — · ·", "Z" }
        };
        
        string aux = "· · · ·  ·  · — · ·  · — · ·  — — —";
        string[] r = aux.Split("  ");
        foreach (string s in r)
        {
            //Console.WriteLine(s);
            Console.Write(dict[s]);
        }
    }
}
