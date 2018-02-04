namespace MegaDesk_4_TessLarcade
{
    partial class AddQuote
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
            this.submit = new System.Windows.Forms.Button();
            this.rush = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.desktop = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.desktopCombo = new System.Windows.Forms.ComboBox();
            this.drawersCombo = new System.Windows.Forms.ComboBox();
            this.rush7 = new System.Windows.Forms.RadioButton();
            this.rush5 = new System.Windows.Forms.RadioButton();
            this.rush3 = new System.Windows.Forms.RadioButton();
            this.rush0 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(205, 244);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // rush
            // 
            this.rush.AutoSize = true;
            this.rush.Location = new System.Drawing.Point(186, 116);
            this.rush.Name = "rush";
            this.rush.Size = new System.Drawing.Size(61, 13);
            this.rush.TabIndex = 41;
            this.rush.Text = "Rush Order";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(32, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 13);
            this.name.TabIndex = 40;
            this.name.Text = "Full Name";
            // 
            // desktop
            // 
            this.desktop.AutoSize = true;
            this.desktop.Location = new System.Drawing.Point(31, 163);
            this.desktop.Name = "desktop";
            this.desktop.Size = new System.Drawing.Size(47, 13);
            this.desktop.TabIndex = 39;
            this.desktop.Text = "Desktop";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Location = new System.Drawing.Point(31, 116);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(46, 13);
            this.drawers.TabIndex = 38;
            this.drawers.Text = "Drawers";
            // 
            // desktopCombo
            // 
            this.desktopCombo.FormattingEnabled = true;
            this.desktopCombo.Location = new System.Drawing.Point(34, 179);
            this.desktopCombo.Name = "desktopCombo";
            this.desktopCombo.Size = new System.Drawing.Size(121, 21);
            this.desktopCombo.TabIndex = 5;
            // 
            // drawersCombo
            // 
            this.drawersCombo.FormattingEnabled = true;
            this.drawersCombo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersCombo.Location = new System.Drawing.Point(34, 132);
            this.drawersCombo.Name = "drawersCombo";
            this.drawersCombo.Size = new System.Drawing.Size(121, 21);
            this.drawersCombo.TabIndex = 4;
            // 
            // rush7
            // 
            this.rush7.AutoSize = true;
            this.rush7.Location = new System.Drawing.Point(189, 203);
            this.rush7.Name = "rush7";
            this.rush7.Size = new System.Drawing.Size(53, 17);
            this.rush7.TabIndex = 9;
            this.rush7.TabStop = true;
            this.rush7.Text = "7 Day";
            this.rush7.UseVisualStyleBackColor = true;
            // 
            // rush5
            // 
            this.rush5.AutoSize = true;
            this.rush5.Location = new System.Drawing.Point(189, 179);
            this.rush5.Name = "rush5";
            this.rush5.Size = new System.Drawing.Size(53, 17);
            this.rush5.TabIndex = 8;
            this.rush5.TabStop = true;
            this.rush5.Text = "5 Day";
            this.rush5.UseVisualStyleBackColor = true;
            // 
            // rush3
            // 
            this.rush3.AutoSize = true;
            this.rush3.Location = new System.Drawing.Point(189, 155);
            this.rush3.Name = "rush3";
            this.rush3.Size = new System.Drawing.Size(53, 17);
            this.rush3.TabIndex = 7;
            this.rush3.TabStop = true;
            this.rush3.Text = "3 Day";
            this.rush3.UseVisualStyleBackColor = true;
            // 
            // rush0
            // 
            this.rush0.AutoSize = true;
            this.rush0.Location = new System.Drawing.Point(189, 132);
            this.rush0.Name = "rush0";
            this.rush0.Size = new System.Drawing.Size(51, 17);
            this.rush0.TabIndex = 6;
            this.rush0.TabStop = true;
            this.rush0.Text = "None";
            this.rush0.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Depth";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(34, 35);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(145, 20);
            this.namebox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Width";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Back_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(34, 88);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(121, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(189, 88);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(121, 20);
            this.depthInput.TabIndex = 3;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valid_KeyPress);
            this.depthInput.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 293);
            this.ControlBox = false;
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.rush);
            this.Controls.Add(this.name);
            this.Controls.Add(this.desktop);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.desktopCombo);
            this.Controls.Add(this.drawersCombo);
            this.Controls.Add(this.rush7);
            this.Controls.Add(this.rush5);
            this.Controls.Add(this.rush3);
            this.Controls.Add(this.rush0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "New Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label rush;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label desktop;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.ComboBox desktopCombo;
        private System.Windows.Forms.ComboBox drawersCombo;
        private System.Windows.Forms.RadioButton rush7;
        private System.Windows.Forms.RadioButton rush5;
        private System.Windows.Forms.RadioButton rush3;
        private System.Windows.Forms.RadioButton rush0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
    }
}