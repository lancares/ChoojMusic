namespace Lancares
{
    partial class Form1
    {
        
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playersCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundsCount = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playersList = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.chooseNameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.scoreValuesLabel = new System.Windows.Forms.Label();
            this.scoreNamesLabel = new System.Windows.Forms.Label();
            this.animationPanel = new System.Windows.Forms.Panel();
            this.whosNextPanel = new System.Windows.Forms.Panel();
            this.whosNextLabel = new System.Windows.Forms.Label();
            this.startTrackPlaying = new System.Windows.Forms.Button();
            this.RatingPanel = new System.Windows.Forms.Panel();
            this.rateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ratingPlayer = new System.Windows.Forms.Label();
            this.markChooseMenu = new System.Windows.Forms.NumericUpDown();
            this.TrackPlayingPanel = new System.Windows.Forms.Panel();
            this.playerPlayingLabel = new System.Windows.Forms.Label();
            this.startRatingButton = new System.Windows.Forms.Button();
            this.activePlayerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundsCount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.whosNextPanel.SuspendLayout();
            this.RatingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markChooseMenu)).BeginInit();
            this.TrackPlayingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersCount
            // 
            this.playersCount.Location = new System.Drawing.Point(162, 19);
            this.playersCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.playersCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playersCount.Name = "playersCount";
            this.playersCount.Size = new System.Drawing.Size(120, 20);
            this.playersCount.TabIndex = 3;
            this.playersCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.playersCount.ValueChanged += new System.EventHandler(this.playersCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba graczy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liczba rund";
            // 
            // roundsCount
            // 
            this.roundsCount.Location = new System.Drawing.Point(162, 50);
            this.roundsCount.Name = "roundsCount";
            this.roundsCount.Size = new System.Drawing.Size(120, 20);
            this.roundsCount.TabIndex = 6;
            this.roundsCount.ValueChanged += new System.EventHandler(this.roundsCount_ValueChanged);
            // 
            // proceedButton
            // 
            this.proceedButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proceedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.proceedButton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.proceedButton.FlatAppearance.BorderSize = 4;
            this.proceedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.proceedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.proceedButton.ForeColor = System.Drawing.SystemColors.Control;
            this.proceedButton.Location = new System.Drawing.Point(30, 84);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(252, 39);
            this.proceedButton.TabIndex = 2;
            this.proceedButton.Text = "Dalej";
            this.proceedButton.UseVisualStyleBackColor = false;
            this.proceedButton.Visible = false;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            this.proceedButton.MouseEnter += new System.EventHandler(this.proceedButton_MouseEnter);
            this.proceedButton.MouseLeave += new System.EventHandler(this.proceedButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.proceedButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.playersCount);
            this.panel1.Controls.Add(this.roundsCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 408);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(399, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 73);
            this.label4.TabIndex = 8;
            this.label4.Text = "Application design / logo © 2019 Lancaster Solutions Inc; user contributions lice" +
    "nsed under cc by-sa 3.0 with attribution required. rev 2019.8.23.34694";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(329, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chooj music";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.playersList);
            this.panel2.Controls.Add(this.playButton);
            this.panel2.Controls.Add(this.chooseNameButton);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 408);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // playersList
            // 
            this.playersList.BackColor = System.Drawing.Color.Transparent;
            this.playersList.Font = new System.Drawing.Font("Perpetua Titling MT", 17F, System.Drawing.FontStyle.Bold);
            this.playersList.ForeColor = System.Drawing.Color.White;
            this.playersList.Location = new System.Drawing.Point(30, 133);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(216, 166);
            this.playersList.TabIndex = 12;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.SystemColors.Window;
            this.playButton.Location = new System.Drawing.Point(402, 302);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(216, 70);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "Graj";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // chooseNameButton
            // 
            this.chooseNameButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chooseNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chooseNameButton.ForeColor = System.Drawing.SystemColors.Window;
            this.chooseNameButton.Location = new System.Drawing.Point(30, 90);
            this.chooseNameButton.Name = "chooseNameButton";
            this.chooseNameButton.Size = new System.Drawing.Size(216, 40);
            this.chooseNameButton.TabIndex = 9;
            this.chooseNameButton.Text = "Wybierz nick";
            this.chooseNameButton.UseVisualStyleBackColor = false;
            this.chooseNameButton.Click += new System.EventHandler(this.chooseNameButton_Click_1);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Location = new System.Drawing.Point(30, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(216, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(26, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(122, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Wybiera gracz";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.scorePanel);
            this.panel3.Controls.Add(this.animationPanel);
            this.panel3.Controls.Add(this.whosNextPanel);
            this.panel3.Controls.Add(this.RatingPanel);
            this.panel3.Controls.Add(this.TrackPlayingPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 408);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.Transparent;
            this.scorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorePanel.Controls.Add(this.scoreValuesLabel);
            this.scorePanel.Controls.Add(this.scoreNamesLabel);
            this.scorePanel.Location = new System.Drawing.Point(231, 19);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(200, 236);
            this.scorePanel.TabIndex = 3;
            this.scorePanel.Visible = false;
            this.scorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.scorePanel_Paint);
            // 
            // scoreValuesLabel
            // 
            this.scoreValuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreValuesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreValuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.scoreValuesLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.scoreValuesLabel.Location = new System.Drawing.Point(148, 12);
            this.scoreValuesLabel.Name = "scoreValuesLabel";
            this.scoreValuesLabel.Size = new System.Drawing.Size(42, 211);
            this.scoreValuesLabel.TabIndex = 3;
            this.scoreValuesLabel.Text = "Punkty";
            this.scoreValuesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoreNamesLabel
            // 
            this.scoreNamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreNamesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.scoreNamesLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.scoreNamesLabel.Location = new System.Drawing.Point(3, 12);
            this.scoreNamesLabel.Name = "scoreNamesLabel";
            this.scoreNamesLabel.Size = new System.Drawing.Size(105, 211);
            this.scoreNamesLabel.TabIndex = 2;
            this.scoreNamesLabel.Text = "Gracze";
            // 
            // animationPanel
            // 
            this.animationPanel.BackColor = System.Drawing.Color.Transparent;
            this.animationPanel.Location = new System.Drawing.Point(30, 324);
            this.animationPanel.Name = "animationPanel";
            this.animationPanel.Size = new System.Drawing.Size(586, 48);
            this.animationPanel.TabIndex = 16;
            this.animationPanel.Visible = false;
            // 
            // whosNextPanel
            // 
            this.whosNextPanel.BackColor = System.Drawing.Color.Transparent;
            this.whosNextPanel.Controls.Add(this.whosNextLabel);
            this.whosNextPanel.Controls.Add(this.startTrackPlaying);
            this.whosNextPanel.Location = new System.Drawing.Point(227, 19);
            this.whosNextPanel.Name = "whosNextPanel";
            this.whosNextPanel.Size = new System.Drawing.Size(207, 158);
            this.whosNextPanel.TabIndex = 15;
            // 
            // whosNextLabel
            // 
            this.whosNextLabel.BackColor = System.Drawing.Color.Transparent;
            this.whosNextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whosNextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.whosNextLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.whosNextLabel.Location = new System.Drawing.Point(4, 31);
            this.whosNextLabel.Name = "whosNextLabel";
            this.whosNextLabel.Size = new System.Drawing.Size(200, 50);
            this.whosNextLabel.TabIndex = 15;
            this.whosNextLabel.Text = "Wjeżdża na DJ\'kę: Maciek";
            this.whosNextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTrackPlaying
            // 
            this.startTrackPlaying.BackColor = System.Drawing.Color.Black;
            this.startTrackPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.startTrackPlaying.ForeColor = System.Drawing.SystemColors.Window;
            this.startTrackPlaying.Location = new System.Drawing.Point(4, 84);
            this.startTrackPlaying.Name = "startTrackPlaying";
            this.startTrackPlaying.Size = new System.Drawing.Size(200, 44);
            this.startTrackPlaying.TabIndex = 14;
            this.startTrackPlaying.Text = "Zapuszczam Track";
            this.startTrackPlaying.UseVisualStyleBackColor = false;
            this.startTrackPlaying.Click += new System.EventHandler(this.startTrackPlaying_Click);
            // 
            // RatingPanel
            // 
            this.RatingPanel.BackColor = System.Drawing.Color.Transparent;
            this.RatingPanel.Controls.Add(this.rateButton);
            this.RatingPanel.Controls.Add(this.label5);
            this.RatingPanel.Controls.Add(this.ratingPlayer);
            this.RatingPanel.Controls.Add(this.markChooseMenu);
            this.RatingPanel.Location = new System.Drawing.Point(30, 288);
            this.RatingPanel.Name = "RatingPanel";
            this.RatingPanel.Size = new System.Drawing.Size(586, 48);
            this.RatingPanel.TabIndex = 12;
            this.RatingPanel.Visible = false;
            // 
            // rateButton
            // 
            this.rateButton.BackColor = System.Drawing.Color.Black;
            this.rateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.rateButton.Location = new System.Drawing.Point(320, 9);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(265, 30);
            this.rateButton.TabIndex = 13;
            this.rateButton.Text = "Wystaw notę";
            this.rateButton.UseVisualStyleBackColor = false;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(-6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ocenia:";
            // 
            // ratingPlayer
            // 
            this.ratingPlayer.BackColor = System.Drawing.Color.Transparent;
            this.ratingPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ratingPlayer.ForeColor = System.Drawing.SystemColors.Window;
            this.ratingPlayer.Location = new System.Drawing.Point(79, 9);
            this.ratingPlayer.Name = "ratingPlayer";
            this.ratingPlayer.Size = new System.Drawing.Size(104, 25);
            this.ratingPlayer.TabIndex = 1;
            this.ratingPlayer.Text = "Gracz 1";
            // 
            // markChooseMenu
            // 
            this.markChooseMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.markChooseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.markChooseMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.markChooseMenu.Location = new System.Drawing.Point(225, 9);
            this.markChooseMenu.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.markChooseMenu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markChooseMenu.Name = "markChooseMenu";
            this.markChooseMenu.Size = new System.Drawing.Size(89, 30);
            this.markChooseMenu.TabIndex = 11;
            this.markChooseMenu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TrackPlayingPanel
            // 
            this.TrackPlayingPanel.BackColor = System.Drawing.Color.Transparent;
            this.TrackPlayingPanel.Controls.Add(this.playerPlayingLabel);
            this.TrackPlayingPanel.Controls.Add(this.startRatingButton);
            this.TrackPlayingPanel.Controls.Add(this.activePlayerLabel);
            this.TrackPlayingPanel.Location = new System.Drawing.Point(30, 288);
            this.TrackPlayingPanel.Name = "TrackPlayingPanel";
            this.TrackPlayingPanel.Size = new System.Drawing.Size(586, 30);
            this.TrackPlayingPanel.TabIndex = 2;
            this.TrackPlayingPanel.Visible = false;
            // 
            // playerPlayingLabel
            // 
            this.playerPlayingLabel.AutoSize = true;
            this.playerPlayingLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerPlayingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerPlayingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.playerPlayingLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.playerPlayingLabel.Location = new System.Drawing.Point(-5, 5);
            this.playerPlayingLabel.Name = "playerPlayingLabel";
            this.playerPlayingLabel.Size = new System.Drawing.Size(109, 25);
            this.playerPlayingLabel.TabIndex = 0;
            this.playerPlayingLabel.Text = "Zapodaje:";
            // 
            // startRatingButton
            // 
            this.startRatingButton.BackColor = System.Drawing.Color.Black;
            this.startRatingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.startRatingButton.ForeColor = System.Drawing.SystemColors.Window;
            this.startRatingButton.Location = new System.Drawing.Point(372, 0);
            this.startRatingButton.Name = "startRatingButton";
            this.startRatingButton.Size = new System.Drawing.Size(214, 30);
            this.startRatingButton.TabIndex = 10;
            this.startRatingButton.Text = "Zacznij oceniać";
            this.startRatingButton.UseVisualStyleBackColor = false;
            this.startRatingButton.Click += new System.EventHandler(this.startRatingButton_Click);
            // 
            // activePlayerLabel
            // 
            this.activePlayerLabel.AutoSize = true;
            this.activePlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.activePlayerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activePlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.activePlayerLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.activePlayerLabel.Location = new System.Drawing.Point(102, 5);
            this.activePlayerLabel.Name = "activePlayerLabel";
            this.activePlayerLabel.Size = new System.Drawing.Size(87, 25);
            this.activePlayerLabel.TabIndex = 1;
            this.activePlayerLabel.Text = "Gracz 1";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.chooseNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ChoojMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundsCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.scorePanel.ResumeLayout(false);
            this.whosNextPanel.ResumeLayout(false);
            this.RatingPanel.ResumeLayout(false);
            this.RatingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markChooseMenu)).EndInit();
            this.TrackPlayingPanel.ResumeLayout(false);
            this.TrackPlayingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown roundsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown playersCount;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button chooseNameButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label scoreNamesLabel;
        private System.Windows.Forms.Panel TrackPlayingPanel;
        private System.Windows.Forms.Label playerPlayingLabel;
        private System.Windows.Forms.Label activePlayerLabel;
        private System.Windows.Forms.Button startRatingButton;
        private System.Windows.Forms.Panel RatingPanel;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ratingPlayer;
        private System.Windows.Forms.NumericUpDown markChooseMenu;
        private System.Windows.Forms.Button startTrackPlaying;
        private System.Windows.Forms.Label scoreValuesLabel;
        private System.Windows.Forms.Panel whosNextPanel;
        private System.Windows.Forms.Label whosNextLabel;
        private System.Windows.Forms.Panel animationPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playersList;
    }
}

