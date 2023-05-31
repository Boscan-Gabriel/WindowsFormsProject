
namespace AdmitereFacultate
{
    partial class Form1
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
            this.btnFacultate = new System.Windows.Forms.Button();
            this.btnCandidat = new System.Windows.Forms.Button();
            this.btnCandidatura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFacultate
            // 
            this.btnFacultate.Location = new System.Drawing.Point(72, 97);
            this.btnFacultate.Name = "btnFacultate";
            this.btnFacultate.Size = new System.Drawing.Size(426, 75);
            this.btnFacultate.TabIndex = 0;
            this.btnFacultate.Text = "Adauga facultate";
            this.btnFacultate.UseVisualStyleBackColor = true;
            this.btnFacultate.Click += new System.EventHandler(this.btnFacultate_Click);
            // 
            // btnCandidat
            // 
            this.btnCandidat.Location = new System.Drawing.Point(72, 205);
            this.btnCandidat.Name = "btnCandidat";
            this.btnCandidat.Size = new System.Drawing.Size(426, 75);
            this.btnCandidat.TabIndex = 1;
            this.btnCandidat.Text = "Adauga candidat";
            this.btnCandidat.UseVisualStyleBackColor = true;
            this.btnCandidat.Click += new System.EventHandler(this.btnCandidat_Click);
            // 
            // btnCandidatura
            // 
            this.btnCandidatura.Location = new System.Drawing.Point(72, 305);
            this.btnCandidatura.Name = "btnCandidatura";
            this.btnCandidatura.Size = new System.Drawing.Size(426, 75);
            this.btnCandidatura.TabIndex = 2;
            this.btnCandidatura.Text = "Adauga candidatura";
            this.btnCandidatura.UseVisualStyleBackColor = true;
            this.btnCandidatura.Click += new System.EventHandler(this.btnCandidatura_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admitere facultate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(636, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCandidatura);
            this.Controls.Add(this.btnCandidat);
            this.Controls.Add(this.btnFacultate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacultate;
        private System.Windows.Forms.Button btnCandidat;
        private System.Windows.Forms.Button btnCandidatura;
        private System.Windows.Forms.Label label1;
    }
}

