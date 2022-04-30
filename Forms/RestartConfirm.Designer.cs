
namespace Hood.Core
{
    partial class RestartConfirm
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
            this._confirm = new System.Windows.Forms.Button();
            this._question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _confirm
            // 
            this._confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._confirm.Location = new System.Drawing.Point(139, 109);
            this._confirm.Name = "_confirm";
            this._confirm.Size = new System.Drawing.Size(94, 38);
            this._confirm.TabIndex = 0;
            this._confirm.Text = "Ok";
            this._confirm.UseVisualStyleBackColor = true;
            this._confirm.Click += new System.EventHandler(this.ConfirmClicked);
            // 
            // _question
            // 
            this._question.AutoSize = true;
            this._question.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._question.Location = new System.Drawing.Point(3, 44);
            this._question.Name = "_question";
            this._question.Size = new System.Drawing.Size(367, 34);
            this._question.TabIndex = 2;
            this._question.Text = "A restart is required in order for these changes to take effect.\r\n\r\n";
            this._question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 159);
            this.Controls.Add(this._question);
            this.Controls.Add(this._confirm);
            this.MinimizeBox = false;
            this.Name = "RestartConfirm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Restart Required";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _confirm;
        private System.Windows.Forms.Label _question;
    }
}