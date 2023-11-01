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
            this.components = new System.ComponentModel.Container();
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
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dgv_state = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_state)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_iteracciones
            // 
            this.txt_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_iteracciones.Location = new System.Drawing.Point(216, 197);
            this.txt_iteracciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_iteracciones.Name = "txt_iteracciones";
            this.txt_iteracciones.Size = new System.Drawing.Size(94, 26);
            this.txt_iteracciones.TabIndex = 45;
            this.txt_iteracciones.Text = "20";
            this.txt_iteracciones.Validating += txt_number_Validating;
            // 
            // txt_desde_hora
            // 
            this.txt_desde_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_desde_hora.Location = new System.Drawing.Point(216, 160);
            this.txt_desde_hora.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_desde_hora.Name = "txt_desde_hora";
            this.txt_desde_hora.Size = new System.Drawing.Size(61, 26);
            this.txt_desde_hora.TabIndex = 44;
            this.txt_desde_hora.Text = "0";
            this.txt_desde_hora.Validating += txt_number_Validating;
            // 
            // label_iteracciones
            // 
            this.label_iteracciones.AutoSize = true;
            this.label_iteracciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_iteracciones.Location = new System.Drawing.Point(71, 201);
            this.label_iteracciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_iteracciones.Name = "label_iteracciones";
            this.label_iteracciones.Size = new System.Drawing.Size(92, 20);
            this.label_iteracciones.TabIndex = 43;
            this.label_iteracciones.Text = "Iteraciones:";
            // 
            // label_desde
            // 
            this.label_desde.AutoSize = true;
            this.label_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_desde.Location = new System.Drawing.Point(71, 164);
            this.label_desde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_desde.Name = "label_desde";
            this.label_desde.Size = new System.Drawing.Size(60, 20);
            this.label_desde.TabIndex = 42;
            this.label_desde.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Vista";
            // 
            // txt_retiro
            // 
            this.txt_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_retiro.Location = new System.Drawing.Point(1504, 172);
            this.txt_retiro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_retiro.Name = "txt_retiro";
            this.txt_retiro.Size = new System.Drawing.Size(43, 26);
            this.txt_retiro.TabIndex = 32;
            this.txt_retiro.Text = "30";
            txt_retiro.Validating += txt_number_Validating;
            // 
            // txt_entrega
            // 
            this.txt_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_entrega.Location = new System.Drawing.Point(1504, 137);
            this.txt_entrega.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_entrega.Name = "txt_entrega";
            this.txt_entrega.Size = new System.Drawing.Size(43, 26);
            this.txt_entrega.TabIndex = 31;
            this.txt_entrega.Text = "25";
            this.txt_entrega.Validating += txt_number_Validating;
            // 
            // txt_compra
            // 
            this.txt_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_compra.Location = new System.Drawing.Point(1504, 100);
            this.txt_compra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_compra.Name = "txt_compra";
            this.txt_compra.Size = new System.Drawing.Size(43, 26);
            this.txt_compra.TabIndex = 29;
            this.txt_compra.Text = "45";
            this.txt_compra.Validating += txt_number_Validating;
            // 
            // label_retiro
            // 
            this.label_retiro.AutoSize = true;
            this.label_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_retiro.Location = new System.Drawing.Point(1426, 181);
            this.label_retiro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_retiro.Name = "label_retiro";
            this.label_retiro.Size = new System.Drawing.Size(52, 20);
            this.label_retiro.TabIndex = 40;
            this.label_retiro.Text = "Retiro";
            // 
            // label_entrega
            // 
            this.label_entrega.AutoSize = true;
            this.label_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_entrega.Location = new System.Drawing.Point(1408, 141);
            this.label_entrega.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_entrega.Name = "label_entrega";
            this.label_entrega.Size = new System.Drawing.Size(66, 20);
            this.label_entrega.TabIndex = 39;
            this.label_entrega.Text = "Entrega";
            // 
            // label_compra
            // 
            this.label_compra.AutoSize = true;
            this.label_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_compra.Location = new System.Drawing.Point(1409, 104);
            this.label_compra.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_compra.Name = "label_compra";
            this.label_compra.Size = new System.Drawing.Size(65, 20);
            this.label_compra.TabIndex = 38;
            this.label_compra.Text = "Compra";
            // 
            // label_probabilidad_eventos
            // 
            this.label_probabilidad_eventos.AutoSize = true;
            this.label_probabilidad_eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_probabilidad_eventos.Location = new System.Drawing.Point(1349, 59);
            this.label_probabilidad_eventos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_probabilidad_eventos.Name = "label_probabilidad_eventos";
            this.label_probabilidad_eventos.Size = new System.Drawing.Size(206, 20);
            this.label_probabilidad_eventos.TabIndex = 37;
            this.label_probabilidad_eventos.Text = "Probabilidad de eventos (%)";
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_subtitulo.Location = new System.Drawing.Point(447, 13);
            this.label_subtitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(187, 24);
            this.label_subtitulo.TabIndex = 36;
            this.label_subtitulo.Text = "Grupo 2 - Relojeria";
            // 
            // lblLlegadas
            // 
            this.lblLlegadas.AutoSize = true;
            this.lblLlegadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLlegadas.Location = new System.Drawing.Point(552, 59);
            this.lblLlegadas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLlegadas.Name = "lblLlegadas";
            this.lblLlegadas.Size = new System.Drawing.Size(197, 20);
            this.lblLlegadas.TabIndex = 28;
            this.lblLlegadas.Text = "Llegada de personas (min)";
            // 
            // label_tiempo_simular
            // 
            this.label_tiempo_simular.AutoSize = true;
            this.label_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_tiempo_simular.Location = new System.Drawing.Point(72, 80);
            this.label_tiempo_simular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_tiempo_simular.Name = "label_tiempo_simular";
            this.label_tiempo_simular.Size = new System.Drawing.Size(175, 20);
            this.label_tiempo_simular.TabIndex = 26;
            this.label_tiempo_simular.Text = "Tiempo a simular (min.):";
            // 
            // btn_simular
            // 
            this.btn_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_simular.Location = new System.Drawing.Point(1685, 59);
            this.btn_simular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(145, 96);
            this.btn_simular.TabIndex = 33;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += btn_simular_Click;
            // 
            // txt_tiempo_simular
            // 
            this.txt_tiempo_simular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tiempo_simular.Location = new System.Drawing.Point(313, 76);
            this.txt_tiempo_simular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tiempo_simular.Name = "txt_tiempo_simular";
            this.txt_tiempo_simular.Size = new System.Drawing.Size(122, 26);
            this.txt_tiempo_simular.TabIndex = 24;
            this.txt_tiempo_simular.Text = "1000";
            this.txt_tiempo_simular.Validating += txt_number_Validating;
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.AllowUserToAddRows = false;
            this.dgv_simulacion.AllowUserToDeleteRows = false;
            this.dgv_simulacion.AllowUserToResizeColumns = false;
            this.dgv_simulacion.AllowUserToResizeRows = false;
            this.dgv_simulacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_simulacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulacion.Location = new System.Drawing.Point(15, 247);
            this.dgv_simulacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.ReadOnly = true;
            this.dgv_simulacion.ShowCellErrors = false;
            this.dgv_simulacion.ShowCellToolTips = false;
            this.dgv_simulacion.ShowEditingIcon = false;
            this.dgv_simulacion.ShowRowErrors = false;
            this.dgv_simulacion.Size = new System.Drawing.Size(1829, 604);
            this.dgv_simulacion.TabIndex = 34;
            this.dgv_simulacion.SelectionChanged += dgv_simulacion_SelectionChanged;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_titulo.Location = new System.Drawing.Point(39, 13);
            this.label_titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(261, 25);
            this.label_titulo.TabIndex = 46;
            this.label_titulo.Text = "TP 4 - Simulación colas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(529, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Fin de atención compra (min)";
            // 
            // llegHasta
            // 
            this.llegHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llegHasta.Location = new System.Drawing.Point(904, 53);
            this.llegHasta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.llegHasta.Name = "llegHasta";
            this.llegHasta.Size = new System.Drawing.Size(43, 26);
            this.llegHasta.TabIndex = 51;
            this.llegHasta.Text = "17";
            this.llegHasta.Validating += txt_number_Validating;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(872, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "a";
            // 
            // llegDesde
            // 
            this.llegDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llegDesde.Location = new System.Drawing.Point(825, 53);
            this.llegDesde.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.llegDesde.Name = "llegDesde";
            this.llegDesde.Size = new System.Drawing.Size(37, 26);
            this.llegDesde.TabIndex = 50;
            this.llegDesde.Text = "13";
            this.llegDesde.Validating += txt_number_Validating;
            // 
            // atencHasta
            // 
            this.atencHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atencHasta.Location = new System.Drawing.Point(904, 153);
            this.atencHasta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.atencHasta.Name = "atencHasta";
            this.atencHasta.Size = new System.Drawing.Size(43, 26);
            this.atencHasta.TabIndex = 54;
            this.atencHasta.Text = "10";
            this.atencHasta.Validating += txt_number_Validating;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(872, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "a";
            // 
            // atencDesde
            // 
            this.atencDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.atencDesde.Location = new System.Drawing.Point(825, 153);
            this.atencDesde.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.atencDesde.Name = "atencDesde";
            this.atencDesde.Size = new System.Drawing.Size(37, 26);
            this.atencDesde.TabIndex = 53;
            this.atencDesde.Text = "6";
            this.atencDesde.Validating += txt_number_Validating;
            // 
            // finRepHasta
            // 
            this.finRepHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finRepHasta.Location = new System.Drawing.Point(904, 204);
            this.finRepHasta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.finRepHasta.Name = "finRepHasta";
            this.finRepHasta.Size = new System.Drawing.Size(43, 26);
            this.finRepHasta.TabIndex = 58;
            this.finRepHasta.Text = "22";
            this.finRepHasta.Validating += txt_number_Validating;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(872, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "a";
            // 
            // finRepDesde
            // 
            this.finRepDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finRepDesde.Location = new System.Drawing.Point(823, 203);
            this.finRepDesde.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.finRepDesde.Name = "finRepDesde";
            this.finRepDesde.Size = new System.Drawing.Size(37, 26);
            this.finRepDesde.TabIndex = 57;
            this.finRepDesde.Text = "18";
            this.finRepDesde.Validating += txt_number_Validating;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(586, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fin de reparación (min)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(473, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fin de atención retiro/entrega (min)";
            // 
            // fin_retiro_entrega
            // 
            this.fin_retiro_entrega.Enabled = false;
            this.fin_retiro_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fin_retiro_entrega.Location = new System.Drawing.Point(825, 104);
            this.fin_retiro_entrega.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fin_retiro_entrega.Name = "fin_retiro_entrega";
            this.fin_retiro_entrega.Size = new System.Drawing.Size(37, 26);
            this.fin_retiro_entrega.TabIndex = 61;
            this.fin_retiro_entrega.Text = "3";
            this.fin_retiro_entrega.Validating += txt_number_Validating;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(872, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "cte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(984, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Fin de ordenamiento (min)";
            // 
            // finOrdenamiento
            // 
            this.finOrdenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finOrdenamiento.Location = new System.Drawing.Point(1250, 53);
            this.finOrdenamiento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.finOrdenamiento.Name = "finOrdenamiento";
            this.finOrdenamiento.Size = new System.Drawing.Size(37, 26);
            this.finOrdenamiento.TabIndex = 64;
            this.finOrdenamiento.Text = "5";
            this.finOrdenamiento.Validating += txt_number_Validating;
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1601, 181);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(229, 31);
            this.progressBar.TabIndex = 65;
            // 
            // dgv_state
            // 
            this.dgv_state.AllowUserToAddRows = false;
            this.dgv_state.AllowUserToDeleteRows = false;
            this.dgv_state.AllowUserToResizeColumns = false;
            this.dgv_state.AllowUserToResizeRows = false;
            this.dgv_state.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_state.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_state.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_state.Location = new System.Drawing.Point(15, 880);
            this.dgv_state.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_state.Name = "dgv_state";
            this.dgv_state.ReadOnly = true;
            this.dgv_state.ShowCellErrors = false;
            this.dgv_state.ShowCellToolTips = false;
            this.dgv_state.ShowEditingIcon = false;
            this.dgv_state.ShowRowErrors = false;
            this.dgv_state.Size = new System.Drawing.Size(1829, 168);
            this.dgv_state.TabIndex = 66;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 1061);
            this.Controls.Add(this.dgv_state);
            this.Controls.Add(this.progressBar);
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
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 - Relojeria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_state)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView dgv_state;
    }
}

