namespace Cuenta
{
    partial class IniSes
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linklb_crear = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(187, 45);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(180, 26);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "INICIA SESION";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(137, 101);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(96, 20);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "USUARIO:";
            // 
            // txb_usuario
            // 
            this.txb_usuario.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_usuario.ForeColor = System.Drawing.Color.White;
            this.txb_usuario.Location = new System.Drawing.Point(141, 124);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(253, 23);
            this.txb_usuario.TabIndex = 2;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_contraseña.ForeColor = System.Drawing.Color.White;
            this.txb_contraseña.Location = new System.Drawing.Point(141, 186);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.PasswordChar = '*';
            this.txb_contraseña.Size = new System.Drawing.Size(253, 23);
            this.txb_contraseña.TabIndex = 4;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lbl_contraseña.Location = new System.Drawing.Point(137, 163);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(134, 20);
            this.lbl_contraseña.TabIndex = 3;
            this.lbl_contraseña.Text = "CONTRASEÑA:";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar.Location = new System.Drawing.Point(214, 232);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(111, 42);
            this.btn_iniciar.TabIndex = 5;
            this.btn_iniciar.Text = "INICIAR";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Aun no tienes cuenta?";
            // 
            // linklb_crear
            // 
            this.linklb_crear.AutoSize = true;
            this.linklb_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_crear.ForeColor = System.Drawing.Color.White;
            this.linklb_crear.LinkColor = System.Drawing.Color.White;
            this.linklb_crear.Location = new System.Drawing.Point(301, 287);
            this.linklb_crear.Name = "linklb_crear";
            this.linklb_crear.Size = new System.Drawing.Size(81, 15);
            this.linklb_crear.TabIndex = 7;
            this.linklb_crear.TabStop = true;
            this.linklb_crear.Text = "Create una!";
            this.linklb_crear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_crear_LinkClicked);
            // 
            // IniSes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(574, 419);
            this.Controls.Add(this.linklb_crear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "IniSes";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.IniSes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklb_crear;
    }
}

