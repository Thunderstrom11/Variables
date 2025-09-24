namespace Variables
{
    partial class Form1
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.lblVariableGlobal = new System.Windows.Forms.Label();
            this.btnVerificarGlobal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(47, 38);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(53, 16);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "nombre";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(47, 91);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(49, 16);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "codigo";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(98, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(207, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(98, 88);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 22);
            this.tbCodigo.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(50, 154);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(207, 50);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar (Local)";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(95, 240);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(90, 16);
            this.lblVariableLocal.TabIndex = 5;
            this.lblVariableLocal.Text = "Variable local";
            // 
            // lblVariableGlobal
            // 
            this.lblVariableGlobal.AutoSize = true;
            this.lblVariableGlobal.Location = new System.Drawing.Point(95, 304);
            this.lblVariableGlobal.Name = "lblVariableGlobal";
            this.lblVariableGlobal.Size = new System.Drawing.Size(101, 16);
            this.lblVariableGlobal.TabIndex = 6;
            this.lblVariableGlobal.Text = "Variable Global";
            // 
            // btnVerificarGlobal
            // 
            this.btnVerificarGlobal.Location = new System.Drawing.Point(286, 154);
            this.btnVerificarGlobal.Name = "btnVerificarGlobal";
            this.btnVerificarGlobal.Size = new System.Drawing.Size(188, 50);
            this.btnVerificarGlobal.TabIndex = 7;
            this.btnVerificarGlobal.Text = "Verificar (Global)";
            this.btnVerificarGlobal.UseVisualStyleBackColor = true;
            this.btnVerificarGlobal.Click += new System.EventHandler(this.btnVerificarGlobal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 522);
            this.Controls.Add(this.btnVerificarGlobal);
            this.Controls.Add(this.lblVariableGlobal);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label lblVariableGlobal;
        private System.Windows.Forms.Button btnVerificarGlobal;
    }
}

