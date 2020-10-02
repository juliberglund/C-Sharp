using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Klasser
{
    class Program
    {
        class person
        {

            public List<Bil> PersonBilList { get; set; }

            public person(List<Bil> bilar)
            {
                PersonBilList = bilar;
            }

        }




        class Bil
        {

            public string vikt { get; set; }
            public DateTime Registrerades { get; set; }

            public string registreringsnummer { get; set; }
            public bool Elbil { get; set; }

            public Bil(string model)
            {
                this.model = model;
            }

            public string model;
            private int mätarställning;

            public void mätarställning_update(int x)
            {
                mätarställning = mätarställning + x;
            }

            public string mätarställning_Get()
            {
                return mätarställning.ToString();
            }


        }

        class Programm
        {



            private static void Main(string[] args)
            {

                while (true)
                {
                    Console.WriteLine("Vad har du för model på din bil?");
                    Bil bil1 = new Bil(Console.ReadLine());


                    Console.WriteLine("Vad är din bils registreringsnummer?");
                    bil1.registreringsnummer = (Console.ReadLine());

                    Console.WriteLine("Vad väger din bil i kg?");
                    bil1.vikt = (Console.ReadLine());


                    bil1.Registrerades = DateTime.Now;


                    Console.WriteLine("Är det en elbil?");
                    string str = Console.ReadLine();
                    if (str == "ja" || str == "Ja")
                    {
                        bil1.Elbil = true;
                        Console.WriteLine("Det är en elbil!!");
                    }
                    else { bil1.Elbil = false; }






                    Console.WriteLine("Vad är bilens mätarställning?");
                    int test = int.Parse(Console.ReadLine());
                    bil1.mätarställning_update(test);


                    Console.WriteLine($"Stämmer det att du har bil modellen {bil1.model} att ditt regnr är {bil1.registreringsnummer}, att bilen väger {bil1.vikt} att du registrerade bilen {DateTime.Now} att det är en elbil är {bil1.Elbil} och att mätarställningen är {bil1.mätarställning_Get()} ");
                    string svarjanej = Console.ReadLine();


                    if (svarjanej == "nej" || svarjanej == "Nej")
                    {

                        Console.WriteLine("Försök igen");
                        continue;

                    }
                    else break;






                }




                while (true)
                {
                    Console.WriteLine("Vad har du för model på din andra bil?");
                    Bil bil2 = new Bil(Console.ReadLine());

                    Console.WriteLine("Vad är din bils registreringsnummer?");
                    bil2.registreringsnummer = (Console.ReadLine());

                    Console.WriteLine("Vad väger din bil i kg?");
                    bil2.vikt = (Console.ReadLine());


                    bil2.Registrerades = DateTime.Now;


                    Console.WriteLine("Är det en elbil?");
                    bil2.Elbil = false;
                    string svarElbil = Console.ReadLine();
                    if (svarElbil == "ja" || svarElbil == "Ja")
                    {
                        Console.WriteLine("Du har en elbil!");


                    }
                    else { bil2.Elbil = false; }


                    Console.WriteLine("Vad är bilens mätarställning?");
                    int svarMätarstallning = int.Parse(Console.ReadLine());
                    bil2.mätarställning_update(svarMätarstallning);

                    Console.WriteLine($"Stämmer det att bilNr2 är modellen {bil2.model}, att registreringsnummret är {bil2.registreringsnummer}, att bilen väger {bil2.vikt} och att det är en elbil är {bil2.Elbil} samt att den har gått {bil2.mätarställning_Get()}km?");
                    string svarJANEJ = Console.ReadLine();

                    if (svarJANEJ == "Nej" || svarJANEJ =="nej")
                    {
                        Console.WriteLine("Försök igen");
                        continue;

                    }
                    else break;

                }





                while (true)
                {
                    Console.WriteLine("Vad har du för model på din tredje bil?");
                    Bil bil3 = new Bil(Console.ReadLine());

                    Console.WriteLine("Vad är din bils registreringsnummer?");
                    bil3.registreringsnummer = (Console.ReadLine());

                    Console.WriteLine("Vad väger din bil i kg?");
                    bil3.vikt = (Console.ReadLine());


                    bil3.Registrerades = DateTime.Now;

                    Console.WriteLine("Är det en elbil?");
                    string svarElbil = Console.ReadLine();
                    bil3.Elbil = false;
                    if (svarElbil == "Ja" || svarElbil == "ja")
                    {
                        Console.WriteLine("Det är en elbil!");
                    }
                    else { bil3.Elbil = false; }


                    Console.WriteLine("Vad är bilens mätarställning?");
                    bil3.mätarställning_update(56);

                    Console.WriteLine($"Stämmer det att din bils model är {bil3.model}, att ditt regnr är {bil3.registreringsnummer}, att din bil väger {bil3.vikt}kg, att det är en elbil är {bil3.Elbil} och att den gått {bil3.mätarställning_Get()}?");
                    string SvarJANEJ = Console.ReadLine();

                    if (SvarJANEJ == "Nej" || SvarJANEJ == "nej")
                    {
                        Console.WriteLine("Försök igen");
                        continue;

                    }
                    else break;

                }



                while (true)
                {
                    Console.WriteLine("Vad har du för model på din fjärde bil?");
                    Bil bil4 = new Bil(Console.ReadLine());

                    Console.WriteLine("Vad är din bils registreringsnummer?");
                    bil4.registreringsnummer = (Console.ReadLine());

                    Console.WriteLine("Vad väger din bil i kg?");
                    bil4.vikt = (Console.ReadLine());


                    bil4.Registrerades = DateTime.Now;

                    Console.WriteLine("Är det en elbil?");
                    string svarElbil = Console.ReadLine();
                    bil4.Elbil = false;
                    if (svarElbil == "Ja" || svarElbil == "ja")
                    {
                        Console.WriteLine("Det är en elbil!");
                    }
                    else { bil4.Elbil = false; }


                    Console.WriteLine("Vad är bilens mätarställning?");
                    bil4.mätarställning_update(56);

                    Console.WriteLine($"Stämmer det att din bils model är {bil4.model}, att ditt regnr är {bil4.registreringsnummer}, att din bil väger {bil4.vikt}kg, att det är en elbil är {bil4.Elbil} och att den gått {bil4.mätarställning_Get()}?");
                    string SvarJANEJ = Console.ReadLine();

                    if (SvarJANEJ == "Nej" || SvarJANEJ == "nej")
                    {
                        Console.WriteLine("Försök igen");
                        continue;

                    }
                    else break;

                    Console.WriteLine("Tack det var all information vi behövde. Ha en trevlig dag så återkommer vi!");

                    Console.ReadLine();

                }


                Console.ReadLine();













            }


            
        }
    }
}  
               


































//}