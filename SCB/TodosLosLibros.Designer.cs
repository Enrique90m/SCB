namespace Biblioteca
{
    partial class TodosLosLibros
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.libro_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.autor_RADIOBUTTON = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(859, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_RADIOBUTTON
            // 
            this.id_RADIOBUTTON.AutoSize = true;
            this.id_RADIOBUTTON.Checked = true;
            this.id_RADIOBUTTON.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_RADIOBUTTON.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_RADIOBUTTON.Location = new System.Drawing.Point(26, 36);
            this.id_RADIOBUTTON.Name = "id_RADIOBUTTON";
            this.id_RADIOBUTTON.Size = new System.Drawing.Size(41, 23);
            this.id_RADIOBUTTON.TabIndex = 1;
            this.id_RADIOBUTTON.TabStop = true;
            this.id_RADIOBUTTON.Text = "ID";
            this.id_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // libro_RADIOBUTTON
            // 
            this.libro_RADIOBUTTON.AutoSize = true;
            this.libro_RADIOBUTTON.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_RADIOBUTTON.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.libro_RADIOBUTTON.Location = new System.Drawing.Point(73, 35);
            this.libro_RADIOBUTTON.Name = "libro_RADIOBUTTON";
            this.libro_RADIOBUTTON.Size = new System.Drawing.Size(83, 23);
            this.libro_RADIOBUTTON.TabIndex = 2;
            this.libro_RADIOBUTTON.TabStop = true;
            this.libro_RADIOBUTTON.Text = "Nombre";
            this.libro_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // autor_RADIOBUTTON
            // 
            this.autor_RADIOBUTTON.AutoSize = true;
            this.autor_RADIOBUTTON.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor_RADIOBUTTON.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.autor_RADIOBUTTON.Location = new System.Drawing.Point(162, 36);
            this.autor_RADIOBUTTON.Name = "autor_RADIOBUTTON";
            this.autor_RADIOBUTTON.Size = new System.Drawing.Size(67, 23);
            this.autor_RADIOBUTTON.TabIndex = 3;
            this.autor_RADIOBUTTON.TabStop = true;
            this.autor_RADIOBUTTON.Text = "Autor";
            this.autor_RADIOBUTTON.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por: ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Biblioteca.Properties.Resources.Line_Chart;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(671, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ver todos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Biblioteca.Properties.Resources.Back;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(548, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Biblioteca.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(417, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gggToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // gggToolStripMenuItem
            // 
            this.gggToolStripMenuItem.Name = "gggToolStripMenuItem";
            this.gggToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gggToolStripMenuItem.Text = "Ver descripcion";
            this.gggToolStripMenuItem.Click += new System.EventHandler(this.gggToolStripMenuItem_Click_1);
            // 
            // TodosLosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 410);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.autor_RADIOBUTTON);
            this.Controls.Add(this.libro_RADIOBUTTON);
            this.Controls.Add(this.id_RADIOBUTTON);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TodosLosLibros";
            this.Text = "Sistema de control bibliotecario ";
            this.Load += new System.EventHandler(this.agregarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      //  private BDlibrosDataSet bDlibrosDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton id_RADIOBUTTON;
        private System.Windows.Forms.RadioButton libro_RADIOBUTTON;
        private System.Windows.Forms.RadioButton autor_RADIOBUTTON;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        // private BDlibrosDataSet1 bDlibrosDataSet1;
       // private BDlibrosDataSet1TableAdapters.LIBROSTableAdapter lIBROSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLIBRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOAUTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTANTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHAROLADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
       // private BDlibrosDataSet bDlibrosDataSet2;
        //private BDlibrosDataSetTableAdapters.LIBROSTableAdapter lIBROSTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gggToolStripMenuItem;
    }
}