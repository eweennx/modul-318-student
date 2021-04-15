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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUhrzeit = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAbfahrtstafelSuchen = new System.Windows.Forms.Button();
            this.buttonNaechsteStation = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxZielVorschlaege = new System.Windows.Forms.ListBox();
            this.listBoxStartVorschlaege = new System.Windows.Forms.ListBox();
            this.textBoxZielStation = new System.Windows.Forms.TextBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.dataGridViewVerbindungen = new System.Windows.Forms.DataGridView();
            this.GleisKante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerUhrzeit = new System.Windows.Forms.Timer(this.components);
            this.labelZeit = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 29);
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
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(255, 124);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(403, 39);
            this.comboBoxStation.TabIndex = 19;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewAbfahrtstafel);
            this.panel2.Controls.Add(this.buttonAbfahrtstafelSuchen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxStation);
            this.panel2.Location = new System.Drawing.Point(1303, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 662);
            this.panel2.TabIndex = 27;
            // 
            // dataGridViewAbfahrtstafel
            // 
            this.dataGridViewAbfahrtstafel.AllowUserToOrderColumns = true;
            this.dataGridViewAbfahrtstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewAbfahrtstafel.Location = new System.Drawing.Point(49, 276);
            this.dataGridViewAbfahrtstafel.Name = "dataGridViewAbfahrtstafel";
            this.dataGridViewAbfahrtstafel.RowHeadersWidth = 102;
            this.dataGridViewAbfahrtstafel.RowTemplate.Height = 40;
            this.dataGridViewAbfahrtstafel.Size = new System.Drawing.Size(736, 356);
            this.dataGridViewAbfahrtstafel.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Kante";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 144;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Zeit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 117;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nummer";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 176;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nach";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 135;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonNaechsteStation);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1303, 905);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 268);
            this.panel3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ziel";
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(498, 435);
            this.buttonVerbindungenSuchen.Name = "buttonVerbindungenSuchen";
            this.buttonVerbindungenSuchen.Size = new System.Drawing.Size(234, 64);
            this.buttonVerbindungenSuchen.TabIndex = 16;
            this.buttonVerbindungenSuchen.Text = "Suchen";
            this.buttonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.buttonVerbindungenSuchen.Click += new System.EventHandler(this.buttonVerbindungenSuchen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 69);
            this.label5.TabIndex = 17;
            this.label5.Text = "Verbindungen suchen";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxZielVorschlaege);
            this.panel1.Controls.Add(this.listBoxStartVorschlaege);
            this.panel1.Controls.Add(this.textBoxZielStation);
            this.panel1.Controls.Add(this.textBoxStart);
            this.panel1.Controls.Add(this.dataGridViewVerbindungen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonVerbindungenSuchen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(60, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 1101);
            this.panel1.TabIndex = 26;
            // 
            // listBoxZielVorschlaege
            // 
            this.listBoxZielVorschlaege.FormattingEnabled = true;
            this.listBoxZielVorschlaege.ItemHeight = 31;
            this.listBoxZielVorschlaege.Location = new System.Drawing.Point(715, 213);
            this.listBoxZielVorschlaege.Name = "listBoxZielVorschlaege";
            this.listBoxZielVorschlaege.Size = new System.Drawing.Size(358, 190);
            this.listBoxZielVorschlaege.TabIndex = 32;
            this.listBoxZielVorschlaege.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxZielVorschlaege_MouseClick);
            // 
            // listBoxStartVorschlaege
            // 
            this.listBoxStartVorschlaege.FormattingEnabled = true;
            this.listBoxStartVorschlaege.ItemHeight = 31;
            this.listBoxStartVorschlaege.Location = new System.Drawing.Point(150, 213);
            this.listBoxStartVorschlaege.Name = "listBoxStartVorschlaege";
            this.listBoxStartVorschlaege.Size = new System.Drawing.Size(358, 190);
            this.listBoxStartVorschlaege.TabIndex = 31;
            this.listBoxStartVorschlaege.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStartVorschlaege_MouseClick);
            // 
            // textBoxZielStation
            // 
            this.textBoxZielStation.Location = new System.Drawing.Point(715, 153);
            this.textBoxZielStation.Name = "textBoxZielStation";
            this.textBoxZielStation.Size = new System.Drawing.Size(358, 38);
            this.textBoxZielStation.TabIndex = 30;
            this.textBoxZielStation.TextChanged += new System.EventHandler(this.textBoxZielStation_TextChanged_1);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(150, 154);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(358, 38);
            this.textBoxStart.TabIndex = 30;
            this.textBoxStart.TextChanged += new System.EventHandler(this.textBoxStart_TextChanged_1);
            // 
            // dataGridViewVerbindungen
            // 
            this.dataGridViewVerbindungen.AllowUserToOrderColumns = true;
            this.dataGridViewVerbindungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GleisKante,
            this.Zeit,
            this.Von,
            this.Nach,
            this.Dauer});
            this.dataGridViewVerbindungen.Location = new System.Drawing.Point(59, 530);
            this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
            this.dataGridViewVerbindungen.RowHeadersWidth = 102;
            this.dataGridViewVerbindungen.RowTemplate.Height = 40;
            this.dataGridViewVerbindungen.Size = new System.Drawing.Size(1074, 508);
            this.dataGridViewVerbindungen.TabIndex = 30;
            // 
            // GleisKante
            // 
            this.GleisKante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.GleisKante.HeaderText = "Kante";
            this.GleisKante.MinimumWidth = 20;
            this.GleisKante.Name = "GleisKante";
            this.GleisKante.Width = 144;
            // 
            // Zeit
            // 
            this.Zeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.MinimumWidth = 75;
            this.Zeit.Name = "Zeit";
            this.Zeit.Width = 117;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 75;
            this.Von.Name = "Von";
            this.Von.Width = 120;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Nach.HeaderText = "Nach";
            this.Nach.MinimumWidth = 75;
            this.Nach.Name = "Nach";
            this.Nach.Width = 135;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 75;
            this.Dauer.Name = "Dauer";
            this.Dauer.Width = 75;
            // 
            // timerUhrzeit
            // 
            this.timerUhrzeit.Enabled = true;
            this.timerUhrzeit.Interval = 500;
            this.timerUhrzeit.Tick += new System.EventHandler(this.timerUhr_Tick);
            // 
            // labelZeit
            // 
            this.labelZeit.AutoSize = true;
            this.labelZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZeit.Location = new System.Drawing.Point(1638, 74);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(226, 69);
            this.labelZeit.TabIndex = 29;
            this.labelZeit.Text = "Uhrzeit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2201, 1531);
            this.Controls.Add(this.labelZeit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUhrzeit;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAbfahrtstafelSuchen;
        private System.Windows.Forms.Button buttonNaechsteStation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAbfahrtstafel;
        private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ListBox listBoxZielVorschlaege;
        private System.Windows.Forms.ListBox listBoxStartVorschlaege;
        private System.Windows.Forms.TextBox textBoxZielStation;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn GleisKante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.Timer timerUhrzeit;
        private System.Windows.Forms.Label labelZeit;
    }
}

