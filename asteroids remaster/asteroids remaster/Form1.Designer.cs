
namespace asteroids_remaster
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.starsMove = new System.Windows.Forms.Timer(this.components);
			this.player = new System.Windows.Forms.PictureBox();
			this.goTimer = new System.Windows.Forms.Timer(this.components);
			this.stopTimer = new System.Windows.Forms.Timer(this.components);
			this.leftTimer = new System.Windows.Forms.Timer(this.components);
			this.rightTimer = new System.Windows.Forms.Timer(this.components);
			this.asteroidTimer = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.shotTimer = new System.Windows.Forms.Timer(this.components);
			this.bulletTimer = new System.Windows.Forms.Timer(this.components);
			this.hp1 = new System.Windows.Forms.PictureBox();
			this.hp2 = new System.Windows.Forms.PictureBox();
			this.hp3 = new System.Windows.Forms.PictureBox();
			this.deathTimer = new System.Windows.Forms.Timer(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.controlsLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hp1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hp2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hp3)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlText;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("a_LCDNova", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.SystemColors.Window;
			this.button1.Location = new System.Drawing.Point(480, 537);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(320, 90);
			this.button1.TabIndex = 0;
			this.button1.Text = "PLAY";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// starsMove
			// 
			this.starsMove.Enabled = true;
			this.starsMove.Interval = 40;
			this.starsMove.Tick += new System.EventHandler(this.starsMove_Tick);
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.Transparent;
			this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.player.Location = new System.Drawing.Point(612, 310);
			this.player.MaximumSize = new System.Drawing.Size(51, 51);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(51, 51);
			this.player.TabIndex = 1;
			this.player.TabStop = false;
			this.player.Visible = false;
			// 
			// goTimer
			// 
			this.goTimer.Interval = 10;
			this.goTimer.Tick += new System.EventHandler(this.go_Tick);
			// 
			// stopTimer
			// 
			this.stopTimer.Interval = 10;
			this.stopTimer.Tick += new System.EventHandler(this.stop_Tick);
			// 
			// leftTimer
			// 
			this.leftTimer.Interval = 10;
			this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
			// 
			// rightTimer
			// 
			this.rightTimer.Interval = 10;
			this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
			// 
			// asteroidTimer
			// 
			this.asteroidTimer.Interval = 10;
			this.asteroidTimer.Tick += new System.EventHandler(this.asteroidTimer_Tick);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("a_LCDNova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.SystemColors.Window;
			this.label6.Location = new System.Drawing.Point(939, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(313, 100);
			this.label6.TabIndex = 8;
			this.label6.Text = "0";
			// 
			// shotTimer
			// 
			this.shotTimer.Interval = 10;
			this.shotTimer.Tick += new System.EventHandler(this.shotTimer_Tick);
			// 
			// bulletTimer
			// 
			this.bulletTimer.Interval = 10;
			this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
			// 
			// hp1
			// 
			this.hp1.BackColor = System.Drawing.Color.Transparent;
			this.hp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.hp1.Image = global::asteroids_remaster.Properties.Resources.up;
			this.hp1.Location = new System.Drawing.Point(12, 618);
			this.hp1.MaximumSize = new System.Drawing.Size(51, 51);
			this.hp1.Name = "hp1";
			this.hp1.Size = new System.Drawing.Size(51, 51);
			this.hp1.TabIndex = 9;
			this.hp1.TabStop = false;
			this.hp1.Visible = false;
			// 
			// hp2
			// 
			this.hp2.BackColor = System.Drawing.Color.Transparent;
			this.hp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.hp2.Image = global::asteroids_remaster.Properties.Resources.up;
			this.hp2.Location = new System.Drawing.Point(69, 618);
			this.hp2.MaximumSize = new System.Drawing.Size(51, 51);
			this.hp2.Name = "hp2";
			this.hp2.Size = new System.Drawing.Size(51, 51);
			this.hp2.TabIndex = 10;
			this.hp2.TabStop = false;
			this.hp2.Visible = false;
			// 
			// hp3
			// 
			this.hp3.BackColor = System.Drawing.Color.Transparent;
			this.hp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.hp3.Image = global::asteroids_remaster.Properties.Resources.up;
			this.hp3.Location = new System.Drawing.Point(126, 618);
			this.hp3.MaximumSize = new System.Drawing.Size(51, 51);
			this.hp3.Name = "hp3";
			this.hp3.Size = new System.Drawing.Size(51, 51);
			this.hp3.TabIndex = 11;
			this.hp3.TabStop = false;
			this.hp3.Visible = false;
			// 
			// deathTimer
			// 
			this.deathTimer.Enabled = true;
			this.deathTimer.Tick += new System.EventHandler(this.deathTimer_Tick);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("a_LCDNova", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(412, 310);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(484, 100);
			this.label7.TabIndex = 12;
			this.label7.Text = "Game Over";
			this.label7.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlText;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("a_LCDNova", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.Window;
			this.button2.Location = new System.Drawing.Point(480, 537);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(320, 90);
			this.button2.TabIndex = 13;
			this.button2.Text = "RESTART";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// scoreLabel
			// 
			this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
			this.scoreLabel.Font = new System.Drawing.Font("a_LCDNova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scoreLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.scoreLabel.Location = new System.Drawing.Point(12, 9);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(130, 51);
			this.scoreLabel.TabIndex = 14;
			this.scoreLabel.Text = "0";
			this.scoreLabel.Visible = false;
			// 
			// controlsLabel
			// 
			this.controlsLabel.BackColor = System.Drawing.Color.Transparent;
			this.controlsLabel.Font = new System.Drawing.Font("a_LCDNova", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.controlsLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.controlsLabel.Location = new System.Drawing.Point(18, 130);
			this.controlsLabel.Name = "controlsLabel";
			this.controlsLabel.Size = new System.Drawing.Size(313, 100);
			this.controlsLabel.TabIndex = 15;
			this.controlsLabel.Text = "Controls:\r\nW - move forward\r\nA - rotate left\r\nS - stop moving\r\nD - rotate right\r\n" +
    "Space - shoot";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.controlsLabel);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.hp3);
			this.Controls.Add(this.hp2);
			this.Controls.Add(this.hp1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.player);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.Name = "Form1";
			this.Text = "Asteroids Remaster";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hp1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hp2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hp3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer starsMove;
		private System.Windows.Forms.Timer goTimer;
		private System.Windows.Forms.Timer stopTimer;
		private System.Windows.Forms.Timer leftTimer;
		private System.Windows.Forms.Timer rightTimer;
		public System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.Timer asteroidTimer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Timer shotTimer;
		private System.Windows.Forms.Timer bulletTimer;
		public System.Windows.Forms.PictureBox hp1;
		public System.Windows.Forms.PictureBox hp2;
		public System.Windows.Forms.PictureBox hp3;
		private System.Windows.Forms.Timer deathTimer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label controlsLabel;
	}
}

