namespace SIM_4K4_2023_G2_TP3
{
    partial class Form1
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
            lbl_n = new Label();
            txt_n = new TextBox();
            dtg_prob = new DataGridView();
            txt_i = new TextBox();
            txt_j = new TextBox();
            lbl_i = new Label();
            lbl_j = new Label();
            lbl_u = new Label();
            txt_u = new TextBox();
            lbl_c = new Label();
            txt_c = new TextBox();
            errorProviderApp = new ErrorProvider(components);
            btn_init = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_prob).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).BeginInit();
            SuspendLayout();
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Location = new Point(21, 18);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(44, 15);
            lbl_n.TabIndex = 0;
            lbl_n.Text = "Cant N";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(145, 15);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 1;
            txt_n.Validating += txt_number_Validating;
            // 
            // dtg_prob
            // 
            dtg_prob.AllowUserToResizeColumns = false;
            dtg_prob.AllowUserToResizeRows = false;
            dtg_prob.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_prob.Location = new Point(322, 15);
            dtg_prob.Name = "dtg_prob";
            dtg_prob.RowTemplate.Height = 25;
            dtg_prob.Size = new Size(214, 211);
            dtg_prob.TabIndex = 2;
            // 
            // txt_i
            // 
            txt_i.Location = new Point(145, 62);
            txt_i.Name = "txt_i";
            txt_i.Size = new Size(100, 23);
            txt_i.TabIndex = 3;
            txt_i.Validating += txt_number_Validating;
            // 
            // txt_j
            // 
            txt_j.Location = new Point(145, 111);
            txt_j.Name = "txt_j";
            txt_j.Size = new Size(100, 23);
            txt_j.TabIndex = 4;
            txt_j.Validating += txt_number_Validating;
            // 
            // lbl_i
            // 
            lbl_i.AutoSize = true;
            lbl_i.Location = new Point(21, 65);
            lbl_i.Name = "lbl_i";
            lbl_i.Size = new Size(103, 15);
            lbl_i.TabIndex = 5;
            lbl_i.Text = "Inicio de muestras";
            // 
            // lbl_j
            // 
            lbl_j.AutoSize = true;
            lbl_j.Location = new Point(21, 114);
            lbl_j.Name = "lbl_j";
            lbl_j.Size = new Size(111, 15);
            lbl_j.TabIndex = 6;
            lbl_j.Text = "Cantidad de vueltas";
            // 
            // lbl_u
            // 
            lbl_u.AutoSize = true;
            lbl_u.Location = new Point(21, 162);
            lbl_u.Name = "lbl_u";
            lbl_u.Size = new Size(48, 15);
            lbl_u.TabIndex = 7;
            lbl_u.Text = "Utilidad";
            // 
            // txt_u
            // 
            txt_u.Location = new Point(145, 159);
            txt_u.Name = "txt_u";
            txt_u.Size = new Size(100, 23);
            txt_u.TabIndex = 8;
            txt_u.Validating += txt_number_Validating;
            // 
            // lbl_c
            // 
            lbl_c.AutoSize = true;
            lbl_c.Location = new Point(21, 206);
            lbl_c.Name = "lbl_c";
            lbl_c.Size = new Size(99, 15);
            lbl_c.TabIndex = 9;
            lbl_c.Text = "Costo sobreventa";
            // 
            // txt_c
            // 
            txt_c.Location = new Point(145, 203);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(100, 23);
            txt_c.TabIndex = 10;
            txt_c.Validating += txt_number_Validating;
            // 
            // errorProviderApp
            // 
            errorProviderApp.ContainerControl = this;
            // 
            // btn_init
            // 
            btn_init.Location = new Point(588, 18);
            btn_init.Name = "btn_init";
            btn_init.Size = new Size(200, 67);
            btn_init.TabIndex = 11;
            btn_init.Text = "INICIAR";
            btn_init.UseVisualStyleBackColor = true;
            btn_init.Click += btn_init_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(btn_init);
            Controls.Add(txt_c);
            Controls.Add(lbl_c);
            Controls.Add(txt_u);
            Controls.Add(lbl_u);
            Controls.Add(lbl_j);
            Controls.Add(lbl_i);
            Controls.Add(txt_j);
            Controls.Add(txt_i);
            Controls.Add(dtg_prob);
            Controls.Add(txt_n);
            Controls.Add(lbl_n);
            Name = "Form1";
            Text = "TP3_Montecarlo";
            ((System.ComponentModel.ISupportInitialize)dtg_prob).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderApp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_n;
        private TextBox txt_n;
        private DataGridView dtg_prob;
        private TextBox txt_i;
        private TextBox txt_j;
        private Label lbl_i;
        private Label lbl_j;
        private Label lbl_u;
        private TextBox txt_u;
        private Label lbl_c;
        private TextBox txt_c;
        private ErrorProvider errorProviderApp;
        private Button btn_init;
    }
}