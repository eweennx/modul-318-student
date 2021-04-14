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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.listBoxVerbindungen = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxAbfahrtstafel = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAbfahrtstafelSuchen = new System.Windows.Forms.Button();
            this.buttonNaechsteStation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 25);
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
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 1531);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // listBoxVerbindungen
            // 
            this.listBoxVerbindungen.FormattingEnabled = true;
            this.listBoxVerbindungen.ItemHeight = 31;
            this.listBoxVerbindungen.Location = new System.Drawing.Point(24, 372);
            this.listBoxVerbindungen.MultiColumn = true;
            this.listBoxVerbindungen.Name = "listBoxVerbindungen";
            this.listBoxVerbindungen.Size = new System.Drawing.Size(1097, 562);
            this.listBoxVerbindungen.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(403, 39);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(395, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(403, 39);
            this.comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ziel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 64);
            this.button1.TabIndex = 16;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 69);
            this.label5.TabIndex = 17;
            this.label5.Text = "Verbindungen suchen";
            // 
            // listBoxAbfahrtstafel
            // 
            this.listBoxAbfahrtstafel.FormattingEnabled = true;
            this.listBoxAbfahrtstafel.ItemHeight = 31;
            this.listBoxAbfahrtstafel.Location = new System.Drawing.Point(33, 285);
            this.listBoxAbfahrtstafel.Name = "listBoxAbfahrtstafel";
            this.listBoxAbfahrtstafel.Size = new System.Drawing.Size(742, 345);
            this.listBoxAbfahrtstafel.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(255, 124);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(403, 39);
            this.comboBox3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(594, 69);
            this.label6.TabIndex = 20;
            this.label6.Text = "Abfahrtstafel suchen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Station";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(633, 69);
            this.label8.TabIndex = 22;
            this.label8.Text = "Deine nächste Station";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "labelNächsteStation";
            // 
            // buttonAbfahrtstafelSuchen
            // 
            this.buttonAbfahrtstafelSuchen.Location = new System.Drawing.Point(358, 188);
            this.buttonAbfahrtstafelSuchen.Name = "buttonAbfahrtstafelSuchen";
            this.buttonAbfahrtstafelSuchen.Size = new System.Drawing.Size(191, 55);
            this.buttonAbfahrtstafelSuchen.TabIndex = 24;
            this.buttonAbfahrtstafelSuchen.Text = "Suchen";
            this.buttonAbfahrtstafelSuchen.UseVisualStyleBackColor = true;
            // 
            // buttonNaechsteStation
            // 
            this.buttonNaechsteStation.Location = new System.Drawing.Point(489, 114);
            this.buttonNaechsteStation.Name = "buttonNaechsteStation";
            this.buttonNaechsteStation.Size = new System.Drawing.Size(234, 95);
            this.buttonNaechsteStation.TabIndex = 25;
            this.buttonNaechsteStation.Text = "Abfahrtstafel sehen";
            this.buttonNaechsteStation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.listBoxVerbindungen);
            this.panel1.Location = new System.Drawing.Point(60, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 996);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAbfahrtstafelSuchen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.listBoxAbfahrtstafel);
            this.panel2.Location = new System.Drawing.Point(1303, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 662);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonNaechsteStation);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1303, 905);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 303);
            this.panel3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2201, 1531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUhrzeit;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListBox listBoxVerbindungen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxAbfahrtstafel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAbfahrtstafelSuchen;
        private System.Windows.Forms.Button buttonNaechsteStation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

