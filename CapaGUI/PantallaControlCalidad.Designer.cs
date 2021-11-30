
namespace CapaGUI
{
    partial class PantallaControlCalidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCaptura = new System.Windows.Forms.TextBox();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtPesoCaptura = new System.Windows.Forms.TextBox();
            this.dteFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoMinimo = new System.Windows.Forms.TextBox();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.btoMostrarPeso = new System.Windows.Forms.Button();
            this.btoGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Captura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Captura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SKU:";
            // 
            // txtNumeroCaptura
            // 
            this.txtNumeroCaptura.Location = new System.Drawing.Point(132, 43);
            this.txtNumeroCaptura.Name = "txtNumeroCaptura";
            this.txtNumeroCaptura.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroCaptura.TabIndex = 4;
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(132, 114);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(130, 20);
            this.txtSku.TabIndex = 5;
            // 
            // txtPesoCaptura
            // 
            this.txtPesoCaptura.Location = new System.Drawing.Point(132, 146);
            this.txtPesoCaptura.Name = "txtPesoCaptura";
            this.txtPesoCaptura.Size = new System.Drawing.Size(130, 20);
            this.txtPesoCaptura.TabIndex = 6;
            // 
            // dteFecha
            // 
            this.dteFecha.Location = new System.Drawing.Point(132, 76);
            this.dteFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dteFecha.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Size = new System.Drawing.Size(200, 20);
            this.dteFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso Mínimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Peso Máximo";
            // 
            // txtPesoMinimo
            // 
            this.txtPesoMinimo.Enabled = false;
            this.txtPesoMinimo.Location = new System.Drawing.Point(400, 76);
            this.txtPesoMinimo.Name = "txtPesoMinimo";
            this.txtPesoMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMinimo.TabIndex = 10;
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Enabled = false;
            this.txtPesoMaximo.Location = new System.Drawing.Point(400, 146);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtPesoMaximo.TabIndex = 11;
            // 
            // btoMostrarPeso
            // 
            this.btoMostrarPeso.Location = new System.Drawing.Point(147, 197);
            this.btoMostrarPeso.Name = "btoMostrarPeso";
            this.btoMostrarPeso.Size = new System.Drawing.Size(97, 47);
            this.btoMostrarPeso.TabIndex = 12;
            this.btoMostrarPeso.Text = "Mostrar Peso Producto";
            this.btoMostrarPeso.UseVisualStyleBackColor = true;
            this.btoMostrarPeso.Click += new System.EventHandler(this.btoMostrarPeso_Click);
            // 
            // btoGuardar
            // 
            this.btoGuardar.Location = new System.Drawing.Point(318, 197);
            this.btoGuardar.Name = "btoGuardar";
            this.btoGuardar.Size = new System.Drawing.Size(97, 47);
            this.btoGuardar.TabIndex = 13;
            this.btoGuardar.Text = "Guardar";
            this.btoGuardar.UseVisualStyleBackColor = true;
            this.btoGuardar.Click += new System.EventHandler(this.btoGuardar_Click);
            // 
            // PantallaControlCalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 275);
            this.Controls.Add(this.btoGuardar);
            this.Controls.Add(this.btoMostrarPeso);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.txtPesoMinimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dteFecha);
            this.Controls.Add(this.txtPesoCaptura);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.txtNumeroCaptura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaControlCalidad";
            this.Text = "Pantalla Control Calidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroCaptura;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtPesoCaptura;
        private System.Windows.Forms.DateTimePicker dteFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesoMinimo;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Button btoMostrarPeso;
        private System.Windows.Forms.Button btoGuardar;
    }
}