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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUhrzeit = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAbfahrtstafelSuchen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxStationVorschlaege = new System.Windows.Forms.ListBox();
            this.textBoxStation = new System.Windows.Forms.TextBox();
            this.dataGridViewAbfahrtstafel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.buttonChangeStation = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).BeginInit();
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
            this.splitter2.Size = new System.Drawing.Size(8, 1612);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
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
            this.label7.Location = new System.Drawing.Point(331, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Station";
            // 
            // buttonAbfahrtstafelSuchen
            // 
            this.buttonAbfahrtstafelSuchen.Location = new System.Drawing.Point(305, 467);
            this.buttonAbfahrtstafelSuchen.Name = "buttonAbfahrtstafelSuchen";
            this.buttonAbfahrtstafelSuchen.Size = new System.Drawing.Size(191, 55);
            this.buttonAbfahrtstafelSuchen.TabIndex = 24;
            this.buttonAbfahrtstafelSuchen.Text = "Suchen";
            this.buttonAbfahrtstafelSuchen.UseVisualStyleBackColor = true;
            this.buttonAbfahrtstafelSuchen.Click += new System.EventHandler(this.buttonAbfahrtstafelSuchen_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.listBoxStationVorschlaege);
            this.panel2.Controls.Add(this.textBoxStation);
            this.panel2.Controls.Add(this.dataGridViewAbfahrtstafel);
            this.panel2.Controls.Add(this.buttonAbfahrtstafelSuchen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1313, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 1171);
            this.panel2.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "Abfahrten suchen";
            // 
            // listBoxStationVorschlaege
            // 
            this.listBoxStationVorschlaege.FormattingEnabled = true;
            this.listBoxStationVorschlaege.ItemHeight = 31;
            this.listBoxStationVorschlaege.Location = new System.Drawing.Point(223, 181);
            this.listBoxStationVorschlaege.Name = "listBoxStationVorschlaege";
            this.listBoxStationVorschlaege.Size = new System.Drawing.Size(358, 190);
            this.listBoxStationVorschlaege.TabIndex = 32;
            this.listBoxStationVorschlaege.SelectedIndexChanged += new System.EventHandler(this.listBoxStationVorschlaege_SelectedIndexChanged);
            // 
            // textBoxStation
            // 
            this.textBoxStation.Location = new System.Drawing.Point(223, 128);
            this.textBoxStation.Name = "textBoxStation";
            this.textBoxStation.Size = new System.Drawing.Size(358, 38);
            this.textBoxStation.TabIndex = 30;
            this.textBoxStation.TextChanged += new System.EventHandler(this.textBoxStation_TextChanged);
            // 
            // dataGridViewAbfahrtstafel
            // 
            this.dataGridViewAbfahrtstafel.AllowUserToOrderColumns = true;
            this.dataGridViewAbfahrtstafel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAbfahrtstafel.ColumnHeadersHeight = 58;
            this.dataGridViewAbfahrtstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewAbfahrtstafel.Location = new System.Drawing.Point(39, 577);
            this.dataGridViewAbfahrtstafel.Name = "dataGridViewAbfahrtstafel";
            this.dataGridViewAbfahrtstafel.RowHeadersVisible = false;
            this.dataGridViewAbfahrtstafel.RowHeadersWidth = 102;
            this.dataGridViewAbfahrtstafel.RowTemplate.Height = 40;
            this.dataGridViewAbfahrtstafel.Size = new System.Drawing.Size(736, 460);
            this.dataGridViewAbfahrtstafel.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Zeit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nummer";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nach";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ziel";
            // 
            // buttonVerbindungenSuchen
            // 
            this.buttonVerbindungenSuchen.Location = new System.Drawing.Point(478, 327);
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
            this.label5.Location = new System.Drawing.Point(280, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 69);
            this.label5.TabIndex = 17;
            this.label5.Text = "Verbindungen suchen";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.timepicker);
            this.panel1.Controls.Add(this.datepicker);
            this.panel1.Controls.Add(this.buttonSendMail);
            this.panel1.Controls.Add(this.buttonChangeStation);
            this.panel1.Controls.Add(this.listBoxZielVorschlaege);
            this.panel1.Controls.Add(this.listBoxStartVorschlaege);
            this.panel1.Controls.Add(this.textBoxZielStation);
            this.panel1.Controls.Add(this.textBoxStart);
            this.panel1.Controls.Add(this.dataGridViewVerbindungen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonVerbindungenSuchen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(76, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 1171);
            this.panel1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(596, 1088);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(334, 32);
            this.label13.TabIndex = 31;
            this.label13.Text = "Verbindungen versenden";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Verbindungen suchen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Wechseln";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(304, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "Datum und Zeit ändern";
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "HH:mm";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepicker.Location = new System.Drawing.Point(740, 502);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(167, 38);
            this.timepicker.TabIndex = 30;
            // 
            // datepicker
            // 
            this.datepicker.CustomFormat = "yyyy:MM:dd hh/mm";
            this.datepicker.Location = new System.Drawing.Point(194, 502);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(499, 38);
            this.datepicker.TabIndex = 30;
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(956, 1070);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(177, 66);
            this.buttonSendMail.TabIndex = 30;
            this.buttonSendMail.Text = "Mail";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // buttonChangeStation
            // 
            this.buttonChangeStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeStation.Location = new System.Drawing.Point(513, 153);
            this.buttonChangeStation.Name = "buttonChangeStation";
            this.buttonChangeStation.Size = new System.Drawing.Size(134, 71);
            this.buttonChangeStation.TabIndex = 30;
            this.buttonChangeStation.Text = "⇄";
            this.buttonChangeStation.UseVisualStyleBackColor = true;
            this.buttonChangeStation.Click += new System.EventHandler(this.buttonChangeStation_Click);
            // 
            // listBoxZielVorschlaege
            // 
            this.listBoxZielVorschlaege.FormattingEnabled = true;
            this.listBoxZielVorschlaege.ItemHeight = 31;
            this.listBoxZielVorschlaege.Location = new System.Drawing.Point(775, 209);
            this.listBoxZielVorschlaege.Name = "listBoxZielVorschlaege";
            this.listBoxZielVorschlaege.Size = new System.Drawing.Size(358, 252);
            this.listBoxZielVorschlaege.TabIndex = 32;
            this.listBoxZielVorschlaege.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxZielVorschlaege_SelectedIndexChanged);
            // 
            // listBoxStartVorschlaege
            // 
            this.listBoxStartVorschlaege.FormattingEnabled = true;
            this.listBoxStartVorschlaege.ItemHeight = 31;
            this.listBoxStartVorschlaege.Location = new System.Drawing.Point(59, 209);
            this.listBoxStartVorschlaege.Name = "listBoxStartVorschlaege";
            this.listBoxStartVorschlaege.Size = new System.Drawing.Size(358, 252);
            this.listBoxStartVorschlaege.TabIndex = 31;
            this.listBoxStartVorschlaege.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStartVorschlaege_SelectedIndexChanged);
            // 
            // textBoxZielStation
            // 
            this.textBoxZielStation.Location = new System.Drawing.Point(775, 144);
            this.textBoxZielStation.Name = "textBoxZielStation";
            this.textBoxZielStation.Size = new System.Drawing.Size(358, 38);
            this.textBoxZielStation.TabIndex = 30;
            this.textBoxZielStation.TextChanged += new System.EventHandler(this.textBoxZielStation_TextChanged_1);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(59, 144);
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
            this.dataGridViewVerbindungen.Location = new System.Drawing.Point(59, 577);
            this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
            this.dataGridViewVerbindungen.RowHeadersVisible = false;
            this.dataGridViewVerbindungen.RowHeadersWidth = 102;
            this.dataGridViewVerbindungen.RowTemplate.Height = 40;
            this.dataGridViewVerbindungen.Size = new System.Drawing.Size(1074, 460);
            this.dataGridViewVerbindungen.TabIndex = 30;
            // 
            // GleisKante
            // 
            this.GleisKante.HeaderText = "Kante";
            this.GleisKante.MinimumWidth = 50;
            this.GleisKante.Name = "GleisKante";
            this.GleisKante.Width = 50;
            // 
            // Zeit
            // 
            this.Zeit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.MinimumWidth = 65;
            this.Zeit.Name = "Zeit";
            this.Zeit.Width = 65;
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Von.HeaderText = "Von";
            this.Von.MinimumWidth = 75;
            this.Von.Name = "Von";
            this.Von.Width = 108;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nach.HeaderText = "Nach";
            this.Nach.MinimumWidth = 75;
            this.Nach.Name = "Nach";
            this.Nach.Width = 108;
            // 
            // Dauer
            // 
            this.Dauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 50;
            this.Dauer.Name = "Dauer";
            this.Dauer.Width = 52;
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
            this.labelZeit.Location = new System.Drawing.Point(1757, 68);
            this.labelZeit.Name = "labelZeit";
            this.labelZeit.Size = new System.Drawing.Size(226, 69);
            this.labelZeit.TabIndex = 29;
            this.labelZeit.Text = "Uhrzeit";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2201, 1612);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelZeit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.labelUhrzeit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbfahrtstafel)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAbfahrtstafelSuchen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVerbindungenSuchen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAbfahrtstafel;
        private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
        private System.Windows.Forms.ListBox listBoxZielVorschlaege;
        private System.Windows.Forms.ListBox listBoxStartVorschlaege;
        private System.Windows.Forms.TextBox textBoxZielStation;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Timer timerUhrzeit;
        private System.Windows.Forms.Label labelZeit;
        private System.Windows.Forms.TextBox textBoxStation;
        private System.Windows.Forms.ListBox listBoxStationVorschlaege;
        private System.Windows.Forms.Button buttonChangeStation;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GleisKante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.Label label13;
    }
}

