using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie
{
    class ProgramowaniePrzybyszewski
    {
        static void Main(string[] args)
        {
            //deklaracje tablic
            int[] tablica = new int[10] { 10, 2, 3, 7, 5, 4, 88, 34, 57, 115 };

            Random random = new Random(); 
            int[] tablicaBinarna = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tablicaBinarna[i] = random.Next(0, 2);
            }

            int[,] tab2D = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab2D[i, j] = (i + 3) * (j + 4);
                }
            }

            int[,] tablicaDwuwymiarowaMnozenie = new int[10, 10];
            for (int k = 0; k < 10; k++)
            {
                tablicaDwuwymiarowaMnozenie[0, k] = k + 1;
            }
            for (int l = 0; l < 10; l++)
            {
                tablicaDwuwymiarowaMnozenie[l, 0] = l + 1;
            }


            Console.WriteLine("Operacje na tablicach");
            Console.WriteLine("");
            Console.WriteLine("Zadanie nr 1");
            Console.Write("Maksymalna wartosc z tej tablicy to: ");
            Console.WriteLine(getMaxValue(tablica));
            Console.WriteLine("");

            Console.WriteLine("Zadanie nr 2");
            Console.Write("Maksymalna wartosc tej tablicy dla parzystych indexow to: ");
            Console.WriteLine(getMaxValueUnderParityIndex(tablica));
            Console.WriteLine("");

            Console.WriteLine("Zadanie nr 3");
            Console.Write("Index ktory zawiera maksymalny element to: ");
            Console.WriteLine(whereIsMaxValue(tablica));
            Console.WriteLine("");

           //   Console.WriteLine("Zadanie nr 4");
           ///   Console.WriteLine("Minimalny/Maksymalny element tablicy ");
          //    Console.WriteLine(getValue());
            //  Console.WriteLine("");

            Console.WriteLine("Zadanie 5");
            Console.Write("Suma elementow tablicy wynosi to: ");
            Console.WriteLine(getSumOfValues(tablica));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Rotacja tablicy o jeden element");
            rotateTable(tablica);
            string wierszTablica = "";
            for (int i = 0; i < 10; i++)
                
            {
                wierszTablica += tablica[i] + " ";
            }
            Console.WriteLine(wierszTablica);
            Console.WriteLine("");



            Console.WriteLine("Zadanie 7");
            Console.Write("Liczba binarna przekonwertowana na decymalna wynosi: ");
            Console.WriteLine(getDecimalValue(tablicaBinarna));
            Console.WriteLine("");

            // Console.Writeln("Zadanie 8");

            Console.WriteLine("Zadanie 9");
            Console.Write("Średnia arytmetyczna z tablicy to: ");
            Console.WriteLine(getArithAverage(tablica));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Lustrzane odbicie tablicy");
            makeMirrorTable(tablica);
            for (int p = 0; p < 10; p++)
            {
                Console.Write(tablica[p] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 11");
            Console.WriteLine("Zamienione wartosci minimalne i maksymalne wyglada nastepujaco ");
            exchangeMinMax(tablica);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 12");
            Console.WriteLine("Wyzerowane elementy tablicy podzielne przez 3 wygladaja nastepujaco ");
            insertZeros(tablica);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 13");
            Console.WriteLine("Tablica binarna wyglada nastepujaco: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tablicaBinarna[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Tablica binarna ExOR wyglada nastepujaco: ");
            doExORTable(tablicaBinarna);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tablicaBinarna[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 14");
            Console.WriteLine("Macierz zamieniona na macierz jednostkowa wyglada nastepujaco ");
            makeIdentity(tab2D);
            for (int h = 0; h < 10; h++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(tab2D[h, i] + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 15");
            Console.WriteLine("Tablica do mnozenia");
            for (int h = 0; h < 10; h++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(tab2D[h, i] + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 16");
            Console.WriteLine("Sumowaie wiersza i kolumny tablicy");
            Console.WriteLine("Podaj wiersz do zsumowania");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj kolumne do zsumowania");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("Suma wynosi ");
            Console.WriteLine(getRowColSum(tab2D, row, col));
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Operacje na liczbach");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj potege liczby 2");
            int potega = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 do poteg i" + potega + " wynosi " + powerOfTwo(potega));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Podaj liczbe do potegowania");
            int liczba = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj potege do ktorej ma byc podniesiona liczba " + liczba);
            int potega2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(liczba + " do potegi " + potega2 + " wynosi " + powerOfNumber(liczba, potega2));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Podaj liczbe binarna do skonwertowania na dziesietna");
            string liczbaBinarna = Console.ReadLine();
            Console.WriteLine("Liczba " + liczbaBinarna + " w systemie dziesietnym to " + convertToDecimal(liczbaBinarna));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Sprawdzanie iloczynu logicznego (0 lub 1)");
            Console.WriteLine("Podaj pierwsza wartosc logiczna");
            bool wartosc1, wartosc2;
            int wartoscLogiczna1 = Convert.ToInt32(Console.ReadLine());
            if (wartoscLogiczna1 == 1)
            {
                wartosc1 = true;
            }
            else
            {
                wartosc1 = false;
            }
            Console.WriteLine("Podaj druga wartosc logiczna");
            int wartoscLogiczna2 = Convert.ToInt32(Console.ReadLine());
            if (wartoscLogiczna2 == 1)
            {
                wartosc2 = true;
            }
            else
            {
                wartosc2 = false;
            }
            Console.WriteLine("Iloczyn logiczny tych dwoch wartosci wynosi " + makeMulti(wartosc1, wartosc2));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Wyswietlanie n elementu ciagu arytmetycznego");
            Console.WriteLine("Podaj pierwszy wyraz ciagu arytmetycznego");
            float a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi wyraz ciagu arytmetycznego");
            float a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ktory wyraz ciagu arytmetycznego chcesz otrzymac");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(an + " wyraz ciagu arytmetycznego wynosi " + getNElementValue(a1, a2, an));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Sumowanie n pierwszych wyrazow ciagu arytmetycznego");
            Console.WriteLine("Podaj pierwszy wyraz ciagu arytmetyczngo");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi wyraz ciagu arytmetycznego");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ile pierwszych wyrazow ciagu arytmetycznego chcesz zsumowac");
            an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma " + an + " pierwszych wyrazow ciagu arytmetycznego wynosi " + getSumOfElements(a1, a2, an));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 7");
            Console.WriteLine("Wyswietlanie n elementu ciagu Fibonacciego");
            Console.WriteLine("Podaj ktory element ciagu chcesz otrzymac");
            an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(an + " wyraz ciagu Fibonacciego wynosi " + fibo(an));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 8");
            Console.WriteLine("Podaj liczbe, aby sprawdzic czy jest liczba pierwsza");
            int liczbaPierwsza = Convert.ToInt32(Console.ReadLine());
            if (checkPrimary(liczbaPierwsza))
            {
                Console.WriteLine(liczbaPierwsza + " jest liczba pierwsza.");
            }
            else
            {
                Console.WriteLine(liczbaPierwsza + " nie jest liczba pierwsza.");
            }
            Console.WriteLine("");

            Console.WriteLine("Zadanie 9");

            Console.WriteLine("");

            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Obliczanie ilosci pierwiastkow rownania kwadratowego");
            Console.WriteLine("Podaj a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba pierwiastkow rownania kwadratowego o parametrach " + a + "," + b + " i " + c + " wynosi " + getRootsNumber(a, b, c));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 11");
            Console.WriteLine("Podaj liczbe do obliczenia silni");
            int silnia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Silnia z liczby " + silnia + " wynosi " + factorial(silnia));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 12");
            Console.WriteLine("Podaj liczbe do obliczenia wartosci bezwzglednej");
            int bezwzgledna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wartosc bezwzgledna z liczby " + bezwzgledna + " wynosi " + absoluteValue(bezwzgledna));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 13");
            Console.WriteLine("Podaj liczbe rzeczywista aby zwrocic z niej liczbe calkowita");
            float liczbaRzeczywista = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Wartosc calkowita liczby " + liczbaRzeczywista + " wynosi " + getIntegerFromReal(liczbaRzeczywista));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 14");
            Console.WriteLine("Podaj liczbe aby zwrocic ilosc cyfr dziesietnych");
            int liczbaDziesietna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(liczbaDziesietna + " ma " + getDecimalDigits(liczbaDziesietna));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 15");
            Console.WriteLine("Podaj liczbe aby otrzymac jej odwrotna wartosc");
            double liczbaOdwrotna = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Odwrotnosc liczby " + liczbaOdwrotna + " wynosi " + inverseNumber(liczbaOdwrotna));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 16");
            Console.WriteLine("Podaj liczbe aby otrzymac jej przeciwna wartosc");
            int liczbaPrzeciwna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Liczba przeciwna do " + liczbaPierwsza + " wynosi " + reverseNumber(liczbaPrzeciwna));
            Console.WriteLine("");


            Console.WriteLine("Operacje na lancuchach");
            Console.WriteLine("");

            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Podaj tekst aby sprawdzic czy jest on palindromem");
            string palindrom = Console.ReadLine();
            bool wynik = isPalindrome(palindrom);
            if (wynik)
            {
                Console.WriteLine(palindrom + " jest palindromem");
            }
            else
            {
                Console.WriteLine(palindrom + " nie jest palindromem");
            }
            Console.WriteLine("");

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Podaj tekst aby usunac z niego biale znaki");
            string tekst = Console.ReadLine();
            Console.WriteLine("Tekst bez znakow wyglada nastepujaco " + trimSpaces(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Podaj tekst aby otrzymac jego lustrzane odbicie");
            tekst = Console.ReadLine();
            Console.WriteLine("Lustrzane odbicie " + tekst + " to " + reverseText(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Podaj tekst aby otrzymac duzy znak na poczatku kazdego wyrazu");
            tekst = Console.ReadLine();
            Console.WriteLine(toUpper(tekst));
            Console.WriteLine("");

            //5

            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Podaj liczbe aby zwrocic jej wartosc");
            tekst = Console.ReadLine();
            Console.WriteLine(extractNumberFromString(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 7");
            Console.WriteLine("Podaj czesc dziesietna liczby");
            string czescDziesietna = Console.ReadLine();
            Console.WriteLine("Podaj czesc ulamkowa liczby");
            string czescUlamkowa = Console.ReadLine();
            Console.WriteLine(extractNumberFromString(czescDziesietna, czescUlamkowa));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 8");
            Console.WriteLine("Podaj tekst aby sprawdzic ile jest w nim samoglosek");
            tekst = Console.ReadLine();
            Console.WriteLine(extractNumberOfVowels(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 9");
            Console.WriteLine("Wpisz tekst do sprawdzenia");
            tekst = Console.ReadLine();
            Console.WriteLine("Wpisz znak aby sprawdzic jego wystapienie");
            char znak = Console.ReadLine()[0];
            Console.WriteLine(getCharIndex(tekst, znak));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 10");
            Console.WriteLine("Wpisz tekst aby sprawdzic liczbe wyrazow");
            tekst = Console.ReadLine();
            Console.WriteLine(getWordsNumber(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 11");
            Console.WriteLine("Podaj imie aby sprawdzic plec wlasciciela");
            tekst = Console.ReadLine();
            wynik = isMale(tekst);
            if (wynik)
            {
                Console.WriteLine(tekst + " jest mezczyzna");
            }
            else
            {
                Console.WriteLine(tekst + " jest kobieta");
            }
            Console.WriteLine("");

            Console.WriteLine("Zadanie 12");
            Console.WriteLine("Podaj tekst aby wstawic do niego spacje");
            tekst = Console.ReadLine();
            Console.WriteLine(insertSpaces(tekst));
            Console.WriteLine("");

        //    Console.WriteLine("Zadanie 13");
        //    Console.WriteLine("Podaj tekst aby wstawic w niego wyraz");
        //    tekst = Console.ReadLine();
         //   Console.WriteLine("Podaj wyraz do wstawienia");
         //   string tekst2 = Console.ReadLine();
          //  Console.WriteLine("Podaj po ktorym wyrazie w tekscie ma zostac wprowadzony nowy wyraz");
          //  numerWyrazu = Convert.ToInt32(Console.ReadLine());
         //   Console.WriteLine(insertWord(tekst, tekst2, numerWyrazu));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 14");
            Console.WriteLine("Podaj tekst aby zamienic wielkie litery na male");
            tekst = Console.ReadLine();
            Console.WriteLine(toLower(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 15");
            Console.WriteLine("Wpisz liczbe aby otrzymac ja typu Integer");
            tekst = Console.ReadLine();
            Console.WriteLine(convertFromStringToNumber(tekst));
            Console.WriteLine("");

            Console.WriteLine("Zadanie 16");
            Console.WriteLine("Podaj tekst do zakodowania szyfrem Cezara");
            tekst = Console.ReadLine();
            Console.WriteLine("Podaj wartosc przesuniecia w szyfrowaniu");
            int przesuniecie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(caeserCipher(tekst, przesuniecie));
            Console.WriteLine("");

        }
        //funkcje tablice
        static int getMaxValue(int[] table)
        {
            int max = table[0];
            for (int i = 0; i < table.Length; i++) //porownywanie tab[i] z max, jesli wartosc tablicy jest wieksza to jest to max
            {
                if (table[i] > max)
                {
                    max = table[i];
                }
            }
            return max;
        }

        static int getMaxValueUnderParityIndex(int[] table) //porwywanie tab[i] z max dla parzystych indeksow
        {
            int max = 0;
            for (int i = 0; i < table.Length; i += 2)
            {
                if (table[i] > max)
                {
                    max = table[i];
                }
            }
            return max;
        }

        static int whereIsMaxValue(int[] table)
        {
            int max = table[0];
            int maxIndex = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > max)
                {
                    max = table[i];
                    maxIndex = i;
                }
                
            }
            return maxIndex;
        }


        static int getSumOfValues(int[] table)
        {
            int suma = 0;
            for (int i = 0; i < table.Length; i++) //sumowanie elementow
            {
                suma += table[i];
            }
            return suma;
        }

        static void rotateTable(int[] table)
        {
            int temp = table[table.Length - 1];
            for(int i = table.Length - 1; i > 0; i--) // przesuwanie elementow od konca
            {
                table[i] = table[i - 1];
            }
            table[0] = temp;
        }

        static int getDecimalValue(int[] table)
        {
            string liczba = "";
            for (int i = 0; i < table.Length; i++)
            {
                liczba += table[i];
            }
            int liczbaBin = Convert.ToInt32(liczba);
            int value = Convert.ToInt32(Convert.ToString(liczbaBin), 2);
            return value;
        }

        static float getArithAverage(int[] table)
        {
            float suma = 0;
            for (int i = 0; i < table.Length; i++)
            {
                suma += table[i];
            }
            float srednia = suma / table.Length;
            return srednia;
        }

        static void makeMirrorTable(int[] table)
        {
            for (int b = 0; b < table.Length / 2; b++)
            {
                int temp = table[b];
                table[b] = table[table.Length - 1 - b];
                table[table.Length - 1 - b] = temp;
            }
        }

        static void exchangeMinMax(int[] table)
        {
            int max = table[0];
            int min = table[0];
            int maxi = 0;
            int mini = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] > max) maxi = i;
                if (table[i] < min) mini = i;
            }
            int temp = table[maxi];
            table[maxi] = table[mini];
            table[mini] = temp;
        }

        static void insertZeros(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if ((table[i] % 3) == 0)
                {
                    table[i] = 0;
                }
            }
        }

        static void doExORTable(int[] binaryTable)
        {
            for (int i = 0; i < binaryTable.Length; i++)
            {
                if (i == 0) //pierwszy element
                {
                    if (binaryTable[binaryTable.Length - 1] == 0 && binaryTable[i + 1] == 1)
                    {
                        binaryTable[i] = 1;
                    }
                    else
                    if (binaryTable[binaryTable.Length - 1] == 1 && binaryTable[i + 1] == 0)
                    {

                        binaryTable[i] = 1;
                    }

                    else
                    {
                        binaryTable[i] = 0;
                    }
                }
                else if (i == binaryTable.Length - 1) //ostatni element
                {
                    if (binaryTable[0] == 0 && binaryTable[i - 1] == 1)
                    {
                        binaryTable[1] = 1;
                    }
                    else if (binaryTable[0] == 1 && binaryTable[i - 1] == 0)
                    {
                        binaryTable[i] = 1;
                    }
                    else
                    {
                        binaryTable[i] = 0;
                    }
                }
                else // pozostale
                {
                    if (binaryTable[i + 1] == 0 && binaryTable[i - 1] == 1)
                    {
                        binaryTable[i] = 1;
                    }
                    else if (binaryTable[i + 1] == 1 && binaryTable[i - 1] == 0)
                    {
                        binaryTable[i] = 1;
                    }
                    else
                    {
                        binaryTable[i] = 0;
                    }
                }
            }
        }

        static void makeIdentity(int[,] tab2D)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab2D[i, j] = 0;
                }
                tab2D[i, i] = 1;
            }
        }

        static void makeMatrixProduct(int[,] tablicaDwuwymiarowaMnozenie)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    tablicaDwuwymiarowaMnozenie[i, j] = tablicaDwuwymiarowaMnozenie[0, j] * tablicaDwuwymiarowaMnozenie[i, 0];
                }
            }
        }

        static int getRowColSum(int[,] tab2D, int row, int col)
        {
            int suma = 0;
            int liczbaRzedow = tab2D.GetLength(0);
            int liczbaKolumn = tab2D.GetLength(1);
            for (int i = 0; i < liczbaRzedow; i++)
            {
                suma += tab2D[row - 1, i];
            }
            for (int i = 0; i < liczbaKolumn; i++)
            {
                suma += tab2D[i, col - 1];
            }
            return suma;
        }


        //funkcje liczby

        static long powerOfTwo(int exp)
        {
            double value = 0;
            value = Math.Pow(2, exp);
            return Convert.ToInt64(value);
        }

        static long powerOfNumber(int number, int exp)
        {
            double value = 0;
            value = Math.Pow(number, exp);
            return Convert.ToInt64(value);
        }

        static int convertToDecimal(string Binary)
        {
            int dec = 0;
            int temp = 0;
            int bin = Convert.ToInt16(Binary);
            while (temp < Binary.Length)
            {
                int last = bin % 10;
                bin = bin / 10;
                if(last != 0)
                {
                    dec += Convert.ToInt32(Math.Pow(2, temp));
                }
                temp++;
            }
            return dec;
        }

        static int makeMulti(bool val1, bool val2)
        {
            int value1 = Convert.ToInt32(val1);
            int value2 = Convert.ToInt32(val2);
            return value1 * value2;
        }


        static float getNElementValue(float a1, float a2, int n)
        {
            float r = a2 - a1;
            float an = a1 + (n - 1) * r;
            return an;
        }

        static float getSumOfElements(float a1, float a2, int n)
        {
            float suma = 0;
            float r = a2 - a1;
            for (int i = 1; i <= n;i++){
                suma += a1 + (i - 1) * r;
            }
            return suma;
        }

        static float fibo(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            else
            {
                return fibo(n - 1) + fibo(n - 2);
            }
        }

        static bool checkPrimary(int number)
        {
            bool prime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }

        static bool makeLogicSum(bool wartosc1, bool wartosc2)
        {
            bool sum = false;
            if (wartosc1)
            {
                sum = true;
            }
            if (wartosc2)
            {
                sum = true;
            }
            return sum;
        }

        static int getRootsNumber(float a, float b, float c)
        {
            int wynik = 0;
            float d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                wynik = 1;
            }
            else if (d > 0)
            {
                wynik = 2;
            }
            return wynik;
        }

        static long factorial (int n)
        {
            if (n < 2)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }


        static float absoluteValue(float number)
        {
            float numer = number;
            if (number < 0)
            {
                numer = -1 * number;
            }
            return numer;
        }

        static int getIntegerFromReal(float number)
        {
            return (int)number;
        }

        static int getDecimalDigits(float number)
        {
            int wynik = Convert.ToString(number).Length;
            return wynik;
        }

        static double inverseNumber(double number)
        {
            double wynik = 0;
            if (number != 0)
            {
                wynik = 1 / number;
            }
            return wynik;
        }

        static int reverseNumber(int number)
        {
            return -number;
        }
            
        //funkcje stringow

        static bool isPalindrome(string text)
        {
            string temp = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                temp += text[i];
            }
            if (temp == text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string trimSpaces(string text)
        {
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    temp += text[i];
                }
            }
            return temp;
        }

        static string reverseText(string text)
        {
            string temp = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                temp += text[i];
            }
            return temp;
        }

        static string toUpper(string text)
        {
            string temp = "";
            string litera = "";
            for (int i = 0; i <text.Length; i++)
            {
                litera = "";
                litera += text[i];
                if (i == 0 || text[i - 1] == ' ')
                {
                    temp += litera.ToUpper();
                }
                else
                {
                    temp += litera;
                }
            }
            return temp;
        }

        //5


        static long extractNumberFromString (string text)
        {
            long temp = Convert.ToInt64(text);
            return temp;
        }

        static float extractNumberFromString (string integral, string fractional)
        {
            float calkowita = Convert.ToSingle(integral);
            float ulamkowa = Convert.ToSingle(fractional) / (float)Math.Pow(10, fractional.Length);
            return calkowita + ulamkowa;
        }


        static int extractNumberOfVowels(string text)
        {
            int wynik = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' || text[i] == 'y')
                {
                    wynik++;
                }
            }
            return wynik;
        }

        static int getCharIndex(string text, char mark)
        {
            int wynik = -1;
            for (int i = 0; i <text.Length; i++)
            {
                if (text[i] == mark)
                {
                    wynik = i;
                    break;
                }
            }
            return wynik;

        }

        static int getWordsNumber(string text)
        {
            int ktory = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && text[i - 1] != ' ')
                {
                    ktory++;
                }
            }
            return ktory;
        }

        static bool isMale(string text)
        {
            if (text[text.Length - 1] == 'a')
            {
                return false;
            }
            else
{
                return true;
            }
        }


        static string insertSpaces(string text)
        {
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 97 && i != 0)
                {
                    temp += ' ';
                    temp += text[i];
                }
                else
                {
                    temp += text[i];
                }

            }
            return temp;
        }


        static string insertWord(string text, string word, int spaceIndex)
        {
            string temp = "";
            int numerWyrazu = 0;
            for (int i = 0; i <text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    numerWyrazu++;
                }
                if (numerWyrazu == spaceIndex)
                {
                    temp += ' ' + word;
                    numerWyrazu++;
                }
                temp += text[i];
            }
            return temp;
        }

        static string toLower(string text)
        {
            string temp = ""; 
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 97 && (int)text[i] > 64)
                {
                    string litera = "";
                    litera += text[i];
                    temp += litera.ToLower();
                }
             
            }
            return temp;
        }


        static int convertFromStringToNumber(string text)
        {
            int numer = 0;
            for (int i = 0; i < text.Length; i++)
            {
                numer = numer * 10 + text[i] - 48;
            }
            return numer;
        }

        static string caeserCipher(string text, int move)
        {
            string zaszyfrowane = "";
            int przesuniecie = 0;
            int znak = 0;
            for (int i = 0; i <text.Length; i++)
            {
                if ((int)text[i] > 64 && (int)text[i] < 91)
                {
                    int przesuniecie1 = (int)text[i] + move;
                    if (przesuniecie1 > 90)
                    {
                        przesuniecie = przesuniecie1 - 90;
                        znak = 64 + przesuniecie;
                    }
                    else
                    {
                        przesuniecie = move;
                        znak = text[i] + przesuniecie;
                    }
                }
                zaszyfrowane += Convert.ToString(Convert.ToChar(znak));
            }
            return zaszyfrowane;
        }

    }
}