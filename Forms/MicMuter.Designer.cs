namespace Hood.Core
{
    partial class MicMuter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicMuter));
            this._muteButton = new System.Windows.Forms.Button();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._about = new System.Windows.Forms.ToolStripMenuItem();
            this._fileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _muteButton
            // 
            this._muteButton.BackColor = System.Drawing.Color.Transparent;
            this._muteButton.FlatAppearance.BorderSize = 0;
            this._muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._muteButton.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._muteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._muteButton.Location = new System.Drawing.Point(-4, 0);
            this._muteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._muteButton.Name = "_muteButton";
            this._muteButton.Size = new System.Drawing.Size(224, 192);
            this._muteButton.TabIndex = 0;
            this._muteButton.Text = "Mic Muted";
            this._muteButton.UseVisualStyleBackColor = false;
            // 
            // _notifyIcon
            // 
            this._notifyIcon.Text = "Snowball Muter";
            this._notifyIcon.Visible = true;
            // 
            // _rightClickMenu
            // 
            this._rightClickMenu.Name = "_rightClickMenu";
            this._rightClickMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // _fileMenu
            // 
            this._fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this._about});
            this._fileMenu.Location = new System.Drawing.Point(0, 0);
            this._fileMenu.Name = "_fileMenu";
            this._fileMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this._fileMenu.Size = new System.Drawing.Size(219, 24);
            this._fileMenu.TabIndex = 1;
            this._fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Settings";
            // 
            // _about
            // 
            this._about.Name = "_about";
            this._about.Size = new System.Drawing.Size(52, 20);
            this._about.Text = "About";
            this._about.Click += new System.EventHandler(this.AboutMenuItemClicked);
            // 
            // MicMuter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 188);
            this.Controls.Add(this._fileMenu);
            this.Controls.Add(this._muteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._fileMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MicMuter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MicMuter";
            this._fileMenu.ResumeLayout(false);
            this._fileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _muteButton;
        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ContextMenuStrip _rightClickMenu;
        private System.Windows.Forms.MenuStrip _fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _about;
    }
}

