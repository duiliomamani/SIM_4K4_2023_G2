namespace SIM_4K4_2023_G2_TP2
{
    partial class ExponentialDistribution
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
            components = new System.ComponentModel.Container();
            radiobtn_lamba = new RadioButton();
            radiobtn_media = new RadioButton();
            txt_lm = new TextBox();
            cmb_interval = new ComboBox();
            lbl_Interval = new Label();
            lbl_n = new Label();
            txt_n = new TextBox();
            progressBar = new ProgressBar();
            btn_generationU = new Button();
            dt_gridExpDistr = new DataGridView();
            btn_return = new Button();
            btn_draw = new Button();
            dt_gridData = new DataGridView();
            errorProviderApp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dt_gridExpDistr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // radiobtn_lamba
            // 
            radiobtn_lamba.AutoSize = true;
            radiobtn_lamba.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radiobtn_lamba.Location = new Point(32, 23);
            radiobtn_lamba.Name = "radiobtn_lamba";
            radiobtn_lamba.Size = new Size(86, 29);
            radiobtn_lamba.TabIndex = 0;
            radiobtn_lamba.TabStop = true;
            radiobtn_lamba.Text = "Lamba";
            radiobtn_lamba.UseVisualStyleBackColor = true;
            // 
            // radiobtn_media
            // 
            radiobtn_media.AutoSize = true;
            radiobtn_media.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            radiobtn_media.Location = new Point(118, 23);
            radiobtn_media.Name = "radiobtn_media";
            radiobtn_media.Size = new Size(83, 29);
            radiobtn_media.TabIndex = 1;
            radiobtn_media.TabStop = true;
            radiobtn_media.Text = "Media";
            radiobtn_media.UseVisualStyleBackColor = true;
            // 
            // txt_lm
            // 
            txt_lm.Location = new Point(207, 29);
            txt_lm.Name = "txt_lm";
            txt_lm.Size = new Size(100, 23);
            txt_lm.TabIndex = 2;
            txt_lm.Validating += txt_lm_Validating;
            // 
            // cmb_interval
            // 
            cmb_interval.FormattingEnabled = true;
            cmb_interval.Items.AddRange(new object[] { "10", "15", "20", "25" });
            cmb_interval.Location = new Point(207, 110);
            cmb_interval.Name = "cmb_interval";
            cmb_interval.Size = new Size(100, 23);
            cmb_interval.TabIndex = 16;
            cmb_interval.Validating += cmb_interval_Validating;
            // 
            // lbl_Interval
            // 
            lbl_Interval.AutoSize = true;
            lbl_Interval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Interval.Location = new Point(32, 110);
            lbl_Interval.Name = "lbl_Interval";
            lbl_Interval.Size = new Size(94, 25);
            lbl_Interval.TabIndex = 15;
            lbl_Interval.Text = "Intervalos";
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_n.Location = new Point(32, 61);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(81, 25);
            lbl_n.TabIndex = 14;
            lbl_n.Text = "Muestra";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(207, 66);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 13;
            txt_n.Validating += txt_n_Validating;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 158);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(275, 23);
            progressBar.TabIndex = 18;
            // 
            // btn_generationU
            // 
            btn_generationU.Location = new Point(32, 196);
            btn_generationU.Name = "btn_generationU";
            btn_generationU.Size = new Size(152, 54);
            btn_generationU.TabIndex = 17;
            btn_generationU.Text = "Generar";
            btn_generationU.UseVisualStyleBackColor = true;
            btn_generationU.Click += btn_generationU_Click;
            // 
            // dt_gridExpDistr
            // 
            dt_gridExpDistr.AllowUserToAddRows = false;
            dt_gridExpDistr.AllowUserToDeleteRows = false;
            dt_gridExpDistr.AllowUserToResizeRows = false;
            dt_gridExpDistr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridExpDistr.Location = new Point(342, 23);
            dt_gridExpDistr.Name = "dt_gridExpDistr";
            dt_gridExpDistr.ReadOnly = true;
            dt_gridExpDistr.RowTemplate.Height = 25;
            dt_gridExpDistr.Size = new Size(441, 227);
            dt_gridExpDistr.TabIndex = 19;
            dt_gridExpDistr.VirtualMode = true;
            // 
            // btn_return
            // 
            btn_return.Location = new Point(660, 531);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(123, 54);
            btn_return.TabIndex = 22;
            btn_return.Text = "Volver";
            btn_return.UseVisualStyleBackColor = true;
            // 
            // btn_draw
            // 
            btn_draw.Location = new Point(660, 461);
            btn_draw.Name = "btn_draw";
            btn_draw.Size = new Size(123, 54);
            btn_draw.TabIndex = 21;
            btn_draw.Text = "Graficar";
            btn_draw.UseVisualStyleBackColor = true;
            btn_draw.Click += btn_draw_Click;
            // 
            // dt_gridData
            // 
            dt_gridData.AllowUserToAddRows = false;
            dt_gridData.AllowUserToDeleteRows = false;
            dt_gridData.AllowUserToResizeRows = false;
            dt_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridData.Location = new Point(32, 294);
            dt_gridData.Name = "dt_gridData";
            dt_gridData.ReadOnly = true;
            dt_gridData.RowTemplate.Height = 25;
            dt_gridData.Size = new Size(606, 291);
            dt_gridData.TabIndex = 20;
            dt_gridData.VirtualMode = true;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // ExponentialDistribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 607);
            Controls.Add(btn_return);
            Controls.Add(btn_draw);
            Controls.Add(dt_gridData);
            Controls.Add(dt_gridExpDistr);
            Controls.Add(progressBar);
            Controls.Add(btn_generationU);
            Controls.Add(cmb_interval);
            Controls.Add(lbl_Interval);
            Controls.Add(lbl_n);
            Controls.Add(txt_n);
            Controls.Add(txt_lm);
            Controls.Add(radiobtn_media);
            Controls.Add(radiobtn_lamba);
            Name = "ExponentialDistribution";
            Text = "ExponentialDistribution";
            ((System.ComponentModel.ISupportInitialize)dt_gridExpDistr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radiobtn_lamba;
        private RadioButton radiobtn_media;
        private TextBox txt_lm;
        private ComboBox cmb_interval;
        private Label lbl_Interval;
        private Label lbl_n;
        private TextBox txt_n;
        private ProgressBar progressBar;
        private Button btn_generationU;
        private DataGridView dt_gridExpDistr;
        private Button btn_return;
        private Button btn_draw;
        private DataGridView dt_gridData;
        private ErrorProvider errorProviderApp;
    }
}