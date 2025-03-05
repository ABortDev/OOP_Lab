using System;

namespace LibrarySystem
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseOrderTypeLable = new System.Windows.Forms.Label();
            this.Term = new System.Windows.Forms.TextBox();
            this.OrderBookConfirmation = new System.Windows.Forms.Button();
            this.OrderType = new System.Windows.Forms.ComboBox();
            this.EnterTermLable = new System.Windows.Forms.Label();
            this.UnnecessaryLable = new System.Windows.Forms.Label();
            this.MaxTermLable = new System.Windows.Forms.Label();
            this.SelectedBookLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseOrderTypeLable
            // 
            this.ChooseOrderTypeLable.AutoSize = true;
            this.ChooseOrderTypeLable.Location = new System.Drawing.Point(71, 104);
            this.ChooseOrderTypeLable.Name = "ChooseOrderTypeLable";
            this.ChooseOrderTypeLable.Size = new System.Drawing.Size(195, 25);
            this.ChooseOrderTypeLable.TabIndex = 0;
            this.ChooseOrderTypeLable.Text = "Choose order type:";
            // 
            // Term
            // 
            this.Term.Location = new System.Drawing.Point(275, 166);
            this.Term.Name = "Term";
            this.Term.Size = new System.Drawing.Size(51, 31);
            this.Term.TabIndex = 1;
            // 
            // OrderBookConfirmation
            // 
            this.OrderBookConfirmation.Location = new System.Drawing.Point(287, 242);
            this.OrderBookConfirmation.Name = "OrderBookConfirmation";
            this.OrderBookConfirmation.Size = new System.Drawing.Size(182, 49);
            this.OrderBookConfirmation.TabIndex = 2;
            this.OrderBookConfirmation.Text = "Order book";
            this.OrderBookConfirmation.UseVisualStyleBackColor = true;
            this.OrderBookConfirmation.Click += new System.EventHandler(this.OrderBookConfirmation_Click);
            // 
            // OrderType
            // 
            this.OrderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OrderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OrderType.FormattingEnabled = true;
            this.OrderType.Items.AddRange(new object[] {
            "For home use",
            "In reading hall use"});
            this.OrderType.Location = new System.Drawing.Point(275, 101);
            this.OrderType.Name = "OrderType";
            this.OrderType.Size = new System.Drawing.Size(212, 33);
            this.OrderType.TabIndex = 3;
            // 
            // EnterTermLable
            // 
            this.EnterTermLable.AutoSize = true;
            this.EnterTermLable.Location = new System.Drawing.Point(63, 168);
            this.EnterTermLable.Name = "EnterTermLable";
            this.EnterTermLable.Size = new System.Drawing.Size(206, 25);
            this.EnterTermLable.TabIndex = 0;
            this.EnterTermLable.Text = "Enter term (in days):";
            // 
            // UnnecessaryLable
            // 
            this.UnnecessaryLable.AutoSize = true;
            this.UnnecessaryLable.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UnnecessaryLable.Location = new System.Drawing.Point(334, 169);
            this.UnnecessaryLable.Name = "UnnecessaryLable";
            this.UnnecessaryLable.Size = new System.Drawing.Size(404, 25);
            this.UnnecessaryLable.TabIndex = 0;
            this.UnnecessaryLable.Text = "Unnecessary for in reading hall use type.";
            // 
            // MaxTermLable
            // 
            this.MaxTermLable.AutoSize = true;
            this.MaxTermLable.ForeColor = System.Drawing.Color.Brown;
            this.MaxTermLable.Location = new System.Drawing.Point(425, 194);
            this.MaxTermLable.Name = "MaxTermLable";
            this.MaxTermLable.Size = new System.Drawing.Size(191, 25);
            this.MaxTermLable.TabIndex = 0;
            this.MaxTermLable.Text = "60 days maximum!";
            // 
            // SelectedBookLabel
            // 
            this.SelectedBookLabel.AutoSize = true;
            this.SelectedBookLabel.Location = new System.Drawing.Point(84, 45);
            this.SelectedBookLabel.Name = "SelectedBookLabel";
            this.SelectedBookLabel.Size = new System.Drawing.Size(155, 25);
            this.SelectedBookLabel.TabIndex = 0;
            this.SelectedBookLabel.Text = "Selected book:";
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Location = new System.Drawing.Point(282, 45);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(0, 25);
            this.BookTitleLabel.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 321);
            this.Controls.Add(this.OrderType);
            this.Controls.Add(this.OrderBookConfirmation);
            this.Controls.Add(this.Term);
            this.Controls.Add(this.MaxTermLable);
            this.Controls.Add(this.UnnecessaryLable);
            this.Controls.Add(this.EnterTermLable);
            this.Controls.Add(this.BookTitleLabel);
            this.Controls.Add(this.SelectedBookLabel);
            this.Controls.Add(this.ChooseOrderTypeLable);
            this.Name = "OrderForm";
            this.Text = "Order confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseOrderTypeLable;
        private System.Windows.Forms.TextBox Term;
        private System.Windows.Forms.Button OrderBookConfirmation;
        private System.Windows.Forms.ComboBox OrderType;
        private System.Windows.Forms.Label EnterTermLable;
        private System.Windows.Forms.Label UnnecessaryLable;
        private System.Windows.Forms.Label MaxTermLable;
        private System.Windows.Forms.Label SelectedBookLabel;
        private System.Windows.Forms.Label BookTitleLabel;
    }
}