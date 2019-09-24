namespace FrmPrincipal
{
    partial class FrmCatedra
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
            this.grpbAlumnos = new System.Windows.Forms.GroupBox();
            this.cmbAlumnos = new System.Windows.Forms.ComboBox();
            this.lstbAlumnos = new System.Windows.Forms.ListBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpbAlumnosCalificados = new System.Windows.Forms.GroupBox();
            this.lstbAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.grpbAlumnos.SuspendLayout();
            this.grpbAlumnosCalificados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbAlumnos
            // 
            this.grpbAlumnos.Controls.Add(this.cmbAlumnos);
            this.grpbAlumnos.Controls.Add(this.lstbAlumnos);
            this.grpbAlumnos.Controls.Add(this.btnCalificar);
            this.grpbAlumnos.Controls.Add(this.btnModificar);
            this.grpbAlumnos.Controls.Add(this.btnAgregar);
            this.grpbAlumnos.Location = new System.Drawing.Point(12, 12);
            this.grpbAlumnos.Name = "grpbAlumnos";
            this.grpbAlumnos.Size = new System.Drawing.Size(347, 214);
            this.grpbAlumnos.TabIndex = 0;
            this.grpbAlumnos.TabStop = false;
            this.grpbAlumnos.Text = "Alumnos";
            // 
            // cmbAlumnos
            // 
            this.cmbAlumnos.FormattingEnabled = true;
            this.cmbAlumnos.Location = new System.Drawing.Point(6, 185);
            this.cmbAlumnos.Name = "cmbAlumnos";
            this.cmbAlumnos.Size = new System.Drawing.Size(335, 21);
            this.cmbAlumnos.TabIndex = 4;
            // 
            // lstbAlumnos
            // 
            this.lstbAlumnos.FormattingEnabled = true;
            this.lstbAlumnos.Location = new System.Drawing.Point(6, 58);
            this.lstbAlumnos.Name = "lstbAlumnos";
            this.lstbAlumnos.Size = new System.Drawing.Size(335, 121);
            this.lstbAlumnos.TabIndex = 1;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(136, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(266, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpbAlumnosCalificados
            // 
            this.grpbAlumnosCalificados.Controls.Add(this.lstbAlumnosCalificados);
            this.grpbAlumnosCalificados.Location = new System.Drawing.Point(12, 232);
            this.grpbAlumnosCalificados.Name = "grpbAlumnosCalificados";
            this.grpbAlumnosCalificados.Size = new System.Drawing.Size(347, 176);
            this.grpbAlumnosCalificados.TabIndex = 1;
            this.grpbAlumnosCalificados.TabStop = false;
            this.grpbAlumnosCalificados.Text = "Alumnos Calificados";
            // 
            // lstbAlumnosCalificados
            // 
            this.lstbAlumnosCalificados.FormattingEnabled = true;
            this.lstbAlumnosCalificados.Location = new System.Drawing.Point(6, 19);
            this.lstbAlumnosCalificados.Name = "lstbAlumnosCalificados";
            this.lstbAlumnosCalificados.Size = new System.Drawing.Size(335, 147);
            this.lstbAlumnosCalificados.TabIndex = 5;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 420);
            this.Controls.Add(this.grpbAlumnosCalificados);
            this.Controls.Add(this.grpbAlumnos);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.grpbAlumnos.ResumeLayout(false);
            this.grpbAlumnosCalificados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbAlumnos;
        private System.Windows.Forms.ListBox lstbAlumnos;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbAlumnos;
        private System.Windows.Forms.GroupBox grpbAlumnosCalificados;
        private System.Windows.Forms.ListBox lstbAlumnosCalificados;
    }
}