using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbrelloEx07
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // Déclaration de la classe 'BankAccount' (nom avec MAJ)
    public class BankAccount
    {
        // déclaration des attributs
        public string holder;
        public double balance;
        public string currency;
        // Déclaration des méthodes (nom avec MAJ) avec parametres de type double
        public void Credit(double amount)
        {
            balance += amount; // Ajouter montant 'amount' à solde 'balance'
        }
        public void Debit(double amount)
        {
            balance -= amount; // Retirer montant 'amount' à solde 'balance'
        }
    }
}
