using EmpresaP.BSS;
using EmpresaP.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaP.Vista.ClienteVistas
{
    public partial class ClienteTotalPe : Form
    {
        public ClienteTotalPe(int id)
        {
            idx = id;
            InitializeComponent();
        }
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();

        private void ClienteTotalPe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteDatosTBss(idx);
        }
    }
}
