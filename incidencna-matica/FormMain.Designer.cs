
namespace incidencna_matica
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMatica = new System.Windows.Forms.DataGridView();
            this.buttonPocetUzlov = new System.Windows.Forms.Button();
            this.labelPocetUzlov = new System.Windows.Forms.Label();
            this.numericUpDownPocetUzlov = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocetUzlov)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatica
            // 
            this.dataGridViewMatica.AllowUserToAddRows = false;
            this.dataGridViewMatica.AllowUserToDeleteRows = false;
            this.dataGridViewMatica.AllowUserToResizeColumns = false;
            this.dataGridViewMatica.AllowUserToResizeRows = false;
            this.dataGridViewMatica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMatica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMatica.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewMatica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatica.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMatica.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatica.Location = new System.Drawing.Point(21, 41);
            this.dataGridViewMatica.Name = "dataGridViewMatica";
            this.dataGridViewMatica.RowHeadersVisible = false;
            this.dataGridViewMatica.Size = new System.Drawing.Size(951, 508);
            this.dataGridViewMatica.TabIndex = 0;
            // 
            // buttonPocetUzlov
            // 
            this.buttonPocetUzlov.Location = new System.Drawing.Point(216, 12);
            this.buttonPocetUzlov.Name = "buttonPocetUzlov";
            this.buttonPocetUzlov.Size = new System.Drawing.Size(75, 23);
            this.buttonPocetUzlov.TabIndex = 1;
            this.buttonPocetUzlov.Text = "Aplikuj";
            this.buttonPocetUzlov.UseVisualStyleBackColor = true;
            this.buttonPocetUzlov.Click += new System.EventHandler(this.buttonPocetUzlov_Click);
            // 
            // labelPocetUzlov
            // 
            this.labelPocetUzlov.AutoSize = true;
            this.labelPocetUzlov.Location = new System.Drawing.Point(18, 17);
            this.labelPocetUzlov.Name = "labelPocetUzlov";
            this.labelPocetUzlov.Size = new System.Drawing.Size(66, 13);
            this.labelPocetUzlov.TabIndex = 2;
            this.labelPocetUzlov.Text = "Počet uzlov:";
            // 
            // numericUpDownPocetUzlov
            // 
            this.numericUpDownPocetUzlov.Location = new System.Drawing.Point(90, 15);
            this.numericUpDownPocetUzlov.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPocetUzlov.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownPocetUzlov.Name = "numericUpDownPocetUzlov";
            this.numericUpDownPocetUzlov.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPocetUzlov.TabIndex = 3;
            this.numericUpDownPocetUzlov.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.numericUpDownPocetUzlov);
            this.Controls.Add(this.labelPocetUzlov);
            this.Controls.Add(this.buttonPocetUzlov);
            this.Controls.Add(this.dataGridViewMatica);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPocetUzlov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatica;
        private System.Windows.Forms.Button buttonPocetUzlov;
        private System.Windows.Forms.Label labelPocetUzlov;
        private System.Windows.Forms.NumericUpDown numericUpDownPocetUzlov;
    }
}

