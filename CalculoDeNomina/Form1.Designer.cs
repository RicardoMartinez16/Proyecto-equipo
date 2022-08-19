namespace CalculoDeNomina
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtxSalarioDia = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.btnCalculoSalario = new System.Windows.Forms.Button();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtxapellidom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txthorasextra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpago_ho_ex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtseguro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seguro_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de nómina semanal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. control:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(273, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario por día:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(503, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Días laborados:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 21);
            this.txtNombre.TabIndex = 6;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(88, 31);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 21);
            this.txtIdentificacion.TabIndex = 7;
            // 
            // txtxSalarioDia
            // 
            this.txtxSalarioDia.Location = new System.Drawing.Point(384, 77);
            this.txtxSalarioDia.Name = "txtxSalarioDia";
            this.txtxSalarioDia.Size = new System.Drawing.Size(100, 21);
            this.txtxSalarioDia.TabIndex = 8;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(677, 12);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(28, 20);
            this.txtDiasLaborados.TabIndex = 9;
            this.txtDiasLaborados.Text = "7";
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.BackColor = System.Drawing.Color.Green;
            this.btnGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRegistro.Location = new System.Drawing.Point(33, 21);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarRegistro.TabIndex = 10;
            this.btnGuardarRegistro.Text = "Guardar";
            this.btnGuardarRegistro.UseVisualStyleBackColor = false;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnCalculoSalario
            // 
            this.btnCalculoSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalculoSalario.Location = new System.Drawing.Point(590, 136);
            this.btnCalculoSalario.Name = "btnCalculoSalario";
            this.btnCalculoSalario.Size = new System.Drawing.Size(108, 28);
            this.btnCalculoSalario.TabIndex = 11;
            this.btnCalculoSalario.Text = "Calcular Salario";
            this.btnCalculoSalario.UseVisualStyleBackColor = false;
            this.btnCalculoSalario.Click += new System.EventHandler(this.btnCalculoSalario_Click);
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.Location = new System.Drawing.Point(598, 73);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.Size = new System.Drawing.Size(100, 21);
            this.txtSalarioTotal.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(583, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtapellidop
            // 
            this.txtapellidop.Location = new System.Drawing.Point(152, 113);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(100, 21);
            this.txtapellidop.TabIndex = 15;
            // 
            // txtxapellidom
            // 
            this.txtxapellidom.Location = new System.Drawing.Point(152, 154);
            this.txtxapellidom.Name = "txtxapellidom";
            this.txtxapellidom.Size = new System.Drawing.Size(100, 21);
            this.txtxapellidom.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Apellido paterno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Apellido materno:";
            // 
            // txthorasextra
            // 
            this.txthorasextra.Location = new System.Drawing.Point(384, 113);
            this.txthorasextra.Name = "txthorasextra";
            this.txthorasextra.Size = new System.Drawing.Size(100, 21);
            this.txthorasextra.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(273, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Horas extra:";
            // 
            // txtpago_ho_ex
            // 
            this.txtpago_ho_ex.Location = new System.Drawing.Point(676, 38);
            this.txtpago_ho_ex.Name = "txtpago_ho_ex";
            this.txtpago_ho_ex.Size = new System.Drawing.Size(29, 20);
            this.txtpago_ho_ex.TabIndex = 21;
            this.txtpago_ho_ex.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hora extra:";
            // 
            // txtseguro
            // 
            this.txtseguro.Location = new System.Drawing.Point(384, 150);
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(100, 21);
            this.txtseguro.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(270, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 30);
            this.label11.TabIndex = 24;
            this.label11.Text = "Descuento \r\nSeguro medico:";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(642, 64);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(64, 20);
            this.txtfecha.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Fecha:";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(152, 193);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(100, 21);
            this.txtpuesto.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(26, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "Puesto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtpuesto);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtseguro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txthorasextra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCalculoSalario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtxapellidom);
            this.groupBox1.Controls.Add(this.txtapellidop);
            this.groupBox1.Controls.Add(this.txtSalarioTotal);
            this.groupBox1.Controls.Add(this.txtxSalarioDia);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 231);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(232, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 23);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Navy;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(416, 21);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 23);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnGuardarRegistro);
            this.groupBox2.Location = new System.Drawing.Point(15, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 64);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.No_Control,
            this.Nombre,
            this.Apellido_p,
            this.Apellido_m,
            this.Puesto,
            this.Salario_dia,
            this.Horas_extra,
            this.Seguro_medico,
            this.Salario_total,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(48, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // No_Control
            // 
            this.No_Control.HeaderText = "No_control";
            this.No_Control.Name = "No_Control";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido_p
            // 
            this.Apellido_p.HeaderText = "Apellido_p";
            this.Apellido_p.Name = "Apellido_p";
            // 
            // Apellido_m
            // 
            this.Apellido_m.HeaderText = "Apellido_m";
            this.Apellido_m.Name = "Apellido_m";
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // Salario_dia
            // 
            this.Salario_dia.HeaderText = "Salario_dia";
            this.Salario_dia.Name = "Salario_dia";
            // 
            // Horas_extra
            // 
            this.Horas_extra.HeaderText = "Horas_extra";
            this.Horas_extra.Name = "Horas_extra";
            // 
            // Seguro_medico
            // 
            this.Seguro_medico.HeaderText = "Seguro_medico";
            this.Seguro_medico.Name = "Seguro_medico";
            // 
            // Salario_total
            // 
            this.Salario_total.HeaderText = "Salario_total";
            this.Salario_total.Name = "Salario_total";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(738, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpago_ho_ex);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo de Nómina";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtxSalarioDia;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.Button btnCalculoSalario;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtxapellidom;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txthorasextra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpago_ho_ex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtseguro;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_extra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seguro_medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}

