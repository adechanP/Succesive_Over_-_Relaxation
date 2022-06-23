namespace Succesive_Over_Relaxation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtGridView_Process = new System.Windows.Forms.DataGridView();
            this.txtBox_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridView_Ans = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGridView_Mtx = new System.Windows.Forms.DataGridView();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Make = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Col = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Row = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_w = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGridView_Process);
            this.groupBox2.Controls.Add(this.txtBox_count);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtGridView_Ans);
            this.groupBox2.Location = new System.Drawing.Point(456, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 417);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // dtGridView_Process
            // 
            this.dtGridView_Process.AllowUserToAddRows = false;
            this.dtGridView_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Process.Location = new System.Drawing.Point(9, 55);
            this.dtGridView_Process.Name = "dtGridView_Process";
            this.dtGridView_Process.Size = new System.Drawing.Size(456, 213);
            this.dtGridView_Process.TabIndex = 14;
            // 
            // txtBox_count
            // 
            this.txtBox_count.Location = new System.Drawing.Point(98, 21);
            this.txtBox_count.Name = "txtBox_count";
            this.txtBox_count.Size = new System.Drawing.Size(37, 20);
            this.txtBox_count.TabIndex = 13;
            this.txtBox_count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Iteration Count";
            // 
            // dtGridView_Ans
            // 
            this.dtGridView_Ans.AllowUserToAddRows = false;
            this.dtGridView_Ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Ans.Location = new System.Drawing.Point(9, 274);
            this.dtGridView_Ans.Name = "dtGridView_Ans";
            this.dtGridView_Ans.Size = new System.Drawing.Size(456, 137);
            this.dtGridView_Ans.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBox_w);
            this.groupBox1.Controls.Add(this.dtGridView_Mtx);
            this.groupBox1.Controls.Add(this.btn_Calc);
            this.groupBox1.Controls.Add(this.btn_Make);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBox_Col);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox_Row);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 417);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // dtGridView_Mtx
            // 
            this.dtGridView_Mtx.AllowUserToAddRows = false;
            this.dtGridView_Mtx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Mtx.Location = new System.Drawing.Point(6, 92);
            this.dtGridView_Mtx.Name = "dtGridView_Mtx";
            this.dtGridView_Mtx.Size = new System.Drawing.Size(430, 319);
            this.dtGridView_Mtx.TabIndex = 12;
            // 
            // btn_Calc
            // 
            this.btn_Calc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Calc.Location = new System.Drawing.Point(310, 48);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(126, 23);
            this.btn_Calc.TabIndex = 11;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Make
            // 
            this.btn_Make.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Make.Location = new System.Drawing.Point(310, 19);
            this.btn_Make.Name = "btn_Make";
            this.btn_Make.Size = new System.Drawing.Size(126, 23);
            this.btn_Make.TabIndex = 10;
            this.btn_Make.Text = "Make Input Grid";
            this.btn_Make.UseVisualStyleBackColor = true;
            this.btn_Make.Click += new System.EventHandler(this.btn_Make_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Row";
            // 
            // txtBox_Col
            // 
            this.txtBox_Col.Location = new System.Drawing.Point(62, 50);
            this.txtBox_Col.Name = "txtBox_Col";
            this.txtBox_Col.Size = new System.Drawing.Size(47, 20);
            this.txtBox_Col.TabIndex = 9;
            this.txtBox_Col.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Column";
            // 
            // txtBox_Row
            // 
            this.txtBox_Row.Location = new System.Drawing.Point(62, 21);
            this.txtBox_Row.Name = "txtBox_Row";
            this.txtBox_Row.Size = new System.Drawing.Size(47, 20);
            this.txtBox_Row.TabIndex = 8;
            this.txtBox_Row.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(140, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "w = ";
            // 
            // txtBox_w
            // 
            this.txtBox_w.Location = new System.Drawing.Point(173, 21);
            this.txtBox_w.Name = "txtBox_w";
            this.txtBox_w.Size = new System.Drawing.Size(47, 20);
            this.txtBox_w.TabIndex = 14;
            this.txtBox_w.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtGridView_Process;
        private System.Windows.Forms.TextBox txtBox_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridView_Ans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGridView_Mtx;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Make;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Col;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Row;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_w;
    }
}

