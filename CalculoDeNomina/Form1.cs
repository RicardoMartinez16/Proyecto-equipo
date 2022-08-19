using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoDeNomina
{
    public partial class Form1 : Form
    {
        Empleado mi_empleado = new Empleado();
        Nomina mi_nomina = new Nomina();

        int i = 1, posicion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            //Validar No. control
            if (txtIdentificacion.Text == "")
            {
                errorProvider1.SetError(txtIdentificacion, "Por favor, ingresar número de control");
                txtIdentificacion.Focus();
                return;
            }
            errorProvider1.SetError(txtIdentificacion, "");

            //Ingresar el nombre
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar su nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            //Validar solo datos numericos
            decimal AsignacionDia;
            if (!Decimal.TryParse(txtxSalarioDia.Text, out AsignacionDia))
            {
                errorProvider1.SetError(txtxSalarioDia, "Debe ingresar un numero");
                txtxSalarioDia.Focus();
                return;
            }
            errorProvider1.SetError(txtxSalarioDia, "");

            string nombre, apellidop, apellidom, puesto, fecha;
            int salariodia, horaextra, seguro, total, nocontrol;

            nombre = txtNombre.Text;
            apellidop = txtapellidop.Text;
            apellidom = txtxapellidom.Text;
            puesto = txtpuesto.Text;
            salariodia = Convert.ToInt32(txtxSalarioDia.Text);
            horaextra = Convert.ToInt32(txthorasextra.Text);
            seguro = Convert.ToInt32(txtseguro.Text);
            total = Convert.ToInt32(txtSalarioTotal.Text);
            fecha = txtfecha.Text;
            nocontrol = Convert.ToInt32(txtIdentificacion.Text);

            dataGridView1.Rows.Add(i + "", nocontrol, nombre, apellidop, apellidom, puesto, salariodia, horaextra, seguro, total, fecha);

            i = i + 1;
            limpiar();
            txtNombre.Focus();

            MessageBox.Show("Los datos se guardaron correctamente.");
        }
        void limpiar()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtxSalarioDia.Clear();
            txtSalarioTotal.Clear();
            txtapellidop.Clear();
            txtxapellidom.Clear();
            txthorasextra.Clear();
            txtseguro.Clear();
            txtpuesto.Clear();
        }

        private void btnCalculoSalario_Click(object sender, EventArgs e)
        {
            mi_empleado.Nombre = txtNombre.Text;
            mi_empleado.Apellidop = txtapellidop.Text;
            mi_empleado.Apellidom = txtxapellidom.Text;
            mi_empleado.Identificacion = txtIdentificacion.Text;
            mi_empleado.Puesto = txtpuesto.Text;
            mi_empleado.AsignacionDia = Convert.ToDecimal(txtxSalarioDia.Text);

            mi_nomina.DiasLaborados = Convert.ToInt32(txtDiasLaborados.Text);
            mi_nomina.Horas_extra = Convert.ToInt32(txthorasextra.Text);
            mi_nomina.Seguro_medico = Convert.ToInt32(txtseguro.Text);
            mi_nomina.Fecha = txtfecha.Text;

            txtSalarioTotal.Text = mi_nomina.CalculoDeNomina(Convert.ToInt32(mi_nomina.DiasLaborados), Convert.ToDecimal(mi_empleado.AsignacionDia), Convert.ToInt32(mi_nomina.Horas_extra),
                Convert.ToInt32(mi_nomina.Seguro_medico)).ToString();

            btnGuardarRegistro.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGuardarRegistro.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtDiasLaborados.Enabled = false;
            txtpago_ho_ex.Enabled = false;
            txtSalarioTotal.Enabled = false;
            txthorasextra.Text = "0";
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtfecha.Enabled = false;
            txtIdentificacion.Focus();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre, apellidop, apellidom, puesto, fecha;
            int salariodia, horaextra, seguro, total, nocontrol;

            nombre = txtNombre.Text;
            apellidop = txtapellidop.Text;
            apellidom = txtxapellidom.Text;
            puesto = txtpuesto.Text;
            salariodia = Convert.ToInt32(txtxSalarioDia.Text);
            horaextra = Convert.ToInt32(txthorasextra.Text);
            seguro = Convert.ToInt32(txtseguro.Text);
            total = Convert.ToInt32(txtSalarioTotal.Text);
            fecha = txtfecha.Text;
            nocontrol = Convert.ToInt32(txtIdentificacion.Text);

            dataGridView1[1, posicion].Value = txtIdentificacion.Text;
            dataGridView1[2, posicion].Value = txtNombre.Text;
            dataGridView1[3, posicion].Value = txtapellidop.Text;
            dataGridView1[4, posicion].Value = txtxapellidom.Text;
            dataGridView1[5, posicion].Value = txtpuesto.Text;
            dataGridView1[6, posicion].Value = txtxSalarioDia.Text;
            dataGridView1[7, posicion].Value = txthorasextra.Text;
            dataGridView1[8, posicion].Value = txtseguro.Text;
            dataGridView1[9, posicion].Value = txtSalarioTotal.Text;
            dataGridView1[10, posicion].Value = txtfecha.Text;

            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(posicion);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;

            txtIdentificacion.Text = dataGridView1[1, posicion].Value.ToString();
            txtNombre.Text = dataGridView1[2, posicion].Value.ToString();
            txtapellidop.Text = dataGridView1[3, posicion].Value.ToString();
            txtxapellidom.Text = dataGridView1[4, posicion].Value.ToString();
            txtpuesto.Text = dataGridView1[5, posicion].Value.ToString();
            txtxSalarioDia.Text = dataGridView1[6, posicion].Value.ToString();
            txthorasextra.Text = dataGridView1[7, posicion].Value.ToString();
            txtseguro.Text = dataGridView1[8, posicion].Value.ToString();
            txtSalarioTotal.Text = dataGridView1[9, posicion].Value.ToString();
            txtfecha.Text = dataGridView1[10, posicion].Value.ToString();

            btnGuardarRegistro.Enabled = false;
    
        }
    }
}
