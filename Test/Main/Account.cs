using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_task
{
    [Serializable]
    public class Account
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public decimal SumaVkladu { get; set; }
        public DateTime LastOperationDate { get; set; }

        public Account()
        {
            
        }

        public Account(string firstName, string secondName, string patronymic, decimal sumaVkladu, DateTime lastOperationDate)
        {
            FirstName = firstName;
            SecondName = secondName;
            Patronymic = patronymic;
            SumaVkladu = sumaVkladu;
            LastOperationDate = lastOperationDate;
        }

        public override string ToString()
        {
            return $"First name - {FirstName}, Second name - {SecondName}, Patronymic - {Patronymic},"
                + $"Suma vkladu - {SumaVkladu}, Last operation date - {LastOperationDate}";
        }
    }
}