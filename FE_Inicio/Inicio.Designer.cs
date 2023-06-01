namespace Cuenta
{
    partial class Inicio
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATOSToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 29);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // dATOSToolStripMenuItem
            // 
            this.dATOSToolStripMenuItem.Name = "dATOSToolStripMenuItem";
            this.dATOSToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            this.dATOSToolStripMenuItem.Text = "DATOS";
            // 
            // dtgv_datos
            // 
            this.dtgv_datos.AllowUserToOrderColumns = true;
            this.dtgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_datos.Location = new System.Drawing.Point(12, 41);
            this.dtgv_datos.Name = "dtgv_datos";
            this.dtgv_datos.Size = new System.Drawing.Size(776, 397);
            this.dtgv_datos.TabIndex = 1;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(727, 0);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(73, 29);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dtgv_datos);
            this.Controls.Add(this.menu);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem dATOSToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgv_datos;
        private System.Windows.Forms.Button btn_volver;
    }
}