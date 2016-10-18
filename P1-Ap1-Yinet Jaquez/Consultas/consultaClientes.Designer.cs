namespace P1_Ap1_Yinet_Jaquez.Consultas
{
    partial class consultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTexBox = new System.Windows.Forms.TextBox();
            this.ConsultarBoton = new System.Windows.Forms.Button();
            this.listadoClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por Nombre";
            // 
            // nombreTexBox
            // 
            this.nombreTexBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTexBox.Location = new System.Drawing.Point(224, 54);
            this.nombreTexBox.Name = "nombreTexBox";
            this.nombreTexBox.Size = new System.Drawing.Size(185, 26);
            this.nombreTexBox.TabIndex = 1;
            // 
            // ConsultarBoton
            // 
            this.ConsultarBoton.BackColor = System.Drawing.Color.LavenderBlush;
            this.ConsultarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarBoton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBoton.Image = global::P1_Ap1_Yinet_Jaquez.Properties.Resources._40px_Icono_buscar;
            this.ConsultarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarBoton.Location = new System.Drawing.Point(415, 47);
            this.ConsultarBoton.Name = "ConsultarBoton";
            this.ConsultarBoton.Size = new System.Drawing.Size(109, 43);
            this.ConsultarBoton.TabIndex = 2;
            this.ConsultarBoton.Text = "Consultar";
            this.ConsultarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarBoton.UseVisualStyleBackColor = false;
            this.ConsultarBoton.Click += new System.EventHandler(this.ConsultarBoton_Click);
            // 
            // listadoClientes
            // 
            this.listadoClientes.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.listadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoClientes.GridColor = System.Drawing.Color.DeepPink;
            this.listadoClientes.Location = new System.Drawing.Point(66, 131);
            this.listadoClientes.Name = "listadoClientes";
            this.listadoClientes.Size = new System.Drawing.Size(531, 175);
            this.listadoClientes.TabIndex = 3;
            // 
            // consultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P1_Ap1_Yinet_Jaquez.Properties.Resources.degradado_de_color_1920x1200_126;
            this.ClientSize = new System.Drawing.Size(682, 372);
            this.Controls.Add(this.listadoClientes);
            this.Controls.Add(this.ConsultarBoton);
            this.Controls.Add(this.nombreTexBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultaClientes";
            this.Text = "Consulta Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTexBox;
        private System.Windows.Forms.Button ConsultarBoton;
        private System.Windows.Forms.DataGridView listadoClientes;
    }
}