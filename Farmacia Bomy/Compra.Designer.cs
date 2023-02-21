namespace Farmacia_Bomy
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxProductosComprados = new System.Windows.Forms.ListBox();
            this.textBoxRecibi = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonPagar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(194, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Carrito";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.White;
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Teal;
            this.labelTotal.Location = new System.Drawing.Point(183, 328);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(133, 50);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Recibí:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cambio:";
            // 
            // listBoxProductosComprados
            // 
            this.listBoxProductosComprados.FormattingEnabled = true;
            this.listBoxProductosComprados.ItemHeight = 20;
            this.listBoxProductosComprados.Location = new System.Drawing.Point(13, 79);
            this.listBoxProductosComprados.Name = "listBoxProductosComprados";
            this.listBoxProductosComprados.Size = new System.Drawing.Size(509, 164);
            this.listBoxProductosComprados.TabIndex = 0;
            // 
            // textBoxRecibi
            // 
            this.textBoxRecibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecibi.Location = new System.Drawing.Point(183, 291);
            this.textBoxRecibi.Name = "textBoxRecibi";
            this.textBoxRecibi.Size = new System.Drawing.Size(133, 31);
            this.textBoxRecibi.TabIndex = 1;
            this.textBoxRecibi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRecibi.TextChanged += new System.EventHandler(this.textBoxRecibi_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Farmacia Bomy";
            // 
            // buttonPagar
            // 
            this.buttonPagar.BackColor = System.Drawing.Color.Transparent;
            this.buttonPagar.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.billete;
            this.buttonPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPagar.FlatAppearance.BorderSize = 0;
            this.buttonPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.ForeColor = System.Drawing.Color.White;
            this.buttonPagar.Location = new System.Drawing.Point(322, 294);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(114, 117);
            this.buttonPagar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonPagar, "Pagar Compra");
            this.buttonPagar.UseVisualStyleBackColor = false;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(182, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de productos comprados:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.BackColor = System.Drawing.Color.White;
            this.labelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCantidad.ForeColor = System.Drawing.Color.Teal;
            this.labelCantidad.Location = new System.Drawing.Point(445, 246);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(56, 28);
            this.labelCantidad.TabIndex = 0;
            this.labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCambio
            // 
            this.labelCambio.BackColor = System.Drawing.Color.White;
            this.labelCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.ForeColor = System.Drawing.Color.Black;
            this.labelCambio.Location = new System.Drawing.Point(183, 385);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(133, 31);
            this.labelCambio.TabIndex = 0;
            this.labelCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(534, 437);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRecibi);
            this.Controls.Add(this.listBoxProductosComprados);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.ListBox listBoxProductosComprados;
        private System.Windows.Forms.TextBox textBoxRecibi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelCambio;
    }
}