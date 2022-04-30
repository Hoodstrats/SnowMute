namespace Hood.Core
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this._modifierKey = new System.Windows.Forms.ComboBox();
            this._keys = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._muteSpeech = new System.Windows.Forms.CheckBox();
            this._applyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._quitKey = new System.Windows.Forms.ComboBox();
            this._quitModKey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._version = new System.Windows.Forms.Label();
            this._description = new System.Windows.Forms.RichTextBox();
            this._websiteLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _modifierKey
            // 
            this._modifierKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._modifierKey.FormattingEnabled = true;
            this._modifierKey.Location = new System.Drawing.Point(8, 65);
            this._modifierKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._modifierKey.Name = "_modifierKey";
            this._modifierKey.Size = new System.Drawing.Size(128, 23);
            this._modifierKey.TabIndex = 0;
            // 
            // _keys
            // 
            this._keys.FormattingEnabled = true;
            this._keys.Location = new System.Drawing.Point(175, 65);
            this._keys.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._keys.Name = "_keys";
            this._keys.Size = new System.Drawing.Size(79, 23);
            this._keys.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._muteSpeech);
            this.panel1.Controls.Add(this._applyButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this._quitKey);
            this.panel1.Controls.Add(this._quitModKey);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._keys);
            this.panel1.Controls.Add(this._modifierKey);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 334);
            this.panel1.TabIndex = 4;
            // 
            // _muteSpeech
            // 
            this._muteSpeech.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._muteSpeech.AutoSize = true;
            this._muteSpeech.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._muteSpeech.Location = new System.Drawing.Point(61, 231);
            this._muteSpeech.Name = "_muteSpeech";
            this._muteSpeech.Size = new System.Drawing.Size(119, 25);
            this._muteSpeech.TabIndex = 11;
            this._muteSpeech.Text = "Mute Speech";
            this._muteSpeech.UseVisualStyleBackColor = true;
            this._muteSpeech.CheckedChanged += new System.EventHandler(this.MuteSpeechToggled);
            // 
            // _applyButton
            // 
            this._applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._applyButton.Location = new System.Drawing.Point(76, 285);
            this._applyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(88, 27);
            this._applyButton.TabIndex = 10;
            this._applyButton.Text = "Apply";
            this._applyButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(170, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Modifier";
            // 
            // _quitKey
            // 
            this._quitKey.FormattingEnabled = true;
            this._quitKey.Location = new System.Drawing.Point(175, 182);
            this._quitKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._quitKey.Name = "_quitKey";
            this._quitKey.Size = new System.Drawing.Size(79, 23);
            this._quitKey.TabIndex = 7;
            // 
            // _quitModKey
            // 
            this._quitModKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._quitModKey.FormattingEnabled = true;
            this._quitModKey.Location = new System.Drawing.Point(8, 182);
            this._quitModKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._quitModKey.Name = "_quitModKey";
            this._quitModKey.Size = new System.Drawing.Size(128, 23);
            this._quitModKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(56, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUIT KEYBIND";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(48, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "MUTE KEYBIND";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _label7
            // 
            this._label7.AutoSize = true;
            this._label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._label7.Location = new System.Drawing.Point(71, 12);
            this._label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label7.Name = "_label7";
            this._label7.Size = new System.Drawing.Size(64, 20);
            this._label7.TabIndex = 5;
            this._label7.Text = "ABOUT";
            this._label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._version);
            this.panel2.Controls.Add(this._description);
            this.panel2.Controls.Add(this._websiteLink);
            this.panel2.Controls.Add(this._label7);
            this.panel2.Location = new System.Drawing.Point(287, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 335);
            this.panel2.TabIndex = 6;
            // 
            // _version
            // 
            this._version.AutoSize = true;
            this._version.Location = new System.Drawing.Point(187, 314);
            this._version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._version.Name = "_version";
            this._version.Size = new System.Drawing.Size(37, 15);
            this._version.TabIndex = 8;
            this._version.Text = "v0.1.0";
            this._version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _description
            // 
            this._description.BackColor = System.Drawing.SystemColors.Menu;
            this._description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._description.Enabled = false;
            this._description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._description.ForeColor = System.Drawing.Color.Crimson;
            this._description.Location = new System.Drawing.Point(4, 38);
            this._description.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            this._description.Size = new System.Drawing.Size(232, 227);
            this._description.TabIndex = 7;
            this._description.TabStop = false;
            this._description.Text = resources.GetString("_description.Text");
            // 
            // _websiteLink
            // 
            this._websiteLink.AutoSize = true;
            this._websiteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._websiteLink.Location = new System.Drawing.Point(40, 277);
            this._websiteLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._websiteLink.Name = "_websiteLink";
            this._websiteLink.Size = new System.Drawing.Size(119, 20);
            this._websiteLink.TabIndex = 6;
            this._websiteLink.TabStop = true;
            this._websiteLink.Text = "Author Website";
            this._websiteLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _modifierKey;
        private System.Windows.Forms.ComboBox _keys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _quitKey;
        private System.Windows.Forms.ComboBox _quitModKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _applyButton;
        private System.Windows.Forms.Label _label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel _websiteLink;
        private System.Windows.Forms.RichTextBox _description;
        private System.Windows.Forms.Label _version;
        private System.Windows.Forms.CheckBox _muteSpeech;
    }
}