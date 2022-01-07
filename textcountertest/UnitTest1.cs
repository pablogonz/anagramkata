using Microsoft.VisualStudio.TestTools.UnitTesting;
using textcounter;
using textcountertest;
namespace textcountertest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void detect_words_correct_count()
        {
            {
                string t1= @"Si me dices que sí, piénsalo dos veces
Puede que te convenga decirme que no
Si me dices que no, puede que te equivoques
Yo me daré a la tarea de que me digas que sí
Si me dices que sí, dejare de soñar y me volveré un idiota
Mejor dime que no
Y dame ese sí como un cuenta gotas, dime que no
Pensando en un sí, y déjame lo otro a mí";

                Assert.AreEqual(77, wordcounter.wordscounted(t1));

            }
        }
    }
}