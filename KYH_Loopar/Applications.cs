using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KYH_Loopar
{
    internal class Applications
    {
        public void Run()
        {
            //            Skapa ett program där användaren får mata in ett tal.
            //            Låt sedan programmet skriva ut alla siffor som är mindre än det inmatade talet
            //            men större än 0.

            //Lös detta med en for-loop.

            //Lös detta med en while-loop.


            //Console.WriteLine("Mata in ett tal");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0;  num > 0; i++)
            //{
            //    Console.WriteLine(num--);
            //}


            Console.WriteLine("Mata in ett tal");
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                Console.WriteLine(num--);

                
            }





            //            Be användaren mata in ett tal.
            //            Spara värdet i en variabel.
            //            Upprepa detta 10 gånger.
            //            För varje gång lägg till det inmatade värdet till variabelns värde.
            //            När det är klart skriv ut-Summan av det du matat in är: summan.

            //Lös både med for-loop och while-loop

            //int num = 0;

            //int sum = 0;

            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine("Mata in ett tal");
            //    num = int.Parse(Console.ReadLine());

            //    sum = num + sum;

            //}

            //Console.WriteLine(sum);

            //int num = 0;

            //int sum = 0;
            //int counter = 0;

            //while (counter < 10)
            //{

            //    Console.WriteLine("Mata in ett tal");
            //    num = int.Parse(Console.ReadLine());

            //    sum = num + sum;

            //    counter++;  
            //}

            //Console.WriteLine(sum);






            //a.Får mata in två tal.
            //b.Skriv sedan till skärmen summan av de två talen.
            //c.Skriv sedan en fråga-Vill du fortsätta(J/ N)?.
            //d.Svarar användaren J återupprepas punkt a-c
            //e.Svarar användaren N avbryts programmet

            //bool run = true;

            //while (run)
            //{

            //    Console.WriteLine("Vill du fortsätta programmet J/N");
            //    char svar = char.Parse(Console.ReadLine());


            //    if (svar == 'J')
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Ange 2 olika tal");
            //        int num1 = int.Parse(Console.ReadLine());
            //        int num2 = int.Parse(Console.ReadLine());

            //        Console.WriteLine(num1 + num2);


            //    }
            //    else if (svar == 'N')
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Programmet avslutas");
            //        Console.ReadKey();
            //        run = false;
            //    }
            //}


            //Console.WriteLine("Ange 2 olika tal");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    while (num1 < num2)
            //    {
            //        num1++;
            //        Console.WriteLine(num1);
            //    }
            //}
            //else if (num1 > num2)
            //{
            //    while (num1 > num2)
            //    {
            //        num2++;
            //        Console.WriteLine(num2);
            //    }
            //}

            //Console.WriteLine("Ange 2 olika tal");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 < num2)
            //{
            //    for (int i = num1 +1; i < num2; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else if (num1 > num2)
            //{
            //    for (int i = num1 -1; i > num2; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // skriv ut talen från 1-10

            // int num = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    num++;
            //    Console.WriteLine(num);
            //}

            //while (num < 10)
            //{
            //    num++;
            //    Console.WriteLine(num);
            //}

            //string namn = "stefan";
            //// char letter = 'a';

            //foreach (char c in namn)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine("1. Starta spelet");
            //Console.WriteLine("2. highscore");
            //Console.WriteLine("3. Avsluta");

            //bool run = true;

            //while (run)
            //{
            //    Console.WriteLine("Välj meny val");
            //    string menyVal = Console.ReadLine();

            //    switch (menyVal)
            //    {
            //        case "1":


            //            Console.WriteLine("Spelet är startat");
            //            Console.WriteLine("Spelet slutar");
            //            break;

            //        case "2":

            //            Console.WriteLine("Här är din highscore");

            //            break;

            //        case "3":

            //            Console.WriteLine("Du avslutar menyn nu");
            //            run = false;

            //            break;

            //    }
            //}




            //int counter = 0;

            //for (int year = 2022; year >= 1972; year--)
            //{
            //    Console.WriteLine(year);
            //}

            //for (int year = 1972; year <= 2022; year++)
            //{
            //    Console.WriteLine(year);
            //}


            //string namn = "Chrille";
            //bool run = true;


            //while (run)
            //{
            //    counter++;
            //    Console.WriteLine(counter);

            //     if (counter == 10)
            //    {
            //        run = false;
            //    }
            //}
            //Console.WriteLine("Slut");

            //Console.WriteLine(namn);
            //Console.WriteLine(namn);
            //Console.WriteLine(namn);
            //Console.WriteLine(namn);
            //Console.WriteLine(namn);

        }

    }
}
