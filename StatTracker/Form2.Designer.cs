namespace StatTracker
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.strikeoutLabel = new System.Windows.Forms.Label();
            this.eraLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.battingLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.leagueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.battingBox = new System.Windows.Forms.TextBox();
            this.hitsBox = new System.Windows.Forms.TextBox();
            this.eraBox = new System.Windows.Forms.TextBox();
            this.strikeoutsBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.leagueBox = new System.Windows.Forms.ComboBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.9341F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.46705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.46418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.04011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.19198F));
            this.tableLayoutPanel1.Controls.Add(this.positionBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yearBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.strikeoutLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.eraLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.hitsLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.battingLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.yearLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.leagueLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.battingBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.hitsBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.eraBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.strikeoutsBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.leagueBox, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearBox.Location = new System.Drawing.Point(580, 15);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(115, 20);
            this.yearBox.TabIndex = 10;
            this.yearBox.TextChanged += new System.EventHandler(this.yearBox_TextChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionLabel.Location = new System.Drawing.Point(3, 50);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(109, 50);
            this.positionLabel.TabIndex = 7;
            this.positionLabel.Text = "Position";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strikeoutLabel
            // 
            this.strikeoutLabel.AutoSize = true;
            this.strikeoutLabel.BackColor = System.Drawing.SystemColors.Control;
            this.strikeoutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.strikeoutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strikeoutLabel.Location = new System.Drawing.Point(3, 350);
            this.strikeoutLabel.Name = "strikeoutLabel";
            this.strikeoutLabel.Size = new System.Drawing.Size(109, 50);
            this.strikeoutLabel.TabIndex = 6;
            this.strikeoutLabel.Text = "Strike Outs";
            this.strikeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eraLabel
            // 
            this.eraLabel.AutoSize = true;
            this.eraLabel.BackColor = System.Drawing.SystemColors.Control;
            this.eraLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eraLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eraLabel.Location = new System.Drawing.Point(3, 300);
            this.eraLabel.Name = "eraLabel";
            this.eraLabel.Size = new System.Drawing.Size(109, 50);
            this.eraLabel.TabIndex = 5;
            this.eraLabel.Text = "ERA";
            this.eraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.hitsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitsLabel.Location = new System.Drawing.Point(3, 200);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(109, 50);
            this.hitsLabel.TabIndex = 4;
            this.hitsLabel.Text = "Hits";
            this.hitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battingLabel
            // 
            this.battingLabel.AutoSize = true;
            this.battingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.battingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.battingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.battingLabel.Location = new System.Drawing.Point(3, 150);
            this.battingLabel.Name = "battingLabel";
            this.battingLabel.Size = new System.Drawing.Size(109, 50);
            this.battingLabel.TabIndex = 3;
            this.battingLabel.Text = "Batting Average";
            this.battingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearLabel.Location = new System.Drawing.Point(483, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(91, 50);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year";
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leagueLabel
            // 
            this.leagueLabel.AutoSize = true;
            this.leagueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.leagueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leagueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leagueLabel.Location = new System.Drawing.Point(304, 0);
            this.leagueLabel.Name = "leagueLabel";
            this.leagueLabel.Size = new System.Drawing.Size(87, 50);
            this.leagueLabel.TabIndex = 1;
            this.leagueLabel.Text = "League";
            this.leagueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(109, 50);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Player Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameBox.Location = new System.Drawing.Point(118, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 8;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // battingBox
            // 
            this.battingBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.battingBox.Location = new System.Drawing.Point(118, 165);
            this.battingBox.Name = "battingBox";
            this.battingBox.Size = new System.Drawing.Size(180, 20);
            this.battingBox.TabIndex = 12;
            this.battingBox.TextChanged += new System.EventHandler(this.battingBox_TextChanged);
            // 
            // hitsBox
            // 
            this.hitsBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hitsBox.Location = new System.Drawing.Point(118, 215);
            this.hitsBox.Name = "hitsBox";
            this.hitsBox.Size = new System.Drawing.Size(180, 20);
            this.hitsBox.TabIndex = 13;
            this.hitsBox.TextChanged += new System.EventHandler(this.hitsBox_TextChanged);
            // 
            // eraBox
            // 
            this.eraBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.eraBox.Location = new System.Drawing.Point(118, 315);
            this.eraBox.Name = "eraBox";
            this.eraBox.Size = new System.Drawing.Size(180, 20);
            this.eraBox.TabIndex = 14;
            this.eraBox.TextChanged += new System.EventHandler(this.eraBox_TextChanged);
            // 
            // strikeoutsBox
            // 
            this.strikeoutsBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.strikeoutsBox.Location = new System.Drawing.Point(118, 365);
            this.strikeoutsBox.Name = "strikeoutsBox";
            this.strikeoutsBox.Size = new System.Drawing.Size(180, 20);
            this.strikeoutsBox.TabIndex = 15;
            this.strikeoutsBox.TextChanged += new System.EventHandler(this.strikeoutsBox_TextChanged);
            // 
            // submitButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.submitButton, 2);
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.Location = new System.Drawing.Point(304, 403);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(173, 51);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // leagueBox
            // 
            this.leagueBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leagueBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leagueBox.FormattingEnabled = true;
            this.leagueBox.Items.AddRange(new object[] {
            "MLB",
            "AAA",
            "AA",
            "A"});
            this.leagueBox.Location = new System.Drawing.Point(397, 14);
            this.leagueBox.Name = "leagueBox";
            this.leagueBox.Size = new System.Drawing.Size(80, 21);
            this.leagueBox.TabIndex = 17;
            this.leagueBox.SelectedIndexChanged += new System.EventHandler(this.leagueBox_SelectedIndexChanged);
            // 
            // positionBox
            // 
            this.positionBox.AllowDrop = true;
            this.positionBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.positionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "SP",
            "RP",
            "CP",
            "1B",
            "2B",
            "3B",
            "SS",
            "LF",
            "CF",
            "RF"});
            this.positionBox.Location = new System.Drawing.Point(118, 64);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(180, 21);
            this.positionBox.TabIndex = 26;
            this.positionBox.SelectedIndexChanged += new System.EventHandler(this.positionBox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Prospect Stats";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label leagueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label strikeoutLabel;
        private System.Windows.Forms.Label eraLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Label battingLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox battingBox;
        private System.Windows.Forms.TextBox hitsBox;
        private System.Windows.Forms.TextBox eraBox;
        private System.Windows.Forms.TextBox strikeoutsBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox leagueBox;
        private System.Windows.Forms.ComboBox positionBox;
    }
}