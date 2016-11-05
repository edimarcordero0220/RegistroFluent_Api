namespace RegistroFluent_Api.Registros
{
    partial class RegitrarGrupos
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
            this.components = new System.ComponentModel.Container();
            this.NombreGrupotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreGrupotextBox
            // 
            this.NombreGrupotextBox.Location = new System.Drawing.Point(75, 106);
            this.NombreGrupotextBox.Name = "NombreGrupotextBox";
            this.NombreGrupotextBox.Size = new System.Drawing.Size(199, 20);
            this.NombreGrupotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Grupo";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(199, 181);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 56);
            this.Guardarbutton.TabIndex = 2;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID del Grupo";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(75, 47);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(62, 20);
            this.IdtextBox.TabIndex = 4;
            this.IdtextBox.TextChanged += new System.EventHandler(this.IdtextBox_TextChanged);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(99, 181);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 56);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(12, 181);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 56);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(292, 181);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 53);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RegitrarGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 320);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreGrupotextBox);
            this.Name = "RegitrarGrupos";
            this.Text = "RegitrarGrupos";
            this.Load += new System.EventHandler(this.RegitrarGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreGrupotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}