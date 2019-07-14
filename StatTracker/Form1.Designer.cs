namespace StatTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.draftRoundBox = new System.Windows.Forms.ComboBox();
            this.spotBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.potentialBox = new System.Windows.Forms.TextBox();
            this.draftSpotLabel = new System.Windows.Forms.Label();
            this.draftRoundLabel = new System.Windows.Forms.Label();
            this.draftYearLabel = new System.Windows.Forms.Label();
            this.potentialLabel = new System.Windows.Forms.Label();
            this.overallLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.form2Button = new System.Windows.Forms.Button();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.overallBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overallBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.draftRoundBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.spotBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.yearBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.potentialBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.draftSpotLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.draftRoundLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.draftYearLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.potentialLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.overallLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.positionLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.submit, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.form2Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.positionBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.overallBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 703);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // draftRoundBox
            // 
            this.draftRoundBox.AllowDrop = true;
            this.draftRoundBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.draftRoundBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.draftRoundBox.FormattingEnabled = true;
            this.draftRoundBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.draftRoundBox.Location = new System.Drawing.Point(161, 493);
            this.draftRoundBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.draftRoundBox.Name = "draftRoundBox";
            this.draftRoundBox.Size = new System.Drawing.Size(184, 28);
            this.draftRoundBox.TabIndex = 26;
            this.draftRoundBox.SelectedIndexChanged += new System.EventHandler(this.draftRoundBox_SelectedIndexChanged);
            // 
            // spotBox
            // 
            this.spotBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spotBox.Location = new System.Drawing.Point(161, 572);
            this.spotBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spotBox.Name = "spotBox";
            this.spotBox.Size = new System.Drawing.Size(862, 26);
            this.spotBox.TabIndex = 14;
            this.spotBox.TextChanged += new System.EventHandler(this.spotBox_TextChanged);
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearBox.Location = new System.Drawing.Point(161, 416);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(880, 26);
            this.yearBox.TabIndex = 12;
            this.yearBox.TextChanged += new System.EventHandler(this.yearBox_TextChanged);
            // 
            // potentialBox
            // 
            this.potentialBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.potentialBox.Location = new System.Drawing.Point(161, 338);
            this.potentialBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.potentialBox.Name = "potentialBox";
            this.potentialBox.Size = new System.Drawing.Size(862, 26);
            this.potentialBox.TabIndex = 11;
            this.potentialBox.TextChanged += new System.EventHandler(this.potentialBox_TextChanged);
            // 
            // draftSpotLabel
            // 
            this.draftSpotLabel.BackColor = System.Drawing.SystemColors.Control;
            this.draftSpotLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.draftSpotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draftSpotLabel.Location = new System.Drawing.Point(4, 546);
            this.draftSpotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.draftSpotLabel.Name = "draftSpotLabel";
            this.draftSpotLabel.Size = new System.Drawing.Size(149, 78);
            this.draftSpotLabel.TabIndex = 15;
            this.draftSpotLabel.Text = "Player\'s Draft Spot";
            this.draftSpotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draftRoundLabel
            // 
            this.draftRoundLabel.BackColor = System.Drawing.SystemColors.Control;
            this.draftRoundLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.draftRoundLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draftRoundLabel.Location = new System.Drawing.Point(4, 468);
            this.draftRoundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.draftRoundLabel.Name = "draftRoundLabel";
            this.draftRoundLabel.Size = new System.Drawing.Size(149, 78);
            this.draftRoundLabel.TabIndex = 16;
            this.draftRoundLabel.Text = "Player\'s Draft Round";
            this.draftRoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draftYearLabel
            // 
            this.draftYearLabel.BackColor = System.Drawing.SystemColors.Control;
            this.draftYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.draftYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.draftYearLabel.Location = new System.Drawing.Point(4, 390);
            this.draftYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.draftYearLabel.Name = "draftYearLabel";
            this.draftYearLabel.Size = new System.Drawing.Size(149, 78);
            this.draftYearLabel.TabIndex = 17;
            this.draftYearLabel.Text = "Player\'s Draft Year";
            this.draftYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potentialLabel
            // 
            this.potentialLabel.BackColor = System.Drawing.SystemColors.Control;
            this.potentialLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.potentialLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potentialLabel.Location = new System.Drawing.Point(4, 312);
            this.potentialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.potentialLabel.Name = "potentialLabel";
            this.potentialLabel.Size = new System.Drawing.Size(149, 78);
            this.potentialLabel.TabIndex = 18;
            this.potentialLabel.Text = "Player\'s Potential";
            this.potentialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overallLabel
            // 
            this.overallLabel.BackColor = System.Drawing.SystemColors.Control;
            this.overallLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.overallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallLabel.Location = new System.Drawing.Point(4, 234);
            this.overallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overallLabel.Name = "overallLabel";
            this.overallLabel.Size = new System.Drawing.Size(149, 78);
            this.overallLabel.TabIndex = 19;
            this.overallLabel.Text = "Player\'s Overall";
            this.overallLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionLabel
            // 
            this.positionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.positionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionLabel.Location = new System.Drawing.Point(4, 156);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(149, 78);
            this.positionLabel.TabIndex = 20;
            this.positionLabel.Text = "Player\'s Position";
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(4, 78);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(149, 78);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Player\'s Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameBox.Location = new System.Drawing.Point(161, 104);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(862, 26);
            this.nameBox.TabIndex = 8;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(161, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(882, 78);
            this.label2.TabIndex = 23;
            this.label2.Text = "MLB The Show Prospect Input";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.submit.Location = new System.Drawing.Point(11, 631);
            this.submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(135, 65);
            this.submit.TabIndex = 22;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // form2Button
            // 
            this.form2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form2Button.Location = new System.Drawing.Point(4, 5);
            this.form2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.form2Button.Name = "form2Button";
            this.form2Button.Size = new System.Drawing.Size(149, 68);
            this.form2Button.TabIndex = 24;
            this.form2Button.Text = "Stat Entry";
            this.form2Button.UseVisualStyleBackColor = true;
            this.form2Button.Click += new System.EventHandler(this.form2Button_Click);
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
            "RF",
            "C"});
            this.positionBox.Location = new System.Drawing.Point(161, 181);
            this.positionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(184, 28);
            this.positionBox.TabIndex = 25;
            this.positionBox.SelectedIndexChanged += new System.EventHandler(this.positionBox_SelectedIndexChanged);
            // 
            // overallBox
            // 
            this.overallBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.overallBox.Location = new System.Drawing.Point(161, 260);
            this.overallBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.overallBox.Name = "overallBox";
            this.overallBox.Size = new System.Drawing.Size(186, 26);
            this.overallBox.TabIndex = 27;
            this.overallBox.ValueChanged += new System.EventHandler(this.overallBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1047, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "StatTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.DraftForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overallBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox spotBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox potentialBox;
        private System.Windows.Forms.Label draftSpotLabel;
        private System.Windows.Forms.Label draftRoundLabel;
        private System.Windows.Forms.Label draftYearLabel;
        private System.Windows.Forms.Label potentialLabel;
        private System.Windows.Forms.Label overallLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button form2Button;
        private System.Windows.Forms.ComboBox positionBox;
        private System.Windows.Forms.ComboBox draftRoundBox;
        private System.Windows.Forms.NumericUpDown overallBox;
    }
}

