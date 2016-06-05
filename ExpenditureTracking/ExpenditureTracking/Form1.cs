using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExpenditureTracking
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private const string FILE_NAME = @"Records.txt";

        private string getFileName()
        {
            return FILE_NAME;
        }

        private void maskedTBClear()
        {
            maskedTBName.Clear();
            maskedTBService.Clear();
            maskedTBAmount.Clear();
        }

        private void TBClear()
        {
            TBAverage.Clear();
            TBTotal.Clear();
        }

        private void listViewClear()
        {
            listViewExpenses.Items.Clear();
            listViewListOfPayment.Items.Clear();
            listViewTransactionsToBeMade.Items.Clear();
            listViewResult.Items.Clear();
        }

        private void maskedTBName_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void maskedTBService_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void maskedTBAmount_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(maskedTBName.Text.Equals("")||maskedTBService.Text.Equals("")||maskedTBAmount.Text.Equals(""))
            {
                MessageBox.Show("All field must be completed!");
            }
            else
            {
                if (IsValidInputDouble(maskedTBAmount.Text.ToString()) || IsValidInputInt(maskedTBAmount.Text.ToString()))
                {
                    string[] lines = { maskedTBName.Text, maskedTBService.Text, maskedTBAmount.Text };

                    if (System.IO.File.Exists(getFileName()))
                    {
                        System.IO.File.AppendAllLines(getFileName(), lines);
                    }
                    else
                    {
                        System.IO.File.WriteAllLines(getFileName(), lines);
                    }

                    maskedTBClear();
                    MessageBox.Show("Record was success added!");
                }
                else
                {
                    MessageBox.Show("Error in amount field! Possible enter 20 or 20.00 etc.");
                }
                
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            maskedTBClear();
            listViewClear();
            TBClear();
            if (System.IO.File.Exists(getFileName()))
            {
                System.IO.File.Delete(getFileName());
            }
            MessageBox.Show("All records were deleted!");
        }

        private void listOfPaymentOutput(List<string> names, List<string> services, List<int> amounts)
        {
            for (int i = 0; i < names.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(names[i]);
                listViewItem.SubItems.Add(services[i]);
                if (amounts[i] != 0)
                {
                    listViewItem.SubItems.Add(amounts[i].ToString().Insert(amounts[i].ToString().Length - 2, "."));
                }
                else
                {
                    listViewItem.SubItems.Add("0.00");
                }    
                listViewListOfPayment.Items.Add(listViewItem);
            }
        }

        private void expensesOutput(Dictionary<string, int> expenses)
        {
            for (int i = 0; i < expenses.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(expenses.Keys.ToList()[i]);
                if (expenses.Values.ToList()[i] != 0)
                {
                    listViewItem.SubItems.Add(expenses.Values.ToList()[i].ToString().Insert(expenses.Values.ToList()[i].ToString().Length - 2, "."));
                }
                else
                {
                    listViewItem.SubItems.Add("0.00");
                } 
                listViewExpenses.Items.Add(listViewItem);
            }
        }

        private void transactionsOutput(int oneRecElem, Dictionary<string, int> expenses, List<int> transactions)
        {
            for (int i = 0; i < transactions.Count; i += oneRecElem)
            {
                ListViewItem listViewItem = new ListViewItem(expenses.Keys.ToList()[transactions[i]]);
                listViewItem.SubItems.Add(expenses.Keys.ToList()[transactions[i + 1]]);
                listViewItem.SubItems.Add(transactions[i + 2].ToString().Insert(transactions[i + 2].ToString().Length-2,"."));
                listViewTransactionsToBeMade.Items.Add(listViewItem);
            }
        }

        private void resultOutput(List<int> result, Dictionary<string,int> expenses)
        {
            for(int i = 0; i < result.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(expenses.Keys.ToList()[i]);
                    if (result[i] != 0)
                    {
                        listViewItem.SubItems.Add(result[i].ToString().Insert(result[i].ToString().Length - 2, "."));
                    }
                    else
                    {
                        listViewItem.SubItems.Add("0.00");
                    }
                    listViewResult.Items.Add(listViewItem);
                }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            listViewClear();
            maskedTBClear();

            if (System.IO.File.Exists(getFileName()))
            {
                string[] lines = System.IO.File.ReadAllLines(getFileName());
                List<string> names = new List<string>();
                List<string> services = new List<string>();
                List<int> amounts = new List<int>();
                const int ONE_RECORD_ELEMENTS = 3;
                const int CONV_TO_CENTS = 100;
                
                for (int i = 0; i < lines.Length; i += ONE_RECORD_ELEMENTS)
                {
                    names.Add(lines[i]);
                    services.Add(lines[i + 1]);
                    if (!lines[i + 2].Contains("."))
                    {
                        amounts.Add(Convert.ToInt32(lines[i + 2]) * CONV_TO_CENTS); 
                    }
                    else
                    {
                        lines[i + 2] = lines[i + 2].Replace(".","");
                        amounts.Add(Convert.ToInt32(lines[i + 2]));
                    }
                }
                listOfPaymentOutput(names, services, amounts);

                Expenses expensesCalc = new Expenses();
                Dictionary<string, int> expenses = new Dictionary<string, int>();
                expenses = expensesCalc.countExpenses(names, amounts);
                expensesOutput(expenses);

                Transactions calculation = new Transactions();
                List<int> transactions = new List<int>();
                transactions = calculation.transactionManagement(expenses.Values.ToList());
                transactionsOutput(ONE_RECORD_ELEMENTS, expenses, transactions);

                Payout payout = new Payout();
                List<int> result = new List<int>();
                result = payout.resultPayout(expenses.Values.ToList(), transactions);
                resultOutput(result, expenses);

                TBTotal.Text = amounts.Sum().ToString().Insert(amounts.Sum().ToString().Length - 2,".");
                TBAverage.Text = ((int)Math.Round(expenses.Values.ToList().Average())).ToString().Insert(((int)Math.Round(expenses.Values.ToList().Average())).ToString().Length - 2, ".");
            }
            else
            {
                MessageBox.Show("There are no records. You should add it.");
            }
        }

        private void maskedTBAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);
        }

        private bool IsValidInputDouble(string p)
        {
            return Regex.Match(p, "^([0-9]{1,6})([.][0-9]{2})?$").Success;
        }

        private bool IsValidInputInt(string p)
        {
            return Regex.Match(p, "^[0-9]{1,6}$").Success;
        }

        private void maskedTBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTBService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}