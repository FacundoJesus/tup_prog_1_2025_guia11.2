namespace Ejercicio1
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
            btnRegistrarNumero = new Button();
            tbIngresoNumero = new TextBox();
            label1 = new Label();
            gb2 = new GroupBox();
            btnMaxYMin = new Button();
            lbMinimo = new Label();
            lbMaximo = new Label();
            label3 = new Label();
            label2 = new Label();
            gb3 = new GroupBox();
            btnPromedio = new Button();
            lbPromedio = new Label();
            label4 = new Label();
            gb4 = new GroupBox();
            btnCantidadIngresos = new Button();
            lbCantidadIngresos = new Label();
            label5 = new Label();
            gb5 = new GroupBox();
            tbValorBuscado = new TextBox();
            btnBuscar = new Button();
            label6 = new Label();
            gb6 = new GroupBox();
            btnListaSuperiorAlPromedio = new Button();
            btnMostrarListaOrdenada = new Button();
            tbListas = new TextBox();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            gb3.SuspendLayout();
            gb4.SuspendLayout();
            gb5.SuspendLayout();
            gb6.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(btnRegistrarNumero);
            gb1.Controls.Add(tbIngresoNumero);
            gb1.Controls.Add(label1);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(391, 100);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Procesar un número";
            // 
            // btnRegistrarNumero
            // 
            btnRegistrarNumero.Location = new Point(270, 37);
            btnRegistrarNumero.Name = "btnRegistrarNumero";
            btnRegistrarNumero.Size = new Size(115, 41);
            btnRegistrarNumero.TabIndex = 2;
            btnRegistrarNumero.Text = "Registrar Número";
            btnRegistrarNumero.UseVisualStyleBackColor = true;
            btnRegistrarNumero.Click += btnRegistrarNumero_Click;
            // 
            // tbIngresoNumero
            // 
            tbIngresoNumero.Location = new Point(149, 44);
            tbIngresoNumero.Name = "tbIngresoNumero";
            tbIngresoNumero.Size = new Size(100, 23);
            tbIngresoNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número:";
            // 
            // gb2
            // 
            gb2.Controls.Add(btnMaxYMin);
            gb2.Controls.Add(lbMinimo);
            gb2.Controls.Add(lbMaximo);
            gb2.Controls.Add(label3);
            gb2.Controls.Add(label2);
            gb2.Location = new Point(12, 118);
            gb2.Name = "gb2";
            gb2.Size = new Size(391, 100);
            gb2.TabIndex = 1;
            gb2.TabStop = false;
            gb2.Text = "Procesar máximo y mínimo";
            // 
            // btnMaxYMin
            // 
            btnMaxYMin.Location = new Point(270, 41);
            btnMaxYMin.Name = "btnMaxYMin";
            btnMaxYMin.Size = new Size(115, 41);
            btnMaxYMin.TabIndex = 3;
            btnMaxYMin.Text = "Actualizar";
            btnMaxYMin.UseVisualStyleBackColor = true;
            btnMaxYMin.Click += btnMaxYMin_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.Location = new Point(185, 67);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(12, 15);
            lbMinimo.TabIndex = 4;
            lbMinimo.Text = "-";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.Location = new Point(185, 32);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(12, 15);
            lbMaximo.TabIndex = 3;
            lbMaximo.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 67);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor mínimo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 32);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor máximo:";
            // 
            // gb3
            // 
            gb3.Controls.Add(btnPromedio);
            gb3.Controls.Add(lbPromedio);
            gb3.Controls.Add(label4);
            gb3.Location = new Point(12, 224);
            gb3.Name = "gb3";
            gb3.Size = new Size(391, 85);
            gb3.TabIndex = 2;
            gb3.TabStop = false;
            gb3.Text = "Procesar promedio";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(270, 29);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(115, 41);
            btnPromedio.TabIndex = 5;
            btnPromedio.Text = "Actualizar";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(185, 42);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(12, 15);
            lbPromedio.TabIndex = 5;
            lbPromedio.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 42);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Promedio:";
            // 
            // gb4
            // 
            gb4.Controls.Add(btnCantidadIngresos);
            gb4.Controls.Add(lbCantidadIngresos);
            gb4.Controls.Add(label5);
            gb4.Location = new Point(12, 315);
            gb4.Name = "gb4";
            gb4.Size = new Size(391, 88);
            gb4.TabIndex = 3;
            gb4.TabStop = false;
            gb4.Text = "Mostrar Cantidad de ingresados";
            // 
            // btnCantidadIngresos
            // 
            btnCantidadIngresos.Location = new Point(270, 33);
            btnCantidadIngresos.Name = "btnCantidadIngresos";
            btnCantidadIngresos.Size = new Size(115, 41);
            btnCantidadIngresos.TabIndex = 6;
            btnCantidadIngresos.Text = "Actualizar";
            btnCantidadIngresos.UseVisualStyleBackColor = true;
            btnCantidadIngresos.Click += btnCantidadIngresos_Click;
            // 
            // lbCantidadIngresos
            // 
            lbCantidadIngresos.AutoSize = true;
            lbCantidadIngresos.Location = new Point(185, 46);
            lbCantidadIngresos.Name = "lbCantidadIngresos";
            lbCantidadIngresos.Size = new Size(12, 15);
            lbCantidadIngresos.TabIndex = 6;
            lbCantidadIngresos.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 46);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad:";
            // 
            // gb5
            // 
            gb5.Controls.Add(tbValorBuscado);
            gb5.Controls.Add(btnBuscar);
            gb5.Controls.Add(label6);
            gb5.Location = new Point(417, 12);
            gb5.Name = "gb5";
            gb5.Size = new Size(383, 100);
            gb5.TabIndex = 4;
            gb5.TabStop = false;
            gb5.Text = "Buscar un número";
            // 
            // tbValorBuscado
            // 
            tbValorBuscado.Location = new Point(95, 44);
            tbValorBuscado.Name = "tbValorBuscado";
            tbValorBuscado.Size = new Size(134, 23);
            tbValorBuscado.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(248, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 41);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 47);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 3;
            label6.Text = "Valor a buscar:";
            // 
            // gb6
            // 
            gb6.Controls.Add(btnListaSuperiorAlPromedio);
            gb6.Controls.Add(btnMostrarListaOrdenada);
            gb6.Controls.Add(tbListas);
            gb6.Location = new Point(417, 118);
            gb6.Name = "gb6";
            gb6.Size = new Size(383, 287);
            gb6.TabIndex = 5;
            gb6.TabStop = false;
            gb6.Text = "Mostrar Lista";
            // 
            // btnListaSuperiorAlPromedio
            // 
            btnListaSuperiorAlPromedio.Location = new Point(248, 170);
            btnListaSuperiorAlPromedio.Name = "btnListaSuperiorAlPromedio";
            btnListaSuperiorAlPromedio.Size = new Size(115, 63);
            btnListaSuperiorAlPromedio.TabIndex = 5;
            btnListaSuperiorAlPromedio.Text = "Mostrar Lista Superior al Promedio";
            btnListaSuperiorAlPromedio.UseVisualStyleBackColor = true;
            btnListaSuperiorAlPromedio.Click += btnListaSuperiorAlPromedio_Click;
            // 
            // btnMostrarListaOrdenada
            // 
            btnMostrarListaOrdenada.Location = new Point(248, 67);
            btnMostrarListaOrdenada.Name = "btnMostrarListaOrdenada";
            btnMostrarListaOrdenada.Size = new Size(115, 46);
            btnMostrarListaOrdenada.TabIndex = 4;
            btnMostrarListaOrdenada.Text = "Mostrar Lista Ordenada";
            btnMostrarListaOrdenada.UseVisualStyleBackColor = true;
            btnMostrarListaOrdenada.Click += btnMostrarListaOrdenada_Click;
            // 
            // tbListas
            // 
            tbListas.Location = new Point(6, 29);
            tbListas.Multiline = true;
            tbListas.Name = "tbListas";
            tbListas.Size = new Size(223, 242);
            tbListas.TabIndex = 0;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 417);
            Controls.Add(gb6);
            Controls.Add(gb5);
            Controls.Add(gb4);
            Controls.Add(gb3);
            Controls.Add(gb2);
            Controls.Add(gb1);
            Name = "FormularioPrincipal";
            Text = "Ejercicio 1 - Un solo vector ";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            gb3.ResumeLayout(false);
            gb3.PerformLayout();
            gb4.ResumeLayout(false);
            gb4.PerformLayout();
            gb5.ResumeLayout(false);
            gb5.PerformLayout();
            gb6.ResumeLayout(false);
            gb6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private GroupBox gb2;
        private GroupBox gb3;
        private GroupBox gb4;
        private GroupBox gb5;
        private TextBox tbIngresoNumero;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private GroupBox gb6;
        private Button btnRegistrarNumero;
        private Button btnMaxYMin;
        private Label lbMinimo;
        private Label lbMaximo;
        private Label lbPromedio;
        private Label lbCantidadIngresos;
        private TextBox tbValorBuscado;
        private Button btnBuscar;
        private Label label6;
        private Button btnPromedio;
        private Button btnCantidadIngresos;
        private Button btnMostrarListaOrdenada;
        private TextBox tbListas;
        private Button btnListaSuperiorAlPromedio;
    }
}
