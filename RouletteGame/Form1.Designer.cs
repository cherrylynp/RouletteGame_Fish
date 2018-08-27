namespace RouletteGame
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
            this.btnCastLine = new System.Windows.Forms.Button();
            this.btnLetGo = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pbxClap = new System.Windows.Forms.PictureBox();
            this.pbxWinLose = new System.Windows.Forms.PictureBox();
            this.pbxFish = new System.Windows.Forms.PictureBox();
            this.lblNoCast = new System.Windows.Forms.Label();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblLetGo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCastLine
            // 
            this.btnCastLine.Location = new System.Drawing.Point(12, 12);
            this.btnCastLine.Name = "btnCastLine";
            this.btnCastLine.Size = new System.Drawing.Size(114, 36);
            this.btnCastLine.TabIndex = 0;
            this.btnCastLine.Text = "Cast your line";
            this.btnCastLine.UseVisualStyleBackColor = true;
            this.btnCastLine.Click += new System.EventHandler(this.btnCastLine_Click);
            // 
            // btnLetGo
            // 
            this.btnLetGo.Location = new System.Drawing.Point(12, 103);
            this.btnLetGo.Name = "btnLetGo";
            this.btnLetGo.Size = new System.Drawing.Size(114, 36);
            this.btnLetGo.TabIndex = 1;
            this.btnLetGo.Text = "Let go";
            this.btnLetGo.UseVisualStyleBackColor = true;
            this.btnLetGo.Click += new System.EventHandler(this.btnLetGo_Click);
            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(12, 61);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(114, 36);
            this.btnCatch.TabIndex = 2;
            this.btnCatch.Text = "Catch Fish";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 178);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(114, 36);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click_1);
            // 
            // pbxClap
            // 
            this.pbxClap.BackColor = System.Drawing.Color.Transparent;
            this.pbxClap.Cursor = System.Windows.Forms.Cursors.No;
            this.pbxClap.Location = new System.Drawing.Point(280, 12);
            this.pbxClap.Name = "pbxClap";
            this.pbxClap.Size = new System.Drawing.Size(155, 134);
            this.pbxClap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxClap.TabIndex = 4;
            this.pbxClap.TabStop = false;
            // 
            // pbxWinLose
            // 
            this.pbxWinLose.BackColor = System.Drawing.Color.Transparent;
            this.pbxWinLose.Location = new System.Drawing.Point(455, 12);
            this.pbxWinLose.Name = "pbxWinLose";
            this.pbxWinLose.Size = new System.Drawing.Size(155, 134);
            this.pbxWinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxWinLose.TabIndex = 5;
            this.pbxWinLose.TabStop = false;
            // 
            // pbxFish
            // 
            this.pbxFish.BackColor = System.Drawing.Color.Transparent;
            this.pbxFish.Location = new System.Drawing.Point(375, 203);
            this.pbxFish.Name = "pbxFish";
            this.pbxFish.Size = new System.Drawing.Size(269, 163);
            this.pbxFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFish.TabIndex = 6;
            this.pbxFish.TabStop = false;
            // 
            // lblNoCast
            // 
            this.lblNoCast.AutoSize = true;
            this.lblNoCast.Location = new System.Drawing.Point(143, 73);
            this.lblNoCast.Name = "lblNoCast";
            this.lblNoCast.Size = new System.Drawing.Size(76, 13);
            this.lblNoCast.TabIndex = 7;
            this.lblNoCast.Text = "No. Cast Used";
            this.lblNoCast.Click += new System.EventHandler(this.lblNoCast_Click);
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Location = new System.Drawing.Point(30, 242);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(49, 13);
            this.lblWinLose.TabIndex = 8;
            this.lblWinLose.Text = "WinLose";
            // 
            // lblLetGo
            // 
            this.lblLetGo.AutoSize = true;
            this.lblLetGo.Location = new System.Drawing.Point(143, 117);
            this.lblLetGo.Name = "lblLetGo";
            this.lblLetGo.Size = new System.Drawing.Size(67, 13);
            this.lblLetGo.TabIndex = 9;
            this.lblLetGo.Text = "No. released";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RouletteGame.Resource1.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.lblLetGo);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.lblNoCast);
            this.Controls.Add(this.pbxFish);
            this.Controls.Add(this.pbxWinLose);
            this.Controls.Add(this.pbxClap);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnLetGo);
            this.Controls.Add(this.btnCastLine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxClap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCastLine;
        private System.Windows.Forms.Button btnLetGo;
        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox pbxClap;
        private System.Windows.Forms.PictureBox pbxWinLose;
        private System.Windows.Forms.PictureBox pbxFish;
        private System.Windows.Forms.Label lblNoCast;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblLetGo;
    }
}

