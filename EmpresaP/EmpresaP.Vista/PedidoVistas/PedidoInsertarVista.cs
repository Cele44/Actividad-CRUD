using EmpresaP.BSS;
using EmpresaP.Modelos;
using EmpresaP.Vista.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmpresaP.Vista.PedidoVistas
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionada = 0;
        ClienteBss bss = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bss.ObtenerIdBss(IdClienteSeleccionada);
                textBox1.Text = cliente.Nombre + " " + cliente.Apellido;
            }
        }
        PedidoBss bsse= new PedidoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IdCliente = IdClienteSeleccionada;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total= Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bsse.InsertarPedidoBss(pedido);
            MessageBox.Show("Usuario registrado");
        }
    }
}


