namespace MyTransportApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUhrzeit = new System.Windows.Forms.Label();
            this.buttonVerbindungenSuchenForm = new System.Windows.Forms.Button();
            this.buttonAbfahrtsTafelForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1350, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖV-Software SteamVac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2488, -22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // labelUhrzeit
            // 
            this.labelUhrzeit.AutoSize = true;
            this.labelUhrzeit.Location = new System.Drawing.Point(1740, 212);
            this.labelUhrzeit.Name = "labelUhrzeit";
            this.labelUhrzeit.Size = new System.Drawing.Size(0, 32);
            this.labelUhrzeit.TabIndex = 8;
            // 
            // buttonVerbindungenSuchenForm
            // 
            this.buttonVerbindungenSuchenForm.Location = new System.Drawing.Point(148, 410);
            this.buttonVerbindungenSuchenForm.Name = "buttonVerbindungenSuchenForm";
            this.buttonVerbindungenSuchenForm.Size = new System.Drawing.Size(762, 352);
            this.buttonVerbindungenSuchenForm.TabIndex = 9;
            this.buttonVerbindungenSuchenForm.Text = "Verbindungen suchen";
            this.buttonVerbindungenSuchenForm.UseVisualStyleBackColor = true;
            // 
            // buttonAbfahrtsTafelForm
            // 
            this.buttonAbfahrtsTafelForm.Location = new System.Drawing.Point(1125, 410);
            this.buttonAbfahrtsTafelForm.Name = "buttonAbfahrtsTafelForm";
            this.buttonAbfahrtsTafelForm.Size = new System.Drawing.Size(762, 352);
            this.buttonAbfahrtsTafelForm.TabIndex = 10;
            this.buttonAbfahrtsTafelForm.Text = "Abfahrtstafel";
            this.buttonAbfahrtsTafelForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2201, 1427);
            this.Controls.Add(this.buttonAbfahrtsTafelForm);
            this.Controls.Add(this.buttonVerbindungenSuchenForm);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUhrzeit;
        private System.Windows.Forms.Button buttonVerbindungenSuchenForm;
        private System.Windows.Forms.Button buttonAbfahrtsTafelForm;
    }
}

