using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpenditureTracking;

namespace ExpenditureTrackingTest
{
    [TestClass]
    public class ExpTrackTest
    {
        [TestMethod]
        public void checkEqualsAbsVal_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 10, -10 };
            List<int> actual = new List<int>();
            actual = transactions.checkEqualsAbsVal(difBetweenAmountAndAverage);
            List<int> expected = new List<int> { 1, 0, 10};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void checkEqualsAbsVal_OnePersonExpenses_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 0 };
            List<int> actual = new List<int>();
            actual = transactions.checkEqualsAbsVal(difBetweenAmountAndAverage);
            List<int> expected = new List<int>();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void differenceCorrection_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 10, -20, 11 };
            List<int> actual = new List<int>();
            actual = transactions.differenceCorrection(difBetweenAmountAndAverage);
            List<int> expected = new List<int> { 10, -21, 11};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void differenceCorrection_OnePersonExpenses_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 0 };
            List<int> actual = new List<int>();
            actual = transactions.differenceCorrection(difBetweenAmountAndAverage);
            List<int> expected = new List<int> { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countDiffBetweenAmountAndAver_Test()
        {
            Transactions transactions = new Transactions();
            List<int> amount = new List<int> { 25, 10 };
            List<int> actual = new List<int>();
            actual = transactions.countDiffBetweenAmountAndAver(amount);
            List<int> expected = new List<int> { 8, -8};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countDiffBetweenAmountAndAver_OnePersonExpanses_Test()
        {
            Transactions transactions = new Transactions();
            List<int> amount = new List<int> { 25 };
            List<int> actual = new List<int>();
            actual = transactions.countDiffBetweenAmountAndAver(amount);
            List<int> expected = new List<int> { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countTransactions_NoChanges_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 0, 0 };
            List<int> transact = new List<int> { 1, 0, 20};
            List<int> actual = new List<int>();
            actual = transactions.countTransactions(difBetweenAmountAndAverage, transact);
            List<int> expected = new List<int> { 1, 0, 20 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countTransactions_WithChanges_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 10, -5, -5 };
            List<int> transact = new List<int>();
            List<int> actual = new List<int>();
            actual = transactions.countTransactions(difBetweenAmountAndAverage, transact);
            List<int> expected = new List<int> { 1, 0, 5, 2, 0, 5};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countTransactions_OnePersonExpanses_Test()
        {
            Transactions transactions = new Transactions();
            List<int> difBetweenAmountAndAverage = new List<int> { 0 };
            List<int> transact = new List<int>();
            List<int> actual = new List<int>();
            actual = transactions.countTransactions(difBetweenAmountAndAverage, transact);
            List<int> expected = new List<int> ();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void transactionManagement_Test()
        {
            Transactions transactions = new Transactions();
            List<int> amount = new List<int> { 23, 10, 0 };
            List<int> actual = new List<int>();
            actual = transactions.transactionManagement(amount);
            List<int> expected = new List<int> { 1, 0, 1, 2, 0, 11};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void transactionManagement_OnePersonExpenses_Test()
        {
            Transactions transactions = new Transactions();
            List<int> amount = new List<int> { 500 };
            List<int> actual = new List<int>();
            actual = transactions.transactionManagement(amount);
            List<int> expected = new List<int> ();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countExpenses_Test()
        {
            Expenses expenses = new Expenses();
            List<string> names = new List<string> { "Bob", "Kevin", "Bob", "Kevin" };
            List<int> amount = new List<int> { 100, 500, 50, 20 };
            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = expenses.countExpenses(names, amount);
            Dictionary<string, int> expected = new Dictionary<string, int> { {"Bob", 150}, {"Kevin", 520} };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void countExpenses_OnePersonExpenses_Test()
        {
            Expenses expenses = new Expenses();
            List<string> names = new List<string> { "Bob", "Bob", "Bob", "Bob" };
            List<int> amount = new List<int> { 100, 500, 50, 20 };
            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = expenses.countExpenses(names, amount);
            Dictionary<string, int> expected = new Dictionary<string, int> { { "Bob", 670 } };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void resultPayout_EqualsExpenses_Test()
        {
            Payout payout = new Payout();
            List<int> expenses = new List<int> { 150, 520 };
            List<int> transactions = new List<int> { 0, 1, 185 };
            List<int> actual = new List<int>();
            actual = payout.resultPayout(expenses, transactions);
            List<int> expected = new List<int> { 335, 335 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void resultPayout_NotEqualsExpenses_Test()
        {
            Payout payout = new Payout();
            List<int> expenses = new List<int> { 150, 521 };
            List<int> transactions = new List<int> { 0, 1, 186 };
            List<int> actual = new List<int>();
            actual = payout.resultPayout(expenses, transactions);
            List<int> expected = new List<int> { 336, 335 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void resultPayout_OnePersonExpenses_Test()
        {
            Payout payout = new Payout();
            List<int> expenses = new List<int> { 150 };
            List<int> transactions = new List<int>();
            List<int> actual = new List<int>();
            actual = payout.resultPayout(expenses, transactions);
            List<int> expected = new List<int> { 150 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
