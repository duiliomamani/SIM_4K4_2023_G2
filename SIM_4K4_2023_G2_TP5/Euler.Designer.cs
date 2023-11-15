namespace SIM_4K4_2023_G2_TP2
{
    partial class Euler
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
            lbl_Interval = new Label();
            dt_gridData = new DataGridView();
            lbl_n = new Label();
            lbl_upper = new Label();
            lbl_lower = new Label();
            txt_n = new TextBox();
            txt_upper = new TextBox();
            txt_lower = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dt_gridData).BeginInit();
            SuspendLayout();
            // 
            // btn_return
            // 
            btn_return.Location = new Point(645, 423);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(123, 54);
            btn_return.TabIndex = 27;
            btn_return.Text = "Volver";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // lbl_Interval
            // 
            lbl_Interval.AutoSize = true;
            lbl_Interval.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Interval.Location = new Point(-100, -10);
            lbl_Interval.Name = "lbl_Interval";
            lbl_Interval.Size = new Size(94, 25);
            lbl_Interval.TabIndex = 25;
            lbl_Interval.Text = "Intervalos";
            // 
            // dt_gridData
            // 
            dt_gridData.AllowUserToAddRows = false;
            dt_gridData.AllowUserToDeleteRows = false;
            dt_gridData.AllowUserToResizeRows = false;
            dt_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridData.Location = new Point(9, 12);
            dt_gridData.Name = "dt_gridData";
            dt_gridData.ReadOnly = true;
            dt_gridData.RowHeadersWidth = 62;
            dt_gridData.RowTemplate.Height = 25;
            dt_gridData.Size = new Size(612, 465);
            dt_gridData.TabIndex = 23;
            dt_gridData.VirtualMode = true;
            // 
            // lbl_n
            // 
            lbl_n.AutoSize = true;
            lbl_n.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_n.Location = new Point(-100, -59);
            lbl_n.Name = "lbl_n";
            lbl_n.Size = new Size(81, 25);
            lbl_n.TabIndex = 20;
            lbl_n.Text = "Muestra";
            // 
            // lbl_upper
            // 
            lbl_upper.AutoSize = true;
            lbl_upper.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_upper.Location = new Point(-100, -104);
            lbl_upper.Name = "lbl_upper";
            lbl_upper.Size = new Size(140, 25);
            lbl_upper.TabIndex = 19;
            lbl_upper.Text = "Limite Superior";
            // 
            // lbl_lower
            // 
            lbl_lower.AutoSize = true;
            lbl_lower.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lower.Location = new Point(-100, -160);
            lbl_lower.Name = "lbl_lower";
            lbl_lower.Size = new Size(130, 25);
            lbl_lower.TabIndex = 18;
            lbl_lower.Text = "Limite Inferior";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(46, -56);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 17;
            // 
            // txt_upper
            // 
            txt_upper.Location = new Point(46, -104);
            txt_upper.Name = "txt_upper";
            txt_upper.Size = new Size(100, 23);
            txt_upper.TabIndex = 16;
            // 
            // txt_lower
            // 
            txt_lower.Location = new Point(46, -160);
            txt_lower.Name = "txt_lower";
            txt_lower.Size = new Size(100, 23);
            txt_lower.TabIndex = 15;
            // 
            // Euler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 498);
            Controls.Add(btn_return);
            Controls.Add(lbl_Interval);
            Controls.Add(dt_gridData);
            Controls.Add(lbl_n);
            Controls.Add(lbl_upper);
            Controls.Add(lbl_lower);
            Controls.Add(txt_n);
            Controls.Add(txt_upper);
            Controls.Add(txt_lower);
            Margin = new Padding(2);
            Name = "Euler";
            Text = "Euler";
            ((System.ComponentModel.ISupportInitialize)dt_gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_return;
        private Label lbl_Interval;
        private DataGridView dt_gridData;
        private Label lbl_n;
        private Label lbl_upper;
        private Label lbl_lower;
        private TextBox txt_n;
        private TextBox txt_upper;
        private TextBox txt_lower;
    }
}