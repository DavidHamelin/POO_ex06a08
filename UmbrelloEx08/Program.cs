using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbrelloEx08
{
    class Program
    {
        static void Main(string[] args)
        {
            // On déclare un nouvel objet 'compteLaManu' instancié avec la classe 'BankAccount'
            BankAccount compteLaManu = new BankAccount();
            // Affectation de valeurs à l'objet compteLaManu
            //compteLaManu.holder = "LaManu";
            //compteLaManu.balance = 2000;
            //compteLaManu.currency = "euros";
            // Appel de la methode credit avec parametre (19)
            //compteLaManu.Credit(19);
            // Demander à l'utilisateur de saisir des valeurs :
            Console.WriteLine("Bonjour, veuillez entrer le nom du titulaire svp :");
            // On donne une valeur saisie par l'utilisateur à l'attribut 'holder' de l'objet 'compteLaManu'
            compteLaManu.holder = Console.ReadLine();
            Console.WriteLine("Merci ! Maintenant, entrez le solde du compte : ");
            compteLaManu.balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Super ! Pour finir, merci d'indiquer la devise :");
            compteLaManu.currency = Console.ReadLine();
            Console.WriteLine("Combien souhaitez vous ajouter à votre solde ? ");
            double creditUser = double.Parse(Console.ReadLine()); // on aurait pu appeler la variable creditUser : 'amount'
            compteLaManu.Credit(creditUser); // appel de la methode Credit
            Console.WriteLine($"Le solde du compte de {compteLaManu.holder} est de {compteLaManu.balance} {compteLaManu.currency}.");
        }
    }
    public class BankAccount
    {
        public string holder;
        public double balance;
        public string currency;

        public void Credit(double amount)
        {
            balance += amount;
        }
        public void Debit(double amount)
        {
            balance -= amount;
        }
    }
}
