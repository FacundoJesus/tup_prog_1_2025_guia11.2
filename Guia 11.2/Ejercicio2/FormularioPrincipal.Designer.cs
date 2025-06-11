namespace Ejercicio2
{
    partial class FormularioPrincipal
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
            gb1 = new GroupBox();
            tbNota = new TextBox();
            tbNombre = new TextBox();
            tbLibreta = new TextBox();
            btnRegistrarAlumno = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gb2 = new GroupBox();
            btnListaSuperiorPromedio = new Button();
            btnListaOrdenada = new Button();
            btnPromedio = new Button();
            btnCantidadAlumnos = new Button();
            btnMayoryMenor = new Button();
            tbResultado = new TextBox();
            btnBuscarNLibreta = new Button();
            tbBuscarLibreta = new TextBox();
            label4 = new Label();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(tbNota);
            gb1.Controls.Add(tbNombre);
            gb1.Controls.Add(tbLibreta);
            gb1.Controls.Add(btnRegistrarAlumno);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(401, 172);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Registro de alumno";
            // 
            // tbNota
            // 
            tbNota.Location = new Point(134, 127);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(100, 23);
            tbNota.TabIndex = 2;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(134, 80);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 1;
            // 
            // tbLibreta
            // 
            tbLibreta.Location = new Point(134, 32);
            tbLibreta.Name = "tbLibreta";
            tbLibreta.Size = new Size(100, 23);
            tbLibreta.TabIndex = 0;
            // 
            // btnRegistrarAlumno
            // 
            btnRegistrarAlumno.Location = new Point(298, 67);
            btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            btnRegistrarAlumno.Size = new Size(97, 47);
            btnRegistrarAlumno.TabIndex = 3;
            btnRegistrarAlumno.Text = "Registrar Alumno";
            btnRegistrarAlumno.UseVisualStyleBackColor = true;
            btnRegistrarAlumno.Click += btnRegistrarAlumno_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Libreta:";
            // 
            // gb2
            // 
            gb2.Controls.Add(btnListaSuperiorPromedio);
            gb2.Controls.Add(btnListaOrdenada);
            gb2.Controls.Add(btnPromedio);
            gb2.Controls.Add(btnCantidadAlumnos);
            gb2.Controls.Add(btnMayoryMenor);
            gb2.Controls.Add(tbResultado);
            gb2.Controls.Add(btnBuscarNLibreta);
            gb2.Controls.Add(tbBuscarLibreta);
            gb2.Controls.Add(label4);
            gb2.Location = new Point(12, 193);
            gb2.Name = "gb2";
            gb2.Size = new Size(401, 356);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            gb2.Text = "Resultados";
            // 
            // btnListaSuperiorPromedio
            // 
            btnListaSuperiorPromedio.Location = new Point(298, 289);
            btnListaSuperiorPromedio.Name = "btnListaSuperiorPromedio";
            btnListaSuperiorPromedio.Size = new Size(97, 54);
            btnListaSuperiorPromedio.TabIndex = 10;
            btnListaSuperiorPromedio.Text = "Mostrar Lista Superior al Promedio";
            btnListaSuperiorPromedio.UseVisualStyleBackColor = true;
            btnListaSuperiorPromedio.Click += btnListaSuperiorPromedio_Click;
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(298, 237);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(97, 47);
            btnListaOrdenada.TabIndex = 9;
            btnListaOrdenada.Text = "Mostrar Lista Ordenada";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(298, 184);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(97, 47);
            btnPromedio.TabIndex = 8;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnCantidadAlumnos
            // 
            btnCantidadAlumnos.Location = new Point(298, 131);
            btnCantidadAlumnos.Name = "btnCantidadAlumnos";
            btnCantidadAlumnos.Size = new Size(97, 47);
            btnCantidadAlumnos.TabIndex = 7;
            btnCantidadAlumnos.Text = "Cantidad de Alumnos";
            btnCantidadAlumnos.UseVisualStyleBackColor = true;
            btnCantidadAlumnos.Click += btnCantidadAlumnos_Click;
            // 
            // btnMayoryMenor
            // 
            btnMayoryMenor.Location = new Point(298, 78);
            btnMayoryMenor.Name = "btnMayoryMenor";
            btnMayoryMenor.Size = new Size(97, 47);
            btnMayoryMenor.TabIndex = 6;
            btnMayoryMenor.Text = "Alumno mayor y menor nota";
            btnMayoryMenor.UseVisualStyleBackColor = true;
            btnMayoryMenor.Click += btnMayoryMenor_Click;
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbResultado.Location = new Point(17, 78);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.ReadOnly = true;
            tbResultado.Size = new Size(264, 265);
            tbResultado.TabIndex = 9;
            // 
            // btnBuscarNLibreta
            // 
            btnBuscarNLibreta.Location = new Point(298, 31);
            btnBuscarNLibreta.Name = "btnBuscarNLibreta";
            btnBuscarNLibreta.Size = new Size(97, 23);
            btnBuscarNLibreta.TabIndex = 5;
            btnBuscarNLibreta.Text = "Buscar";
            btnBuscarNLibreta.UseVisualStyleBackColor = true;
            btnBuscarNLibreta.Click += btnBuscarNLibreta_Click;
            // 
            // tbBuscarLibreta
            // 
            tbBuscarLibreta.Location = new Point(134, 31);
            tbBuscarLibreta.Name = "tbBuscarLibreta";
            tbBuscarLibreta.Size = new Size(100, 23);
            tbBuscarLibreta.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 34);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Libreta:";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 561);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Name = "FormularioPrincipal";
            Text = "Ejercicio 2 - Vectores con índice compartido";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private GroupBox gb2;
        private TextBox tbNota;
        private TextBox tbNombre;
        private TextBox tbLibreta;
        private Button btnRegistrarAlumno;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBuscarNLibreta;
        private TextBox tbBuscarLibreta;
        private Label label4;
        private Button btnListaSuperiorPromedio;
        private Button btnListaOrdenada;
        private Button btnPromedio;
        private Button btnCantidadAlumnos;
        private Button btnMayoryMenor;
        private TextBox tbResultado;
    }
}
