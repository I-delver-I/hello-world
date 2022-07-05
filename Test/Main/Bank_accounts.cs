using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace My_task
{
    [Serializable]
    public class Bank_accounts
    {
        private CustomList _accounts = new CustomList();

        public void AddAccount(Account account)
        {
            _accounts.AddNode(account);
        }

        public void Print()
        {
            _accounts.Print();
        }

        public CustomList GetAccounts()
        {
            return _accounts;
        }

        public Account GetAccountWithBiggestSum()
        {
            return _accounts.MaxBySum().Data;
        }
    }
}