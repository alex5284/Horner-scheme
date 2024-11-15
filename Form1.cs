using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {

        int MatrixSize = 0;//розмір многочлена(найбільша сткпінь х)
        double[] A;//масив коефіцієнтів біля х
        string f;//задана функція

        //double[] Count;
        List<double> Count;
        public Form1()
        {
            InitializeComponent();
        }

        void ReadMatrixFromGrid()
        {
            A = new double[MatrixSize+1];//створюємо масив коеф

            for (int i = 0; i < MatrixSize+1; i++)
            {
                A[i] = Convert.ToDouble(dgMatrix.Rows[1].Cells[i].Value);//запам'ятовуємо значення
            }


            ShowMatrixInGrid();

        }


        void ShowMatrixInGrid()
        {
            for (int i = 0; i < MatrixSize+1; i++)
            {
                    dgMatrix.Rows[1].Cells[i].Value = A[i].ToString();//показуємо значення масиву 
            }
        }

        void CreateMatrix()//створюємо панелі у DataDridView
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            dgMatrix.ColumnCount = MatrixSize + 2; 
            dgMatrix.Rows.Add(2);
            for (int i = 0; i <= MatrixSize+1; i++)
            {
                if(i < MatrixSize+1)
                {
                    dgMatrix.Rows[0].Cells[i].Value = $" x^{MatrixSize - i}";
                }
                else dgMatrix.Rows[0].Cells[i].Value = " y";
            }

            for (int i = 0; i <= MatrixSize+1; i++)
            {
                if (i < MatrixSize + 1) dgMatrix.Rows[1].Cells[i].Value = "1"; // записываем значеня в соответсвующие места
                else dgMatrix.Rows[1].Cells[i].Value = "0";
            }
        }
        void CreateMatrix1()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            int j = 0;
            dgMatrix.ColumnCount = MatrixSize + 2;
            dgMatrix.Rows.Add(2);
            for (int i = 0; i <= MatrixSize + 1; i++)
            {
                if (i < MatrixSize + 1)
                {
                    dgMatrix.Rows[0].Cells[i].Value = $" x^{MatrixSize - i}";
                }
                else dgMatrix.Rows[0].Cells[i].Value = " y";
            }

            j = 1;
            dgMatrix.Rows[j].Cells[0].Value = "1";
            dgMatrix.Rows[j].Cells[1].Value = "0";
            dgMatrix.Rows[j].Cells[2].Value = "21";
            dgMatrix.Rows[j].Cells[3].Value = "30";
            dgMatrix.Rows[j].Cells[4].Value = "0";
        }

        void F()//перетворюю масив коеф у рівняння f
        {
            A = new double[MatrixSize + 1];
            ReadMatrixFromGrid();
            f = " ";
            for(int i = 0; i < MatrixSize+1; i++)
            {
                f += $"({dgMatrix[i, 1].Value}) * ";
                if (i < MatrixSize)
                {
                    f += $"{dgMatrix[i, 0].Value} + ";
                }
                else f += $"{dgMatrix[i, 0].Value}";
            }
        }

        void Chart()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].BorderWidth = 2;
            
            F();
            double F1;
            MathExpression fun = new MathExpression(f);//берем функцию
            double A = Convert.ToDouble(tbA.Text);//роблю інтервали для чарта таінтервал
            double B = Convert.ToDouble(tbB.Text);
            double H = Convert.ToDouble(tbH.Text);
            double X;
            
            X = A;
            while (X <= B)
            {
                F1 = fun.Calculate(X);//рахую значення функції

                chart1.Series[0].Points.AddXY(X, F1);//виводимо графік функції
                chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(tbA.Text);//А - початок
                chart1.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(tbB.Text);//В - кінець
                chart1.ChartAreas[0].AxisX.Interval = Convert.ToDouble(tbH.Text);//Н - інтервал

                X += H;//збільшуємо крок 
            }
        }

        void Afunc()
        {
            Count = new List<double>();
            //Count = new double[];
            //double X = a;
            F();
            MathExpression fun = new MathExpression(f);//берем функцию
            double A = Convert.ToDouble(tbA.Text);//роблю інтервали для чарта таінтервал
            double B = Convert.ToDouble(tbB.Text);
            double H = Convert.ToDouble(tbH.Text);
            double x = A;
            double previousF = 0;//попередне значення функції
            double previousX = A;//попередне значення х

            while (x <= B)
            {
                double f = fun.Calculate(x);

                if (Math.Sign(f) == 1)
                {
                    listBox1.Items.Add("X=" + x.ToString() + ", Sign f(x) = + ");
                }
                else
                {
                    listBox1.Items.Add("X=" + x.ToString() + ", Sign f(x) = - ");
                }

                try
                {//якщо попереднє значення функції не дорівнює нулю та знак значення ф відрізняється від попереднього значення ф
                    if (previousF != 0 && Math.Sign(previousF) != Math.Sign(f))
                    {
                        Count.Add(x);
                        //count++;
                        //listBox3.Items.Add(previousX.ToString() + "; " + X.ToString());//записуемо проміжок від попереднього х до даного
                    }
                }
                catch//в іншому випадку проміжків немає
                {
                    //listBox3.Items.Add("---");
                }

                if (x != A)//якщо х не дорівнює А
                {
                    previousF = f;//попереднє ф прирівнюємо до даного
                    previousX = x;//попереднє х прирівнюємо до даного
                }

                x += H;//збільшуємо крок 
            }

        }

        void Gorner()
        {
            Afunc();
            listBox1.Items.Clear();
            A = new double[MatrixSize + 1];
            ReadMatrixFromGrid();
            double eps = 0.1; 
            double[] X;
            X = new double[MatrixSize + 1];
            double x;
            int iter = 0;
            
        //программую алгоритм Горнора по формулам
            x = Count[0];//початкове наближення
            X[0] = A[0];
            do
            {
                for (int i = 1; i < MatrixSize + 1; i++)
                {
                    X[i] = Math.Round(x * X[i - 1], 6) + A[i];
                }
                x = Math.Round(-A[MatrixSize] / X[MatrixSize - 1], 6);
                iter++;
                        
                if(iter > 100)
                {
                    listBox1.Items.Add("ERROR");
                    break;
                }

            }
            while (Math.Abs(X[MatrixSize]) >= eps);
            if (iter < 100)
            {
                listBox1.Items.Add("x =  " + x.ToString());
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix();
        }

        private void btnGornora_Click(object sender, EventArgs e)
        {
            Gorner();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrix1();
        }


        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart();
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
