namespace A_Day_At_The_Races
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.race = new System.Windows.Forms.Button();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.alBet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.BettorName = new System.Windows.Forms.Label();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.race.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("race.BackgroundImage")));
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.race.Location = new System.Drawing.Point(1053, 522);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(322, 166);
            this.race.TabIndex = 0;
            this.race.Text = "Race!";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click_1);
            // 
            // racetrack
            // 
            this.racetrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("racetrack.BackgroundImage")));
            this.racetrack.Location = new System.Drawing.Point(12, 12);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1402, 456);
            this.racetrack.TabIndex = 1;
            this.racetrack.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bets";
            // 
            // joeBet
            // 
            this.joeBet.AutoSize = true;
            this.joeBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joeBet.Location = new System.Drawing.Point(598, 538);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(94, 20);
            this.joeBet.TabIndex = 3;
            this.joeBet.Text = "joeBetLabel";
            // 
            // bobBet
            // 
            this.bobBet.AutoSize = true;
            this.bobBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobBet.Location = new System.Drawing.Point(598, 577);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(100, 20);
            this.bobBet.TabIndex = 4;
            this.bobBet.Text = "bobBetLabel";
            // 
            // alBet
            // 
            this.alBet.AutoSize = true;
            this.alBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alBet.Location = new System.Drawing.Point(602, 614);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(85, 20);
            this.alBet.TabIndex = 5;
            this.alBet.Text = "alBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Betting Parlor";
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Location = new System.Drawing.Point(123, 561);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(98, 17);
            this.joeButton.TabIndex = 8;
            this.joeButton.TabStop = true;
            this.joeButton.Text = "joeRadioButton";
            this.joeButton.UseVisualStyleBackColor = true;
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Location = new System.Drawing.Point(123, 591);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(102, 17);
            this.bobButton.TabIndex = 9;
            this.bobButton.TabStop = true;
            this.bobButton.Text = "bobRadioButton";
            this.bobButton.UseVisualStyleBackColor = true;
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(123, 617);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(92, 17);
            this.alButton.TabIndex = 10;
            this.alButton.TabStop = true;
            this.alButton.Text = "alRadioButton";
            this.alButton.UseVisualStyleBackColor = true;
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(641, 668);
            this.DogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(30, 20);
            this.DogNumber.TabIndex = 11;
            this.DogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 664);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "bucks on dog number";
            // 
            // BetAmount
            // 
            this.BetAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Location = new System.Drawing.Point(424, 668);
            this.BetAmount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(46, 20);
            this.BetAmount.TabIndex = 13;
            this.BetAmount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 665);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "BETS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BettorName
            // 
            this.BettorName.AutoSize = true;
            this.BettorName.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BettorName.Location = new System.Drawing.Point(267, 660);
            this.BettorName.Name = "BettorName";
            this.BettorName.Size = new System.Drawing.Size(53, 28);
            this.BettorName.TabIndex = 15;
            this.BettorName.Text = "name";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBet.Location = new System.Drawing.Point(104, 538);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(151, 20);
            this.MinimumBet.TabIndex = 16;
            this.MinimumBet.Text = "minimumBetLabel";
            // 
            // dog1
            // 
            this.dog1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog1.BackgroundImage")));
            this.dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog1.Location = new System.Drawing.Point(83, 29);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(129, 65);
            this.dog1.TabIndex = 17;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog2.BackgroundImage")));
            this.dog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog2.Location = new System.Drawing.Point(65, 129);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(147, 73);
            this.dog2.TabIndex = 18;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog3.BackgroundImage")));
            this.dog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog3.Location = new System.Drawing.Point(65, 263);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(147, 76);
            this.dog3.TabIndex = 19;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dog4.BackgroundImage")));
            this.dog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dog4.Location = new System.Drawing.Point(65, 382);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(147, 72);
            this.dog4.TabIndex = 20;
            this.dog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 731);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.MinimumBet);
            this.Controls.Add(this.BettorName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DogNumber);
            this.Controls.Add(this.alButton);
            this.Controls.Add(this.bobButton);
            this.Controls.Add(this.joeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alBet);
            this.Controls.Add(this.bobBet);
            this.Controls.Add(this.joeBet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.racetrack);
            this.Controls.Add(this.race);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button race;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BettorName;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
    }
}

