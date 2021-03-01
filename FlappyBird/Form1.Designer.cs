
namespace FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeGround = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.flappybird, "flappybird");
            this.flappybird.Name = "flappybird";
            this.flappybird.TabStop = false;
            this.flappybird.Click += new System.EventHandler(this.flappybird_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            resources.ApplyResources(this.pipeBottom, "pipeBottom");
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.TabStop = false;
            // 
            // pipeGround
            // 
            this.pipeGround.Image = global::FlappyBird.Properties.Resources.ground;
            resources.ApplyResources(this.pipeGround, "pipeGround");
            this.pipeGround.Name = "pipeGround";
            this.pipeGround.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.scoreText, "scoreText");
            this.scoreText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.scoreText.Name = "scoreText";
            this.scoreText.Click += new System.EventHandler(this.Score_Click);
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            resources.ApplyResources(this.pipeTop, "pipeTop");
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Image = global::FlappyBird.Properties.Resources.pipe;
            resources.ApplyResources(this.pipeBottom2, "pipeBottom2");
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::FlappyBird.Properties.Resources.pipedown;
            resources.ApplyResources(this.pipeTop2, "pipeTop2");
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom3.Image = global::FlappyBird.Properties.Resources.pipe;
            resources.ApplyResources(this.pipeBottom3, "pipeBottom3");
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.TabStop = false;
            // 
            // pipeTop3
            // 
            this.pipeTop3.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop3.Image = global::FlappyBird.Properties.Resources.pipedown;
            resources.ApplyResources(this.pipeTop3, "pipeTop3");
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.TabStop = false;
            this.pipeTop3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeGround);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappybird);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamkeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeGround;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.PictureBox pipeTop3;
    }
}

