namespace Biblioteca
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usarElSistemaComoAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ocurrioAlgunaFallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarUnCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Biblioteca.Properties.Resources.Exit1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(357, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 107);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Biblioteca.Properties.Resources.arbol;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel1.Text = "TreeSoft";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usarElSistemaComoAdministradorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Biblioteca.Properties.Resources.Modify1;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton1.Text = "Archivo";
            // 
            // usarElSistemaComoAdministradorToolStripMenuItem
            // 
            this.usarElSistemaComoAdministradorToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.Profile;
            this.usarElSistemaComoAdministradorToolStripMenuItem.Name = "usarElSistemaComoAdministradorToolStripMenuItem";
            this.usarElSistemaComoAdministradorToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.usarElSistemaComoAdministradorToolStripMenuItem.Text = "Usar el sistema como administrador";
            this.usarElSistemaComoAdministradorToolStripMenuItem.Click += new System.EventHandler(this.usarElSistemaComoAdministradorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.Exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocurrioAlgunaFallaToolStripMenuItem,
            this.contactenosToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::Biblioteca.Properties.Resources.Users;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton2.Text = "Soporte";
            // 
            // ocurrioAlgunaFallaToolStripMenuItem
            // 
            this.ocurrioAlgunaFallaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarUnCorreoToolStripMenuItem});
            this.ocurrioAlgunaFallaToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.Get_Info_Blue_Button;
            this.ocurrioAlgunaFallaToolStripMenuItem.Name = "ocurrioAlgunaFallaToolStripMenuItem";
            this.ocurrioAlgunaFallaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ocurrioAlgunaFallaToolStripMenuItem.Text = "Ocurrio alguna falla?";
            // 
            // enviarUnCorreoToolStripMenuItem
            // 
            this.enviarUnCorreoToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.Web_Browser;
            this.enviarUnCorreoToolStripMenuItem.Name = "enviarUnCorreoToolStripMenuItem";
            this.enviarUnCorreoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.enviarUnCorreoToolStripMenuItem.Text = "Enviar un correo";
            this.enviarUnCorreoToolStripMenuItem.Click += new System.EventHandler(this.enviarUnCorreoToolStripMenuItem_Click);
            // 
            // contactenosToolStripMenuItem
            // 
            this.contactenosToolStripMenuItem.Image = global::Biblioteca.Properties.Resources.Discussion;
            this.contactenosToolStripMenuItem.Name = "contactenosToolStripMenuItem";
            this.contactenosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.contactenosToolStripMenuItem.Text = "Contactenos";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Biblioteca.Properties.Resources.Modify2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(357, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Biblioteca.Properties.Resources.Add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(92, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Biblioteca.Properties.Resources.Pie_Chart;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(92, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Todos los libros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(702, 405);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem usarElSistemaComoAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ocurrioAlgunaFallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarUnCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactenosToolStripMenuItem;

    }
}

