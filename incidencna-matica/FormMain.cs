using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace incidencna_matica
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region events
        private void buttonPocetUzlov_Click(object sender, EventArgs e)
        {
            buttonPocetUzlovClick();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonLoadTestingDataClick();
        }

        private void buttonLoadTestingData_Click(object sender, EventArgs e)
        {
            buttonLoadTestingDataClick();

        }

        private void buttonVypocitaj_Click(object sender, EventArgs e)
        {
            Vypocet();

        }



        #endregion

        private void DesignTable(int pocet_uzlov)
        {
            dataGridViewMatica.Columns.Clear();

            //add columns
            dataGridViewMatica.Columns.Add("uzol", "Uzol");
            for (int i = 0; i < pocet_uzlov; i++)
            {
                dataGridViewMatica.Columns.Add(i.ToString(), i.ToString());
            }
            dataGridViewMatica.Columns.Add("TP", "TP");

            //add rows
            dataGridViewMatica.Rows.Add();
            for (int i = 0; i < pocet_uzlov; i++)
            {
                dataGridViewMatica.Rows.Add();
            }
            dataGridViewMatica.Rows.Add();



            foreach (DataGridViewColumn column in dataGridViewMatica.Columns)
            {
                column.Width = 30;
            }

            //foreach (DataGridViewRow row in dataGridViewMatica.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //    }
            //}


            //foreach (DataGridViewColumn row in dataGridViewMatica.Rows)
            //{
            //    if (row.Index != 0)
            //    {
            //        row.Width = 30;
            //    }
            //}
        }

        private void VyplnZakladneHodnoty(int pocet_uzlov)
        {
            dataGridViewMatica[0, 0].Value = "Uz";
            for (int i = 0; i < pocet_uzlov; i++)
            {
                dataGridViewMatica[0, i+1].Value = i.ToString();
                dataGridViewMatica[i + 1, 0].Value = i.ToString();
                dataGridViewMatica[i + 1, i + 1].Value = "X";
            }
            dataGridViewMatica[0, pocet_uzlov + 1].Value = "TM";
            dataGridViewMatica[pocet_uzlov + 1, 0].Value = "TP";
            dataGridViewMatica[pocet_uzlov + 1, pocet_uzlov + 1].Value = "X";
        }




        private void buttonPocetUzlovClick()
        {
            //if (MessageBox.Show("Pozor tabuľka bude vymazaná a prekresmená !!!", "Upozornenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            //{
            //    return;
            //}

            int pocet_uzlov = int.Parse(numericUpDownPocetUzlov.Value.ToString());
            DesignTable(pocet_uzlov);
            VyplnZakladneHodnoty(pocet_uzlov);
        }

        struct MaxIndexValue
        {
            public int index;
            public int value;
        }

        private MaxIndexValue MaxInColumn_index(int columnIndex)
        {
            int pocet_uzlov = int.Parse(numericUpDownPocetUzlov.Value.ToString());
            int cellValue = 0;
            int maxIndex = 0;
            int maxValue = 0;
            for (int i = 1; i <= pocet_uzlov; i++)
            {
                if (dataGridViewMatica[columnIndex, i].Value != null) {
                    if (int.TryParse(dataGridViewMatica[columnIndex, i].Value.ToString(), out cellValue))
                    {
                        int tmValue = int.Parse(dataGridViewMatica[i, pocet_uzlov + 1].Value.ToString());
                        


                        if (cellValue + tmValue > maxValue)
                        {
                            maxValue = cellValue + tmValue;
                            maxIndex = i;


                        }
                    }
                }
            }



            MaxIndexValue maxIndexValue = new MaxIndexValue
            {
                index = maxIndex,
                value = maxValue
            };

            return maxIndexValue;
        }

        private MaxIndexValue MaxInRow_index(int rowIndex)
        {
            int pocet_uzlov = int.Parse(numericUpDownPocetUzlov.Value.ToString());
            int cellValue = 0;
            int maxIndex = 0;
            int maxValue = 0;
            for (int i = 1; i <= pocet_uzlov; i++)
            {
                if (dataGridViewMatica[i, rowIndex].Value != null)
                {
                    if (int.TryParse(dataGridViewMatica[i, rowIndex].Value.ToString(), out cellValue))
                    {
                        int tpValue = int.Parse(dataGridViewMatica[pocet_uzlov + 1, i].Value.ToString());



                        if (cellValue - tpValue > maxValue)
                        {
                            maxValue = cellValue - tpValue;
                            maxIndex = i;


                        }
                    }
                }
            }



            MaxIndexValue maxIndexValue = new MaxIndexValue
            {
                index = maxIndex,
                value = maxValue
            };

            return maxIndexValue;
        }


        private void vypocetTM()
        {
            int pocet_uzlov = int.Parse(numericUpDownPocetUzlov.Value.ToString());

            dataGridViewMatica[1, pocet_uzlov + 1].Value = "0";

            for (int i = 2; i <= pocet_uzlov; i++)
            {

                MaxIndexValue maxIndexValue = MaxInColumn_index(i);

                dataGridViewMatica[i, pocet_uzlov + 1].Value = maxIndexValue.value;
            }



        }


        private void vypocetTP()
        {
            int pocet_uzlov = int.Parse(numericUpDownPocetUzlov.Value.ToString());

            dataGridViewMatica[pocet_uzlov + 1, pocet_uzlov].Value = dataGridViewMatica[pocet_uzlov, pocet_uzlov + 1].Value;
            dataGridViewMatica[pocet_uzlov + 1, pocet_uzlov - 1].Value = dataGridViewMatica[pocet_uzlov, pocet_uzlov + 1].Value;

            for (int i = pocet_uzlov-1 ; i >= 1; i--)
            {
                MaxIndexValue maxIndexValue = MaxInRow_index(i);

                dataGridViewMatica[pocet_uzlov + 1, i].Value = maxIndexValue.value;
                //dataGridViewMatica[pocet_uzlov + 1, i].Value = i.ToString();
            }
        }

        private void NaplnTestovacieData()
        {
            dataGridViewMatica[2, 1].Value = "8";
            dataGridViewMatica[3, 1].Value = "15";

            dataGridViewMatica[3, 2].Value = "0";
            dataGridViewMatica[4, 3].Value = "4";

            dataGridViewMatica[5, 4].Value = "4";
            dataGridViewMatica[6, 4].Value = "8";

            dataGridViewMatica[6, 5].Value = "0";
            dataGridViewMatica[7, 6].Value = "8";
            dataGridViewMatica[8, 6].Value = "20";
            dataGridViewMatica[9, 6].Value = "24";
            //dataGridViewMatica[9, 7].Value = "23";//--------------
            dataGridViewMatica[8, 7].Value = "0";
            dataGridViewMatica[9, 8].Value = "0";
            dataGridViewMatica[10, 9].Value = "4";
            dataGridViewMatica[11, 10].Value = "12";
            dataGridViewMatica[12, 11].Value = "4";
        }

        private void Vypocet()
        {
            vypocetTM();
            vypocetTP();
        }

        private void buttonLoadTestingDataClick()
        {
            //----------------------------
            numericUpDownPocetUzlov.Value = 12;
            buttonPocetUzlovClick();

            NaplnTestovacieData();

            Vypocet();
        }

        private void dataGridViewMatica_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            //Vypocet();
        }
    }
}
