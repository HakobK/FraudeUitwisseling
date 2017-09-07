using FraudeUitwisseling.Fraudeberichten;
using System;

namespace FraudeUitwisseling
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new Fraudeberichten.FraudeContext())
            {
                // Create and save a new Blog 
                Console.Write("Voer fraude id in: ");
                var FraudeID = Console.ReadLine();

                Console.Write("Voer contactpersoon email in: ");
                var ContactMail = Console.ReadLine();

                Console.Write("Voer contactpersoon achternaam in: ");
                var ContactAchternaam = Console.ReadLine();

                Console.Write("Voer contactpersoon straatnaam in: ");
                var ContactAdres = Console.ReadLine();

                Fraudesignaal signaal = new Fraudesignaal()
                {
                    FraudeID = new FraudeID() { SignaalNummer = Convert.ToInt32(FraudeID) },
                    Contactpersoon = new Contactpersoon() { EmailAdres = ContactMail,
                                                            NatuurlijkPersoonNaam = new NatuurlijkPersoonNaam() {Achternaam = ContactAchternaam},
                                                            Adres = new Adres() {Straatnaam = ContactAdres}}
                    
                };

                fs.Fraudesignalen.Add(signaal);
                fs.SaveChangesAsync();

                Console.WriteLine("Fraude met fraude id:" + signaal.FraudeID.SignaalNummer.ToString() + " opgeslagen.");
                Console.WriteLine("Fraude heeft als contactpersoon: " + signaal.Contactpersoon.NatuurlijkPersoonNaam.Achternaam);
                Console.ReadLine();

                //Console.WriteLine("Fraude opgeslagen"); 
                //Console.Write("Om fraude op te halen voer fraude id in: ");
                //var ZoekFraudeIDText = Console.ReadLine();

                //int ZoekFraudeID = Convert.ToInt32(ZoekFraudeIDText);

                //var gevondensignaal = fs.Fraudesignalen
                //            .FirstOrDefault(f => f.FraudeID.SignaalNummer == ZoekFraudeID);

                //Console.Write(gevondensignaal.Contactpersoon.NatuurlijkPersoonNaam.Achternaam);

                //Console.ReadLine();




            }
        }
    }
}
