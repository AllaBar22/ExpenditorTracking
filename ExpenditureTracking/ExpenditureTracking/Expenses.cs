using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracking
{
    public class Expenses
    {
        public Dictionary<string, int> countExpenses(List<string> names, List<int> amount)
        {
            var expenses = new Dictionary<string, int>();
            List<string> namesList = new List<string>();
            namesList.AddRange(names.Distinct());
            foreach (string name in namesList)
            {
                int sum = 0;
                for (int i = 0; i < names.Count; i++)
                {
                    if (name.Equals(names[i]))
                    {
                        sum += amount[i];
                    }
                }
                expenses.Add(name, sum);
            }
            return expenses;
        }
    }
}
