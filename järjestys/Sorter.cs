
namespace Jarjestys
{

    class Sorter
    {
        /// <summary>
        ///Tarkista onko annettu taulukko järjestyksessä. Jos on, niin palauttaa true. Jos ei ole, palauttaa false.
        /// </summary>
        ///</summary>
        /// <param name="taulukko">taulukko jossa on lukuja</param>
        /// <returns>true jos taulukko on järjestyksessä</returns>
        public bool OnkoJarjestyksessa(int[] taulukko)
        {
            for (int i = 0; i < taulukko.Length - 1; i++) // Vältetään indeksin ylitys - Избегаем выхода за пределы массива
            {
                if (taulukko[i] > taulukko[i + 1]) // Jos ei ole järjestyksessä, palautetaan false - Если неупорядочено, вернуть false
                {
                    return false;
                }
            }
            return true; // Jos silmukka päättyy, taulukko on järjestyksessä - Если цикл завершился, массив упорядочен
        }

        public int[] JarjestaTaulukko(int[] taulukko)
        {
            // Реализация пузырьковой сортировки
            int n = taulukko.Length;
            for (int i = 0; i < n - 1; i++) // Ulompi silmukka - Внешний цикл
            {
                for (int j = 0; j < n - i - 1; j++) // Sisempi silmukka - Внутренний цикл
                {
                    if (taulukko[j] > taulukko[j + 1]) // Verrataan vierekkäisiä lukuja - Сравнение соседних элементов
                    {
                        //Vaihdetaan paikkoja - Меняем местами элементы
                        int vara = taulukko[j];
                        taulukko[j] = taulukko[j + 1];
                        taulukko[j + 1] = vara;
                    }
                }
            }
            /*
            //Jos kaikki luvut ovat suuruusjärjestyksessä
            // palauta true
            // jos ysikin luku on väärässä paikassa
            // palauta false
            bool jarjestyksessa = true; //Oleta että kunnossa
            //1,100,2,3,4,5,6,7
            // 1,1,1,2,3,
            //-1,0,2
            for (int i = 0; i < taulukko.Length; i += 1)
            {
                // saa olla piennempi tai sama
                if (taulukko[i] < taulukko[i + 1])
                {
                    // OK
                    // ei tarvitse tehdä mitään

                }
                else
                {
                    // Ei saa olla suurempi!
                    jarjestyksessa = false;
                    break;

                }
            }
            return jarjestyksessa;
        }
        /// <summary>
        /// Palauttaa järjestyksessä olevan kopion annetusta taulukosta
        /// Järjestys pienimmästä suurimpaan: 1,2,3,4, ...
        ///  </summary>
        ///</summary>
        /// <param name="taulukko"></param>
        /// <returns></returns>

        public int[] JarjestaTaulukko(int[] taulukko)
        {
            // [3,2,1]
            // käy kaikki  luvut läpi
            // [0]: vertaa lukuun [1]
            // Jos [0] on suurempi: vaihda paikat

            // [1]: vertaa lukuun [2]
            // jos [1] on suurempi vaihda paikat

            // [2]: lopeta kun olet viimeisessä
            for (int i = 0; i < taulukko.Length; i += 1)
            {
                // Lopeta kun olet viimeisen luvun kohdalla
                if (i == taulukko.Length - 1)
                {
                    break;
                }
                // Vertaa ja vaihtaa:
                //[2,1]
                // Vertaa kahta lukua A ja B keskenään:
                // Jos A > B: A menee taulukon loppuun
                // Jos A == B: älä tee mitään
                // Jos A < B: Älä tee mitään
                if (taulukko[i] > taulukko[i + 1])
                {
                    int vara = taulukko[i + 1];
                    taulukko[i + 1] = taulukko[i]; //[2,2]
                    taulukko[i] = vara;
                }
            }
            */
            return taulukko;
        }
    }
}
