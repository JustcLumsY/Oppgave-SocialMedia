using System;
using System.Linq;
using System.Text;

namespace Oppgave_SocialMedia
{
    internal class Program
    {
        static App app = new App("Fjøsboka");


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            app.Users.Add(new Person("Kenneth", "M", 25, "Veien203", true));
            app.Users.Add(new Person("Marius", "B", 28, "Vegen200002", false));
            app.Users.Add(new Person("John", "T", 30, "Kongevegen", false));

            Console.WriteLine($"Velkommen til {app.Name}. Hvilken bruker vil du logge deg inn på?");
            var userInput = Console.ReadLine();
            var match = app.Users.FindIndex(x => x.Name == userInput);
            if (match != -1)
            {
                app.CurrentUser = userInput;
                var currentUser = app.CurrentUser;
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("Bluh");
            }

            Console.WriteLine(app.CurrentUser);

            while (true)
            {
                userInput = Console.ReadLine();

                userInput.ToLower();

                //if (userInput == "vis venner") kenneth.PrintFriends();
                //if (userInput == "legg til venn") kenneth.AddFriend("JohnT");
                //if (userInput == "slett venn") kenneth.RemoveFriend();
            }
        }

    }

    //Lag applikasjon FriendFace.Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm.Her trenger en bruker
    //en profilside med diverse info om seg(ta gjerne inspirasjon fra andre sosiale medier),en metode som heter “AddFriend” og en metode
    //“RemoveFriend”. Når programmet starter opp skal du lage en hovedbruker som er “innlogget” og du må også opprette flere forskjellige
    //brukere som lever på det sosiale mediet.Lag et kommandovindu i konsollen der du kan

    //Legge til forskjellige brukere som venn (på den som er innlogget)

    //Fjerne brukere som venn

    //Printe ut en liste av alle man har lagt til som venn

    //Velge en av vennene og printe ut profilinformasjonen deres.
}
