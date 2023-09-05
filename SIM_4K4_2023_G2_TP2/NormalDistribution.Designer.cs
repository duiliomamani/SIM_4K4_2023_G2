namespace SIM_4K4_2023_G2_TP2
{
    partial class NormalDistribution
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
            btn_return = new Button();
            cmb_interval = new ComboBox();
            lbl_Interval = new Label();
            btn_draw = new Button();
            dt_gridData = new DataGridView();
            progressBar = new ProgressBar();
            dt_gridUniformDistr = new DataGridView();
            lbl_n = new Label();
            lbl_upper = new Label();
            lbl_lower = new Label();
            txt_n = new TextBox();
            txt_upper = new TextBox();
            txt_lower = new TextBox();
            btn_generationN = new Button();
            text_n = new TextBox();
            txt_desv = new TextBox();
            txt_media = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridUniformDistr).BeginInit();
            SuspendLayout();
            // 
            // btn_return
            // 
            btn_return.Location = new Point(950, 687);
            btn_return.Margin = new Padding(4, 5, 4, 5);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(176, 90);
            btn_return.TabIndex = 27;
            btn_return.Text = "Volver";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // cmb_interval
            // 
            cmb_interval.FormattingEnabled = true;
            cmb_interval.Items.AddRange(new object[] { "10", "15", "20", "25" });
            cmb_interval.Location = new Point(234, 267);
            cmb_interval.Margin = new Padding(4, 5, 4, 5);
            cmb_interval.Name = "cmb_interval";
            cmb_interval.Size = new Size(141, 33);
            cmb_interval.TabIndex = 26;
            // 
            // lbl_Interval
            // 
            lbl_Interval.AutoSize = true;
            lbl_Interval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Interval.Location = new Point(-143, -16);
            lbl_Interval.Margin = new Padding(4, 0, 4, 0);
            lbl_Interval.Name = "lbl_Interval";
            lbl_Interval.Size = new Size(136, 38);
            lbl_Interval.TabIndex = 25;
            lbl_Interval.Text = "Intervalos";
            // 
            // btn_draw
            // 
            btn_draw.Location = new Point(950, 559);
            btn_draw.Margin = new Padding(4, 5, 4, 5);
            btn_draw.Name = "btn_draw";
            btn_draw.Size = new Size(176, 90);
            btn_draw.TabIndex = 24;
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
            dt_gridData.Location = new Point(13, 485);
            dt_gridData.Margin = new Padding(4, 5, 4, 5);
            dt_gridData.Name = "dt_gridData";
            dt_gridData.ReadOnly = true;
            dt_gridData.RowHeadersWidth = 62;
            dt_gridData.RowTemplate.Height = 25;
            dt_gridData.Size = new Size(874, 310);
            dt_gridData.TabIndex = 23;
            dt_gridData.VirtualMode = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(24, 337);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(351, 38);
            progressBar.TabIndex = 22;
            // 
            // dt_gridUniformDistr
            // 
            dt_gridUniformDistr.AllowUserToAddRows = false;
            dt_gridUniformDistr.AllowUserToDeleteRows = false;
            dt_gridUniformDistr.AllowUserToResizeRows = false;
            dt_gridUniformDistr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridUniformDistr.Location = new Point(466, 31);
            dt_gridUniformDistr.Margin = new Padding(4, 5, 4, 5);
            dt_gridUniformDistr.Name = "dt_gridUniformDistr";
            dt_gridUniformDistr.ReadOnly = true;
            dt_gridUniformDistr.RowHeadersWidth = 62;
            dt_gridUniformDistr.RowTemplate.Height = 25;
            dt_gridUniformDistr.Size = new Size(640, 302);
            dt_gridUniformDistr.TabIndex = 21;
            dt_gridUniformDistr.VirtualMode = true;
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_n.Location = new Point(-143, -98);
            lbl_n.Margin = new Padding(4, 0, 4, 0);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(118, 38);
            lbl_n.TabIndex = 20;
            lbl_n.Text = "Muestra";
            // 
            // lbl_upper
            // 
            lbl_upper.AutoSize = true;
            lbl_upper.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_upper.Location = new Point(-143, -174);
            lbl_upper.Margin = new Padding(4, 0, 4, 0);
            lbl_upper.Name = "lbl_upper";
            lbl_upper.Size = new Size(205, 38);
            lbl_upper.TabIndex = 19;
            lbl_upper.Text = "Limite Superior";
            // 
            // lbl_lower
            // 
            lbl_lower.AutoSize = true;
            lbl_lower.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lower.Location = new Point(-143, -266);
            lbl_lower.Margin = new Padding(4, 0, 4, 0);
            lbl_lower.Name = "lbl_lower";
            lbl_lower.Size = new Size(190, 38);
            lbl_lower.TabIndex = 18;
            lbl_lower.Text = "Limite Inferior";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(66, -94);
            txt_n.Margin = new Padding(4, 5, 4, 5);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(141, 31);
            txt_n.TabIndex = 17;
            // 
            // txt_upper
            // 
            txt_upper.Location = new Point(66, -174);
            txt_upper.Margin = new Padding(4, 5, 4, 5);
            txt_upper.Name = "txt_upper";
            txt_upper.Size = new Size(141, 31);
            txt_upper.TabIndex = 16;
            // 
            // txt_lower
            // 
            txt_lower.Location = new Point(66, -266);
            txt_lower.Margin = new Padding(4, 5, 4, 5);
            txt_lower.Name = "txt_lower";
            txt_lower.Size = new Size(141, 31);
            txt_lower.TabIndex = 15;
            // 
            // btn_generationN
            // 
            btn_generationN.Location = new Point(102, 385);
            btn_generationN.Margin = new Padding(4, 5, 4, 5);
            btn_generationN.Name = "btn_generationN";
            btn_generationN.Size = new Size(176, 90);
            btn_generationN.TabIndex = 14;
            btn_generationN.Text = "Generar";
            btn_generationN.UseVisualStyleBackColor = true;
            btn_generationN.Click += btn_generationN_Click;
            // 
            // text_n
            // 
            text_n.Location = new Point(234, 193);
            text_n.Margin = new Padding(4, 5, 4, 5);
            text_n.Name = "text_n";
            text_n.Size = new Size(141, 31);
            text_n.TabIndex = 28;
            // 
            // txt_desv
            // 
            txt_desv.Location = new Point(234, 117);
            txt_desv.Margin = new Padding(4, 5, 4, 5);
            txt_desv.Name = "txt_desv";
            txt_desv.Size = new Size(141, 31);
            txt_desv.TabIndex = 29;
            // 
            // txt_media
            // 
            txt_media.Location = new Point(234, 38);
            txt_media.Margin = new Padding(4, 5, 4, 5);
            txt_media.Name = "txt_media";
            txt_media.Size = new Size(141, 31);
            txt_media.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 267);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 38);
            label1.TabIndex = 34;
            label1.Text = "Intervalos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 33;
            label2.Text = "Muestra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 110);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 38);
            label3.TabIndex = 32;
            label3.Text = "Desviacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 38);
            label4.TabIndex = 31;
            label4.Text = "Media";
            // 
            // NormalDistribution
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 830);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_media);
            Controls.Add(txt_desv);
            Controls.Add(text_n);
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
            Controls.Add(btn_generationN);
            Name = "NormalDistribution";
            Text = "NormalDistribution";
            ((System.ComponentModel.ISupportInitialize)dt_gridData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_gridUniformDistr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_return;
        private ComboBox cmb_interval;
        private Label lbl_Interval;
        private Button btn_draw;
        private DataGridView dt_gridData;
        private ProgressBar progressBar;
        private DataGridView dt_gridUniformDistr;
        private Label lbl_n;
        private Label lbl_upper;
        private Label lbl_lower;
        private TextBox txt_n;
        private TextBox txt_upper;
        private TextBox txt_lower;
        private Button btn_generationN;
        private TextBox text_n;
        private TextBox txt_desv;
        private TextBox txt_media;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}