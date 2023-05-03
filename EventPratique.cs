using System;

namespace Events
{
    
    public class EventPratique
    {
        ///CTOR
        public EventPratique()
        {
            ///ABONNEMENT LOCAL
            OnMessageRecu += EcrireEnBleu;
            OnMessageRecu += EcrireEnBlanc;
            OnMessageRecu += EcrireEnRouge;
        }

        public event Action<string> OnMessageRecu;

        public void EcrireMessage(string message)

        {
            Console.Clear();
            ///NOTIFIE TOUTES LES METHODES ABONNEES A ONMESSAGERECU
            OnMessageRecu(message);
        }

        private void EcrireEnBleu(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }

        private void EcrireEnRouge(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
            Console.ResetColor();
        }

        private void EcrireEnBlanc(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
