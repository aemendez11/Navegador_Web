
namespace Navegador_Web
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.irToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribaAquíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // irToolStripMenuItem
            // 
            this.irToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.haciaAtrasToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem,
            this.escribaAquíToolStripMenuItem});
            this.irToolStripMenuItem.Name = "irToolStripMenuItem";
            this.irToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.irToolStripMenuItem.Text = "Navegar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox",
            "https://github.com/",
            "https://www.amazon.com/-/es/"});
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(707, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 65);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(770, 371);
            this.webBrowser1.TabIndex = 3;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // haciaAtrasToolStripMenuItem
            // 
            this.haciaAtrasToolStripMenuItem.Name = "haciaAtrasToolStripMenuItem";
            this.haciaAtrasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.haciaAtrasToolStripMenuItem.Text = "Hacia atras";
            this.haciaAtrasToolStripMenuItem.Click += new System.EventHandler(this.haciaAtrasToolStripMenuItem_Click);
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia Adelante";
            this.haciaAdelanteToolStripMenuItem.Click += new System.EventHandler(this.haciaAdelanteToolStripMenuItem_Click);
            // 
            // escribaAquíToolStripMenuItem
            // 
            this.escribaAquíToolStripMenuItem.Name = "escribaAquíToolStripMenuItem";
            this.escribaAquíToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.escribaAquíToolStripMenuItem.Text = "Refrescar";
            this.escribaAquíToolStripMenuItem.Click += new System.EventHandler(this.escribaAquíToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador Web";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem irToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribaAquíToolStripMenuItem;
    }
}

