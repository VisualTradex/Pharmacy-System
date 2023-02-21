namespace Farmacia_Bomy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.Turquoise;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSesion.Location = new System.Drawing.Point(76, 413);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(1);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(120, 27);
            this.buttonIniciarSesion.TabIndex = 3;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.toolTip1.SetToolTip(this.buttonIniciarSesion, "Iniciar Sesión");
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Samantha",
            "Fábian",
            "Alejandro"});
            this.comboBoxUser.Location = new System.Drawing.Point(34, 272);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(205, 29);
            this.comboBoxUser.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxUser, "Usuarios");
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Turquoise;
            this.labelPassword.Location = new System.Drawing.Point(93, 326);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 23);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Tahoma", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Turquoise;
            this.labelUserName.Location = new System.Drawing.Point(91, 240);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(94, 23);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Username";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackgroundImage = global::Farmacia_Bomy.Properties.Resources.close_icon;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(238, 4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(30, 30);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonCerrar, "Salir");
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Farmacia_Bomy.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(61, 63);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 12;
            this.pictureBoxUser.TabStop = false;
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(34, 358);
            this.maskedTextBoxPassword.Mask = "99999";
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.PasswordChar = '*';
            this.maskedTextBoxPassword.PromptChar = ' ';
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(205, 27);
            this.maskedTextBoxPassword.TabIndex = 2;
            this.maskedTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxPassword.ValidatingType = typeof(int);
            this.maskedTextBoxPassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPassword_MaskInputRejected);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Farmacia Bomy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 489);
            this.Controls.Add(this.maskedTextBoxPassword);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia Bomy - Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

