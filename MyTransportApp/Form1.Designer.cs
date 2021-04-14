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
            this.textBoxStartOrt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZielOrt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // textBoxStartOrt
            // 
            this.textBoxStartOrt.Location = new System.Drawing.Point(290, 505);
            this.textBoxStartOrt.Name = "textBoxStartOrt";
            this.textBoxStartOrt.Size = new System.Drawing.Size(375, 38);
            this.textBoxStartOrt.TabIndex = 1;
            this.textBoxStartOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStartOrt.TextChanged += new System.EventHandler(this.textBoxStartOrt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suche Verbindungen";
            // 
            // textBoxZielOrt
            // 
            this.textBoxZielOrt.Location = new System.Drawing.Point(290, 587);
            this.textBoxZielOrt.Name = "textBoxZielOrt";
            this.textBoxZielOrt.Size = new System.Drawing.Size(375, 38);
            this.textBoxZielOrt.TabIndex = 3;
            this.textBoxZielOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ziel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVerbindungenSuchen);
            this.panel1.Location = new System.Drawing.Point(164, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 408);
            this.panel1.TabIndex = 7;
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(200, 284);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(208, 91);
            this.buttonVerbindungenSuchen.TabIndex = 0;
            this.buttonVerbindungenSuchen.Text = "Verbindungen suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2555, 1678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZielOrt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStartOrt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartOrt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZielOrt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
    }
}

