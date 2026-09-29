using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab33
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, decimal> precios = new()
        {
            { "Pizza", 8.00m },
            { "Hamburguesa", 6.00m },
            { "Ensalada", 5.00m }
        };

        private decimal totalPedido = 0m;

        public Form1()
        {
            InitializeComponent();


            btnAgregar.Click -= btnAgregar_Click;
            btnAgregar.Click += btnAgregar_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            cboProducto.SelectedIndexChanged -= cboProducto_SelectedIndexChanged;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;

            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cboProducto.Items.Count > 0)
                cboProducto.SelectedIndex = 0;

            ActualizarTotal();
        }

        private string ObtenerNombreProducto()
        {
            return cboProducto.SelectedItem.ToString().Split('-')[0].Trim();
        }


        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            string producto = combo.SelectedItem.ToString().Split('-')[0].Trim();

           

            picProducto.Image = null;
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            string producto = ObtenerNombreProducto();
            int cantidad = (int)nudCantidad.Value;
            decimal precioUnitario = precios[producto];

            List<string> extras = new();
            if (chkQueso.Checked) { precioUnitario += 1.00m; extras.Add("Queso"); }
            if (chkBebida.Checked) { precioUnitario += 1.50m; extras.Add("Bebida"); }
            if (chkPapas.Checked) { precioUnitario += 2.00m; extras.Add("Papas"); }

            decimal subtotal = precioUnitario * cantidad;

            string entrega = "Local";
            if (rdbDomicilio.Checked)
            {
                subtotal += 2.00m;
                entrega = "Domicilio";
            }

            string descuento = "";
            if (chkDescuento.Checked)
            {
                subtotal *= 0.90m;
                descuento = " | -10%";
            }

            totalPedido += subtotal;

            string textoExtras = extras.Count > 0 ? string.Join(", ", extras) : "Sin extras";
            lstResumen.Items.Add(
                $"{cantidad} x {producto} ({textoExtras}) | {entrega}{descuento} | {subtotal:C}");

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            lblTotal.Text = "Total: " + totalPedido.ToString("C");
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResumen.Items.Clear();
            totalPedido = 0m;
            cboProducto.SelectedIndex = 0;
            nudCantidad.Value = 1;
            rdbLocal.Checked = true;
            chkQueso.Checked = false;
            chkBebida.Checked = false;
            chkPapas.Checked = false;
            chkDescuento.Checked = false;
            ActualizarTotal();
        }
    }
}