namespace InfixToPostfix
{
	partial class SplashForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.panelLogo = new System.Windows.Forms.Panel();
			this.timerSplash = new System.Windows.Forms.Timer(this.components);
			this.panelTitle = new System.Windows.Forms.Panel();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.labelSplashVersion = new System.Windows.Forms.Label();
			this.labelSplashTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelLogo.SuspendLayout();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.pbLogo);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(567, 347);
			this.panelLogo.TabIndex = 0;
			// 
			// timerSplash
			// 
			this.timerSplash.Enabled = true;
			this.timerSplash.Interval = 3500;
			this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.panel1);
			this.panelTitle.Controls.Add(this.labelSplashTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelTitle.Location = new System.Drawing.Point(0, 353);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(567, 106);
			this.panelTitle.TabIndex = 1;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = global::InfixToPostfix.Properties.Resources.infix_postfix_logo;
			this.pbLogo.Location = new System.Drawing.Point(17, 13);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(533, 321);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// labelSplashVersion
			// 
			this.labelSplashVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelSplashVersion.AutoSize = true;
			this.labelSplashVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSplashVersion.Location = new System.Drawing.Point(129, 15);
			this.labelSplashVersion.Name = "labelSplashVersion";
			this.labelSplashVersion.Size = new System.Drawing.Size(57, 19);
			this.labelSplashVersion.TabIndex = 0;
			this.labelSplashVersion.Text = "Version";
			this.labelSplashVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelSplashTitle
			// 
			this.labelSplashTitle.AutoSize = true;
			this.labelSplashTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSplashTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.labelSplashTitle.Location = new System.Drawing.Point(123, 9);
			this.labelSplashTitle.Name = "labelSplashTitle";
			this.labelSplashTitle.Size = new System.Drawing.Size(320, 59);
			this.labelSplashTitle.TabIndex = 1;
			this.labelSplashTitle.Text = "Infix to PostFix";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelSplashVersion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(567, 43);
			this.panel1.TabIndex = 2;
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 459);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SplashForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashForm";
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.SplashForm_Load);
			this.panelLogo.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Timer timerSplash;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelSplashVersion;
		private System.Windows.Forms.Label labelSplashTitle;
		private System.Windows.Forms.Panel panel1;
	}
}