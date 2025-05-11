// namespace (nimiavaruus) saman niminen kuin Projekti
namespace Jarjestys
{
    //class (luokka) saman niminen kuin tiedosto
    class Program
    {
        public static int[]? KopioiTaulukko(int[] taulukko)
        {
            int koko = taulukko.Length;
            // new varaa lisää muistia sen verran
            // että sinne mahtuu koko -kappaletta
            // kokonaislukuja
            int[] kopio = new int[koko];
            if (kopio == null)
            {
                // Muistin varaus ei onnistunut
                Console.WriteLine("Ei tarpeelsi muistia");
                return null;
            }
            // Kopioi jokainen taulukon alkio
            for (int i = 0; i < taulukko.Length; i += 1)
            {
                kopio[i] = taulukko[i];
            }
            return kopio;
        }
        public static void Main()
        {
            //Ohjelma alkaa tästä

            //luo uusi kokonaislukutaulukko,
            //jossa luvut menevät suuresta pieneen
            int[] luvut = new int[] { 3, 2, 1 };

            // Muuttuja kopio viittaa samaan muistiin
            // kuin luvut
            int[] kopio = luvut;
            int[] aitoKopio = KopioiTaulukko(luvut);


            kopio[0] = 500;
            aitoKopio[0] = 4512;

            // Jos muuttujan arvo on alkeistyyppi,
            // ei tarvitse varata muistia
            int A = 5;
            int B = 4;
            B = A;
            B += 1;
            Console.WriteLine($"A on {A} ja B on {B}");

            // Lähetä taulukko järjesttääväksi niin että 
            //pienin luku on ensin

            // Luo uusi Sorter tyyppinen olio
            Sorter jarjestaja = new Sorter();
            int[] jarjestetty = jarjestaja.JarjestaTaulukko(luvut);
            //Tarkista että kaikki meni oikein
            //tulostamalla taulukon luvut yksi kerrallaan
            if (jarjestaja.OnkoJarjestyksessa(jarjestetty))
            {
                Console.WriteLine("Järjestäminen onnistui");
            }
            else
            {
                Console.WriteLine("Järjestäminen meni pieleen: (");
            }
            for (int i = 0; i < jarjestetty.Length; i += 1)
            {
                Console.WriteLine($"Luku {i} on {jarjestetty[i]}");
            }
        }
    }
}


/*Что делает эта программа?
Программа берет список чисел, например: [3, 5, 8, 8, 200, -1, 0].
Она упорядочивает числа в списке так, чтобы они шли от самого маленького до самого большого:
[-1, 0, 3, 5, 8, 8, 200].

После этого программа проверяет, правильно ли числа упорядочены. Если да — она пишет:
"Järjestäminen onnistui" (Упорядочивание прошло успешно).

Как это работает?
1. Часть с Program.cs
Это главная часть программы, откуда всё начинается:

- nt[] luvut = new int[] { 3, 5, 8, 8, 200, -1, 0 };
Создается список чисел (массив). Сейчас числа не в порядке.

- Sorter jarjestaja = new Sorter();
Здесь создается специальный "помощник", который умеет упорядочивать числа. Он называется Sorter.

- int[] jarjestetty = jarjestaja.JarjestaTaulukko(luvut);
Помощник берет наш список и делает так, чтобы числа шли от самого маленького к самому большому.

- jarjestaja.OnkoJarjestyksessa(jarjestetty)
Проверяется, всё ли получилось правильно. Если да, выводится сообщение об успехе.

- Цикл for
В конце числа из упорядоченного списка печатаются по очереди.

2. Часть с Sorter
В этой части хранится "умение" упорядочивать и проверять список.

1) Метод OnkoJarjestyksessa (Упорядочено ли?):

    - Программа проверяет все числа по очереди:
        -) Берет одно число и сравнивает его с соседним.
        -) Если одно из чисел стоит не на месте (например, больше следующего), она говорит: "Непорядок!".
    - Если все числа идут правильно, она возвращает ответ true ("да, всё в порядке").

2) Метод JarjestaTaulukko (Упорядочить список):

    - Используется пузырьковая сортировка:
        -)Программа многократно сравнивает соседние числа.
        -)Если одно больше другого, она их меняет местами.
        -)Например, из [3, 2] делается [2, 3].
    - Она повторяет это, пока все числа не окажутся в нужном порядке.

Как это выглядит по шагам?
Было: [3, 5, 8, 8, 200, -1, 0]
После первого круга: [3, 5, 8, 8, -1, 0, 200]
После второго: [3, 5, 8, -1, 0, 8, 200]
После нескольких кругов: [-1, 0, 3, 5, 8, 8, 200]


Итог:
Программа:
1. Создает список чисел.
2. Сортирует их.
3. Проверяет, правильно ли они упорядочены.
4. Печатает результат.*/