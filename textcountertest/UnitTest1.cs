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
                string t1= @"Si me dices que s�, pi�nsalo dos veces
Puede que te convenga decirme que no
Si me dices que no, puede que te equivoques
Yo me dar� a la tarea de que me digas que s�
Si me dices que s�, dejare de so�ar y me volver� un idiota
Mejor dime que no
Y dame ese s� como un cuenta gotas, dime que no
Pensando en un s�, y d�jame lo otro a m�";

                Assert.AreEqual(77, wordcounter.wordscounted(t1));

            }
        }
    }
}