namespace WindowsPresentacion
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
            this.btnListarMedicos = new System.Windows.Forms.Button();
            this.btnMostarListaMedicos = new System.Windows.Forms.Button();
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.lstMedicosClinicos = new System.Windows.Forms.ListBox();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.btnMostarListaPacientes = new System.Windows.Forms.Button();
            this.btnContarYMostrarClinicos = new System.Windows.Forms.Button();
            this.btnContaryListarHabitaciones = new System.Windows.Forms.Button();
            this.btnListarHabitaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarMedicos
            // 
            this.btnListarMedicos.Location = new System.Drawing.Point(28, 47);
            this.btnListarMedicos.Name = "btnListarMedicos";
            this.btnListarMedicos.Size = new System.Drawing.Size(138, 23);
            this.btnListarMedicos.TabIndex = 0;
            this.btnListarMedicos.Text = "Listar Medicos";
            this.btnListarMedicos.UseVisualStyleBackColor = true;
            this.btnListarMedicos.Click += new System.EventHandler(this.btnListarMedicos_Click);
            // 
            // btnMostarListaMedicos
            // 
            this.btnMostarListaMedicos.Location = new System.Drawing.Point(80, 219);
            this.btnMostarListaMedicos.Name = "btnMostarListaMedicos";
            this.btnMostarListaMedicos.Size = new System.Drawing.Size(138, 20);
            this.btnMostarListaMedicos.TabIndex = 1;
            this.btnMostarListaMedicos.Text = "Mostrar Medicos";
            this.btnMostarListaMedicos.UseVisualStyleBackColor = true;
            this.btnMostarListaMedicos.Click += new System.EventHandler(this.btnMostarListaMedicos_Click);
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(28, 257);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(240, 150);
            this.gridMedicos.TabIndex = 3;
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(293, 257);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.Size = new System.Drawing.Size(240, 150);
            this.gridPacientes.TabIndex = 4;
            // 
            // lstMedicosClinicos
            // 
            this.lstMedicosClinicos.FormattingEnabled = true;
            this.lstMedicosClinicos.Location = new System.Drawing.Point(655, 47);
            this.lstMedicosClinicos.Name = "lstMedicosClinicos";
            this.lstMedicosClinicos.Size = new System.Drawing.Size(120, 95);
            this.lstMedicosClinicos.TabIndex = 5;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(655, 279);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(120, 95);
            this.lstHabitaciones.TabIndex = 6;
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.Location = new System.Drawing.Point(213, 47);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(138, 23);
            this.btnListarPacientes.TabIndex = 7;
            this.btnListarPacientes.Text = "Listar Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = true;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // btnMostarListaPacientes
            // 
            this.btnMostarListaPacientes.Location = new System.Drawing.Point(347, 219);
            this.btnMostarListaPacientes.Name = "btnMostarListaPacientes";
            this.btnMostarListaPacientes.Size = new System.Drawing.Size(138, 20);
            this.btnMostarListaPacientes.TabIndex = 8;
            this.btnMostarListaPacientes.Text = "Mostrar Pacientes";
            this.btnMostarListaPacientes.UseVisualStyleBackColor = true;
            this.btnMostarListaPacientes.Click += new System.EventHandler(this.btnMostarListaPacientes_Click);
            // 
            // btnContarYMostrarClinicos
            // 
            this.btnContarYMostrarClinicos.Location = new System.Drawing.Point(542, 72);
            this.btnContarYMostrarClinicos.Name = "btnContarYMostrarClinicos";
            this.btnContarYMostrarClinicos.Size = new System.Drawing.Size(107, 34);
            this.btnContarYMostrarClinicos.TabIndex = 9;
            this.btnContarYMostrarClinicos.Text = "Mostrar Medicos Clinicos";
            this.btnContarYMostrarClinicos.UseVisualStyleBackColor = true;
            this.btnContarYMostrarClinicos.Click += new System.EventHandler(this.btnContarYMostrarClinicos_Click);
            // 
            // btnContaryListarHabitaciones
            // 
            this.btnContaryListarHabitaciones.Location = new System.Drawing.Point(542, 309);
            this.btnContaryListarHabitaciones.Name = "btnContaryListarHabitaciones";
            this.btnContaryListarHabitaciones.Size = new System.Drawing.Size(107, 34);
            this.btnContaryListarHabitaciones.TabIndex = 10;
            this.btnContaryListarHabitaciones.Text = "Mostrar Habitaciones";
            this.btnContaryListarHabitaciones.UseVisualStyleBackColor = true;
            this.btnContaryListarHabitaciones.Click += new System.EventHandler(this.btnContaryListarHabitaciones_Click);
            // 
            // btnListarHabitaciones
            // 
            this.btnListarHabitaciones.Location = new System.Drawing.Point(395, 47);
            this.btnListarHabitaciones.Name = "btnListarHabitaciones";
            this.btnListarHabitaciones.Size = new System.Drawing.Size(138, 23);
            this.btnListarHabitaciones.TabIndex = 11;
            this.btnListarHabitaciones.Text = "Listar Habitaciones";
            this.btnListarHabitaciones.UseVisualStyleBackColor = true;
            this.btnListarHabitaciones.Click += new System.EventHandler(this.btnListarHabitaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarHabitaciones);
            this.Controls.Add(this.btnContaryListarHabitaciones);
            this.Controls.Add(this.btnContarYMostrarClinicos);
            this.Controls.Add(this.btnMostarListaPacientes);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lstMedicosClinicos);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.gridMedicos);
            this.Controls.Add(this.btnMostarListaMedicos);
            this.Controls.Add(this.btnListarMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarMedicos;
        private System.Windows.Forms.Button btnMostarListaMedicos;
        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.ListBox lstMedicosClinicos;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.Button btnMostarListaPacientes;
        private System.Windows.Forms.Button btnContarYMostrarClinicos;
        private System.Windows.Forms.Button btnContaryListarHabitaciones;
        private System.Windows.Forms.Button btnListarHabitaciones;
    }
}

