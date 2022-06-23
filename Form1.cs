using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Succesive_Over_Relaxation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Make_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtBox_Row.Text);
            int M = int.Parse(txtBox_Col.Text);

            dtGridView_Ans.Rows.Clear();
            dtGridView_Ans.Columns.Clear();
            dtGridView_Mtx.Rows.Clear();
            dtGridView_Mtx.Columns.Clear();
            dtGridView_Process.Columns.Clear();
            txtBox_count.Text = "";

            var colA = new DataGridViewColumn();
            colA.HeaderText = " ";
            colA.CellTemplate = new DataGridViewTextBoxCell();
            colA.Width = 40;
            dtGridView_Ans.Columns.Add(colA);

            var colA1 = new DataGridViewColumn();
            colA1.HeaderText = "X Answers";
            colA1.CellTemplate = new DataGridViewTextBoxCell();
            colA1.Width = 70;
            dtGridView_Ans.Columns.Add(colA1);

            for (int i = 0; i < M + 1; i++)
            {
                var colMtxP = new DataGridViewColumn();
                colMtxP.HeaderText = (i == 0 ? "Iteration" : "X" + (i).ToString());
                colMtxP.CellTemplate = new DataGridViewTextBoxCell();
                colMtxP.Width = 70;
                dtGridView_Process.Columns.Add(colMtxP);
            }

            for (int i = 0; i < M + 1; i++)
            {
                var colMtx1 = new DataGridViewColumn();
                colMtx1.HeaderText = (i == M ? "B" : "X" + (i + 1).ToString());
                colMtx1.CellTemplate = new DataGridViewTextBoxCell();
                colMtx1.Width = 40;
                dtGridView_Mtx.Columns.Add(colMtx1);

                if (i != M)
                {
                    dtGridView_Ans.Rows.Add();
                }

            }

            for (int j = 0; j < N; j++)
            {
                dtGridView_Mtx.Rows.Add();
            }

            for (int k = 0; k < M; k++)
            {
                dtGridView_Ans[0, k].Value = "X" + (k + 1).ToString();
            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            int count = 0;
            double[,] Mtx_A;
            double[] Mtx_B;
            double[] Answer;
            int N = int.Parse(txtBox_Row.Text);
            int M = int.Parse(txtBox_Col.Text);
            double W = double.Parse(txtBox_w.Text);

            dtGridView_Process.Columns.Clear();
            for (int i = 0; i < M + 1; i++)
            {
                var colMtxP = new DataGridViewColumn();
                colMtxP.HeaderText = (i == 0 ? "Iteration" : "X" + (i).ToString());
                colMtxP.CellTemplate = new DataGridViewTextBoxCell();
                colMtxP.Width = 70;
                dtGridView_Process.Columns.Add(colMtxP);
            }

            Mtx_A = new double[N, M];
            Mtx_B = new double[N];
            Answer = new double[N];

            for (int i = 0; i < N; i++)
            {
                Mtx_B[i] = Convert.ToDouble(dtGridView_Mtx[N, i].Value);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Mtx_A[i, j] = Convert.ToDouble(dtGridView_Mtx[j, i].Value);
                }
            }

            Answer = SOR_Iterative(count, Mtx_A, Mtx_B, W);


            for (int i = 0; i < N; i++)
            {
                dtGridView_Ans[1, i].Value = Answer[i];
            }
        }
        private double[] SOR_Iterative(int cnt, double[,] A, double[] B, double w)
        {
            int n = A.GetLength(0);
            double[] x0 = new double[n];
            double[] x1 = new double[n];
            double e = 0.0000001;
            double[] e1 = new double[n];
            bool check;

            for (int i = 0; i < n; i++)
            {
                x0[i] = 0;
                x1[i] = 0;
            }
            check = false;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    double sum = 0;
                    double sumL = 0;                    
                    for (int j=0; j < n; j++)
                    {
                        sum += A[i,j] * x0[j];
                    }
                    sum = sum - A[i, i] * x0[i];
                    for (int j = 0; j < i; j++)
                    {
                        sumL += A[i, j] * x1[j];
                        sum = sum - A[i, j] * x0[j];
                    }
                    sum = sum + sumL;
                    x1[i] = ((1 - w) * x0[i]) + (w * ((B[i] - sum) / A[i, i]));
                }

                for (int i = 0; i < n; i++)
                {
                    e1[i] = Math.Abs(x0[i] - x1[i]);
                }

                cnt++;
                for (int i = 0; i < n; i++)
                {
                    x0[i] = x1[i];
                }
                check = e1.All(element => element > e);

                dtGridView_Process.Rows.Add(cnt.ToString());
                for (int i = 0; i < n; i++)
                {
                    dtGridView_Process[i + 1, (cnt - 1)].Value = x1[i];
                }

            }
            while (check == true);
            txtBox_count.Text = cnt.ToString();
            return x1;
        }
    }
}
