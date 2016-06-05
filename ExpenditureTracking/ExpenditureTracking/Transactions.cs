using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenditureTracking
{
    public class Transactions
    {
        public List<int> differenceCorrection(List<int> difBetweenAmountAndAverage)
        {
            List<int> temp = new List<int>();
            temp.AddRange(difBetweenAmountAndAverage);

            while (difBetweenAmountAndAverage.Sum() > 0)
            {
                difBetweenAmountAndAverage[difBetweenAmountAndAverage.IndexOf(temp.Min())] -= 1;
                temp.Remove(temp.Min());
            }

            while (difBetweenAmountAndAverage.Sum() < 0)
            {
                difBetweenAmountAndAverage[difBetweenAmountAndAverage.IndexOf(temp.Max())] += 1;
                temp.Remove(temp.Max());
            }

            return difBetweenAmountAndAverage;
        }

        public List<int> countDiffBetweenAmountAndAver(List<int> amount)
        {
            int average = (int)Math.Round(amount.Average());
            List<int> difBetweenAmountAndAverage = new List<int>();

            for (int i = 0; i < amount.Count; i++)
            {
                difBetweenAmountAndAverage.Add(amount[i] - average);
            }

            if (difBetweenAmountAndAverage.Sum() != 0)
            {
                difBetweenAmountAndAverage = differenceCorrection(difBetweenAmountAndAverage);
            }

            return difBetweenAmountAndAverage;
        }

        public List<int> checkEqualsAbsVal(List<int> difBetweenAmountAndAverage)
        {
            List<int> transactions = new List<int>();
            for (int i = 0; i < difBetweenAmountAndAverage.Count - 1; i++)
            {
                for (int j = i + 1; j < difBetweenAmountAndAverage.Count; j++)
                {
                    if (difBetweenAmountAndAverage[i] != 0 && difBetweenAmountAndAverage[i] == difBetweenAmountAndAverage[j] * (-1))
                    {
                        if (difBetweenAmountAndAverage[i] > 0)
                        {
                            transactions.Add(j);
                            transactions.Add(i);
                        }
                        else
                        {
                            transactions.Add(i);
                            transactions.Add(j);
                        }
                        transactions.Add(Math.Abs(difBetweenAmountAndAverage[i]));
                        difBetweenAmountAndAverage[i] = 0;
                        difBetweenAmountAndAverage[j] = 0;
                    }
                }
            }
            return transactions;
        }

        public List<int> countTransactions(List<int> difBetweenAmountAndAverage, List<int> transactions)
        {
            for (int i = 0; i < difBetweenAmountAndAverage.Count - 1; i++)
            {
                for (int j = i + 1; j < difBetweenAmountAndAverage.Count; j++)
                {
                    if (difBetweenAmountAndAverage[i] != 0 && difBetweenAmountAndAverage[j] != 0
                        && Math.Sign(difBetweenAmountAndAverage[i]) != Math.Sign(difBetweenAmountAndAverage[j]))
                    {
                        if (difBetweenAmountAndAverage[i] > 0)
                        {
                            transactions.Add(j);
                            transactions.Add(i);
                            if (difBetweenAmountAndAverage[i] > Math.Abs(difBetweenAmountAndAverage[j]))
                            {
                                transactions.Add(Math.Abs(difBetweenAmountAndAverage[j]));
                                difBetweenAmountAndAverage[i] += difBetweenAmountAndAverage[j];
                                difBetweenAmountAndAverage[j] = 0;
                            }
                            else
                            {
                                transactions.Add(Math.Abs(difBetweenAmountAndAverage[i]));
                                difBetweenAmountAndAverage[j] += difBetweenAmountAndAverage[i];
                                difBetweenAmountAndAverage[i] = 0;
                            }
                        }
                        else
                        {
                            transactions.Add(i);
                            transactions.Add(j);
                            if (difBetweenAmountAndAverage[j] > Math.Abs(difBetweenAmountAndAverage[i]))
                            {
                                transactions.Add(Math.Abs(difBetweenAmountAndAverage[i]));
                                difBetweenAmountAndAverage[j] += difBetweenAmountAndAverage[i];
                                difBetweenAmountAndAverage[i] = 0;
                            }
                            else
                            {
                                transactions.Add(Math.Abs(difBetweenAmountAndAverage[i]));
                                difBetweenAmountAndAverage[i] += difBetweenAmountAndAverage[j];
                                difBetweenAmountAndAverage[j] = 0;
                            }
                        }
                    }
                }
            }
            return transactions;
        }

        public List<int> transactionManagement(List<int> amount)
        {
            List<int> difBetweenAmountAndAverage = new List<int>();
            difBetweenAmountAndAverage = countDiffBetweenAmountAndAver(amount);

            List<int> transactions = new List<int>();
            transactions = checkEqualsAbsVal(difBetweenAmountAndAverage);
            transactions = countTransactions(difBetweenAmountAndAverage, transactions);

            return transactions;
        }
    }
}
