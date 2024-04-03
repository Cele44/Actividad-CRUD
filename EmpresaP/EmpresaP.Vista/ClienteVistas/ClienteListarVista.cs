using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaP.BSS;
using EmpresaP.Vista.PedidoVistas;

namespace EmpresaP.Vista.ClienteVistas
{
    public partial class ClienteListarVista : Form
    {
        public ClienteListarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteInsertarVista fr = new ClienteInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();

                dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este cliente", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdClienteSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PedidoInsertarVista.IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteTotalPe fr = new ClienteTotalPe(IdClienteSeleccionada);
            fr.ShowDialog();
            bss.ClienteDatosTBss(IdClienteSeleccionada);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int IdClienteSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClientePedidos fr = new ClientePedidos(IdClienteSeleccionada);
            fr.ShowDialog();
            bss.ClienteDatosLBss(IdClienteSeleccionada);
        }
    }
}

