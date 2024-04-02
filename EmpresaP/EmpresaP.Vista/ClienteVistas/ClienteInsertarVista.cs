using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpresaP.BSS;
using EmpresaP.Modelos;

namespace EmpresaP.Vista.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }

        ClienteBss bss = new ClienteBss();

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.Correo = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;
            bss.InsertarClienteBss(cliente);
            MessageBox.Show("Usuario registrado");
        }
    }
}
