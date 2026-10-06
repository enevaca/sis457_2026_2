using CadMinerva;
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
            resetearErrores();
        }

        private void resetearErrores()
        {
            erpUnidadMedida.Clear();
            erpCodigo.Clear();
            erpDescripcion.Clear();
            erpPrecioVenta.Clear();
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

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var producto = ProductoCln.obtenerUno(id);
            cbxUnidadMedida.SelectedValue = producto.idUnidadMedida;
            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            nudPrecioVenta.Value = producto.precioVenta;
            nudSaldo.Value = producto.saldo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(901, 365);
            pnlAcciones.Enabled = true;

        }

        private bool validarCampos()
        {
            bool esValido = true;
            resetearErrores();

            if (cbxUnidadMedida.SelectedIndex == -1)
            {
                erpUnidadMedida.SetError(cbxUnidadMedida, "La unidad de medida es obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                erpCodigo.SetError(txtCodigo, "El código es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La descripción es obligatoria");
                esValido = false;
            }
            if (nudPrecioVenta.Value == 0)
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El precio de venta debe ser mayor a cero");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                var producto = new Producto
                {
                    codigo = txtCodigo.Text.Trim(),
                    descripcion = txtDescripcion.Text.Trim(),
                    idUnidadMedida = (int)cbxUnidadMedida.SelectedValue,
                    precioVenta = nudPrecioVenta.Value,
                    saldo = nudSaldo.Value,
                    usuarioRegistro = Util.usuario.usuario1
                };

                try
                {
                    if (esNuevo)
                    {
                        producto.fechaRegistro = DateTime.Now;
                        producto.estado = (short)Estado.Activo;
                        ProductoCln.crear(producto);
                    }
                    else
                    {
                        producto.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                        ProductoCln.actualizar(producto);
                    }
                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Producto guardado correctamente", "::: Mensaje - Minerva :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "::: Error - Minerva :::", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string codigo = dgvLista.CurrentRow.Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el producto {codigo}?",
                "::: Confirmación - Minerva :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ProductoCln.eliminar(id, Util.usuario.usuario1);
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: Mensaje - Minerva :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
