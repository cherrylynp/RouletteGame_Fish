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
            this.btnHowToPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWinLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFish)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCastLine
            // 
            this.btnCastLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCastLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCastLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCastLine.Location = new System.Drawing.Point(25, 120);
            this.btnCastLine.Name = "btnCastLine";
            this.btnCastLine.Size = new System.Drawing.Size(144, 41);
            this.btnCastLine.TabIndex = 0;
            this.btnCastLine.Text = "Cast your line";
            this.btnCastLine.UseVisualStyleBackColor = false;
            this.btnCastLine.Click += new System.EventHandler(this.btnCastLine_Click);
            // 
            // btnLetGo
            // 
            this.btnLetGo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLetGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetGo.Location = new System.Drawing.Point(25, 245);
            this.btnLetGo.Name = "btnLetGo";
            this.btnLetGo.Size = new System.Drawing.Size(144, 40);
            this.btnLetGo.TabIndex = 1;
            this.btnLetGo.Text = "Unhook";
            this.btnLetGo.UseVisualStyleBackColor = false;
            this.btnLetGo.Click += new System.EventHandler(this.btnLetGo_Click);
            // 
            // btnCatch
            // 
            this.btnCatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatch.Location = new System.Drawing.Point(25, 182);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(144, 40);
            this.btnCatch.TabIndex = 2;
            this.btnCatch.Text = "Catch Fish";
            this.btnCatch.UseVisualStyleBackColor = false;
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayAgain.Location = new System.Drawing.Point(25, 339);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(126, 41);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
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
            this.pbxFish.Location = new System.Drawing.Point(469, 238);
            this.pbxFish.Name = "pbxFish";
            this.pbxFish.Size = new System.Drawing.Size(291, 193);
            this.pbxFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFish.TabIndex = 6;
            this.pbxFish.TabStop = false;
            // 
            // lblNoCast
            // 
            this.lblNoCast.AutoSize = true;
            this.lblNoCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCast.Location = new System.Drawing.Point(175, 194);
            this.lblNoCast.Name = "lblNoCast";
            this.lblNoCast.Size = new System.Drawing.Size(98, 15);
            this.lblNoCast.TabIndex = 7;
            this.lblNoCast.Text = "No. Cast Used";
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.Location = new System.Drawing.Point(36, 411);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(78, 20);
            this.lblWinLose.TabIndex = 8;
            this.lblWinLose.Text = "WinLose";
            // 
            // lblLetGo
            // 
            this.lblLetGo.AutoSize = true;
            this.lblLetGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetGo.Location = new System.Drawing.Point(175, 257);
            this.lblLetGo.Name = "lblLetGo";
            this.lblLetGo.Size = new System.Drawing.Size(96, 15);
            this.lblLetGo.TabIndex = 9;
            this.lblLetGo.Text = "No. unhooked";
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHowToPlay.Location = new System.Drawing.Point(28, 31);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(123, 48);
            this.btnHowToPlay.TabIndex = 10;
            this.btnHowToPlay.Text = "How to play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RouletteGame.Resource1.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.btnHowToPlay);
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
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button btnHowToPlay;
    }
}

