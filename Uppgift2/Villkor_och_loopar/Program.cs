using System;


namespace Del_2_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            int startnummer = 0;
            int starttimme = 0;
            int startminut = 0;
            int startsekund = 0;
            int startTidISekunder = 0;

            int sluttimme = 0;
            int slutminut = 0;
            int slutsekund = 0;
            int slutTidISek = 0;
            int malTidISekunder = 0;


            int bastaStartNummer = 0,
                 bastaTid = int.MaxValue,
                 antalTavlande = 0;

            int bastaSlutTimme = 0,
                bastaSlutMinut = 0,
                bastaSlutSekund = 0;

            //bool forstaTavlande = true;




            while (true)
            {
                Console.WriteLine("Ange startnummer: ");

                int.TryParse(Console.ReadLine(), out startnummer);
                // startnumber = int.Parse(console.ReadLine());
                // Convert.ToInt32 och .Parse kommer krascha om användaren skriver in något annat en en siffra.

                if (startnummer < 1)
                {
                    break;
                }

                antalTavlande++;

                Console.WriteLine("Ange timme för start: ");
                starttimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange minut för start: ");
                startminut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange sekund för start: ");
                startsekund = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange timme för mål: ");
                sluttimme = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange minut för mål: ");
                slutminut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ange sekund för mål: ");
                slutsekund = Convert.ToInt32(Console.ReadLine());


                startTidISekunder = (starttimme * 3600) + (startminut * 60) + startsekund;
                malTidISekunder = (sluttimme * 3600) + (slutminut * 60) + slutsekund;

                slutTidISek = malTidISekunder - startTidISekunder;
                if (slutTidISek < 0)
                {
                    slutTidISek += 24 * 3600; // +ar på med en hel dag i sekunder
                }


                if (slutTidISek < bastaTid)
                {
                    bastaStartNummer = startnummer;
                    bastaTid = slutTidISek;
                }



                Console.WriteLine($"Startnummer {bastaStartNummer}  är vinnaren");

                bastaSlutTimme = (int)Math.Floor((decimal)bastaTid / 3600);
                bastaSlutMinut = (int)Math.Floor((decimal)bastaTid / 60) - bastaSlutTimme * 60;
                bastaSlutSekund = bastaTid % 60;

                //hur många gånger går 60 i bästa tid resten kommer bli sekunder 
                //Math.Roud avrundar neutralt om de är över 0.5 eller inte
                // Math.Floor avrundar alltid nedåt
                // Math. Seeling gör tvärt om avrundar upppåt

                Console.WriteLine($"Vinnande sluttid: {bastaSlutTimme} timmar {bastaSlutMinut} minuter {bastaSlutSekund} sekunder ");
                Console.WriteLine($"Antal tävlande var {antalTavlande} stycken");

                Console.ReadLine();



            }






        }
    }
}


