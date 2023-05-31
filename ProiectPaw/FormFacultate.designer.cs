
namespace AdmitereFacultate
{
    partial class FormFacultate
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbDenumireSpecializare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbModAdmitere = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewSpecializari = new System.Windows.Forms.ListView();
            this.columnSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumarLocuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaSpecializare = new System.Windows.Forms.Button();
            this.btnAdaugaFacultate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schibaCuloareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbNumarLocuri = new AdmitereFacultate.NumericTextBox();
            this.userControl11 = new ProiectPaw.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDenumire.Location = new System.Drawing.Point(253, 56);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(144, 22);
            this.tbDenumire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adăugare facultate";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdresa.Location = new System.Drawing.Point(253, 115);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(144, 22);
            this.tbAdresa.TabIndex = 4;
            // 
            // tbDenumireSpecializare
            // 
            this.tbDenumireSpecializare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbDenumireSpecializare.Location = new System.Drawing.Point(164, 323);
            this.tbDenumireSpecializare.Name = "tbDenumireSpecializare";
            this.tbDenumireSpecializare.Size = new System.Drawing.Size(100, 22);
            this.tbDenumireSpecializare.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mod de admitere";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specializari";
            // 
            // cbModAdmitere
            // 
            this.cbModAdmitere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbModAdmitere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModAdmitere.FormattingEnabled = true;
            this.cbModAdmitere.Items.AddRange(new object[] {
            "Dosar",
            "Examen"});
            this.cbModAdmitere.Location = new System.Drawing.Point(253, 163);
            this.cbModAdmitere.Name = "cbModAdmitere";
            this.cbModAdmitere.Size = new System.Drawing.Size(165, 24);
            this.cbModAdmitere.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Denumire specializare";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Numar locuri";
            // 
            // listViewSpecializari
            // 
            this.listViewSpecializari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSpecializari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSpecializare,
            this.columnNumarLocuri});
            this.listViewSpecializari.GridLines = true;
            this.listViewSpecializari.HideSelection = false;
            this.listViewSpecializari.Location = new System.Drawing.Point(203, 201);
            this.listViewSpecializari.Name = "listViewSpecializari";
            this.listViewSpecializari.Size = new System.Drawing.Size(562, 103);
            this.listViewSpecializari.TabIndex = 15;
            this.listViewSpecializari.UseCompatibleStateImageBehavior = false;
            this.listViewSpecializari.View = System.Windows.Forms.View.Details;
            // 
            // columnSpecializare
            // 
            this.columnSpecializare.Text = "Specializare";
            this.columnSpecializare.Width = 276;
            // 
            // columnNumarLocuri
            // 
            this.columnNumarLocuri.Text = "Număr locuri";
            this.columnNumarLocuri.Width = 234;
            // 
            // btnAdaugaSpecializare
            // 
            this.btnAdaugaSpecializare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdaugaSpecializare.Location = new System.Drawing.Point(502, 310);
            this.btnAdaugaSpecializare.Name = "btnAdaugaSpecializare";
            this.btnAdaugaSpecializare.Size = new System.Drawing.Size(106, 49);
            this.btnAdaugaSpecializare.TabIndex = 16;
            this.btnAdaugaSpecializare.Text = "Adaugă specializare";
            this.btnAdaugaSpecializare.UseVisualStyleBackColor = true;
            this.btnAdaugaSpecializare.Click += new System.EventHandler(this.btnAdaugaSpecializare_Click);
            // 
            // btnAdaugaFacultate
            // 
            this.btnAdaugaFacultate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdaugaFacultate.Location = new System.Drawing.Point(144, 396);
            this.btnAdaugaFacultate.Name = "btnAdaugaFacultate";
            this.btnAdaugaFacultate.Size = new System.Drawing.Size(205, 54);
            this.btnAdaugaFacultate.TabIndex = 17;
            this.btnAdaugaFacultate.Text = "&Adaugă";
            this.btnAdaugaFacultate.UseVisualStyleBackColor = true;
            this.btnAdaugaFacultate.Click += new System.EventHandler(this.btnAdaugaFacultate_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(417, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Vi&zualizare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.errorProvider1.SetIconAlignment(this.contextMenuStrip1, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schibaCuloareaToolStripMenuItem,
            this.schimbaFontulToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 52);
            // 
            // schibaCuloareaToolStripMenuItem
            // 
            this.schibaCuloareaToolStripMenuItem.Name = "schibaCuloareaToolStripMenuItem";
            this.schibaCuloareaToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.schibaCuloareaToolStripMenuItem.Text = "Schiba culoarea";
            this.schibaCuloareaToolStripMenuItem.Click += new System.EventHandler(this.schibaCuloareaToolStripMenuItem_Click);
            // 
            // schimbaFontulToolStripMenuItem
            // 
            this.schimbaFontulToolStripMenuItem.Name = "schimbaFontulToolStripMenuItem";
            this.schimbaFontulToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.schimbaFontulToolStripMenuItem.Text = "Schimba fontul";
            this.schimbaFontulToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontulToolStripMenuItem_Click);
            // 
            // tbNumarLocuri
            // 
            this.tbNumarLocuri.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbNumarLocuri.Location = new System.Drawing.Point(375, 323);
            this.tbNumarLocuri.Name = "tbNumarLocuri";
            this.tbNumarLocuri.Size = new System.Drawing.Size(100, 22);
            this.tbNumarLocuri.TabIndex = 14;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(487, 456);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(408, 150);
            this.userControl11.TabIndex = 19;
            // 
            // FormFacultate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 556);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdaugaFacultate);
            this.Controls.Add(this.btnAdaugaSpecializare);
            this.Controls.Add(this.listViewSpecializari);
            this.Controls.Add(this.tbNumarLocuri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbModAdmitere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDenumireSpecializare);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenumire);
            this.Name = "FormFacultate";
            this.Text = "FormFacultate";
            this.Load += new System.EventHandler(this.FormFacultate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbDenumireSpecializare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbModAdmitere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private NumericTextBox tbNumarLocuri;
        private System.Windows.Forms.ListView listViewSpecializari;
        private System.Windows.Forms.Button btnAdaugaSpecializare;
        private System.Windows.Forms.ColumnHeader columnSpecializare;
        private System.Windows.Forms.ColumnHeader columnNumarLocuri;
        private System.Windows.Forms.Button btnAdaugaFacultate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schibaCuloareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontulToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProiectPaw.UserControl1 userControl11;
    }
}