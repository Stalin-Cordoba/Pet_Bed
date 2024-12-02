namespace petbedcrack
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.txtingreso = new System.Windows.Forms.Label();
            this.txtsalida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.Label();
            this.txtcel = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.Label();
            this.txtcontacto = new System.Windows.Forms.Label();
            this.txtdire = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.Label();
            this.txtcostototal = new System.Windows.Forms.Label();
            this.Reservar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.txtdias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de Reservación: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtingreso
            // 
            this.txtingreso.AutoSize = true;
            this.txtingreso.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingreso.Location = new System.Drawing.Point(457, 75);
            this.txtingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtingreso.Name = "txtingreso";
            this.txtingreso.Size = new System.Drawing.Size(218, 27);
            this.txtingreso.TabIndex = 1;
            this.txtingreso.Text = "Fecha de Ingreso: ";
            this.txtingreso.Click += new System.EventHandler(this.txtingreso_Click);
            // 
            // txtsalida
            // 
            this.txtsalida.AutoSize = true;
            this.txtsalida.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalida.Location = new System.Drawing.Point(457, 155);
            this.txtsalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(199, 27);
            this.txtsalida.TabIndex = 2;
            this.txtsalida.Text = "Fecha de Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Días Totales: ";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(18, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(109, 27);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Text = "Nombre:";
            // 
            // txtcel
            // 
            this.txtcel.AutoSize = true;
            this.txtcel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(18, 142);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(114, 27);
            this.txtcel.TabIndex = 4;
            this.txtcel.Text = "Teléfono:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.AutoSize = true;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(18, 216);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(95, 27);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.Text = "Correo:";
            // 
            // txtcontacto
            // 
            this.txtcontacto.AutoSize = true;
            this.txtcontacto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontacto.Location = new System.Drawing.Point(18, 398);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(305, 27);
            this.txtcontacto.TabIndex = 6;
            this.txtcontacto.Text = "Contacto de emergencia:";
            // 
            // txtdire
            // 
            this.txtdire.AutoSize = true;
            this.txtdire.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdire.Location = new System.Drawing.Point(18, 302);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(127, 27);
            this.txtdire.TabIndex = 7;
            this.txtdire.Text = "Dirección:";
            // 
            // txtpago
            // 
            this.txtpago.AutoSize = true;
            this.txtpago.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpago.Location = new System.Drawing.Point(457, 311);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(208, 27);
            this.txtpago.TabIndex = 8;
            this.txtpago.Text = "Método de pago:";
            // 
            // txtcostototal
            // 
            this.txtcostototal.AutoSize = true;
            this.txtcostototal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostototal.Location = new System.Drawing.Point(457, 398);
            this.txtcostototal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtcostototal.Name = "txtcostototal";
            this.txtcostototal.Size = new System.Drawing.Size(0, 30);
            this.txtcostototal.TabIndex = 9;
            this.txtcostototal.Click += new System.EventHandler(this.txtcostototal_Click);
            // 
            // Reservar
            // 
            this.Reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservar.Location = new System.Drawing.Point(618, 504);
            this.Reservar.Name = "Reservar";
            this.Reservar.Size = new System.Drawing.Size(241, 41);
            this.Reservar.TabIndex = 10;
            this.Reservar.Text = "Efectuar reserva";
            this.Reservar.UseVisualStyleBackColor = true;
            this.Reservar.Click += new System.EventHandler(this.Reservar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(23, 504);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(274, 41);
            this.Cancelar.TabIndex = 11;
            this.Cancelar.Text = "Cancelar reserva";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // txtdias
            // 
            this.txtdias.AutoSize = true;
            this.txtdias.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdias.Location = new System.Drawing.Point(457, 239);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(155, 27);
            this.txtdias.TabIndex = 12;
            this.txtdias.Text = "Días Totales: ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(889, 581);
            this.ControlBox = false;
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Reservar);
            this.Controls.Add(this.txtcostototal);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txtdire);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtcel);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.txtingreso);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Resumen de la reservación";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtingreso;
        private System.Windows.Forms.Label txtsalida;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.Label txtcel;
        private System.Windows.Forms.Label txtcorreo;
        private System.Windows.Forms.Label txtcontacto;
        private System.Windows.Forms.Label txtdire;
        private System.Windows.Forms.Label txtpago;
        private System.Windows.Forms.Label txtcostototal;
        private System.Windows.Forms.Button Reservar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label txtdias;
    }
}