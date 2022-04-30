
namespace Hood.Core
{
    partial class FirstRunDiag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRunDiag));
            this._about = new System.Windows.Forms.Label();
            this._okBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _about
            // 
            this._about.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._about.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._about.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._about.Location = new System.Drawing.Point(12, 9);
            this._about.Name = "_about";
            this._about.Size = new System.Drawing.Size(572, 455);
            this._about.TabIndex = 0;
            this._about.Text = resources.GetString("_about.Text");
            // 
            // _okBut
            // 
            this._okBut.Location = new System.Drawing.Point(12, 465);
            this._okBut.Name = "_okBut";
            this._okBut.Size = new System.Drawing.Size(572, 57);
            this._okBut.TabIndex = 1;
            this._okBut.Text = "Ok";
            this._okBut.UseVisualStyleBackColor = true;
            this._okBut.Click += new System.EventHandler(this.OkClicked);
            // 
            // FirstRunDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 524);
            this.Controls.Add(this._okBut);
            this.Controls.Add(this._about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstRunDiag";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _about;
        private System.Windows.Forms.Button _okBut;
    }
}