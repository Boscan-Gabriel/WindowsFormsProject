
namespace AdmitereFacultate
{
    partial class FormVizualizareFaculate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireDinFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.creareBubleChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(-2, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(799, 450);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareInFisierTextToolStripMenuItem,
            this.citireDinFisierTextToolStripMenuItem,
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem,
            this.creareBubleChartToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 152);
            // 
            // salvareInFisierTextToolStripMenuItem
            // 
            this.salvareInFisierTextToolStripMenuItem.Name = "salvareInFisierTextToolStripMenuItem";
            this.salvareInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.salvareInFisierTextToolStripMenuItem.Text = "Salvare in fisier text";
            this.salvareInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareInFisierTextToolStripMenuItem_Click);
            // 
            // citireDinFisierTextToolStripMenuItem
            // 
            this.citireDinFisierTextToolStripMenuItem.Name = "citireDinFisierTextToolStripMenuItem";
            this.citireDinFisierTextToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.citireDinFisierTextToolStripMenuItem.Text = "Citire din fisier text";
            this.citireDinFisierTextToolStripMenuItem.Click += new System.EventHandler(this.citireDinFisierTextToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // creareBubleChartToolStripMenuItem
            // 
            this.creareBubleChartToolStripMenuItem.Name = "creareBubleChartToolStripMenuItem";
            this.creareBubleChartToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.creareBubleChartToolStripMenuItem.Text = "Creare Bubble Chart";
            this.creareBubleChartToolStripMenuItem.Click += new System.EventHandler(this.creareBubleChartToolStripMenuItem_Click);
            // 
            // FormVizualizareFaculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "FormVizualizareFaculate";
            this.Text = "FormVizualizareFaculate";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireDinFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem creareBubleChartToolStripMenuItem;
    }
}