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
            components = new System.ComponentModel.Container();
            txt_iteracciones = new MaskedTextBox();
            txt_desde_hora = new MaskedTextBox();
            label_iteracciones = new Label();
            label_desde = new Label();
            label1 = new Label();
            txt_retiro = new MaskedTextBox();
            txt_entrega = new MaskedTextBox();
            txt_compra = new MaskedTextBox();
            label_retiro = new Label();
            label_entrega = new Label();
            label_compra = new Label();
            label_probabilidad_eventos = new Label();
            label_subtitulo = new Label();
            lblLlegadas = new Label();
            label_tiempo_simular = new Label();
            btn_simular = new Button();
            txt_tiempo_simular = new MaskedTextBox();
            dgv_simulacion = new DataGridView();
            label_titulo = new Label();
            label2 = new Label();
            llegHasta = new MaskedTextBox();
            label4 = new Label();
            llegDesde = new MaskedTextBox();
            atencHasta = new MaskedTextBox();
            label3 = new Label();
            atencDesde = new MaskedTextBox();
            finRepHasta = new MaskedTextBox();
            label5 = new Label();
            finRepDesde = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            fin_retiro_entrega = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            finOrdenamiento = new MaskedTextBox();
            errorProviderApp = new ErrorProvider(components);
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgv_simulacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // txt_iteracciones
            // 
            txt_iteracciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_iteracciones.Location = new Point(189, 148);
            txt_iteracciones.Margin = new Padding(4, 3, 4, 3);
            txt_iteracciones.Name = "txt_iteracciones";
            txt_iteracciones.Size = new Size(83, 26);
            txt_iteracciones.TabIndex = 45;
            txt_iteracciones.Text = "20";
            txt_iteracciones.Validating += txt_number_Validating;
            // 
            // txt_desde_hora
            // 
            txt_desde_hora.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_desde_hora.Location = new Point(189, 120);
            txt_desde_hora.Margin = new Padding(4, 3, 4, 3);
            txt_desde_hora.Name = "txt_desde_hora";
            txt_desde_hora.Size = new Size(54, 26);
            txt_desde_hora.TabIndex = 44;
            txt_desde_hora.Text = "0";
            txt_desde_hora.Validating += txt_number_Validating;
            // 
            // label_iteracciones
            // 
            label_iteracciones.AutoSize = true;
            label_iteracciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_iteracciones.Location = new Point(62, 151);
            label_iteracciones.Margin = new Padding(4, 0, 4, 0);
            label_iteracciones.Name = "label_iteracciones";
            label_iteracciones.Size = new Size(92, 20);
            label_iteracciones.TabIndex = 43;
            label_iteracciones.Text = "Iteraciones:";
            // 
            // label_desde
            // 
            label_desde.AutoSize = true;
            label_desde.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_desde.Location = new Point(62, 123);
            label_desde.Margin = new Padding(4, 0, 4, 0);
            label_desde.Name = "label_desde";
            label_desde.Size = new Size(60, 20);
            label_desde.TabIndex = 42;
            label_desde.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 41;
            label1.Text = "Vista";
            // 
            // txt_retiro
            // 
            txt_retiro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_retiro.Location = new Point(1316, 129);
            txt_retiro.Margin = new Padding(4, 3, 4, 3);
            txt_retiro.Name = "txt_retiro";
            txt_retiro.Size = new Size(38, 26);
            txt_retiro.TabIndex = 32;
            txt_retiro.Text = "30";
            txt_retiro.Validating += txt_number_Validating;
            // 
            // txt_entrega
            // 
            txt_entrega.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_entrega.Location = new Point(1316, 103);
            txt_entrega.Margin = new Padding(4, 3, 4, 3);
            txt_entrega.Name = "txt_entrega";
            txt_entrega.Size = new Size(38, 26);
            txt_entrega.TabIndex = 31;
            txt_entrega.Text = "25";
            txt_entrega.Validating += txt_number_Validating;
            // 
            // txt_compra
            // 
            txt_compra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_compra.Location = new Point(1316, 75);
            txt_compra.Margin = new Padding(4, 3, 4, 3);
            txt_compra.Name = "txt_compra";
            txt_compra.Size = new Size(38, 26);
            txt_compra.TabIndex = 29;
            txt_compra.Text = "45";
            txt_compra.Validating += txt_number_Validating;
            // 
            // label_retiro
            // 
            label_retiro.AutoSize = true;
            label_retiro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_retiro.Location = new Point(1248, 136);
            label_retiro.Margin = new Padding(4, 0, 4, 0);
            label_retiro.Name = "label_retiro";
            label_retiro.Size = new Size(52, 20);
            label_retiro.TabIndex = 40;
            label_retiro.Text = "Retiro";
            // 
            // label_entrega
            // 
            label_entrega.AutoSize = true;
            label_entrega.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_entrega.Location = new Point(1232, 106);
            label_entrega.Margin = new Padding(4, 0, 4, 0);
            label_entrega.Name = "label_entrega";
            label_entrega.Size = new Size(66, 20);
            label_entrega.TabIndex = 39;
            label_entrega.Text = "Entrega";
            // 
            // label_compra
            // 
            label_compra.AutoSize = true;
            label_compra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_compra.Location = new Point(1233, 78);
            label_compra.Margin = new Padding(4, 0, 4, 0);
            label_compra.Name = "label_compra";
            label_compra.Size = new Size(65, 20);
            label_compra.TabIndex = 38;
            label_compra.Text = "Compra";
            // 
            // label_probabilidad_eventos
            // 
            label_probabilidad_eventos.AutoSize = true;
            label_probabilidad_eventos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_probabilidad_eventos.Location = new Point(1180, 44);
            label_probabilidad_eventos.Margin = new Padding(4, 0, 4, 0);
            label_probabilidad_eventos.Name = "label_probabilidad_eventos";
            label_probabilidad_eventos.Size = new Size(206, 20);
            label_probabilidad_eventos.TabIndex = 37;
            label_probabilidad_eventos.Text = "Probabilidad de eventos (%)";
            // 
            // label_subtitulo
            // 
            label_subtitulo.AutoSize = true;
            label_subtitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_subtitulo.Location = new Point(391, 10);
            label_subtitulo.Margin = new Padding(4, 0, 4, 0);
            label_subtitulo.Name = "label_subtitulo";
            label_subtitulo.Size = new Size(187, 24);
            label_subtitulo.TabIndex = 36;
            label_subtitulo.Text = "Grupo 2 - Relojeria";
            // 
            // lblLlegadas
            // 
            lblLlegadas.AutoSize = true;
            lblLlegadas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLlegadas.Location = new Point(483, 44);
            lblLlegadas.Margin = new Padding(4, 0, 4, 0);
            lblLlegadas.Name = "lblLlegadas";
            lblLlegadas.Size = new Size(197, 20);
            lblLlegadas.TabIndex = 28;
            lblLlegadas.Text = "Llegada de personas (min)";
            // 
            // label_tiempo_simular
            // 
            label_tiempo_simular.AutoSize = true;
            label_tiempo_simular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_tiempo_simular.Location = new Point(63, 60);
            label_tiempo_simular.Margin = new Padding(4, 0, 4, 0);
            label_tiempo_simular.Name = "label_tiempo_simular";
            label_tiempo_simular.Size = new Size(175, 20);
            label_tiempo_simular.TabIndex = 26;
            label_tiempo_simular.Text = "Tiempo a simular (min.):";
            // 
            // btn_simular
            // 
            btn_simular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simular.Location = new Point(1474, 44);
            btn_simular.Margin = new Padding(4, 3, 4, 3);
            btn_simular.Name = "btn_simular";
            btn_simular.Size = new Size(127, 72);
            btn_simular.TabIndex = 33;
            btn_simular.Text = "Simular";
            btn_simular.UseVisualStyleBackColor = true;
            btn_simular.Click += btn_simular_Click;
            // 
            // txt_tiempo_simular
            // 
            txt_tiempo_simular.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tiempo_simular.Location = new Point(274, 57);
            txt_tiempo_simular.Margin = new Padding(4, 3, 4, 3);
            txt_tiempo_simular.Name = "txt_tiempo_simular";
            txt_tiempo_simular.Size = new Size(107, 26);
            txt_tiempo_simular.TabIndex = 24;
            txt_tiempo_simular.Text = "1000";
            txt_tiempo_simular.Validating += txt_number_Validating;
            // 
            // dgv_simulacion
            // 
            dgv_simulacion.AllowUserToAddRows = false;
            dgv_simulacion.AllowUserToDeleteRows = false;
            dgv_simulacion.AllowUserToResizeColumns = false;
            dgv_simulacion.AllowUserToResizeRows = false;
            dgv_simulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_simulacion.Location = new Point(14, 185);
            dgv_simulacion.Margin = new Padding(4, 3, 4, 3);
            dgv_simulacion.Name = "dgv_simulacion";
            dgv_simulacion.Size = new Size(1587, 563);
            dgv_simulacion.TabIndex = 34;
            // 
            // label_titulo
            // 
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(34, 10);
            label_titulo.Margin = new Padding(4, 0, 4, 0);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(261, 25);
            label_titulo.TabIndex = 46;
            label_titulo.Text = "TP 4 - Simulación colas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(463, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 47;
            label2.Text = "Fin de atención compra (min)";
            // 
            // llegHasta
            // 
            llegHasta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            llegHasta.Location = new Point(791, 40);
            llegHasta.Margin = new Padding(4, 3, 4, 3);
            llegHasta.Name = "llegHasta";
            llegHasta.Size = new Size(38, 26);
            llegHasta.TabIndex = 51;
            llegHasta.Text = "17";
            llegHasta.Validating += txt_number_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(763, 44);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 52;
            label4.Text = "a";
            // 
            // llegDesde
            // 
            llegDesde.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            llegDesde.Location = new Point(722, 40);
            llegDesde.Margin = new Padding(4, 3, 4, 3);
            llegDesde.Name = "llegDesde";
            llegDesde.Size = new Size(33, 26);
            llegDesde.TabIndex = 50;
            llegDesde.Text = "13";
            llegDesde.Validating += txt_number_Validating;
            // 
            // atencHasta
            // 
            atencHasta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            atencHasta.Location = new Point(791, 115);
            atencHasta.Margin = new Padding(4, 3, 4, 3);
            atencHasta.Name = "atencHasta";
            atencHasta.Size = new Size(38, 26);
            atencHasta.TabIndex = 54;
            atencHasta.Text = "10";
            atencHasta.Validating += txt_number_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(763, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 55;
            label3.Text = "a";
            // 
            // atencDesde
            // 
            atencDesde.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            atencDesde.Location = new Point(722, 115);
            atencDesde.Margin = new Padding(4, 3, 4, 3);
            atencDesde.Name = "atencDesde";
            atencDesde.Size = new Size(33, 26);
            atencDesde.TabIndex = 53;
            atencDesde.Text = "6";
            atencDesde.Validating += txt_number_Validating;
            // 
            // finRepHasta
            // 
            finRepHasta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finRepHasta.Location = new Point(791, 153);
            finRepHasta.Margin = new Padding(4, 3, 4, 3);
            finRepHasta.Name = "finRepHasta";
            finRepHasta.Size = new Size(38, 26);
            finRepHasta.TabIndex = 58;
            finRepHasta.Text = "22";
            finRepHasta.Validating += txt_number_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(763, 156);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 59;
            label5.Text = "a";
            // 
            // finRepDesde
            // 
            finRepDesde.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finRepDesde.Location = new Point(720, 152);
            finRepDesde.Margin = new Padding(4, 3, 4, 3);
            finRepDesde.Name = "finRepDesde";
            finRepDesde.Size = new Size(33, 26);
            finRepDesde.TabIndex = 57;
            finRepDesde.Text = "18";
            finRepDesde.Validating += txt_number_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(513, 153);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 56;
            label6.Text = "Fin de reparación (min)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(414, 81);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(256, 20);
            label7.TabIndex = 60;
            label7.Text = "Fin de atención retiro/entrega (min)";
            // 
            // fin_retiro_entrega
            // 
            fin_retiro_entrega.Enabled = false;
            fin_retiro_entrega.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fin_retiro_entrega.Location = new Point(722, 78);
            fin_retiro_entrega.Margin = new Padding(4, 3, 4, 3);
            fin_retiro_entrega.Name = "fin_retiro_entrega";
            fin_retiro_entrega.Size = new Size(33, 26);
            fin_retiro_entrega.TabIndex = 61;
            fin_retiro_entrega.Text = "3";
            fin_retiro_entrega.Validating += txt_number_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(763, 81);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 62;
            label8.Text = "cte";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(861, 44);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(194, 20);
            label9.TabIndex = 63;
            label9.Text = "Fin de ordenamiento (min)";
            // 
            // finOrdenamiento
            // 
            finOrdenamiento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finOrdenamiento.Location = new Point(1094, 40);
            finOrdenamiento.Margin = new Padding(4, 3, 4, 3);
            finOrdenamiento.Name = "finOrdenamiento";
            finOrdenamiento.Size = new Size(33, 26);
            finOrdenamiento.TabIndex = 64;
            finOrdenamiento.Text = "5";
            finOrdenamiento.Validating += txt_number_Validating;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // progressBar1
            // 
            progressBar.Location = new Point(1401, 136);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(200, 23);
            progressBar.TabIndex = 65;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1615, 763);
            Controls.Add(progressBar);
            Controls.Add(finOrdenamiento);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(fin_retiro_entrega);
            Controls.Add(label7);
            Controls.Add(finRepHasta);
            Controls.Add(label5);
            Controls.Add(finRepDesde);
            Controls.Add(label6);
            Controls.Add(atencHasta);
            Controls.Add(label3);
            Controls.Add(atencDesde);
            Controls.Add(llegHasta);
            Controls.Add(label4);
            Controls.Add(llegDesde);
            Controls.Add(label2);
            Controls.Add(label_titulo);
            Controls.Add(txt_iteracciones);
            Controls.Add(txt_desde_hora);
            Controls.Add(label_iteracciones);
            Controls.Add(label_desde);
            Controls.Add(label1);
            Controls.Add(txt_retiro);
            Controls.Add(txt_entrega);
            Controls.Add(txt_compra);
            Controls.Add(label_retiro);
            Controls.Add(label_entrega);
            Controls.Add(label_compra);
            Controls.Add(label_probabilidad_eventos);
            Controls.Add(label_subtitulo);
            Controls.Add(lblLlegadas);
            Controls.Add(label_tiempo_simular);
            Controls.Add(btn_simular);
            Controls.Add(txt_tiempo_simular);
            Controls.Add(dgv_simulacion);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmPrincipal";
            Text = "TP4 - Relojeria";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_simulacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MaskedTextBox txt_iteracciones;
        public MaskedTextBox txt_desde_hora;
        private Label label_iteracciones;
        private Label label_desde;
        private Label label1;
        public MaskedTextBox txt_retiro;
        public MaskedTextBox txt_entrega;
        public MaskedTextBox txt_compra;
        private Label label_retiro;
        private Label label_entrega;
        private Label label_compra;
        private Label label_probabilidad_eventos;
        private Label label_subtitulo;
        private Label lblLlegadas;
        private Label label_tiempo_simular;
        private Button btn_simular;
        public MaskedTextBox txt_tiempo_simular;
        private DataGridView dgv_simulacion;
        private Label label_titulo;
        private Label label2;
        public MaskedTextBox llegHasta;
        private Label label4;
        public MaskedTextBox llegDesde;
        public MaskedTextBox atencHasta;
        private Label label3;
        public MaskedTextBox atencDesde;
        public MaskedTextBox finRepHasta;
        private Label label5;
        public MaskedTextBox finRepDesde;
        private Label label6;
        private Label label7;
        public MaskedTextBox fin_retiro_entrega;
        private Label label8;
        private Label label9;
        public MaskedTextBox finOrdenamiento;
        private ErrorProvider errorProviderApp;
        public ProgressBar progressBar;
    }
}

