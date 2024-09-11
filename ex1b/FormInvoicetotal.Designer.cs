namespace ex1b
{
    partial class FormInvoicetotal
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
            label1 = new Label();
            textBoxSubtotal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDiscountAmount = new TextBox();
            textBoxTotal = new TextBox();
            buttonCalculate = new Button();
            buttonExit = new Button();
            DiscountPercent = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 0;
            label1.Text = "&Subtotal:";
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Location = new Point(229, 28);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(125, 27);
            textBoxSubtotal.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 82);
            label2.Name = "label2";
            label2.Size = new Size(184, 23);
            label2.TabIndex = 2;
            label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 135);
            label3.Name = "label3";
            label3.Size = new Size(182, 23);
            label3.TabIndex = 3;
            label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 189);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 4;
            label4.Text = "Total:";
            // 
            // textBoxDiscountAmount
            // 
            textBoxDiscountAmount.Location = new Point(229, 135);
            textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            textBoxDiscountAmount.ReadOnly = true;
            textBoxDiscountAmount.Size = new Size(125, 27);
            textBoxDiscountAmount.TabIndex = 6;
            textBoxDiscountAmount.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(229, 189);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(125, 27);
            textBoxTotal.TabIndex = 7;
            textBoxTotal.TabStop = false;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Arial Rounded MT Bold", 12F);
            buttonCalculate.Location = new Point(55, 257);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(118, 51);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "&Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Arial Rounded MT Bold", 12F);
            buttonExit.Location = new Point(209, 257);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 51);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "E&xit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // DiscountPercent
            // 
            DiscountPercent.Location = new Point(229, 78);
            DiscountPercent.Name = "DiscountPercent";
            DiscountPercent.ReadOnly = true;
            DiscountPercent.Size = new Size(125, 27);
            DiscountPercent.TabIndex = 10;
            DiscountPercent.TabStop = false;
            // 
            // FormInvoicetotal
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(404, 349);
            Controls.Add(DiscountPercent);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxDiscountAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSubtotal);
            Controls.Add(label1);
            Name = "FormInvoicetotal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice total";
            Load += FormInvoicetotal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSubtotal;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDiscountAmount;
        private TextBox textBoxTotal;
        private Button buttonCalculate;
        private Button buttonExit;
        private TextBox DiscountPercent;
    }
}