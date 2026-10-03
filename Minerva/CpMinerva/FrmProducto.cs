using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmProducto : Form
    {
        private bool esNuevo;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var productos = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = productos;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idUnidadMedida"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (productos.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["codigo"];
            btnEditar.Enabled = productos.Count > 0;
            btnEliminar.Enabled = productos.Count > 0;
        }

        private void cargarUnidadesMedida()
        {
            cbxUnidadMedida.DataSource = UnidadMedidaCln.listar();
            cbxUnidadMedida.ValueMember = "id";
            cbxUnidadMedida.DisplayMember = "descripcion";
            cbxUnidadMedida.SelectedIndex = -1;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(901, 365);
            listar();
            cargarUnidadesMedida();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void resetearCampos()
        {
            cbxUnidadMedida.SelectedIndex = -1;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            nudPrecioVenta.Value = 0;
            nudSaldo.Value = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(901, 476);
            pnlAcciones.Enabled = false;
            resetearCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(901, 476);
            pnlAcciones.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(901, 365);
            pnlAcciones.Enabled = true;
        }
    }
}
