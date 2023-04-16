using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace override_C_
{
    internal class CreditCard
    {


        private string cardNumber;
        private string cvc;
        private DateTime expirationDate;
        private double sum;

        public CreditCard(string cardNumber, string cvc, DateTime expirationDate, double sum)
        {
            this.cardNumber = cardNumber;
            this.cvc = cvc;
            this.expirationDate = expirationDate;
            this.sum = sum;
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public string CVC
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public static CreditCard operator +(CreditCard card, double amount)
        {
            card.Sum += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, double amount)
        {
            card.Sum -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (card1 is null || card2 is null)
            {
                return false;
            }
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public override bool Equals(object obj)
        {
            return obj is CreditCard card &&
                   CVC == card.CVC;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Sum > card2.Sum;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Sum < card2.Sum;
        }
    }
}

