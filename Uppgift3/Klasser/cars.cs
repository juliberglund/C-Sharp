using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Klasser
{
    class cars
    {
        
        private string model;
        private int vikt;
        private DateTime registrerades;
        private bool elbil;
        private string registreringsnummer;

        //public cars()
        //{
        //    this.color = color;
        //    this.model = model;

        //    this.vikt = vikt;

        //    this.elbil = elbil;

        //    this.registrerades = registrerades;

        //    GetModel();
        //}

        public string GetModel()
        {
            Console.WriteLine("Vilken model har du på bilen?");
            string modelanswer = Console.ReadLine();
            Console.WriteLine($"Din bil har modellen {modelanswer} stämmer det?");
            string answer = Console.ReadLine();
            return GetModel();   
        }

        public void SetModel()
        {
            this.model = model;
        }

        


    }
}
