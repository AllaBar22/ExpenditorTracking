using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracking
{
    public class Payout
    {
        public List<int> resultPayout(List<int> expenses, List<int> transactions)
        {
            const int NUMBER_OF_TRANCACTION_FIELDS = 3;

            for (int i = 0; i < transactions.Count; i += NUMBER_OF_TRANCACTION_FIELDS)
            {
                expenses[transactions[i]] += transactions[i+2];
                expenses[transactions[i + 1]] -= transactions[i + 2];
            }

            return expenses;
        }
    }
}
