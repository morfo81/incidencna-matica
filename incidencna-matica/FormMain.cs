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


        private void buttonPocetUzlov_Click(object sender, EventArgs e)
        {
            buttonPocetUzlovClick();

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonPocetUzlovClick();

        }
    }
}
