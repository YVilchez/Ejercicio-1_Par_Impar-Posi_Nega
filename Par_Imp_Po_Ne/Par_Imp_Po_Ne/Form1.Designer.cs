
namespace Par_Imp_Po_Ne
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_IngresoNu = new System.Windows.Forms.TextBox();
            this.BT_comp_info = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_par_imp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBsigno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un número entero: ";
            // 
            // TB_IngresoNu
            // 
            this.TB_IngresoNu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_IngresoNu.Location = new System.Drawing.Point(108, 98);
            this.TB_IngresoNu.Name = "TB_IngresoNu";
            this.TB_IngresoNu.Size = new System.Drawing.Size(39, 20);
            this.TB_IngresoNu.TabIndex = 2;
            // 
            // BT_comp_info
            // 
            this.BT_comp_info.Location = new System.Drawing.Point(56, 137);
            this.BT_comp_info.Name = "BT_comp_info";
            this.BT_comp_info.Size = new System.Drawing.Size(140, 24);
            this.BT_comp_info.TabIndex = 3;
            this.BT_comp_info.Text = "Comprobar Información";
            this.BT_comp_info.UseVisualStyleBackColor = true;
            this.BT_comp_info.Click += new System.EventHandler(this.BT_comp_info_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "El número es: ";
            // 
            // TB_par_imp
            // 
            this.TB_par_imp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TB_par_imp.Location = new System.Drawing.Point(157, 179);
            this.TB_par_imp.Name = "TB_par_imp";
            this.TB_par_imp.Size = new System.Drawing.Size(67, 20);
            this.TB_par_imp.TabIndex = 5;
            this.TB_par_imp.TextChanged += new System.EventHandler(this.TB_par_imp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Con signo: ";
            // 
            // TBsigno
            // 
            this.TBsigno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBsigno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TBsigno.Location = new System.Drawing.Point(157, 216);
            this.TBsigno.Name = "TBsigno";
            this.TBsigno.Size = new System.Drawing.Size(67, 20);
            this.TBsigno.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 269);
            this.Controls.Add(this.TBsigno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_par_imp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_comp_info);
            this.Controls.Add(this.TB_IngresoNu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_IngresoNu;
        private System.Windows.Forms.Button BT_comp_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_par_imp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBsigno;
    }
}

