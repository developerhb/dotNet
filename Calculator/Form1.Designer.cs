namespace Calculator
{
    partial class Form1
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
            this.result = new System.Windows.Forms.TextBox();
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.memRead = new System.Windows.Forms.Button();
            this.memPlus = new System.Windows.Forms.Button();
            this.memMinus = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.ButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(229, 27);
            this.result.TabIndex = 0;
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLayout.ColumnCount = 4;
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayout.Controls.Add(this.btn0, 0, 4);
            this.ButtonLayout.Controls.Add(this.clear, 0, 4);
            this.ButtonLayout.Controls.Add(this.plus, 0, 4);
            this.ButtonLayout.Controls.Add(this.dot, 0, 4);
            this.ButtonLayout.Controls.Add(this.minus, 3, 3);
            this.ButtonLayout.Controls.Add(this.btn3, 2, 3);
            this.ButtonLayout.Controls.Add(this.btn2, 1, 3);
            this.ButtonLayout.Controls.Add(this.btn1, 0, 3);
            this.ButtonLayout.Controls.Add(this.product, 3, 2);
            this.ButtonLayout.Controls.Add(this.btn6, 2, 2);
            this.ButtonLayout.Controls.Add(this.btn5, 1, 2);
            this.ButtonLayout.Controls.Add(this.btn4, 0, 2);
            this.ButtonLayout.Controls.Add(this.division, 3, 1);
            this.ButtonLayout.Controls.Add(this.btn9, 2, 1);
            this.ButtonLayout.Controls.Add(this.btn8, 1, 1);
            this.ButtonLayout.Controls.Add(this.btn7, 0, 1);
            this.ButtonLayout.Controls.Add(this.delete, 3, 0);
            this.ButtonLayout.Controls.Add(this.memMinus, 2, 0);
            this.ButtonLayout.Controls.Add(this.memPlus, 1, 0);
            this.ButtonLayout.Controls.Add(this.memRead, 0, 0);
            this.ButtonLayout.Location = new System.Drawing.Point(12, 55);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 5;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.Size = new System.Drawing.Size(229, 317);
            this.ButtonLayout.TabIndex = 1;
            // 
            // memRead
            // 
            this.memRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memRead.Location = new System.Drawing.Point(3, 3);
            this.memRead.Name = "memRead";
            this.memRead.Size = new System.Drawing.Size(51, 57);
            this.memRead.TabIndex = 0;
            this.memRead.Text = "MR";
            this.memRead.UseVisualStyleBackColor = true;
            this.memRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // memPlus
            // 
            this.memPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memPlus.Location = new System.Drawing.Point(60, 3);
            this.memPlus.Name = "memPlus";
            this.memPlus.Size = new System.Drawing.Size(51, 57);
            this.memPlus.TabIndex = 1;
            this.memPlus.Text = "M+";
            this.memPlus.UseVisualStyleBackColor = true;
            // 
            // memMinus
            // 
            this.memMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memMinus.Location = new System.Drawing.Point(117, 3);
            this.memMinus.Name = "memMinus";
            this.memMinus.Size = new System.Drawing.Size(51, 57);
            this.memMinus.TabIndex = 2;
            this.memMinus.Text = "M-";
            this.memMinus.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete.Location = new System.Drawing.Point(174, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(52, 57);
            this.delete.TabIndex = 3;
            this.delete.Text = "DEL";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 66);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 57);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(60, 66);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 57);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(117, 66);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 57);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // division
            // 
            this.division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.division.Location = new System.Drawing.Point(174, 66);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(52, 57);
            this.division.TabIndex = 7;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 57);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(60, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 57);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(117, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 57);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // product
            // 
            this.product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product.Location = new System.Drawing.Point(174, 129);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(52, 57);
            this.product.TabIndex = 11;
            this.product.Text = "*";
            this.product.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 192);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 57);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(60, 192);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 57);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(117, 192);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 57);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button15_Click);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(174, 192);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(52, 57);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // dot
            // 
            this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot.Location = new System.Drawing.Point(117, 255);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(51, 59);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(174, 255);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(52, 59);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Location = new System.Drawing.Point(3, 255);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(51, 59);
            this.clear.TabIndex = 18;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(60, 255);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 59);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 384);
            this.Controls.Add(this.ButtonLayout);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TableLayoutPanel ButtonLayout;
        private System.Windows.Forms.Button memRead;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button memMinus;
        private System.Windows.Forms.Button memPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dot;
    }
}

