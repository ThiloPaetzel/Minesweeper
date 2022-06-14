
namespace Demineur
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNbrOfFlags = new System.Windows.Forms.Label();
            this.lblNbrOfBombs = new System.Windows.Forms.Label();
            this.lblFlag = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lblTime);
            this.splitContainer.Panel1.Controls.Add(this.lblNbrOfFlags);
            this.splitContainer.Panel1.Controls.Add(this.lblNbrOfBombs);
            this.splitContainer.Panel1.Controls.Add(this.lblFlag);
            this.splitContainer.Panel1.Controls.Add(this.lblScore);
            this.splitContainer.Panel1.Controls.Add(this.btnNewGame);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnHard);
            this.splitContainer.Panel2.Controls.Add(this.btnMedium);
            this.splitContainer.Panel2.Controls.Add(this.btnEasy);
            this.splitContainer.Size = new System.Drawing.Size(942, 534);
            this.splitContainer.SplitterDistance = 141;
            this.splitContainer.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(28, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 5;
            // 
            // lblNbrOfFlags
            // 
            this.lblNbrOfFlags.AutoSize = true;
            this.lblNbrOfFlags.Location = new System.Drawing.Point(260, 86);
            this.lblNbrOfFlags.Name = "lblNbrOfFlags";
            this.lblNbrOfFlags.Size = new System.Drawing.Size(108, 15);
            this.lblNbrOfFlags.TabIndex = 4;
            this.lblNbrOfFlags.Text = "Number of flags : 0";
            // 
            // lblNbrOfBombs
            // 
            this.lblNbrOfBombs.AutoSize = true;
            this.lblNbrOfBombs.Location = new System.Drawing.Point(260, 30);
            this.lblNbrOfBombs.Name = "lblNbrOfBombs";
            this.lblNbrOfBombs.Size = new System.Drawing.Size(114, 15);
            this.lblNbrOfBombs.TabIndex = 3;
            this.lblNbrOfBombs.Text = "Number of bombs : ";
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFlag.Location = new System.Drawing.Point(12, 62);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(222, 15);
            this.lblFlag.TabIndex = 2;
            this.lblFlag.Text = "To flag a button use the mouse wheel !";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(28, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(45, 15);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score : ";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(455, 0);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(487, 138);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(653, 206);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(400, 206);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(153, 206);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 534);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Demineur";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.Label lblNbrOfBombs;
        private System.Windows.Forms.Label lblNbrOfFlags;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}

