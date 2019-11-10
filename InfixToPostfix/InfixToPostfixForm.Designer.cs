namespace InfixToPostfix
{
	partial class InfixToPostfixForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfixToPostfixForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelMain = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.labelPostfix = new System.Windows.Forms.Label();
			this.labelInfix = new System.Windows.Forms.Label();
			this.tbPostfix = new System.Windows.Forms.TextBox();
			this.tbInfix = new System.Windows.Forms.TextBox();
			this.listBoxInfix = new System.Windows.Forms.ListBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.openInfixDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutInfixToPostfixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInfixDataFileToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPostfixToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.labelTitle);
			this.panelMain.Controls.Add(this.btnExit);
			this.panelMain.Controls.Add(this.btnClear);
			this.panelMain.Controls.Add(this.btnGenerate);
			this.panelMain.Controls.Add(this.labelPostfix);
			this.panelMain.Controls.Add(this.labelInfix);
			this.panelMain.Controls.Add(this.tbPostfix);
			this.panelMain.Controls.Add(this.tbInfix);
			this.panelMain.Controls.Add(this.listBoxInfix);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 24);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(800, 426);
			this.panelMain.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
			this.labelTitle.Location = new System.Drawing.Point(325, 12);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(156, 26);
			this.labelTitle.TabIndex = 4;
			this.labelTitle.Text = "Infix Expressions";
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(556, 354);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(167, 33);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(317, 354);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(167, 33);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.Location = new System.Drawing.Point(78, 354);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(167, 33);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate Postfix";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// labelPostfix
			// 
			this.labelPostfix.AutoSize = true;
			this.labelPostfix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPostfix.Location = new System.Drawing.Point(30, 310);
			this.labelPostfix.Name = "labelPostfix";
			this.labelPostfix.Size = new System.Drawing.Size(127, 19);
			this.labelPostfix.TabIndex = 2;
			this.labelPostfix.Text = "Postfix Expression";
			// 
			// labelInfix
			// 
			this.labelInfix.AutoSize = true;
			this.labelInfix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfix.Location = new System.Drawing.Point(30, 274);
			this.labelInfix.Name = "labelInfix";
			this.labelInfix.Size = new System.Drawing.Size(110, 19);
			this.labelInfix.TabIndex = 2;
			this.labelInfix.Text = "Infix Expression";
			// 
			// tbPostfix
			// 
			this.tbPostfix.BackColor = System.Drawing.SystemColors.Info;
			this.tbPostfix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPostfix.ForeColor = System.Drawing.Color.RoyalBlue;
			this.tbPostfix.Location = new System.Drawing.Point(163, 302);
			this.tbPostfix.Name = "tbPostfix";
			this.tbPostfix.ReadOnly = true;
			this.tbPostfix.Size = new System.Drawing.Size(607, 27);
			this.tbPostfix.TabIndex = 1;
			// 
			// tbInfix
			// 
			this.tbInfix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbInfix.Location = new System.Drawing.Point(163, 266);
			this.tbInfix.Name = "tbInfix";
			this.tbInfix.Size = new System.Drawing.Size(607, 27);
			this.tbInfix.TabIndex = 1;
			this.tbInfix.Click += new System.EventHandler(this.tbInfix_Enter);
			this.tbInfix.Enter += new System.EventHandler(this.tbInfix_Enter);
			// 
			// listBoxInfix
			// 
			this.listBoxInfix.Enabled = false;
			this.listBoxInfix.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxInfix.FormattingEnabled = true;
			this.listBoxInfix.ItemHeight = 19;
			this.listBoxInfix.Location = new System.Drawing.Point(30, 48);
			this.listBoxInfix.Name = "listBoxInfix";
			this.listBoxInfix.Size = new System.Drawing.Size(740, 194);
			this.listBoxInfix.TabIndex = 0;
			this.listBoxInfix.SelectedIndexChanged += new System.EventHandler(this.listBoxInfix_SelectedIndexChanged);
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(174, 6);
			// 
			// openInfixDataFileToolStripMenuItem
			// 
			this.openInfixDataFileToolStripMenuItem.Image = global::InfixToPostfix.Properties.Resources.file_48px;
			this.openInfixDataFileToolStripMenuItem.Name = "openInfixDataFileToolStripMenuItem";
			this.openInfixDataFileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.openInfixDataFileToolStripMenuItem.Text = "Open Infix Data File";
			this.openInfixDataFileToolStripMenuItem.Click += new System.EventHandler(this.openInfixDataFileToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::InfixToPostfix.Properties.Resources.close_window_48px;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// aboutInfixToPostfixToolStripMenuItem
			// 
			this.aboutInfixToPostfixToolStripMenuItem.Image = global::InfixToPostfix.Properties.Resources.info_48px;
			this.aboutInfixToPostfixToolStripMenuItem.Name = "aboutInfixToPostfixToolStripMenuItem";
			this.aboutInfixToPostfixToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.aboutInfixToPostfixToolStripMenuItem.Text = "About Infix to Postfix...";
			this.aboutInfixToPostfixToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPostfixToolStripMenuItem_Click);
			// 
			// InfixToPostfixForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "InfixToPostfixForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Infix to Postfix";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InfixToPostfixForm_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openInfixDataFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutInfixToPostfixToolStripMenuItem;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ListBox listBoxInfix;
		private System.Windows.Forms.Label labelPostfix;
		private System.Windows.Forms.Label labelInfix;
		private System.Windows.Forms.TextBox tbPostfix;
		private System.Windows.Forms.TextBox tbInfix;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
	}
}

