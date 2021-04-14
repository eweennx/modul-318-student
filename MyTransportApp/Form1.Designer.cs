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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 1427);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(60, 686);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1097, 562);
            this.listBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(403, 39);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(457, 507);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(403, 39);
            this.comboBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ziel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 574);
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
            this.label5.Location = new System.Drawing.Point(233, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 69);
            this.label5.TabIndex = 17;
            this.label5.Text = "Verbindungen suchen";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(1380, 686);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(742, 562);
            this.listBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2201, 1427);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.splitter2);
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
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
    }
}

