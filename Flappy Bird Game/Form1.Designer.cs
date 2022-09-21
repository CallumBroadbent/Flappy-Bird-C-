namespace Flappy_Bird_Game
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
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.AccessibleName = "";
            this.pipeTop.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(465, -213);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(190, 552);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.AccessibleName = "";
            this.flappyBird.Image = global::Flappy_Bird_Game.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(120, 525);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(79, 60);
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.AccessibleName = "";
            this.pipeBottom.Image = global::Flappy_Bird_Game.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(579, 758);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(190, 477);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            this.pipeBottom.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ground
            // 
            this.ground.AccessibleName = "";
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = global::Flappy_Bird_Game.Properties.Resources.ground;
            this.ground.Image = global::Flappy_Bird_Game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(3, 914);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(713, 251);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AccessibleName = "";
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.scoreText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(12, 977);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(220, 55);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(704, 1041);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeTop);
            this.MaximumSize = new System.Drawing.Size(720, 1080);
            this.MinimumSize = new System.Drawing.Size(720, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gameKeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox flappyBird;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}