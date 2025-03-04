namespace BlackJack
{
    partial class frmMain
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
            this.splitP1 = new System.Windows.Forms.SplitContainer();
            this.btnP1Hit = new System.Windows.Forms.Button();
            this.btnP1Stay = new System.Windows.Forms.Button();
            this.splitP2 = new System.Windows.Forms.SplitContainer();
            this.btnP2Hit = new System.Windows.Forms.Button();
            this.btnP2Stay = new System.Windows.Forms.Button();
            this.pnlP1 = new System.Windows.Forms.Panel();
            this.flpP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblP1 = new System.Windows.Forms.Label();
            this.pnlP1Score = new System.Windows.Forms.Panel();
            this.lblP1ScoreOutput = new System.Windows.Forms.Label();
            this.lblP1Score = new System.Windows.Forms.Label();
            this.pnlP2 = new System.Windows.Forms.Panel();
            this.flpP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblP2 = new System.Windows.Forms.Label();
            this.pnlP2Score = new System.Windows.Forms.Panel();
            this.lblP2ScoreOutput = new System.Windows.Forms.Label();
            this.lblP2Score = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblP1Win = new System.Windows.Forms.Label();
            this.pnlP1Stats = new System.Windows.Forms.Panel();
            this.lblP1WinOutput = new System.Windows.Forms.Label();
            this.lblP1BlackJack = new System.Windows.Forms.Label();
            this.lblP1BlackJackOutput = new System.Windows.Forms.Label();
            this.lblP2Win = new System.Windows.Forms.Label();
            this.pnlP2Stats = new System.Windows.Forms.Panel();
            this.lblP2BlackJackOutput = new System.Windows.Forms.Label();
            this.lblP2BlackJack = new System.Windows.Forms.Label();
            this.lblP2WinOutput = new System.Windows.Forms.Label();
            this.btnP1Stats = new System.Windows.Forms.Button();
            this.btnP2Stats = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitP1)).BeginInit();
            this.splitP1.Panel1.SuspendLayout();
            this.splitP1.Panel2.SuspendLayout();
            this.splitP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitP2)).BeginInit();
            this.splitP2.Panel1.SuspendLayout();
            this.splitP2.Panel2.SuspendLayout();
            this.splitP2.SuspendLayout();
            this.pnlP1.SuspendLayout();
            this.pnlP1Score.SuspendLayout();
            this.pnlP2.SuspendLayout();
            this.pnlP2Score.SuspendLayout();
            this.pnlP1Stats.SuspendLayout();
            this.pnlP2Stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitP1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitP2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlP1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlP1Score, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlP2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlP2Score, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlP1Stats, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlP2Stats, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnP1Stats, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnP2Stats, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitP1
            // 
            this.splitP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitP1.Location = new System.Drawing.Point(769, 3);
            this.splitP1.Name = "splitP1";
            this.splitP1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitP1.Panel1
            // 
            this.splitP1.Panel1.Controls.Add(this.btnP1Hit);
            // 
            // splitP1.Panel2
            // 
            this.splitP1.Panel2.Controls.Add(this.btnP1Stay);
            this.splitP1.Size = new System.Drawing.Size(94, 159);
            this.splitP1.SplitterDistance = 71;
            this.splitP1.TabIndex = 1;
            // 
            // btnP1Hit
            // 
            this.btnP1Hit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP1Hit.Location = new System.Drawing.Point(0, 0);
            this.btnP1Hit.Name = "btnP1Hit";
            this.btnP1Hit.Size = new System.Drawing.Size(94, 71);
            this.btnP1Hit.TabIndex = 0;
            this.btnP1Hit.Text = "Hit me!";
            this.btnP1Hit.UseVisualStyleBackColor = true;
            this.btnP1Hit.Click += new System.EventHandler(this.btnP1Hit_Click);
            // 
            // btnP1Stay
            // 
            this.btnP1Stay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP1Stay.Location = new System.Drawing.Point(0, 0);
            this.btnP1Stay.Name = "btnP1Stay";
            this.btnP1Stay.Size = new System.Drawing.Size(94, 84);
            this.btnP1Stay.TabIndex = 0;
            this.btnP1Stay.Text = "Stay";
            this.btnP1Stay.UseVisualStyleBackColor = true;
            this.btnP1Stay.Click += new System.EventHandler(this.btnP1Stay_Click);
            // 
            // splitP2
            // 
            this.splitP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitP2.Location = new System.Drawing.Point(769, 168);
            this.splitP2.Name = "splitP2";
            this.splitP2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitP2.Panel1
            // 
            this.splitP2.Panel1.Controls.Add(this.btnP2Hit);
            // 
            // splitP2.Panel2
            // 
            this.splitP2.Panel2.Controls.Add(this.btnP2Stay);
            this.splitP2.Size = new System.Drawing.Size(94, 159);
            this.splitP2.SplitterDistance = 70;
            this.splitP2.TabIndex = 2;
            // 
            // btnP2Hit
            // 
            this.btnP2Hit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP2Hit.Location = new System.Drawing.Point(0, 0);
            this.btnP2Hit.Name = "btnP2Hit";
            this.btnP2Hit.Size = new System.Drawing.Size(94, 70);
            this.btnP2Hit.TabIndex = 0;
            this.btnP2Hit.Text = "Hit Me!";
            this.btnP2Hit.UseVisualStyleBackColor = true;
            this.btnP2Hit.Click += new System.EventHandler(this.btnP2Hit_Click);
            // 
            // btnP2Stay
            // 
            this.btnP2Stay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP2Stay.Location = new System.Drawing.Point(0, 0);
            this.btnP2Stay.Name = "btnP2Stay";
            this.btnP2Stay.Size = new System.Drawing.Size(94, 85);
            this.btnP2Stay.TabIndex = 0;
            this.btnP2Stay.Text = "Stay";
            this.btnP2Stay.UseVisualStyleBackColor = true;
            this.btnP2Stay.Click += new System.EventHandler(this.btnP2Stay_Click);
            // 
            // pnlP1
            // 
            this.pnlP1.Controls.Add(this.flpP1);
            this.pnlP1.Controls.Add(this.lblP1);
            this.pnlP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP1.Location = new System.Drawing.Point(3, 3);
            this.pnlP1.Name = "pnlP1";
            this.pnlP1.Size = new System.Drawing.Size(660, 159);
            this.pnlP1.TabIndex = 7;
            // 
            // flpP1
            // 
            this.flpP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpP1.Location = new System.Drawing.Point(10, 57);
            this.flpP1.Name = "flpP1";
            this.flpP1.Size = new System.Drawing.Size(638, 99);
            this.flpP1.TabIndex = 7;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.Location = new System.Drawing.Point(3, 6);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(113, 31);
            this.lblP1.TabIndex = 6;
            this.lblP1.Text = "Player 1";
            // 
            // pnlP1Score
            // 
            this.pnlP1Score.Controls.Add(this.lblP1ScoreOutput);
            this.pnlP1Score.Controls.Add(this.lblP1Score);
            this.pnlP1Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP1Score.Location = new System.Drawing.Point(669, 3);
            this.pnlP1Score.Name = "pnlP1Score";
            this.pnlP1Score.Size = new System.Drawing.Size(94, 159);
            this.pnlP1Score.TabIndex = 8;
            // 
            // lblP1ScoreOutput
            // 
            this.lblP1ScoreOutput.AutoSize = true;
            this.lblP1ScoreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1ScoreOutput.Location = new System.Drawing.Point(8, 36);
            this.lblP1ScoreOutput.Name = "lblP1ScoreOutput";
            this.lblP1ScoreOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP1ScoreOutput.TabIndex = 4;
            this.lblP1ScoreOutput.Text = "0";
            // 
            // lblP1Score
            // 
            this.lblP1Score.AutoSize = true;
            this.lblP1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Score.Location = new System.Drawing.Point(3, 6);
            this.lblP1Score.Name = "lblP1Score";
            this.lblP1Score.Size = new System.Drawing.Size(75, 26);
            this.lblP1Score.TabIndex = 3;
            this.lblP1Score.Text = "Score:";
            // 
            // pnlP2
            // 
            this.pnlP2.Controls.Add(this.flpP2);
            this.pnlP2.Controls.Add(this.lblP2);
            this.pnlP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP2.Location = new System.Drawing.Point(3, 168);
            this.pnlP2.Name = "pnlP2";
            this.pnlP2.Size = new System.Drawing.Size(660, 159);
            this.pnlP2.TabIndex = 9;
            // 
            // flpP2
            // 
            this.flpP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpP2.Location = new System.Drawing.Point(9, 57);
            this.flpP2.Name = "flpP2";
            this.flpP2.Size = new System.Drawing.Size(638, 99);
            this.flpP2.TabIndex = 8;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.Location = new System.Drawing.Point(3, 9);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(113, 31);
            this.lblP2.TabIndex = 6;
            this.lblP2.Text = "Player 2";
            // 
            // pnlP2Score
            // 
            this.pnlP2Score.Controls.Add(this.lblP2ScoreOutput);
            this.pnlP2Score.Controls.Add(this.lblP2Score);
            this.pnlP2Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP2Score.Location = new System.Drawing.Point(669, 168);
            this.pnlP2Score.Name = "pnlP2Score";
            this.pnlP2Score.Size = new System.Drawing.Size(94, 159);
            this.pnlP2Score.TabIndex = 10;
            // 
            // lblP2ScoreOutput
            // 
            this.lblP2ScoreOutput.AutoSize = true;
            this.lblP2ScoreOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2ScoreOutput.Location = new System.Drawing.Point(8, 42);
            this.lblP2ScoreOutput.Name = "lblP2ScoreOutput";
            this.lblP2ScoreOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP2ScoreOutput.TabIndex = 5;
            this.lblP2ScoreOutput.Text = "0";
            // 
            // lblP2Score
            // 
            this.lblP2Score.AutoSize = true;
            this.lblP2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Score.Location = new System.Drawing.Point(3, 9);
            this.lblP2Score.Name = "lblP2Score";
            this.lblP2Score.Size = new System.Drawing.Size(75, 26);
            this.lblP2Score.TabIndex = 4;
            this.lblP2Score.Text = "Score:";
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Location = new System.Drawing.Point(869, 333);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 54);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblP1Win
            // 
            this.lblP1Win.AutoSize = true;
            this.lblP1Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Win.Location = new System.Drawing.Point(3, 6);
            this.lblP1Win.Name = "lblP1Win";
            this.lblP1Win.Size = new System.Drawing.Size(82, 26);
            this.lblP1Win.TabIndex = 12;
            this.lblP1Win.Text = "Win %:";
            // 
            // pnlP1Stats
            // 
            this.pnlP1Stats.Controls.Add(this.lblP1BlackJackOutput);
            this.pnlP1Stats.Controls.Add(this.lblP1BlackJack);
            this.pnlP1Stats.Controls.Add(this.lblP1WinOutput);
            this.pnlP1Stats.Controls.Add(this.lblP1Win);
            this.pnlP1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP1Stats.Location = new System.Drawing.Point(869, 3);
            this.pnlP1Stats.Name = "pnlP1Stats";
            this.pnlP1Stats.Size = new System.Drawing.Size(94, 159);
            this.pnlP1Stats.TabIndex = 12;
            // 
            // lblP1WinOutput
            // 
            this.lblP1WinOutput.AutoSize = true;
            this.lblP1WinOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1WinOutput.Location = new System.Drawing.Point(31, 36);
            this.lblP1WinOutput.Name = "lblP1WinOutput";
            this.lblP1WinOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP1WinOutput.TabIndex = 13;
            this.lblP1WinOutput.Text = "0";
            // 
            // lblP1BlackJack
            // 
            this.lblP1BlackJack.AutoSize = true;
            this.lblP1BlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1BlackJack.Location = new System.Drawing.Point(4, 88);
            this.lblP1BlackJack.Name = "lblP1BlackJack";
            this.lblP1BlackJack.Size = new System.Drawing.Size(57, 26);
            this.lblP1BlackJack.TabIndex = 14;
            this.lblP1BlackJack.Text = "21\'s:";
            // 
            // lblP1BlackJackOutput
            // 
            this.lblP1BlackJackOutput.AutoSize = true;
            this.lblP1BlackJackOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1BlackJackOutput.Location = new System.Drawing.Point(31, 114);
            this.lblP1BlackJackOutput.Name = "lblP1BlackJackOutput";
            this.lblP1BlackJackOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP1BlackJackOutput.TabIndex = 15;
            this.lblP1BlackJackOutput.Text = "0";
            // 
            // lblP2Win
            // 
            this.lblP2Win.AutoSize = true;
            this.lblP2Win.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Win.Location = new System.Drawing.Point(3, 9);
            this.lblP2Win.Name = "lblP2Win";
            this.lblP2Win.Size = new System.Drawing.Size(82, 26);
            this.lblP2Win.TabIndex = 16;
            this.lblP2Win.Text = "Win %:";
            // 
            // pnlP2Stats
            // 
            this.pnlP2Stats.Controls.Add(this.lblP2BlackJackOutput);
            this.pnlP2Stats.Controls.Add(this.lblP2Win);
            this.pnlP2Stats.Controls.Add(this.lblP2BlackJack);
            this.pnlP2Stats.Controls.Add(this.lblP2WinOutput);
            this.pnlP2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlP2Stats.Location = new System.Drawing.Point(869, 168);
            this.pnlP2Stats.Name = "pnlP2Stats";
            this.pnlP2Stats.Size = new System.Drawing.Size(94, 159);
            this.pnlP2Stats.TabIndex = 13;
            // 
            // lblP2BlackJackOutput
            // 
            this.lblP2BlackJackOutput.AutoSize = true;
            this.lblP2BlackJackOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2BlackJackOutput.Location = new System.Drawing.Point(31, 113);
            this.lblP2BlackJackOutput.Name = "lblP2BlackJackOutput";
            this.lblP2BlackJackOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP2BlackJackOutput.TabIndex = 18;
            this.lblP2BlackJackOutput.Text = "0";
            // 
            // lblP2BlackJack
            // 
            this.lblP2BlackJack.AutoSize = true;
            this.lblP2BlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2BlackJack.Location = new System.Drawing.Point(4, 87);
            this.lblP2BlackJack.Name = "lblP2BlackJack";
            this.lblP2BlackJack.Size = new System.Drawing.Size(57, 26);
            this.lblP2BlackJack.TabIndex = 17;
            this.lblP2BlackJack.Text = "21\'s:";
            // 
            // lblP2WinOutput
            // 
            this.lblP2WinOutput.AutoSize = true;
            this.lblP2WinOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2WinOutput.Location = new System.Drawing.Point(31, 35);
            this.lblP2WinOutput.Name = "lblP2WinOutput";
            this.lblP2WinOutput.Size = new System.Drawing.Size(30, 31);
            this.lblP2WinOutput.TabIndex = 16;
            this.lblP2WinOutput.Text = "0";
            // 
            // btnP1Stats
            // 
            this.btnP1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP1Stats.Location = new System.Drawing.Point(669, 333);
            this.btnP1Stats.Name = "btnP1Stats";
            this.btnP1Stats.Size = new System.Drawing.Size(94, 54);
            this.btnP1Stats.TabIndex = 14;
            this.btnP1Stats.Text = "P1 Stats";
            this.btnP1Stats.UseVisualStyleBackColor = true;
            // 
            // btnP2Stats
            // 
            this.btnP2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP2Stats.Location = new System.Drawing.Point(769, 333);
            this.btnP2Stats.Name = "btnP2Stats";
            this.btnP2Stats.Size = new System.Drawing.Size(94, 54);
            this.btnP2Stats.TabIndex = 15;
            this.btnP2Stats.Text = "P2 Stats";
            this.btnP2Stats.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(801, 381);
            this.Name = "frmMain";
            this.Text = "BlackJack";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitP1.Panel1.ResumeLayout(false);
            this.splitP1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitP1)).EndInit();
            this.splitP1.ResumeLayout(false);
            this.splitP2.Panel1.ResumeLayout(false);
            this.splitP2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitP2)).EndInit();
            this.splitP2.ResumeLayout(false);
            this.pnlP1.ResumeLayout(false);
            this.pnlP1.PerformLayout();
            this.pnlP1Score.ResumeLayout(false);
            this.pnlP1Score.PerformLayout();
            this.pnlP2.ResumeLayout(false);
            this.pnlP2.PerformLayout();
            this.pnlP2Score.ResumeLayout(false);
            this.pnlP2Score.PerformLayout();
            this.pnlP1Stats.ResumeLayout(false);
            this.pnlP1Stats.PerformLayout();
            this.pnlP2Stats.ResumeLayout(false);
            this.pnlP2Stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnP1Hit;
        private System.Windows.Forms.SplitContainer splitP1;
        private System.Windows.Forms.SplitContainer splitP2;
        private System.Windows.Forms.Button btnP1Stay;
        private System.Windows.Forms.Button btnP2Hit;
        private System.Windows.Forms.Button btnP2Stay;
        private System.Windows.Forms.Label lblP1Score;
        private System.Windows.Forms.Label lblP2Score;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Panel pnlP1;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Panel pnlP1Score;
        private System.Windows.Forms.Panel pnlP2;
        private System.Windows.Forms.Panel pnlP2Score;
        private System.Windows.Forms.FlowLayoutPanel flpP1;
        private System.Windows.Forms.FlowLayoutPanel flpP2;
        private System.Windows.Forms.Label lblP1ScoreOutput;
        private System.Windows.Forms.Label lblP2ScoreOutput;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblP1Win;
        private System.Windows.Forms.Panel pnlP1Stats;
        private System.Windows.Forms.Label lblP1BlackJack;
        private System.Windows.Forms.Label lblP1WinOutput;
        private System.Windows.Forms.Label lblP1BlackJackOutput;
        private System.Windows.Forms.Panel pnlP2Stats;
        private System.Windows.Forms.Label lblP2BlackJackOutput;
        private System.Windows.Forms.Label lblP2Win;
        private System.Windows.Forms.Label lblP2BlackJack;
        private System.Windows.Forms.Label lblP2WinOutput;
        private System.Windows.Forms.Button btnP1Stats;
        private System.Windows.Forms.Button btnP2Stats;
    }
}

