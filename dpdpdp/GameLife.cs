using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;

namespace WindowsFormsApp2
{
    public partial class GameLife : Form
    {
        private Graphics graphics;
        private bool[,] field;
        private int rows;
        private int cols;
        private GameLife Instance;
        private bool isMouseDown;
        private int currentStep = 0;
        List<string> HistoryHashes = new List<string>();
        int countCells = 0;
        public GameLife()
        {
            InitializeComponent();
            Instance = this;
            this.Width += 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            timer1.Interval=(int)nudTime.Value;
            timer1.Start();
        }


        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            StopGame();
            TakeSize();
        }

        private void pbField_SizeChanged(object sender, EventArgs e)
        {
            StopGame();
            TakeSize();
        }

        private void TakeSize()
        {
            GC.Collect();
            pbField.Image = new Bitmap(pbField.Width, pbField.Height);
            graphics = Graphics.FromImage(pbField.Image);
            for (int i=0;i<cols;i++)
            {
                for (int j=0;j<rows;j++)
                {
                    graphics.FillRectangle(Brushes.White, i * (int)nudResolution.Value + 1, j * (int)nudResolution.Value + 1, (int)nudResolution.Value - 2, (int)nudResolution.Value - 2);
                    graphics.DrawRectangle(new Pen(Color.Black), i * (int)nudResolution.Value, j * (int)nudResolution.Value, (int)nudResolution.Value, (int)nudResolution.Value);
                }
            }
            rows = pbField.Height / ((int)nudResolution.Value);
            cols = pbField.Width / ((int)nudResolution.Value);
            field = new bool[cols, rows];
        }
    
        private void NextGeneration()
        {
            GC.Collect();
            lblStep.Text = (++currentStep).ToString();
            if (countCells == 0)
            {
                if (timer1.Enabled)
                    timer1.Stop();
                MessageBox.Show("Количество живых ячеек равно 0", "Конец игры");
                btnStart.Enabled = false;
                btnStep.Enabled = false;
                currentStep = 0;
                lblStep.Text = "0";
            }
            else
            {
                Task.Run(() =>
                {
                    Instance.Invoke((MethodInvoker)delegate
                    {
                        countCells = 0;
                        var newField = new bool[cols, rows];
                        int neigh;
                        Image img = (Image)pbField.Image.Clone();
                        for (int x = 0; x < cols; x++)
                        {
                            for (int y = 0; y < rows; y++)
                            {
                                graphics.FillRectangle(Brushes.White, x * (int)nudResolution.Value + 2, y * (int)nudResolution.Value + 2, (int)nudResolution.Value - 2, (int)nudResolution.Value - 2);
                                graphics.DrawRectangle(new Pen(Color.Black), y * (int)nudResolution.Value, y * (int)nudResolution.Value, (int)nudResolution.Value, (int)nudResolution.Value);
                                neigh = CointNeight(x, y);
                                bool hasLife = field[x, y];

                                if (!hasLife && neigh == 3)
                                {
                                    newField[x, y] = true;
                                }
                                else if (hasLife && (neigh < 2 || neigh > 3))
                                    newField[x, y] = false;
                                else
                                    newField[x, y] = field[x, y];

                                if (newField[x, y])
                                {
                                    graphics.FillRectangle(Brushes.Blue, x * (int)nudResolution.Value + 2, y * (int)nudResolution.Value + 2, (int)nudResolution.Value - 3, (int)nudResolution.Value - 3);
                                    graphics.DrawRectangle(new Pen(Color.Black), x * (int)nudResolution.Value, y * (int)nudResolution.Value, (int)nudResolution.Value, (int)nudResolution.Value);
                                    countCells++;
                                }
                            }
                        }
                        field = newField;
                        pbField.Refresh();
                    });
                });
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private int CointNeight(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var selfChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !selfChecking)
                        count++;
                }
            }
            return count;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                return;
            timer1.Stop();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            NextGeneration();
        }

        private void pbField_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void pbField_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                DrawRectangle(e);
            }
        }

        /// <summary>
        /// Метод для отрисовки ячейки
        /// </summary>
        /// <param name="e">Событие мыши</param>
        private void DrawRectangle(MouseEventArgs e)
        {
            //Определение позиции для отрисовчки ячейки
            int curX = e.X / (int)nudResolution.Value;
            int curY = e.Y / (int)nudResolution.Value;
            //Если нажатие мыши не выходит за границы
            if (curX >= 0 && curX < cols && curY < rows && curY >= 0)
            {
                //Отрисовка ячейки в указанной позиции
                graphics.FillRectangle(Brushes.Blue, curX * (int)nudResolution.Value+2, curY * (int)nudResolution.Value+2, (int)nudResolution.Value - 3, (int)nudResolution.Value - 3);
                //Отрисовка рамки ячейки в указанной позиции
                graphics.DrawRectangle(new Pen(Color.Black), curX * (int)nudResolution.Value, curY * (int)nudResolution.Value, (int)nudResolution.Value, (int)nudResolution.Value);
                //Нарисованная чейка становится живой
                field[curX, curY] = true;
                //Увеличение количества живых ячеек
                countCells++;
                //Обновления поля игры
                pbField.Refresh();
            }
        }

        private void pbField_MouseUp(object sender, MouseEventArgs e)
        {
            btnStep.Enabled = true;
            btnStart.Enabled = true;
            isMouseDown = false;
        }

        private void pbField_MouseClick(object sender, MouseEventArgs e)
        {
            DrawRectangle(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStep.Enabled = false;
            StopGame();
        }

        private void StopGame()
        {
            if (timer1.Enabled)
                timer1.Stop();
            TakeSize();
            currentStep = 0;
            lblStep.Text = "0";
            countCells = 0;
        }

        private void GameLife_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 212;
        }

        private void GameLife_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}