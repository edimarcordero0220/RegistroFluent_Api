namespace RegistroFluent_Api
{
    partial class Detalles
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
            this.Insertarbutton = new System.Windows.Forms.Button();
            this.NombreGrupotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Seleccionarlabel = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstudiantedataGridView = new System.Windows.Forms.DataGridView();
            this.EstudiantescomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Insertarbutton
            // 
            this.Insertarbutton.Location = new System.Drawing.Point(212, 420);
            this.Insertarbutton.Name = "Insertarbutton";
            this.Insertarbutton.Size = new System.Drawing.Size(111, 54);
            this.Insertarbutton.TabIndex = 0;
            this.Insertarbutton.Text = "Insertar Estudiante";
            this.Insertarbutton.UseVisualStyleBackColor = true;
            this.Insertarbutton.Click += new System.EventHandler(this.Insertarbutton_Click);
            // 
            // NombreGrupotextBox
            // 
            this.NombreGrupotextBox.Location = new System.Drawing.Point(123, 84);
            this.NombreGrupotextBox.Name = "NombreGrupotextBox";
            this.NombreGrupotextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreGrupotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupo Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Grupo";
            // 
            // Seleccionarlabel
            // 
            this.Seleccionarlabel.AutoSize = true;
            this.Seleccionarlabel.Location = new System.Drawing.Point(14, 32);
            this.Seleccionarlabel.Name = "Seleccionarlabel";
            this.Seleccionarlabel.Size = new System.Drawing.Size(63, 13);
            this.Seleccionarlabel.TabIndex = 5;
            this.Seleccionarlabel.Text = "Seleccionar";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(29, 420);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(397, 27);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(248, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(80, 19);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox.TabIndex = 9;
            this.IdtextBox.TextChanged += new System.EventHandler(this.IdtextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EstudiantedataGridView);
            this.groupBox1.Controls.Add(this.EstudiantescomboBox);
            this.groupBox1.Controls.Add(this.Seleccionarlabel);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EstudiantedataGridView
            // 
            this.EstudiantedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantedataGridView.Location = new System.Drawing.Point(17, 65);
            this.EstudiantedataGridView.Name = "EstudiantedataGridView";
            this.EstudiantedataGridView.Size = new System.Drawing.Size(453, 174);
            this.EstudiantedataGridView.TabIndex = 6;
            this.EstudiantedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiantedataGridView_CellContentClick);
            // 
            // EstudiantescomboBox
            // 
            this.EstudiantescomboBox.FormattingEnabled = true;
            this.EstudiantescomboBox.Location = new System.Drawing.Point(83, 29);
            this.EstudiantescomboBox.Name = "EstudiantescomboBox";
            this.EstudiantescomboBox.Size = new System.Drawing.Size(308, 21);
            this.EstudiantescomboBox.TabIndex = 0;
            this.EstudiantescomboBox.SelectedIndexChanged += new System.EventHandler(this.EstudiantescomboBox_SelectedIndexChanged);
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreGrupotextBox);
            this.Controls.Add(this.Insertarbutton);
            this.Name = "Detalles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Detalles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insertarbutton;
        private System.Windows.Forms.TextBox NombreGrupotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Seleccionarlabel;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EstudiantedataGridView;
        private System.Windows.Forms.ComboBox EstudiantescomboBox;
    }
}

