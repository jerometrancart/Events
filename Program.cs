using Events;

///CREE POINT D ABONNEMENT ET DE DIFFUSION
///PAS DE NEW, SYNTAXE ON....
///ABONNEMENT DU DELEGATE AVEC +=, DESABONNEMENT AVEC -=
///POSSIBLE D UTILISER LES CLASSES GENERIQUES Action<> (sans retour) ET Func<> (avec retour) POUR CREER DES EVENTS
///EVENTHANDLER ET EVENTHANDLER<T> SIGNATURE PRECONFIGUREE QUI CORRESPOND AUX EVENTS

System.Console.WriteLine("Ecrivez une chose pour la voir aux couleurs de la France !");

var message = Console.ReadLine();

var ep = new EventPratique();

///ABONNE A ONMESSAGERECU
ep.OnMessageRecu += EventPratiqueARecuUnMessage;
ep.EcrireMessage(message);


void EventPratiqueARecuUnMessage(string message)
{
    System.Console.WriteLine("Merci !");
}

