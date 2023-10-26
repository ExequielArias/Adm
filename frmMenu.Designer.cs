
namespace Adm
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tAREASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROOVEDORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRTICULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAREASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tAREASToolStripMenuItem
            // 
            this.tAREASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROOVEDORESToolStripMenuItem,
            this.aRTICULOSToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.tAREASToolStripMenuItem.Name = "tAREASToolStripMenuItem";
            this.tAREASToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tAREASToolStripMenuItem.Text = "TAREAS";
            // 
            // pROOVEDORESToolStripMenuItem
            // 
            this.pROOVEDORESToolStripMenuItem.Name = "pROOVEDORESToolStripMenuItem";
            this.pROOVEDORESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pROOVEDORESToolStripMenuItem.Text = "PROOVEDORES";
            this.pROOVEDORESToolStripMenuItem.Click += new System.EventHandler(this.pROOVEDORESToolStripMenuItem_Click);
            // 
            // aRTICULOSToolStripMenuItem
            // 
            this.aRTICULOSToolStripMenuItem.Name = "aRTICULOSToolStripMenuItem";
            this.aRTICULOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aRTICULOSToolStripMenuItem.Text = "ARTICULOS";
            this.aRTICULOSToolStripMenuItem.Click += new System.EventHandler(this.aRTICULOSToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 237);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tAREASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROOVEDORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}

