namespace SIM_4K4_2023_G2_TP2
{
    partial class UniformDistribution
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_generationU = new Button();
            txt_lower = new TextBox();
            txt_upper = new TextBox();
            txt_n = new TextBox();
            lbl_lower = new Label();
            lbl_upper = new Label();
            lbl_n = new Label();
            dt_gridUniformDistr = new DataGridView();
            progressBar = new ProgressBar();
            errorProviderApp = new ErrorProvider(components);
            dt_gridData = new DataGridView();
            btn_draw = new Button();
            lbl_Interval = new Label();
            cmb_interval = new ComboBox();
            btn_return = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_gridUniformDistr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).BeginInit();
            SuspendLayout();
            // 
            // btn_generationU
            // 
            btn_generationU.Location = new Point(12, 257);
            btn_generationU.Name = "btn_generationU";
            btn_generationU.Size = new Size(123, 54);
            btn_generationU.TabIndex = 0;
            btn_generationU.Text = "Generar";
            btn_generationU.UseVisualStyleBackColor = true;
            btn_generationU.Click += btn_generationU_Click;
            // 
            // txt_lower
            // 
            txt_lower.Location = new Point(158, 27);
            txt_lower.Name = "txt_lower";
            txt_lower.Size = new Size(100, 23);
            txt_lower.TabIndex = 1;
            txt_lower.KeyPress += textBox_KeyPress;
            txt_lower.Validating += txt_lower_Validating;
            // 
            // txt_upper
            // 
            txt_upper.Location = new Point(158, 82);
            txt_upper.Name = "txt_upper";
            txt_upper.Size = new Size(100, 23);
            txt_upper.TabIndex = 2;
            txt_upper.KeyPress += textBox_KeyPress;
            txt_upper.Validating += txt_upper_Validating;
            // 
            // txt_n
            // 
            txt_n.Location = new Point(158, 130);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 3;
            txt_n.KeyPress += textBox_KeyPress;
            txt_n.Validating += txt_n_Validating;
            // 
            // lbl_lower
            // 
            lbl_lower.AutoSize = true;
            lbl_lower.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lower.Location = new Point(12, 27);
            lbl_lower.Name = "lbl_lower";
            lbl_lower.Size = new Size(130, 25);
            lbl_lower.TabIndex = 4;
            lbl_lower.Text = "Limite Inferior";
            // 
            // lbl_upper
            // 
            lbl_upper.AutoSize = true;
            lbl_upper.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_upper.Location = new Point(12, 82);
            lbl_upper.Name = "lbl_upper";
            lbl_upper.Size = new Size(140, 25);
            lbl_upper.TabIndex = 5;
            lbl_upper.Text = "Limite Superior";
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_n.Location = new Point(12, 128);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(81, 25);
            lbl_n.TabIndex = 6;
            lbl_n.Text = "Muestra";
            // 
            // dt_gridUniformDistr
            // 
            dt_gridUniformDistr.AllowUserToAddRows = false;
            dt_gridUniformDistr.AllowUserToDeleteRows = false;
            dt_gridUniformDistr.AllowUserToResizeRows = false;
            dt_gridUniformDistr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridUniformDistr.Location = new Point(297, 27);
            dt_gridUniformDistr.Name = "dt_gridUniformDistr";
            dt_gridUniformDistr.ReadOnly = true;
            dt_gridUniformDistr.RowTemplate.Height = 25;
            dt_gridUniformDistr.Size = new Size(475, 284);
            dt_gridUniformDistr.TabIndex = 7;
            dt_gridUniformDistr.VirtualMode = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 219);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(246, 23);
            progressBar.TabIndex = 8;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // dt_gridData
            // 
            dt_gridData.AllowUserToAddRows = false;
            dt_gridData.AllowUserToDeleteRows = false;
            dt_gridData.AllowUserToResizeRows = false;
            dt_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridData.Location = new Point(12, 326);
            dt_gridData.Name = "dt_gridData";
            dt_gridData.ReadOnly = true;
            dt_gridData.RowTemplate.Height = 25;
            dt_gridData.Size = new Size(606, 291);
            dt_gridData.TabIndex = 9;
            dt_gridData.VirtualMode = true;
            // 
            // btn_draw
            // 
            btn_draw.Location = new Point(640, 493);
            btn_draw.Name = "btn_draw";
            btn_draw.Size = new Size(123, 54);
            btn_draw.TabIndex = 10;
            btn_draw.Text = "Graficar";
            btn_draw.UseVisualStyleBackColor = true;
            btn_draw.Click += btn_draw_Click;
            // 
            // lbl_Interval
            // 
            lbl_Interval.AutoSize = true;
            lbl_Interval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Interval.Location = new Point(12, 177);
            lbl_Interval.Name = "lbl_Interval";
            lbl_Interval.Size = new Size(94, 25);
            lbl_Interval.TabIndex = 11;
            lbl_Interval.Text = "Intervalos";
            // 
            // cmb_interval
            // 
            cmb_interval.FormattingEnabled = true;
            cmb_interval.Items.AddRange(new object[] { "10", "15", "20", "25" });
            cmb_interval.Location = new Point(158, 177);
            cmb_interval.Name = "cmb_interval";
            cmb_interval.Size = new Size(100, 23);
            cmb_interval.TabIndex = 12;
            cmb_interval.Validating += cmb_interval_Validating;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(640, 563);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(123, 54);
            btn_return.TabIndex = 13;
            btn_return.Text = "Volver";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // UniformDistribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 674);
            Controls.Add(btn_return);
            Controls.Add(cmb_interval);
            Controls.Add(lbl_Interval);
            Controls.Add(btn_draw);
            Controls.Add(dt_gridData);
            Controls.Add(progressBar);
            Controls.Add(dt_gridUniformDistr);
            Controls.Add(lbl_n);
            Controls.Add(lbl_upper);
            Controls.Add(lbl_lower);
            Controls.Add(txt_n);
            Controls.Add(txt_upper);
            Controls.Add(txt_lower);
            Controls.Add(btn_generationU);
            Name = "UniformDistribution";
            Text = "UniformDistribution";
            ((System.ComponentModel.ISupportInitialize)dt_gridUniformDistr).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_generationU;
        private TextBox txt_lower;
        private TextBox txt_upper;
        private TextBox txt_n;
        private Label lbl_lower;
        private Label lbl_upper;
        private Label lbl_n;
        private DataGridView dt_gridUniformDistr;
        private DataGridViewTextBoxColumn n;
        private DataGridViewTextBoxColumn RND;
        private DataGridViewTextBoxColumn UniformValue;
        private ProgressBar progressBar;
        private ErrorProvider errorProviderApp;
        private DataGridView dt_gridData;
        private Button btn_draw;
        private Label lbl_Interval;
        private ComboBox cmb_interval;
        private Button btn_return;
    }
}