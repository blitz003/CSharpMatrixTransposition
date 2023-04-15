using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transposing_A_Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {   // Developed by Marcus D. Block.
            InitializeComponent();
        }



        const int row = 6;
        const int col = 6;
        int[,] THEMATRIX = new int[row, col]    { {3 , 25, 62, 13, 9 , 8 },
                                                  {99, 75, 2 , 25, 32, 21},
                                                  {88, 92, 5 , 18, 17, 33},
                                                  {77, 91, 60, 55, 47, 36},
                                                  {31, 26, 73, 38, 35, 99},
                                                  {5 , 97, 83, 76, 58, 22}  };



        int temp;
        int i, j;


        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayMatrix();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Populating oiginal Matrix...");
                    TransposeMatrix();
                    DisplayMatrix();
                    MessageBox.Show("Transposing Matrix.");
                    AlternateTranspositionAlgorithm();
                    DisplayTransposedMatrix();
                }
                else
                { 
                //TransposeMatrix();
                AlternateTranspositionAlgorithm();
                DisplayTransposedMatrix();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DisplayMatrix()
        {
            try
            {
               for ( int row = 0; row < 6; row++)
                {
                    for ( int col = 0; col < 6; col++)
                    {
                        listView1.Items.Add(THEMATRIX[row, col].ToString());
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TransposeMatrix()
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {

                   for (int j = i + 1; j < 6; j++)
                   {
                       
                        temp = THEMATRIX[i, j];
                        THEMATRIX[i, j] = THEMATRIX[j, i];
                        THEMATRIX[j, i] = temp;
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AlternateTranspositionAlgorithm()
        {
            try
            {
                for (int i = 0; i < 6; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        if (THEMATRIX[i, j] == THEMATRIX[j, i])
                        {
                            break;
                        }
                        else
                        {
                            temp = THEMATRIX[i, j];
                            THEMATRIX[i, j] = THEMATRIX[j, i];
                            THEMATRIX[j, i] = temp;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void DisplayTransposedMatrix()
        {
            try
            {
                for  (i = 0; i < 6; i++)
                {
                    for (j = 0; j < 6; j++)
                    {
                        listView2.Items.Add(THEMATRIX[i, j].ToString());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearListViews();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClearListViews()
        {
            try
            {
                listView1.Clear();
                listView2.Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TerminateApplication();
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void TerminateApplication()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
