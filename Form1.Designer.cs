
namespace ProyectoProgra2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.VOCALES = new System.Windows.Forms.Label();
            this.txtVocales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsonantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.btnCaracteres = new System.Windows.Forms.Button();
            this.btnVocales = new System.Windows.Forms.Button();
            this.btnConsonantes = new System.Windows.Forms.Button();
            this.btnPalabras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra: ";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(130, 27);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(263, 20);
            this.txtPalabra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL DE CARACTERES";
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Location = new System.Drawing.Point(181, 103);
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(100, 20);
            this.txtCaracteres.TabIndex = 3;
            // 
            // VOCALES
            // 
            this.VOCALES.AutoSize = true;
            this.VOCALES.Location = new System.Drawing.Point(40, 148);
            this.VOCALES.Name = "VOCALES";
            this.VOCALES.Size = new System.Drawing.Size(62, 13);
            this.VOCALES.TabIndex = 4;
            this.VOCALES.Text = "VOCALES: ";
            // 
            // txtVocales
            // 
            this.txtVocales.Location = new System.Drawing.Point(181, 145);
            this.txtVocales.Name = "txtVocales";
            this.txtVocales.Size = new System.Drawing.Size(100, 20);
            this.txtVocales.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONSONANTES: ";
            // 
            // txtConsonantes
            // 
            this.txtConsonantes.Location = new System.Drawing.Point(181, 184);
            this.txtConsonantes.Name = "txtConsonantes";
            this.txtConsonantes.Size = new System.Drawing.Size(100, 20);
            this.txtConsonantes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PALABRAS";
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(181, 226);
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(100, 20);
            this.txtPalabras.TabIndex = 9;
            // 
            // btnCaracteres
            // 
            this.btnCaracteres.Location = new System.Drawing.Point(326, 99);
            this.btnCaracteres.Name = "btnCaracteres";
            this.btnCaracteres.Size = new System.Drawing.Size(75, 23);
            this.btnCaracteres.TabIndex = 10;
            this.btnCaracteres.Tag = "btnCaracteres";
            this.btnCaracteres.Text = "<-";
            this.btnCaracteres.UseVisualStyleBackColor = true;
            this.btnCaracteres.Click += new System.EventHandler(this.btnCaracteres_Click);
            // 
            // btnVocales
            // 
            this.btnVocales.Location = new System.Drawing.Point(326, 138);
            this.btnVocales.Name = "btnVocales";
            this.btnVocales.Size = new System.Drawing.Size(75, 23);
            this.btnVocales.TabIndex = 11;
            this.btnVocales.Text = "<-";
            this.btnVocales.UseVisualStyleBackColor = true;
            this.btnVocales.Click += new System.EventHandler(this.btnVocales_Click);
            // 
            // btnConsonantes
            // 
            this.btnConsonantes.Location = new System.Drawing.Point(326, 186);
            this.btnConsonantes.Name = "btnConsonantes";
            this.btnConsonantes.Size = new System.Drawing.Size(75, 23);
            this.btnConsonantes.TabIndex = 12;
            this.btnConsonantes.Text = "<-";
            this.btnConsonantes.UseVisualStyleBackColor = true;
            this.btnConsonantes.Click += new System.EventHandler(this.btnConsonantes_Click);
            // 
            // btnPalabras
            // 
            this.btnPalabras.Location = new System.Drawing.Point(326, 233);
            this.btnPalabras.Name = "btnPalabras";
            this.btnPalabras.Size = new System.Drawing.Size(75, 23);
            this.btnPalabras.TabIndex = 13;
            this.btnPalabras.Text = "<-";
            this.btnPalabras.UseVisualStyleBackColor = true;
            this.btnPalabras.Click += new System.EventHandler(this.btnPalabras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 347);
            this.Controls.Add(this.btnPalabras);
            this.Controls.Add(this.btnConsonantes);
            this.Controls.Add(this.btnVocales);
            this.Controls.Add(this.btnCaracteres);
            this.Controls.Add(this.txtPalabras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConsonantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVocales);
            this.Controls.Add(this.VOCALES);
            this.Controls.Add(this.txtCaracteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.Label VOCALES;
        private System.Windows.Forms.TextBox txtVocales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsonantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Button btnCaracteres;
        private System.Windows.Forms.Button btnVocales;
        private System.Windows.Forms.Button btnConsonantes;
        private System.Windows.Forms.Button btnPalabras;
    }
}

