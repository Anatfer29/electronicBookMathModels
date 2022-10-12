using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace dpdpdp
{
    public partial class Interactive : Form
    {

        List<List<double>> matrixAMult = new List<List<double>>();
        List<List<double>> matrixBMult = new List<List<double>>();
        List<List<double>> matrixAdaptive = new List<List<double>>();
        List<List<double>> matrixNum = new List<List<double>>();
        List<List<double>> opredMatrix = new List<List<double>>();
        List<List<double>> transMatrix = new List<List<double>>();

        List<List<double>> resultMatrix = new List<List<double>>();

        public Interactive()
        {
            InitializeComponent();
            System.Runtime.GCSettings.LargeObjectHeapCompactionMode = System.Runtime.GCLargeObjectHeapCompactionMode.CompactOnce;
            if (currentUser.GetRole()==3)
            {
                gbAdaptive.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }

            nudNum.BackColor = Color.Empty;

            tpMultiply.SetToolTip(pbMulti, "Для перемножения матриц выберите матрицу А и В\nи нажмите \"Сохранить\".\n   Если хотите использовать параллельное перемножение,\nпоставьте соотвествующий флажок.");
            tpInverse.SetToolTip(pbInverse, "Для нахождения обратной матрицы выберите матрицу\nи нажмите \"Сохранить\".");
            tpNum.SetToolTip(pbOnNum, "Для умножения матрицы на число выберите матрицу,\nвведите число и нажмите \"Сохранить\".");
            tpDeter.SetToolTip(pbDeter, "Для нахождения определителя матрицы выберите матрицу\nи нажмите \"Сохранить\".");
            tpTrans.SetToolTip(pbTrans, "Для нахождения транспонированной матрицы выберите матрицу\nи нажмите \"Сохранить\".");
        }

        private void interactive_FormClosing(object sender, FormClosingEventArgs e)
        {
            matrixAMult.Clear();
            matrixBMult.Clear();
            matrixAdaptive.Clear();
            matrixNum.Clear();
            opredMatrix.Clear();
            transMatrix.Clear();
            GC.Collect();
        }

        private void btnReadMatrix(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnMatrixA":
                    matrixAMult.Clear();
                    ReadMatrix(ref matrixAMult, lblA);
                    break;
                case "btnMatrixB":
                    matrixBMult.Clear();
                    ReadMatrix(ref matrixBMult, lblB);
                    break;
                case "btnReadAdaptive":
                    matrixAdaptive.Clear();
                    ReadMatrix(ref matrixAdaptive, lblAdaptive);
                    if (matrixAdaptive.Count != 0)
                    {
                        if (matrixAdaptive.Count==matrixAdaptive[0].Count)
                            lblAdaptive.Text = "Матрица успешно считана";
                        else
                        {
                            lblAdaptive.Text = "Матрица не является квадратной";
                            matrixAdaptive.Clear();
                        }
                    }
                    break;
                case "btnMatrixANum":
                    matrixNum.Clear();
                    ReadMatrix(ref matrixNum, lblNum);
                    break;
                case "btnOpred":
                    opredMatrix.Clear();
                    ReadMatrix(ref opredMatrix, lblROpred);
                    if (opredMatrix.Count != 0 && opredMatrix.Count == opredMatrix[0].Count && opredMatrix.Count != 0)
                    {
                        
                    }
                    else if (opredMatrix.Count!=0)
                    {
                        lblROpred.Text = "Матрица не является квадратной";
                        opredMatrix.Clear();
                    }
                    break;
                case "btnTransMatrix":
                    transMatrix.Clear();
                    ReadMatrix(ref transMatrix, lblReadTrans);
                    break;
            }
        }

        private void Multiply(List<List<double>> a, List<List<double>> b)
        {
            List<double> row = new List<double>();
            double num;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b[0].Count; j++)
                {
                    num = 0;
                    for (int k = 0; k < a[0].Count; k++)
                        num += a[i][k] * b[k][j];
                    row.Add(num);
                }
                resultMatrix.Add(row);
                row = new List<double>();
            }
            SaveMatrix(lblMulti, "Матрицы перемножены");
        }

        private void ParallelMatrix(List<List<double>> a, List<List<double>> b)
        {
            List<double> row = new List<double>();
            double num;
            Parallel.For(0, a.Count, i =>
            {

                for (int j = 0; j < b[0].Count; j++)
                {
                    num = 0;
                    for (int k = 0; k < a[0].Count; k++)
                        num += a[i][k] * b[k][j];
                    row.Add(num);
                }
                resultMatrix.Add(row);
                row = new List<double>();
            });
            SaveMatrix(lblMulti, "Матрицы перемножены");
        }

        private void ReadMatrix(ref List<List<double>> matrix, Label lbl)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml|*.xml";
            matrix = new List<List<double>>();
            List<double> row = new List<double>();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.ReadAllText(ofd.FileName).Trim() == "")
                    lbl.Text="Файл пуст";
                else
                {
                    StreamReader sr = new StreamReader(ofd.FileName);
                    try
                    {
                        string s;
                        do
                        {
                            s = sr.ReadLine();
                            if (s.Trim() != "")
                                foreach (string a in s.Split(' '))
                                {
                                    row.Add(Convert.ToDouble(a));
                                }
                        } while (row.Count() == 0);
                        matrix.Add(row);

                        row = new List<double>();

                        while (!sr.EndOfStream)
                        {
                            s = sr.ReadLine();
                            if (s.Trim() != "")
                            {
                                foreach (string a in s.Split(' '))
                                {
                                    if (s.Split(' ').Count() != matrix[0].Count())
                                    {
                                        lbl.Text = "Матрица не прямоугольная";
                                        matrix.Clear();
                                        sr.Close();
                                        return;
                                    }
                                    row.Add(Convert.ToDouble(a));
                                }
                                matrix.Add(row);
                                row = new List<double>();
                            }
                        }
                        sr.Close();
                        lbl.Text = "Матрица успешно считана";
                    }
                    catch
                    {
                        lbl.Text = "Неккоректные данные матрицы";
                        matrix.Clear();
                        sr.Close();
                    }
                }
            }
            else
            {
                lbl.Text = "Вы не выбрали файл";
            }
        }

        private void SaveMatrix(Label lbl, string str)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "xml|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (List<double> b in resultMatrix)
                {
                    sw.WriteLine(string.Join(" ", b.ToArray()));
                }
                sw.Close();
                lbl.Text = str;
                System.Diagnostics.Process.Start("explorer", new DirectoryInfo(sfd.FileName).ToString());
                resultMatrix.Clear();
            }
            else
            {
                lbl.Text = "Вы не выбрали файл для сохранения";
            }
        }

        private void btnMatrixOnNum_Click(object sender, EventArgs e)
        {
            if (matrixNum.Count != 0)
            {
                List<double> row = new List<double>();
                if (matrixNum.Count() != 0)
                {
                    for (int i = 0; i < matrixNum.Count(); i++)
                    {
                        for (int j = 0; j < matrixNum[0].Count(); j++)
                        {
                            row.Add(matrixNum[i][j] * Convert.ToDouble(nudNum.Value));
                        }
                        resultMatrix.Add(row);
                    }
                    SaveMatrix(lblNumRez, "Матрица успешно сохранена");
                }
            }
            else
                lblNumRez.Text = "Матрица не считана";
        }


        private void btnMultiMatrix_Click(object sender, EventArgs e)
        {
            if (matrixAMult.Count == 0 && matrixBMult.Count == 0)
            {
                lblMulti.Text = "Матрицы не считаны\nили считаны неккоректно";
            }
            else
            {
                if (matrixBMult[0].Count() == matrixAMult.Count)
                {
                    if (cbParallel.Checked)
                        ParallelMatrix(matrixBMult, matrixAMult);
                    else
                        Multiply(matrixBMult, matrixAMult);
                }
                else
                    lblMulti.Text = "Матрицы не являются\nсогласованными";
            }
        }

        private double[][] MatrixInverse(double[][] matrix)
        {
            int n = matrix.Length;
            double[][] result = MatrixCreate(matrix.Length, matrix.Length);
            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }
                double[] x = HelperSolve(lum, b);
                for (int j = 0; j < n; ++j)
                    result[j][i] = Math.Round(x[j],2);
            }
            return result;
        }

        private static double[] HelperSolve(double[][] luMatrix,
 double[] b)
        {
            int n = luMatrix.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);
            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum;
            }
            x[n - 1] /= luMatrix[n - 1][n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i][j] * x[j];
                x[i] = sum / luMatrix[i][i];
            }
            return x;
        }

        private static double[][] MatrixDecompose(double[][] matrix,
  out int[] perm, out int toggle)
        {
            int n = matrix.Length;
            double[][] result = MatrixDuplicate(matrix);
            perm = new int[n];
            for (int i = 0; i < n; ++i) { perm[i] = i; }
            toggle = 1;
            for (int j = 0; j < n - 1; ++j)
            {
                double colMax = Math.Abs(result[j][j]);
                int pRow = j;
                for (int i = j + 1; i < n; ++i)
                {
                    if (result[i][j] > colMax)
                    {
                        colMax = result[i][j];
                        pRow = i;
                    }
                }
                if (pRow != j)
                {
                    double[] rowPtr = result[pRow];
                    result[pRow] = result[j];
                    result[j] = rowPtr;
                    int tmp = perm[pRow];
                    perm[pRow] = perm[j];
                    perm[j] = tmp;
                    toggle = -toggle;
                }
                if (Math.Abs(result[j][j]) < 1.0E-20)
                    return null;
                for (int i = j + 1; i < n; ++i)
                {
                    result[i][j] /= result[j][j];
                    for (int k = j + 1; k < n; ++k)
                        result[i][k] -= result[i][j] * result[j][k];
                }
            }
            return result;
        }

        private static double[][] MatrixDuplicate(double[][] matrix)
        {
            double[][] result = MatrixCreate(matrix.Length, matrix[0].Length);
            for (int i = 0; i < matrix.Length; ++i)
                for (int j = 0; j < matrix[i].Length; ++j)
                    result[i][j] = matrix[i][j];
            return result;
        }

        private static double[][] MatrixCreate(int rows, int cols)
        {
            double[][] result = new double[rows][];
            for (int i = 0; i < rows; ++i)
                result[i] = new double[cols];
            return result;
        }

        private void btnAdaptiveMatrix_Click(object sender, EventArgs e)
        {
            if (matrixAdaptive.Count != 0)
            {
                double[][] adaptMatrix = new double[matrixAdaptive.Count][];
                for (int i = 0; i < matrixAdaptive.Count; i++)
                    adaptMatrix[i] = matrixAdaptive[i].ToArray();
                if (MatrixDeterminant(adaptMatrix) == 0)
                {
                    lblSaveAdapt.Text = "Определитель матрицы равен 0";
                }
                else
                {
                    adaptMatrix = MatrixInverse(adaptMatrix);
                    if (adaptMatrix != null)
                    {
                        List<List<double>> inversion = new List<List<double>>();
                        for (int i = 0; i < matrixAdaptive.Count; i++)
                            inversion.Add(adaptMatrix[i].ToList());
                        resultMatrix = inversion;
                        SaveMatrix(lblSaveAdapt, "Матрица успешно сохранена");
                    }
                }
            }
            else
                lblSaveAdapt.Text = "Матрица не считана";
        }

        private double MatrixDeterminant(double[][] matrix)
        {
            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm, out toggle);
            double result = toggle;
            for (int i = 0; i < lum.Length; ++i)
                result *= lum[i][i];
            return result;
        }

        private void btnSaveDeterminator_Click(object sender, EventArgs e)
        {
            if (opredMatrix.Count != 0)
            {
                double[][] array = new double[opredMatrix.Count][];
                for (int i = 0; i < opredMatrix.Count; i++)
                    array[i] = opredMatrix[i].ToArray();
                lblOpred.Text = "Определитель матрицы: " + MatrixDeterminant(array);
            }
            else
                lblOpred.Text = "Матрица не считана";
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (transMatrix.Count != 0)
            {
                double[][] arr = new double[transMatrix[0].Count][];
                List<List<double>> temp = new List<List<double>>();
                for (int i = 0; i < transMatrix[0].Count; i++)
                {
                    arr[i] = new double[transMatrix.Count];
                    for (int j = 0; j < transMatrix.Count; j++)
                    {
                        arr[i][j] = transMatrix[j][i];
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                    resultMatrix.Add(arr[i].ToList());

                SaveMatrix(lblSaveTrans, "Транспонированная матрица рассчитана");
            }
            else
            {
                lblSaveTrans.Text = "Матрица не считана";
            }
        }
    }
}