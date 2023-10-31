namespace SIM_4K4_2023_G2_TP4
{
    partial class frmPrincipal
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
            this.txt_iteracciones = new System.Windows.Forms.MaskedTextBox();
            this.txt_desde_hora = new System.Windows.Forms.MaskedTextBox();
            this.label_iteracciones = new System.Windows.Forms.Label();
            this.label_desde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_retiro = new System.Windows.Forms.MaskedTextBox();
            this.txt_entrega = new System.Windows.Forms.MaskedTextBox();
            this.txt_compra = new System.Windows.Forms.MaskedTextBox();
            this.label_retiro = new System.Windows.Forms.Label();
            this.label_entrega = new System.Windows.Forms.Label();
            this.label_compra = new System.Windows.Forms.Label();
            this.label_probabilidad_eventos = new System.Windows.Forms.Label();
            this.label_subtitulo = new System.Windows.Forms.Label();
            this.lblLlegadas = new System.Windows.Forms.Label();
            this.label_tiempo_simular = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.txt_tiempo_simular = new System.Windows.Forms.MaskedTextBox();
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llegHasta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.llegDesde = new System.Windows.Forms.MaskedTextBox();
            this.atencHasta = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.atencDesde = new System.Windows.Forms.MaskedTextBox();
            this.finRepHasta = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finRepDesde = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fin_retiro_entrega = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.finOrdenamiento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_iteracciones
            // 
            this.txt_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iteracciones.Location = new System.Drawing.Point(163, 127);
            this.txt_iteracciones.Name = "txt_iteracciones";
            this.txt_iteracciones.Size = new System.Drawing.Size(72, 26);
            this.txt_iteracciones.TabIndex = 45;
            this.txt_iteracciones.Text = "100";
            // 
            // txt_desde_hora
            // 
            this.txt_desde_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desde_hora.Location = new System.Drawing.Point(163, 103);
            this.txt_desde_hora.Name = "txt_desde_hora";
            this.txt_desde_hora.Size = new System.Drawing.Size(47, 26);
            this.txt_desde_hora.TabIndex = 44;
            this.txt_desde_hora.Text = "10";
            // 
            // label_iteracciones
            // 
            this.label_iteracciones.AutoSize = true;
            this.label_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteracciones.Location = new System.Drawing.Point(54, 130);
            this.label_iteracciones.Name = "label_iteracciones";
            this.label_iteracciones.Size = new System.Drawing.Size(92, 20);
            this.label_iteracciones.TabIndex = 43;
            this.label_iteracciones.Text = "Iteraciones:";
            // 
            // label_desde
            // 
            this.label_desde.AutoSize = true;
            this.label_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desde.Location = new System.Drawing.Point(54, 106);
            this.label_desde.Name = "label_desde";
            this.label_desde.Size = new System.Drawing.Size(103, 20);
            this.label_desde.TabIndex = 42;
            this.label_desde.Text = "Desde (min.):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vista";
            // 
            // txt_retiro
            // 
            this.txt_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retiro.Location = new System.Drawing.Point(1128, 112);
            this.txt_retiro.Name = "txt_retiro";
            this.txt_retiro.Size = new System.Drawing.Size(33, 26);
            this.txt_retiro.TabIndex = 32;
            this.txt_retiro.Text = "30";
            // 
            // txt_entrega
            // 
            this.txt_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrega.Location = new System.Drawing.Point(1128, 89);
            this.txt_entrega.Name = "txt_entrega";
            this.txt_entrega.Size = new System.Drawing.Size(33, 26);
            this.txt_entrega.TabIndex = 31;
            this.txt_entrega.Text = "25";
            // 
            // txt_compra
            // 
            this.txt_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compra.Location = new System.Drawing.Point(1128, 65);
            this.txt_compra.Name = "txt_compra";
            this.txt_compra.Size = new System.Drawing.Size(33, 26);
            this.txt_compra.TabIndex = 29;
            this.txt_compra.Text = "45";
            // 
            // label_retiro
            // 
            this.label_retiro.AutoSize = true;
            this.label_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retiro.Location = new System.Drawing.Point(1070, 118);
            this.label_retiro.Name = "label_retiro";
            this.label_retiro.Size = new System.Drawing.Size(52, 20);
            this.label_retiro.TabIndex = 40;
            this.label_retiro.Text = "Retiro";
            // 
            // label_entrega
            // 
            this.label_entrega.AutoSize = true;
            this.label_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entrega.Location = new System.Drawing.Point(1056, 92);
            this.label_entrega.Name = "label_entrega";
            this.label_entrega.Size = new System.Drawing.Size(66, 20);
            this.label_entrega.TabIndex = 39;
            this.label_entrega.Text = "Entrega";
            // 
            // label_compra
            // 
            this.label_compra.AutoSize = true;
            this.label_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_compra.Location = new System.Drawing.Point(1057, 68);
            this.label_compra.Name = "label_compra";
            this.label_compra.Size = new System.Drawing.Size(65, 20);
            this.label_compra.TabIndex = 38;
            this.label_compra.Text = "Compra";
            // 
            // label_probabilidad_eventos
            // 
            this.label_probabilidad_eventos.AutoSize = true;
            this.label_probabilidad_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_probabilidad_eventos.Location = new System.Drawing.Point(1011, 38);
            this.label_probabilidad_eventos.Name = "label_probabilidad_eventos";
            this.label_probabilidad_eventos.Size = new System.Drawing.Size(206, 20);
            this.label_probabilidad_eventos.TabIndex = 37;
            this.label_probabilidad_eventos.Text = "Probabilidad de eventos (%)";
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(335, 9);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(187, 24);
            this.label_subtitulo.TabIndex = 36;
            this.label_subtitulo.Text = "Grupo 2 - Relojeria";
            // 
            // lblLlegadas
            // 
            this.lblLlegadas.AutoSize = true;
            this.lblLlegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegadas.Location = new System.Drawing.Point(414, 38);
            this.lblLlegadas.Name = "lblLlegadas";
            this.lblLlegadas.Size = new System.Drawing.Size(197, 20);
            this.lblLlegadas.TabIndex = 28;
            this.lblLlegadas.Text = "Llegada de personas (min)";
            // 
            // label_tiempo_simular
            // 
            this.label_tiempo_simular.AutoSize = true;
            this.label_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempo_simular.Location = new System.Drawing.Point(54, 52);
            this.label_tiempo_simular.Name = "label_tiempo_simular";
            this.label_tiempo_simular.Size = new System.Drawing.Size(175, 20);
            this.label_tiempo_simular.TabIndex = 26;
            this.label_tiempo_simular.Text = "Tiempo a simular (min.):";
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simular.Location = new System.Drawing.Point(1263, 38);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(109, 107);
            this.btn_simular.TabIndex = 33;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            // 
            // txt_tiempo_simular
            // 
            this.txt_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo_simular.Location = new System.Drawing.Point(235, 49);
            this.txt_tiempo_simular.Name = "txt_tiempo_simular";
            this.txt_tiempo_simular.Size = new System.Drawing.Size(92, 26);
            this.txt_tiempo_simular.TabIndex = 24;
            this.txt_tiempo_simular.Text = "1000";
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            this.dgv_simulacion.AllowUserToResizeColumns = false;
            this.dgv_simulacion.AllowUserToResizeRows = false;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulacion.Location = new System.Drawing.Point(12, 165);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.Size = new System.Drawing.Size(1360, 484);
            this.dgv_simulacion.TabIndex = 34;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(29, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(261, 25);
            this.label_titulo.TabIndex = 46;
            this.label_titulo.Text = "TP 4 - Simulación colas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fin de atención compra (min)";
            // 
            // llegHasta
            // 
            this.llegHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegHasta.Location = new System.Drawing.Point(678, 35);
            this.llegHasta.Name = "llegHasta";
            this.llegHasta.Size = new System.Drawing.Size(33, 26);
            this.llegHasta.TabIndex = 51;
            this.llegHasta.Text = "17";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "a";
            // 
            // llegDesde
            // 
            this.llegDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegDesde.Location = new System.Drawing.Point(619, 35);
            this.llegDesde.Name = "llegDesde";
            this.llegDesde.Size = new System.Drawing.Size(29, 26);
            this.llegDesde.TabIndex = 50;
            this.llegDesde.Text = "13";
            // 
            // atencHasta
            // 
            this.atencHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atencHasta.Location = new System.Drawing.Point(678, 100);
            this.atencHasta.Name = "atencHasta";
            this.atencHasta.Size = new System.Drawing.Size(33, 26);
            this.atencHasta.TabIndex = 54;
            this.atencHasta.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "a";
            // 
            // atencDesde
            // 
            this.atencDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atencDesde.Location = new System.Drawing.Point(619, 100);
            this.atencDesde.Name = "atencDesde";
            this.atencDesde.Size = new System.Drawing.Size(29, 26);
            this.atencDesde.TabIndex = 53;
            this.atencDesde.Text = "6";
            // 
            // finRepHasta
            // 
            this.finRepHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finRepHasta.Location = new System.Drawing.Point(678, 133);
            this.finRepHasta.Name = "finRepHasta";
            this.finRepHasta.Size = new System.Drawing.Size(33, 26);
            this.finRepHasta.TabIndex = 58;
            this.finRepHasta.Text = "22";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "a";
            // 
            // finRepDesde
            // 
            this.finRepDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finRepDesde.Location = new System.Drawing.Point(617, 132);
            this.finRepDesde.Name = "finRepDesde";
            this.finRepDesde.Size = new System.Drawing.Size(29, 26);
            this.finRepDesde.TabIndex = 57;
            this.finRepDesde.Text = "18";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fin de reparación (min)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fin de atención retiro/entrega (min)";
            // 
            // fin_retiro_entrega
            // 
            this.fin_retiro_entrega.Enabled = false;
            this.fin_retiro_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fin_retiro_entrega.Location = new System.Drawing.Point(619, 68);
            this.fin_retiro_entrega.Name = "fin_retiro_entrega";
            this.fin_retiro_entrega.Size = new System.Drawing.Size(29, 26);
            this.fin_retiro_entrega.TabIndex = 61;
            this.fin_retiro_entrega.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(654, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "cte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(738, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fin de ordenamiento (min)";
            // 
            // finOrdenamiento
            // 
            this.finOrdenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finOrdenamiento.Location = new System.Drawing.Point(938, 35);
            this.finOrdenamiento.Name = "finOrdenamiento";
            this.finOrdenamiento.Size = new System.Drawing.Size(29, 26);
            this.finOrdenamiento.TabIndex = 64;
            this.finOrdenamiento.Text = "5";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.finOrdenamiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fin_retiro_entrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.finRepHasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finRepDesde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.atencHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.atencDesde);
            this.Controls.Add(this.llegHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llegDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.txt_iteracciones);
            this.Controls.Add(this.txt_desde_hora);
            this.Controls.Add(this.label_iteracciones);
            this.Controls.Add(this.label_desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_retiro);
            this.Controls.Add(this.txt_entrega);
            this.Controls.Add(this.txt_compra);
            this.Controls.Add(this.label_retiro);
            this.Controls.Add(this.label_entrega);
            this.Controls.Add(this.label_compra);
            this.Controls.Add(this.label_probabilidad_eventos);
            this.Controls.Add(this.label_subtitulo);
            this.Controls.Add(this.lblLlegadas);
            this.Controls.Add(this.label_tiempo_simular);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txt_tiempo_simular);
            this.Controls.Add(this.dgv_simulacion);
            this.Name = "frmPrincipal";
            this.Text = "TP4 - Relojeria";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_iteracciones;
        private System.Windows.Forms.MaskedTextBox txt_desde_hora;
        private System.Windows.Forms.Label label_iteracciones;
        private System.Windows.Forms.Label label_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_retiro;
        private System.Windows.Forms.MaskedTextBox txt_entrega;
        private System.Windows.Forms.MaskedTextBox txt_compra;
        private System.Windows.Forms.Label label_retiro;
        private System.Windows.Forms.Label label_entrega;
        private System.Windows.Forms.Label label_compra;
        private System.Windows.Forms.Label label_probabilidad_eventos;
        private System.Windows.Forms.Label label_subtitulo;
        private System.Windows.Forms.Label lblLlegadas;
        private System.Windows.Forms.Label label_tiempo_simular;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.MaskedTextBox txt_tiempo_simular;
        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox llegHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox llegDesde;
        private System.Windows.Forms.MaskedTextBox atencHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox atencDesde;
        private System.Windows.Forms.MaskedTextBox finRepHasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox finRepDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox fin_retiro_entrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox finOrdenamiento;
    }
}

