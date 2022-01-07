using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace textcounter
{
    public class wordcounter
    {
       public static void Main()
        {
            const string t1 = @"Si me dices que sí, piénsalo dos veces
Puede que te convenga decirme que no
Si me dices que no, puede que te equivoques
Yo me daré a la tarea de que me digas que sí
Si me dices que sí, dejare de soñar y me volveré un idiota
Mejor dime que no
Y dame ese sí como un cuenta gotas, dime que no
Pensando en un sí, y déjame lo otro a mí";

            Console.WriteLine(wordscounted(t1));
           
        }
        

       public static int wordscounted(string s)
        {
            return Regex.Matches(s, @"[A-Za-z0-9]+").Count;
          
        }
        
    }
    
}


