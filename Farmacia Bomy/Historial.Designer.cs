namespace Farmacia_Bomy
{
    partial class Historial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCerra = new System.Windows.Forms.Button();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonRedesSociales = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.buttonAcercaDe = new System.Windows.Forms.Button();
            this.buttonCambiarUsuario = new System.Windows.Forms.Button();
            this.buttonGaleria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet2 = new Farmacia_Bomy.ProyectoDataSet2();
            this.historialTableAdapter = new Farmacia_Bomy.ProyectoDataSet2TableAdapters.HistorialTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonCerra);
            this.panel1.Controls.Add(this.labelMatricula);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 150);
            this.panel1.TabIndex = 4;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Gray;
            this.labelFecha.Location = new System.Drawing.Point(1031, 119);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(335, 25);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.Teal;
            this.labelHora.Location = new System.Drawing.Point(1205, 70);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(161, 47);
            this.labelHora.TabIndex = 0;
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(156, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 206);
            this.label3.TabIndex = 0;
            this.label3.Text = "Historial \r\nde Ventas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCerra
            // 
            this.buttonCerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerra.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.close_icon;
            this.buttonCerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCerra.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCerra.FlatAppearance.BorderSize = 0;
            this.buttonCerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerra.ForeColor = System.Drawing.Color.Red;
            this.buttonCerra.Location = new System.Drawing.Point(1335, 5);
            this.buttonCerra.Name = "buttonCerra";
            this.buttonCerra.Size = new System.Drawing.Size(31, 31);
            this.buttonCerra.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonCerra, "Cerrar");
            this.buttonCerra.UseVisualStyleBackColor = true;
            this.buttonCerra.Click += new System.EventHandler(this.buttonCerra_Click);
            // 
            // labelMatricula
            // 
            this.labelMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelMatricula.Location = new System.Drawing.Point(780, 93);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(165, 23);
            this.labelMatricula.TabIndex = 0;
            this.labelMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "No de Empleado:";
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelUsuario.Location = new System.Drawing.Point(734, 66);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(195, 23);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(478, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 140);
            this.label1.TabIndex = 1;
            this.label1.Text = "Farmacia Bomy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Farmacia_Bomy.Properties.Resources.losrobles2_g;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Farmacia Bomy";
            // 
            // buttonVentas
            // 
            this.buttonVentas.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.volver;
            this.buttonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVentas.FlatAppearance.BorderSize = 0;
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Location = new System.Drawing.Point(38, 22);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Size = new System.Drawing.Size(75, 75);
            this.buttonVentas.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonVentas, "Ventas");
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // buttonRedesSociales
            // 
            this.buttonRedesSociales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRedesSociales.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.anuncio;
            this.buttonRedesSociales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRedesSociales.FlatAppearance.BorderSize = 0;
            this.buttonRedesSociales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRedesSociales.Location = new System.Drawing.Point(38, 502);
            this.buttonRedesSociales.Name = "buttonRedesSociales";
            this.buttonRedesSociales.Size = new System.Drawing.Size(75, 75);
            this.buttonRedesSociales.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonRedesSociales, "Redes Sociales");
            this.buttonRedesSociales.UseVisualStyleBackColor = true;
            this.buttonRedesSociales.Click += new System.EventHandler(this.buttonRedesSociales_Click);
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmpleados.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.asistente;
            this.buttonEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleados.Location = new System.Drawing.Point(38, 310);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(75, 75);
            this.buttonEmpleados.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonEmpleados, "Empleados");
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // buttonAcercaDe
            // 
            this.buttonAcercaDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAcercaDe.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.programacion;
            this.buttonAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAcercaDe.FlatAppearance.BorderSize = 0;
            this.buttonAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcercaDe.Location = new System.Drawing.Point(38, 406);
            this.buttonAcercaDe.Name = "buttonAcercaDe";
            this.buttonAcercaDe.Size = new System.Drawing.Size(75, 75);
            this.buttonAcercaDe.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonAcercaDe, "Información del Software");
            this.buttonAcercaDe.UseVisualStyleBackColor = true;
            this.buttonAcercaDe.Click += new System.EventHandler(this.buttonAcercaDe_Click);
            // 
            // buttonCambiarUsuario
            // 
            this.buttonCambiarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCambiarUsuario.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.globalizacion;
            this.buttonCambiarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCambiarUsuario.FlatAppearance.BorderSize = 0;
            this.buttonCambiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiarUsuario.Location = new System.Drawing.Point(38, 214);
            this.buttonCambiarUsuario.Name = "buttonCambiarUsuario";
            this.buttonCambiarUsuario.Size = new System.Drawing.Size(75, 75);
            this.buttonCambiarUsuario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonCambiarUsuario, "Cambiar Usuario");
            this.buttonCambiarUsuario.UseVisualStyleBackColor = true;
            this.buttonCambiarUsuario.Click += new System.EventHandler(this.buttonCambiarUsuario_Click);
            // 
            // buttonGaleria
            // 
            this.buttonGaleria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGaleria.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.foto;
            this.buttonGaleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGaleria.FlatAppearance.BorderSize = 0;
            this.buttonGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGaleria.Location = new System.Drawing.Point(38, 118);
            this.buttonGaleria.Name = "buttonGaleria";
            this.buttonGaleria.Size = new System.Drawing.Size(75, 75);
            this.buttonGaleria.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonGaleria, "Galería de Productos");
            this.buttonGaleria.UseVisualStyleBackColor = true;
            this.buttonGaleria.Click += new System.EventHandler(this.buttonGaleria_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.buttonGaleria);
            this.panel2.Controls.Add(this.buttonVentas);
            this.panel2.Controls.Add(this.buttonRedesSociales);
            this.panel2.Controls.Add(this.buttonEmpleados);
            this.panel2.Controls.Add(this.buttonAcercaDe);
            this.panel2.Controls.Add(this.buttonCambiarUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 599);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(149, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 602);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.totalDeCompraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 149;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 323;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 252;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 226;
            // 
            // totalDeCompraDataGridViewTextBoxColumn
            // 
            this.totalDeCompraDataGridViewTextBoxColumn.DataPropertyName = "TotalDeCompra";
            this.totalDeCompraDataGridViewTextBoxColumn.HeaderText = "TotalDeCompra";
            this.totalDeCompraDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.totalDeCompraDataGridViewTextBoxColumn.Name = "totalDeCompraDataGridViewTextBoxColumn";
            this.totalDeCompraDataGridViewTextBoxColumn.Width = 536;
            // 
            // historialBindingSource
            // 
            this.historialBindingSource.DataMember = "Historial";
            this.historialBindingSource.DataSource = this.proyectoDataSet2;
            // 
            // proyectoDataSet2
            // 
            this.proyectoDataSet2.DataSetName = "ProyectoDataSet2";
            this.proyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialTableAdapter
            // 
            this.historialTableAdapter.ClearBeforeFill = true;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Historial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCerra;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonRedesSociales;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Button buttonAcercaDe;
        private System.Windows.Forms.Button buttonCambiarUsuario;
        private System.Windows.Forms.Button buttonGaleria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoDataSet2 proyectoDataSet2;
        private System.Windows.Forms.BindingSource historialBindingSource;
        private ProyectoDataSet2TableAdapters.HistorialTableAdapter historialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeCompraDataGridViewTextBoxColumn;
    }
}