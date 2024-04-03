namespace EmpresaP.Vista.PedidoVistas
{
    partial class PedidoListarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 490);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 1;
            label1.Text = "PEDIDOS";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(749, 361);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(913, 262);
            button3.Name = "button3";
            button3.Size = new Size(120, 29);
            button3.TabIndex = 8;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(913, 192);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 7;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(913, 122);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PedidoListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 567);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PedidoListarVista";
            Text = "PedidoListarVista";
            Load += PedidoListarVista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}