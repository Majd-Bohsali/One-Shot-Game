
namespace game
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bulletUpTimer = new System.Windows.Forms.Timer(this.components);
            this.bird1Timer = new System.Windows.Forms.Timer(this.components);
            this.collisionTimer = new System.Windows.Forms.Timer(this.components);
            this.bulletDownTimer = new System.Windows.Forms.Timer(this.components);
            this.checkForWinOrLossTimer = new System.Windows.Forms.Timer(this.components);
            this.bird2Timer = new System.Windows.Forms.Timer(this.components);
            this.aITimer = new System.Windows.Forms.Timer(this.components);
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // bulletUpTimer
            // 
            this.bulletUpTimer.Interval = 25;
            this.bulletUpTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bird1Timer
            // 
            this.bird1Timer.Enabled = true;
            this.bird1Timer.Interval = 50;
            this.bird1Timer.Tick += new System.EventHandler(this.bird1Timer_Tick);
            // 
            // collisionTimer
            // 
            this.collisionTimer.Enabled = true;
            this.collisionTimer.Interval = 1;
            this.collisionTimer.Tick += new System.EventHandler(this.collisionTimer_Tick);
            // 
            // bulletDownTimer
            // 
            this.bulletDownTimer.Interval = 25;
            this.bulletDownTimer.Tick += new System.EventHandler(this.bulletDownTImer_Tick);
            // 
            // checkForWinOrLossTimer
            // 
            this.checkForWinOrLossTimer.Enabled = true;
            this.checkForWinOrLossTimer.Interval = 1;
            this.checkForWinOrLossTimer.Tick += new System.EventHandler(this.checkForWin_Tick);
            // 
            // bird2Timer
            // 
            this.bird2Timer.Enabled = true;
            this.bird2Timer.Interval = 50;
            this.bird2Timer.Tick += new System.EventHandler(this.bird2Timer_Tick);
            // 
            // aITimer
            // 
            this.aITimer.Interval = 1;
            this.aITimer.Tick += new System.EventHandler(this.aITimer_Tick);
            // 
            // countTimer
            // 
            this.countTimer.Interval = 50;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 594);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer bulletUpTimer;
        private System.Windows.Forms.Timer bird1Timer;
        private System.Windows.Forms.Timer collisionTimer;
        private System.Windows.Forms.Timer bulletDownTimer;
        private System.Windows.Forms.Timer checkForWinOrLossTimer;
        private System.Windows.Forms.Timer bird2Timer;
        private System.Windows.Forms.Timer aITimer;
        private System.Windows.Forms.Timer countTimer;
    }
}

