namespace petbedcrack
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpentrada = new System.Windows.Forms.DateTimePicker();
            this.dtpsalida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbttcredito = new System.Windows.Forms.RadioButton();
            this.rbttdebito = new System.Windows.Forms.RadioButton();
            this.rbttefectivo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbttvip = new System.Windows.Forms.RadioButton();
            this.rbttnormal = new System.Windows.Forms.RadioButton();
            this.rbttgrande = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de la habitación:";
            // 
            // dtpentrada
            // 
            this.dtpentrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpentrada.Location = new System.Drawing.Point(303, 78);
            this.dtpentrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpentrada.Name = "dtpentrada";
            this.dtpentrada.Size = new System.Drawing.Size(340, 27);
            this.dtpentrada.TabIndex = 1;
            this.dtpentrada.ValueChanged += new System.EventHandler(this.dtphospedaje_ValueChanged);
            // 
            // dtpsalida
            // 
            this.dtpsalida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsalida.Location = new System.Drawing.Point(244, 126);
            this.dtpsalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpsalida.Name = "dtpsalida";
            this.dtpsalida.Size = new System.Drawing.Size(337, 27);
            this.dtpsalida.TabIndex = 2;
            this.dtpsalida.MouseCaptureChanged += new System.EventHandler(this.dtpsalida_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de hospedaje: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de salida: ";
            // 
            // rbttcredito
            // 
            this.rbttcredito.AutoSize = true;
            this.rbttcredito.Location = new System.Drawing.Point(21, 76);
            this.rbttcredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbttcredito.Name = "rbttcredito";
            this.rbttcredito.Size = new System.Drawing.Size(209, 34);
            this.rbttcredito.TabIndex = 6;
            this.rbttcredito.TabStop = true;
            this.rbttcredito.Text = "Tarjeta Crédito";
            this.rbttcredito.UseVisualStyleBackColor = true;
            // 
            // rbttdebito
            // 
            this.rbttdebito.AutoSize = true;
            this.rbttdebito.Location = new System.Drawing.Point(21, 114);
            this.rbttdebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbttdebito.Name = "rbttdebito";
            this.rbttdebito.Size = new System.Drawing.Size(200, 34);
            this.rbttdebito.TabIndex = 7;
            this.rbttdebito.TabStop = true;
            this.rbttdebito.Text = "Tarjeta Débito";
            this.rbttdebito.UseVisualStyleBackColor = true;
            // 
            // rbttefectivo
            // 
            this.rbttefectivo.AutoSize = true;
            this.rbttefectivo.Location = new System.Drawing.Point(20, 38);
            this.rbttefectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbttefectivo.Name = "rbttefectivo";
            this.rbttefectivo.Size = new System.Drawing.Size(132, 34);
            this.rbttefectivo.TabIndex = 8;
            this.rbttefectivo.TabStop = true;
            this.rbttefectivo.Text = "Efectivo";
            this.rbttefectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbttvip);
            this.groupBox2.Controls.Add(this.rbttnormal);
            this.groupBox2.Controls.Add(this.rbttgrande);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 300);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(292, 146);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamaño de la cama";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbttvip
            // 
            this.rbttvip.AutoSize = true;
            this.rbttvip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbttvip.Location = new System.Drawing.Point(21, 114);
            this.rbttvip.Margin = new System.Windows.Forms.Padding(4);
            this.rbttvip.Name = "rbttvip";
            this.rbttvip.Size = new System.Drawing.Size(63, 27);
            this.rbttvip.TabIndex = 2;
            this.rbttvip.TabStop = true;
            this.rbttvip.Text = "VIP";
            this.rbttvip.UseVisualStyleBackColor = true;
            // 
            // rbttnormal
            // 
            this.rbttnormal.AutoSize = true;
            this.rbttnormal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbttnormal.Location = new System.Drawing.Point(21, 38);
            this.rbttnormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbttnormal.Name = "rbttnormal";
            this.rbttnormal.Size = new System.Drawing.Size(103, 27);
            this.rbttnormal.TabIndex = 1;
            this.rbttnormal.TabStop = true;
            this.rbttnormal.Text = "Normal";
            this.rbttnormal.UseVisualStyleBackColor = true;
            this.rbttnormal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbttgrande
            // 
            this.rbttgrande.AutoSize = true;
            this.rbttgrande.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbttgrande.Location = new System.Drawing.Point(21, 76);
            this.rbttgrande.Margin = new System.Windows.Forms.Padding(4);
            this.rbttgrande.Name = "rbttgrande";
            this.rbttgrande.Size = new System.Drawing.Size(107, 27);
            this.rbttgrande.TabIndex = 0;
            this.rbttgrande.TabStop = true;
            this.rbttgrande.Text = "Grande";
            this.rbttgrande.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbttcredito);
            this.groupBox3.Controls.Add(this.rbttefectivo);
            this.groupBox3.Controls.Add(this.rbttdebito);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(384, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(259, 146);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Método de Pago";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(264, 37);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(171, 27);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Camas Juntas";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(8, 37);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(215, 27);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Camas Separadas";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comodidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(792, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Costos (por noche):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(835, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Normal: 10$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(835, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Grande: 15$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(858, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "VIP: 20$";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpsalida);
            this.Controls.Add(this.dtpentrada);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Sistema de Reserva \"PetBed\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpentrada;
        private System.Windows.Forms.DateTimePicker dtpsalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbttcredito;
        private System.Windows.Forms.RadioButton rbttdebito;
        private System.Windows.Forms.RadioButton rbttefectivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbttvip;
        private System.Windows.Forms.RadioButton rbttnormal;
        private System.Windows.Forms.RadioButton rbttgrande;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}