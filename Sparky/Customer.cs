using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public int Discount = 15;
        public string GreetMessage { get; set; }

        public bool IsPlatinum { get; set; }


        public Customer()
        {
            IsPlatinum = false;
        }

        public string GreetAndCombineNames(string name, string lastName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Empty first name");
            }
            GreetMessage = $"Hello, {name} {lastName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}
