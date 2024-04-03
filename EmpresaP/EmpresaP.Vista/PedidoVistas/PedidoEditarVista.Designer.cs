namespace EmpresaP.Vista.PedidoVistas
{
    partial class PedidoEditarVista
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
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(382, 83);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 36;
            button3.Text = "Seleccionar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(43, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 27);
            dateTimePicker1.TabIndex = 35;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(244, 450);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 34;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(87, 450);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 33;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(40, 361);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 27);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
            textBox1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 320);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 29;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 226);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 28;
            label3.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 136);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 27;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 59);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 26;
            label1.Text = "Cliente";
            // 
            // PedidoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(509, 523);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PedidoEditarVista";
            Text = "PedidoEditarVista";
            Load += PedidoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}