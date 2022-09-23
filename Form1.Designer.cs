namespace FormularioComplejos
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
            this.txtbComplejo = new System.Windows.Forms.TextBox();
            this.lbComplejo1 = new System.Windows.Forms.Label();
            this.lbComplejo2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbComplejo
            // 
            this.txtbComplejo.Location = new System.Drawing.Point(55, 60);
            this.txtbComplejo.Name = "txtbComplejo";
            this.txtbComplejo.Size = new System.Drawing.Size(279, 20);
            this.txtbComplejo.TabIndex = 0;
            // 
            // lbComplejo1
            // 
            this.lbComplejo1.AutoSize = true;
            this.lbComplejo1.Location = new System.Drawing.Point(52, 111);
            this.lbComplejo1.Name = "lbComplejo1";
            this.lbComplejo1.Size = new System.Drawing.Size(31, 15);
            this.lbComplejo1.TabIndex = 1;
            this.lbComplejo1.Text = "5+4j";
            // 
            // lbComplejo2
            // 
            this.lbComplejo2.AutoSize = true;
            this.lbComplejo2.Location = new System.Drawing.Point(211, 111);
            this.lbComplejo2.Name = "lbComplejo2";
            this.lbComplejo2.Size = new System.Drawing.Size(31, 15);
            this.lbComplejo2.TabIndex = 1;
            this.lbComplejo2.Text = "7+8j";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(422, 111);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(14, 15);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "=";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(205, 178);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 37);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 255);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbComplejo2);
            this.Controls.Add(this.lbComplejo1);
            this.Controls.Add(this.txtbComplejo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbComplejo;
        private System.Windows.Forms.Label lbComplejo1;
        private System.Windows.Forms.Label lbComplejo2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSumar;
    }
}

