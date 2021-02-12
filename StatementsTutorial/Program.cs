using System;

namespace StatementsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // fizzbuzz

            for( var nbr = 0; nbr <= 30; nbr ++ )
            {
                if (nbr % 3 == 0 && nbr % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                    if (nbr % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                    if (nbr % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine($"{nbr}");
            }
            
            
            
            
            /*
            // more ternary practice

            var trafficLight = "green";
            var command = trafficLight == "red" ? "Stop" : "Go";
            Console.WriteLine($"The sign says {command}!");
            */


            /*
            var stateCode = "OH";
            var stateName = stateCode switch
            {
                "OH" => "Ohio",
                "KY" => "Kentucky",
                "IN" => "Indiana",
                _ => "Not Found"
            };

            // ternary
            var fInLaw = "Greg";
            var JadaFavLang = "";

            if(fInLaw == "Greg")
            {
                JadaFavLang = "C#";
            }
            else
            {
                JadaFavLang = "Java";
            }

            Console.WriteLine($" Jada LOVES {JadaFavLang}");
            */

            /*
            // while and do..while examples

            var counter = 1;
            while(counter <= 25)
            {
                if(counter % 2 != 0)
                {

                    Console.WriteLine($"Number: {counter*counter*counter}");

                }
                counter++;
            }

            var stateCode = "OH";
            var stateName = "";
            switch(stateCode)
            {
                case "IN":
                    stateName = "Indiana";
                    break;
                case "KY":
                    stateName = "Kentucky";
                    break;
                case "OH":
                    stateName = "Ohio";
                    break;
                default:
                    stateName = "Not Found";
                    break;
            }

            Console.WriteLine($"StateCode: {stateCode}, StateName: {stateName}");
            */

            /*
            // Created "Song" class --> practice 'for' and 'if'. Created index for songs

            var thriller = new Song
            {
                Title = "Thriller",
                Artist = "Michael Jackson",
                Genre = "Pop",
                Released = new DateTime(1984, 6, 1),
                Platinum = true
            };

            var thunderstruck = new Song
            {
                Title = "Thunderstruck",
                Artist = "AC/DC",
                Genre = "Rock",
                Released = new DateTime(1973, 1, 1),
                Platinum = true
            };
            // remember semicolon goes after closing brace only if initializing a variable

            var wastedontheway = new Song
            {
                Title = "Wasted on the way",
                Artist = "Crosby, Stills, & Nash",
                Genre = "Pop",
                Released = new DateTime(1982, 1, 1),
                Platinum = false
            };

            var overmyhead = new Song
            {
                Title = "Over my head",
                Artist = "Fleetwood Mac",
                Genre = "Pop Rock",
                Released = new DateTime(1975, 1, 1),
                Platinum = true
            };

            var songs = new Song[]
            {
                thriller,thunderstruck,wastedontheway
            };

            foreach(var song in songs)
            {
                if(song.Platinum == true)
                {
                    Console.WriteLine($"{song.Title}");
                }
            }
            */


            /*
            // more if...else practice
            Console.WriteLine("Enter a number:");
            var aNbr = Console.ReadLine();
            var Nbr = Convert.ToInt32(aNbr);
            if (Nbr % 2 == 0)
            { Console.WriteLine($"{aNbr} is even!"); }
            else
            { Console.WriteLine($"{aNbr} is odd :("); }

            // for() example
            var ints = new[] { 77, 32, 94, 46, 28 };
            for (var idx = 0; idx < 5; idx++)
            {
                Console.WriteLine($" idx: {idx} | ints[idx]: {ints[idx]}");
                //idx = index #, ints[idx] = value in index#
            }


            // list/sum examples

            var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
            var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
            var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };

            var sum = 0;
            foreach(var i in ints1)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");

            var sum2 = 0;
            foreach (var anInt in ints2)
            {
                if(anInt % 3 == 0)
                {
                    sum2 += anInt;
                }
            }
            Console.WriteLine($"Sum2: {sum2}");

            //var total1 = 0;
            //for (var idx = 0; idx < ints1.Length; idx++)
            //{
            //    if (ints1[idx] % 2 == 0)
            //    {
            //        total1 = total1 + ints1[idx];
            //    }
            //}
            //Console.WriteLine($"Total of even nbrs in [ints1]: {total1}");

            //var total3 = 0;
            //for (var idx = 0; idx < ints3.Length; idx++)
            //{
            //    if(ints3[idx] % 3 ==0)
            //    {
            //        total3 = total3 + ints3[idx];
            //    }
            //}
            //Console.WriteLine($"Total of odd nbrs in [ints3]: {total3}");






            var ans = 0;
            for (var nbr = 0; nbr <= 50; nbr++)
            {
                if (nbr % 5 == 0 || nbr % 7 == 0)
                    ans += nbr;
            }
            Console.WriteLine($"This is the sum of numbers 1 to 50 divisable by 5 or 7 : {ans}");
            */
        }
    }
}
