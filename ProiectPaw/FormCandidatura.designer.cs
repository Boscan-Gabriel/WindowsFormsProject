
namespace AdmitereFacultate
{
    partial class FormCandidatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCandidatura = new System.Windows.Forms.Button();
            this.tbSpecializari = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCNPCandidat = new AdmitereFacultate.NumericTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewSpecializari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFacultate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl11 = new ProiectPaw.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adăugare candidatură";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specializări:";
            // 
            // btnCandidatura
            // 
            this.btnCandidatura.Location = new System.Drawing.Point(198, 354);
            this.btnCandidatura.Name = "btnCandidatura";
            this.btnCandidatura.Size = new System.Drawing.Size(105, 46);
            this.btnCandidatura.TabIndex = 5;
            this.btnCandidatura.Text = "&Adaugă";
            this.btnCandidatura.UseVisualStyleBackColor = true;
            this.btnCandidatura.Click += new System.EventHandler(this.btnCandidatura_Click);
            // 
            // tbSpecializari
            // 
            this.tbSpecializari.Location = new System.Drawing.Point(285, 255);
            this.tbSpecializari.Name = "tbSpecializari";
            this.tbSpecializari.ReadOnly = true;
            this.tbSpecializari.Size = new System.Drawing.Size(121, 22);
            this.tbSpecializari.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareaToolStripMenuItem,
            this.schimbaFontulToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 52);
            // 
            // schimbaCuloareaToolStripMenuItem
            // 
            this.schimbaCuloareaToolStripMenuItem.Name = "schimbaCuloareaToolStripMenuItem";
            this.schimbaCuloareaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.schimbaCuloareaToolStripMenuItem.Text = "Schimba culoarea";
            this.schimbaCuloareaToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareaToolStripMenuItem_Click);
            // 
            // schimbaFontulToolStripMenuItem
            // 
            this.schimbaFontulToolStripMenuItem.Name = "schimbaFontulToolStripMenuItem";
            this.schimbaFontulToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.schimbaFontulToolStripMenuItem.Text = "Schimba fontul";
            this.schimbaFontulToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontulToolStripMenuItem_Click);
            // 
            // tbCNPCandidat
            // 
            this.tbCNPCandidat.Location = new System.Drawing.Point(289, 209);
            this.tbCNPCandidat.Name = "tbCNPCandidat";
            this.tbCNPCandidat.Size = new System.Drawing.Size(121, 22);
            this.tbCNPCandidat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(318, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Vi&zualizare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewSpecializari
            // 
            this.listViewSpecializari.CausesValidation = false;
            this.listViewSpecializari.CheckBoxes = true;
            this.listViewSpecializari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSpecializari.GridLines = true;
            this.listViewSpecializari.HideSelection = false;
            this.listViewSpecializari.Location = new System.Drawing.Point(443, 112);
            this.listViewSpecializari.Name = "listViewSpecializari";
            this.listViewSpecializari.Scrollable = false;
            this.listViewSpecializari.Size = new System.Drawing.Size(507, 230);
            this.listViewSpecializari.TabIndex = 12;
            this.listViewSpecializari.UseCompatibleStateImageBehavior = false;
            this.listViewSpecializari.View = System.Windows.Forms.View.Details;
            this.listViewSpecializari.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewSpecializari_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Specializari";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numar locuri";
            this.columnHeader2.Width = 250;
            // 
            // cbFacultate
            // 
            this.cbFacultate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacultate.FormattingEnabled = true;
            this.cbFacultate.Location = new System.Drawing.Point(289, 161);
            this.cbFacultate.Name = "cbFacultate";
            this.cbFacultate.Size = new System.Drawing.Size(121, 24);
            this.cbFacultate.TabIndex = 13;
            this.cbFacultate.SelectedIndexChanged += new System.EventHandler(this.cbFacultate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Facultate";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(709, 378);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(408, 118);
            this.userControl11.TabIndex = 15;
            // 
            // FormCandidatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 469);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFacultate);
            this.Controls.Add(this.listViewSpecializari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSpecializari);
            this.Controls.Add(this.tbCNPCandidat);
            this.Controls.Add(this.btnCandidatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormCandidatura";
            this.Text = "FormCandidatura";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCandidatura;
        private NumericTextBox tbCNPCandidat;
        private System.Windows.Forms.TextBox tbSpecializari;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontulToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewSpecializari;
        private System.Windows.Forms.ComboBox cbFacultate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private ProiectPaw.UserControl1 userControl11;
    }
}