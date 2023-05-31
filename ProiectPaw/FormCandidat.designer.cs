
namespace AdmitereFacultate
{
    partial class FormCandidat
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btnAdaugareCandidat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMedie = new AdmitereFacultate.NumericTextBox();
            this.tbCNP = new AdmitereFacultate.NumericTextBox();
            this.userControl11 = new ProiectPaw.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(149, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adăugare candidat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume și prenume: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNP: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medie Bacalaureat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Admis",
            "Respins",
            "În așteptare"});
            this.cbStatus.Location = new System.Drawing.Point(233, 270);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(196, 24);
            this.cbStatus.TabIndex = 7;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSex.Location = new System.Drawing.Point(233, 182);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(196, 24);
            this.cbSex.TabIndex = 8;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(233, 97);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(196, 22);
            this.tbNume.TabIndex = 10;
            // 
            // btnAdaugareCandidat
            // 
            this.btnAdaugareCandidat.Location = new System.Drawing.Point(151, 332);
            this.btnAdaugareCandidat.Name = "btnAdaugareCandidat";
            this.btnAdaugareCandidat.Size = new System.Drawing.Size(154, 52);
            this.btnAdaugareCandidat.TabIndex = 13;
            this.btnAdaugareCandidat.Text = "&Adaugă";
            this.btnAdaugareCandidat.UseVisualStyleBackColor = true;
            this.btnAdaugareCandidat.Click += new System.EventHandler(this.btnAdaugareCandidat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vi&zualizare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(233, 225);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(196, 22);
            this.tbMedie.TabIndex = 12;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(233, 140);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(196, 22);
            this.tbCNP.TabIndex = 11;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(368, 383);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(358, 87);
            this.userControl11.TabIndex = 15;
            // 
            // FormCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(727, 471);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdaugareCandidat);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormCandidat";
            this.Text = "FormCandidat";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbNume;
        private NumericTextBox tbCNP;
        private NumericTextBox tbMedie;
        private System.Windows.Forms.Button btnAdaugareCandidat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontulToolStripMenuItem;
        private ProiectPaw.UserControl1 userControl11;
    }
}