namespace ExpenditureTracking
{
    partial class GUI
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewListOfPayment = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.TBAverage = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewExpenses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.listViewTransactionsToBeMade = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTBName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBService = new System.Windows.Forms.MaskedTextBox();
            this.maskedTBAmount = new System.Windows.Forms.MaskedTextBox();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(288, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add new record";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // listViewListOfPayment
            // 
            this.listViewListOfPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Service,
            this.Amount});
            this.listViewListOfPayment.GridLines = true;
            this.listViewListOfPayment.Location = new System.Drawing.Point(12, 73);
            this.listViewListOfPayment.Name = "listViewListOfPayment";
            this.listViewListOfPayment.Size = new System.Drawing.Size(263, 355);
            this.listViewListOfPayment.TabIndex = 7;
            this.listViewListOfPayment.UseCompatibleStateImageBehavior = false;
            this.listViewListOfPayment.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 78;
            // 
            // Service
            // 
            this.Service.Text = "Service";
            this.Service.Width = 86;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "List of payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average";
            // 
            // TBTotal
            // 
            this.TBTotal.BackColor = System.Drawing.SystemColors.Window;
            this.TBTotal.Location = new System.Drawing.Point(197, 434);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(74, 20);
            this.TBTotal.TabIndex = 11;
            // 
            // TBAverage
            // 
            this.TBAverage.BackColor = System.Drawing.SystemColors.Window;
            this.TBAverage.Location = new System.Drawing.Point(197, 460);
            this.TBAverage.Name = "TBAverage";
            this.TBAverage.ReadOnly = true;
            this.TBAverage.Size = new System.Drawing.Size(74, 20);
            this.TBAverage.TabIndex = 12;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(288, 73);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(100, 23);
            this.buttonCalc.TabIndex = 13;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(288, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear all records";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expenses";
            // 
            // listViewExpenses
            // 
            this.listViewExpenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listViewExpenses.GridLines = true;
            this.listViewExpenses.Location = new System.Drawing.Point(426, 22);
            this.listViewExpenses.Name = "listViewExpenses";
            this.listViewExpenses.Size = new System.Drawing.Size(152, 142);
            this.listViewExpenses.TabIndex = 16;
            this.listViewExpenses.UseCompatibleStateImageBehavior = false;
            this.listViewExpenses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            this.columnHeader3.Width = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Transactions ";
            // 
            // listViewTransactionsToBeMade
            // 
            this.listViewTransactionsToBeMade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTransactionsToBeMade.GridLines = true;
            this.listViewTransactionsToBeMade.Location = new System.Drawing.Point(288, 352);
            this.listViewTransactionsToBeMade.Name = "listViewTransactionsToBeMade";
            this.listViewTransactionsToBeMade.Size = new System.Drawing.Size(290, 137);
            this.listViewTransactionsToBeMade.TabIndex = 18;
            this.listViewTransactionsToBeMade.UseCompatibleStateImageBehavior = false;
            this.listViewTransactionsToBeMade.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "To";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 71;
            // 
            // maskedTBName
            // 
            this.maskedTBName.Location = new System.Drawing.Point(12, 24);
            this.maskedTBName.Name = "maskedTBName";
            this.maskedTBName.Size = new System.Drawing.Size(95, 20);
            this.maskedTBName.TabIndex = 19;
            this.maskedTBName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTBName_MouseClick);
            this.maskedTBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTBName_KeyPress);
            // 
            // maskedTBService
            // 
            this.maskedTBService.Location = new System.Drawing.Point(113, 24);
            this.maskedTBService.Name = "maskedTBService";
            this.maskedTBService.Size = new System.Drawing.Size(97, 20);
            this.maskedTBService.TabIndex = 20;
            this.maskedTBService.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTBService_MouseClick);
            this.maskedTBService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTBService_KeyPress);
            // 
            // maskedTBAmount
            // 
            this.maskedTBAmount.Location = new System.Drawing.Point(216, 24);
            this.maskedTBAmount.Name = "maskedTBAmount";
            this.maskedTBAmount.Size = new System.Drawing.Size(55, 20);
            this.maskedTBAmount.TabIndex = 21;
            this.maskedTBAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTBAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTBAmount_MouseClick);
            this.maskedTBAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTBAmount_KeyPress);
            // 
            // listViewResult
            // 
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewResult.GridLines = true;
            this.listViewResult.Location = new System.Drawing.Point(426, 193);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(152, 124);
            this.listViewResult.TabIndex = 22;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Payout";
            this.columnHeader7.Width = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Result";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 492);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.maskedTBAmount);
            this.Controls.Add(this.maskedTBService);
            this.Controls.Add(this.maskedTBName);
            this.Controls.Add(this.listViewTransactionsToBeMade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewExpenses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.TBAverage);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewListOfPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Text = "ExpenditureTracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewListOfPayment;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Service;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.TextBox TBAverage;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewExpenses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewTransactionsToBeMade;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MaskedTextBox maskedTBName;
        private System.Windows.Forms.MaskedTextBox maskedTBService;
        private System.Windows.Forms.MaskedTextBox maskedTBAmount;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label9;
    }
}

