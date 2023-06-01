namespace Cuenta
{
    partial class CrearCuenta
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.mcal_fechnaci = new System.Windows.Forms.MonthCalendar();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.lvl_contraseña = new System.Windows.Forms.Label();
            this.txb_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(12, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(86, 30);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(303, 49);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(198, 26);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "CREAR CUENTA";
            // 
            // txb_nombre
            // 
            this.txb_nombre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nombre.ForeColor = System.Drawing.Color.White;
            this.txb_nombre.Location = new System.Drawing.Point(130, 220);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(253, 23);
            this.txb_nombre.TabIndex = 9;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(126, 197);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(76, 20);
            this.lbl_nombre.TabIndex = 8;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txb_apellido
            // 
            this.txb_apellido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_apellido.ForeColor = System.Drawing.Color.White;
            this.txb_apellido.Location = new System.Drawing.Point(130, 278);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(253, 23);
            this.txb_apellido.TabIndex = 11;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_apellido.Location = new System.Drawing.Point(126, 255);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(78, 20);
            this.lbl_apellido.TabIndex = 10;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // txb_telefono
            // 
            this.txb_telefono.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_telefono.ForeColor = System.Drawing.Color.White;
            this.txb_telefono.Location = new System.Drawing.Point(130, 392);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(253, 23);
            this.txb_telefono.TabIndex = 15;
            this.txb_telefono.TextChanged += new System.EventHandler(this.txb_telefono_TextChanged);
            this.txb_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_telefono_KeyPress);
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.ForeColor = System.Drawing.Color.White;
            this.lbl_tel.Location = new System.Drawing.Point(126, 369);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(84, 20);
            this.lbl_tel.TabIndex = 14;
            this.lbl_tel.Text = "Telefono:";
            // 
            // txb_email
            // 
            this.txb_email.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.ForeColor = System.Drawing.Color.White;
            this.txb_email.Location = new System.Drawing.Point(130, 334);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(253, 23);
            this.txb_email.TabIndex = 13;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(126, 311);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 20);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email:";
            // 
            // mcal_fechnaci
            // 
            this.mcal_fechnaci.BackColor = System.Drawing.Color.MidnightBlue;
            this.mcal_fechnaci.Location = new System.Drawing.Point(443, 113);
            this.mcal_fechnaci.Name = "mcal_fechnaci";
            this.mcal_fechnaci.TabIndex = 16;
            this.mcal_fechnaci.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.mcal_fechnaci.TrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(482, 317);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(168, 47);
            this.btn_registrar.TabIndex = 17;
            this.btn_registrar.Text = "REGISTRARSE";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_contraseña.ForeColor = System.Drawing.Color.White;
            this.txb_contraseña.Location = new System.Drawing.Point(130, 161);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(253, 23);
            this.txb_contraseña.TabIndex = 19;
            // 
            // lvl_contraseña
            // 
            this.lvl_contraseña.AutoSize = true;
            this.lvl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl_contraseña.ForeColor = System.Drawing.Color.White;
            this.lvl_contraseña.Location = new System.Drawing.Point(126, 138);
            this.lvl_contraseña.Name = "lvl_contraseña";
            this.lvl_contraseña.Size = new System.Drawing.Size(107, 20);
            this.lvl_contraseña.TabIndex = 18;
            this.lvl_contraseña.Text = "Contraseña:";
            // 
            // txb_user
            // 
            this.txb_user.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_user.ForeColor = System.Drawing.Color.White;
            this.txb_user.Location = new System.Drawing.Point(130, 103);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(253, 23);
            this.txb_user.TabIndex = 21;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(126, 80);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(76, 20);
            this.lbl_user.TabIndex = 20;
            this.lbl_user.Text = "Usuario:";
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(830, 437);
            this.Controls.Add(this.txb_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txb_contraseña);
            this.Controls.Add(this.lvl_contraseña);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.mcal_fechnaci);
            this.Controls.Add(this.txb_telefono);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_volver);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CrearCuenta";
            this.Text = "Crear Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.MonthCalendar mcal_fechnaci;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.Label lvl_contraseña;
        private System.Windows.Forms.TextBox txb_user;
        private System.Windows.Forms.Label lbl_user;
    }
}