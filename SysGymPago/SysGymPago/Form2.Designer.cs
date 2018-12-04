namespace SysGymPago
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnVencidos = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.BtnActivos = new System.Windows.Forms.Button();
            this.BtnBuscarCedula = new System.Windows.Forms.Button();
            this.Btn5ultimos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 390);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnVencidos
            // 
            this.BtnVencidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVencidos.Location = new System.Drawing.Point(13, 405);
            this.BtnVencidos.Name = "BtnVencidos";
            this.BtnVencidos.Size = new System.Drawing.Size(128, 33);
            this.BtnVencidos.TabIndex = 2;
            this.BtnVencidos.Text = "Clientes Vencidos";
            this.BtnVencidos.UseVisualStyleBackColor = true;
            this.BtnVencidos.Click += new System.EventHandler(this.BtnVencidos_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(62, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(177, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // BtnActivos
            // 
            this.BtnActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivos.Location = new System.Drawing.Point(170, 405);
            this.BtnActivos.Name = "BtnActivos";
            this.BtnActivos.Size = new System.Drawing.Size(128, 33);
            this.BtnActivos.TabIndex = 4;
            this.BtnActivos.Text = "Clientes Activos";
            this.BtnActivos.UseVisualStyleBackColor = true;
            this.BtnActivos.Click += new System.EventHandler(this.BtnActivos_Click);
            // 
            // BtnBuscarCedula
            // 
            this.BtnBuscarCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCedula.Location = new System.Drawing.Point(87, 46);
            this.BtnBuscarCedula.Name = "BtnBuscarCedula";
            this.BtnBuscarCedula.Size = new System.Drawing.Size(128, 33);
            this.BtnBuscarCedula.TabIndex = 5;
            this.BtnBuscarCedula.Text = "Buscar Cliente";
            this.BtnBuscarCedula.UseVisualStyleBackColor = true;
            this.BtnBuscarCedula.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn5ultimos
            // 
            this.Btn5ultimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5ultimos.Location = new System.Drawing.Point(87, 85);
            this.Btn5ultimos.Name = "Btn5ultimos";
            this.Btn5ultimos.Size = new System.Drawing.Size(128, 33);
            this.Btn5ultimos.TabIndex = 6;
            this.Btn5ultimos.Text = "Buscar Ultimos 5";
            this.Btn5ultimos.UseVisualStyleBackColor = true;
            this.Btn5ultimos.Click += new System.EventHandler(this.Btn5ultimos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cedula";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(91, 520);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(128, 33);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Elimina Registro";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn5ultimos);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBuscarCedula);
            this.panel1.Location = new System.Drawing.Point(730, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 146);
            this.panel1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActivos);
            this.Controls.Add(this.BtnVencidos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Clientes ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnVencidos;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button BtnActivos;
        private System.Windows.Forms.Button BtnBuscarCedula;
        private System.Windows.Forms.Button Btn5ultimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}