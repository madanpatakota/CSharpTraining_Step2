using System;

namespace MovieNews
{

    // Note 1 : YOu cannot call the static members by using this keyboard
    //          this always represents the Reference of the class





    public class MovieDirector
    {
        //Static members

        //static conscturo you can create only once in the staic class
        public static string LeadActor = "Jakes";
        public static string Cinematographer = "Fiore";

        public static void CallLeadActor()
        {
            Console.WriteLine($"Calling Lead Actor: {MovieDirector.LeadActor}");
        }


        //Non-static memebers
        public string JuniorTechnician { get; set; }
        public string lightingAssistant { get; set; }


        public MovieDirector(string technician, string LightingAssistant)
        {
            this.JuniorTechnician = technician;
            this.lightingAssistant = LightingAssistant;
        }

        public void CallJuniorTechnician()
        {
            Console.WriteLine($"Calling Junior Technician: {JuniorTechnician}");
        }

        public void CallLightingAssistant()
        {
            Console.WriteLine($"Calling LightingAssistant: {this.lightingAssistant}");
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            //Direct calls
            Console.WriteLine("Static Members (Direct Call):");
            MovieDirector.CallLeadActor();
            string name =  MovieDirector.Cinematographer;

            // Indirect calls (Non-Static Members)
            Console.WriteLine("\nNon-Static Members (Indirect Call):");
            MovieDirector assistantDirector = new MovieDirector("Emily", "Clerk");
            assistantDirector.CallJuniorTechnician();
            assistantDirector.CallLightingAssistant();



        }
    }
}