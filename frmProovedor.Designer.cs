
namespace Adm
{
    partial class frmProovedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProovedores = new System.Windows.Forms.DataGridView();
            this.ProovedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.txtProovedorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdGrabar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO PROOVEDOR";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(323, 30);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(104, 23);
            this.cmdGrabar.TabIndex = 2;
            this.cmdGrabar.Text = "GRABAR";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROOVEDORES";
            // 
            // dgvProovedores
            // 
            this.dgvProovedores.AllowUserToAddRows = false;
            this.dgvProovedores.AllowUserToDeleteRows = false;
            this.dgvProovedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProovedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProovedorID,
            this.Nombre});
            this.dgvProovedores.Location = new System.Drawing.Point(21, 141);
            this.dgvProovedores.Name = "dgvProovedores";
            this.dgvProovedores.ReadOnly = true;
            this.dgvProovedores.RowTemplate.Height = 25;
            this.dgvProovedores.Size = new System.Drawing.Size(454, 150);
            this.dgvProovedores.TabIndex = 2;
            // 
            // ProovedorID
            // 
            this.ProovedorID.HeaderText = "ProovedorID";
            this.ProovedorID.Name = "ProovedorID";
            this.ProovedorID.ReadOnly = true;
            this.ProovedorID.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBorrar);
            this.groupBox2.Controls.Add(this.txtProovedorID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ELIMINAR PROOVEDOR";
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(323, 47);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(104, 23);
            this.cmdBorrar.TabIndex = 3;
            this.cmdBorrar.Text = "BORRAR";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // txtProovedorID
            // 
            this.txtProovedorID.Location = new System.Drawing.Point(99, 47);
            this.txtProovedorID.Name = "txtProovedorID";
            this.txtProovedorID.Size = new System.Drawing.Size(161, 23);
            this.txtProovedorID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "IDENTIFICADOR";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(344, 455);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(104, 23);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // frmProovedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 497);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProovedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProovedor";
            this.Text = "PROOVEDOR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProovedores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProovedores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.TextBox txtProovedorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProovedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}