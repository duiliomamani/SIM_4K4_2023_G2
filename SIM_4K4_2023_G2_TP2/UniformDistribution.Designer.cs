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
            ((System.ComponentModel.ISupportInitialize)dt_gridUniformDistr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // btn_generationU
            // 
            btn_generationU.Location = new Point(28, 176);
            btn_generationU.Name = "btn_generationU";
            btn_generationU.Size = new Size(134, 54);
            btn_generationU.TabIndex = 0;
            btn_generationU.Text = "Generar";
            btn_generationU.UseVisualStyleBackColor = true;
            btn_generationU.Click += btn_generationU_Click;
            // 
            // txt_lower
            // 
            txt_lower.Location = new Point(168, 27);
            txt_lower.Name = "txt_lower";
            txt_lower.Size = new Size(100, 23);
            txt_lower.TabIndex = 1;
            txt_lower.KeyPress += TextBox_KeyPress;
            txt_lower.Validating += txt_lower_Validating;
            // 
            // txt_upper
            // 
            txt_upper.Location = new Point(168, 77);
            txt_upper.Name = "txt_upper";
            txt_upper.Size = new Size(100, 23);
            txt_upper.TabIndex = 2;
            txt_upper.KeyPress += TextBox_KeyPress;
            txt_upper.Validating += txt_upper_Validating;
            // 
            // txt_n
            // 
            txt_n.Location = new Point(168, 127);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 3;
            txt_n.KeyPress += TextBox_KeyPress;
            txt_n.Validating += txt_n_Validating;
            // 
            // lbl_lower
            // 
            lbl_lower.AutoSize = true;
            lbl_lower.Location = new Point(28, 30);
            lbl_lower.Name = "lbl_lower";
            lbl_lower.Size = new Size(81, 15);
            lbl_lower.TabIndex = 4;
            lbl_lower.Text = "Limite Inferior";
            // 
            // lbl_upper
            // 
            lbl_upper.AutoSize = true;
            lbl_upper.Location = new Point(28, 80);
            lbl_upper.Name = "lbl_upper";
            lbl_upper.Size = new Size(87, 15);
            lbl_upper.TabIndex = 5;
            lbl_upper.Text = "Limite Superior";
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Location = new Point(28, 133);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(50, 15);
            lbl_n.TabIndex = 6;
            lbl_n.Text = "Muestra";
            // 
            // dt_gridUniformDistr
            // 
            dt_gridUniformDistr.AllowUserToAddRows = false;
            dt_gridUniformDistr.AllowUserToDeleteRows = false;
            dt_gridUniformDistr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridUniformDistr.Location = new Point(544, 30);
            dt_gridUniformDistr.Name = "dt_gridUniformDistr";
            dt_gridUniformDistr.RowTemplate.Height = 25;
            dt_gridUniformDistr.Size = new Size(343, 578);
            dt_gridUniformDistr.TabIndex = 7;
           
            // 
            // progressBar
            // 
            progressBar.Location = new Point(28, 254);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 23);
            progressBar.TabIndex = 8;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // UniformDistribution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 620);
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
    }
}