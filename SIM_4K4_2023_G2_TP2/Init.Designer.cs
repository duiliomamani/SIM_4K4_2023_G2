namespace SIM_4K4_2023_G2_TP2
{
    partial class Init
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
            btn_uniform = new Button();
            btn_exp = new Button();
            btn_normal = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_uniform
            // 
            btn_uniform.Location = new Point(82, 24);
            btn_uniform.Name = "btn_uniform";
            btn_uniform.Size = new Size(178, 79);
            btn_uniform.TabIndex = 0;
            btn_uniform.Text = "Generador Uniforme";
            btn_uniform.UseVisualStyleBackColor = true;
            btn_uniform.Click += btn_uniform_Click;
            // 
            // btn_exp
            // 
            btn_exp.Location = new Point(82, 128);
            btn_exp.Name = "btn_exp";
            btn_exp.Size = new Size(178, 81);
            btn_exp.TabIndex = 1;
            btn_exp.Text = "Generador Exponencial";
            btn_exp.UseVisualStyleBackColor = true;
            btn_exp.Click += btn_exp_Click;
            // 
            // btn_normal
            // 
            btn_normal.Location = new Point(82, 240);
            btn_normal.Name = "btn_normal";
            btn_normal.Size = new Size(178, 81);
            btn_normal.TabIndex = 2;
            btn_normal.Text = "Generador Normal";
            btn_normal.UseVisualStyleBackColor = true;
            btn_normal.Click += btn_normal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 376);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 3;
            label1.Text = "SIM - 2023 - 4K4 - Grupo 2";
            // 
            // Init
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 450);
            Controls.Add(label1);
            Controls.Add(btn_normal);
            Controls.Add(btn_exp);
            Controls.Add(btn_uniform);
            Name = "Init";
            Text = "Init";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_uniform;
        private Button btn_exp;
        private Button btn_normal;
        private Label label1;
    }
}