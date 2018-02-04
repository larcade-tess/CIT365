namespace MegaDesk_4_TessLarcade
{
    partial class SearchQuotes
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
            this.Back = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.searchMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(211, 285);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(104, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Cancel";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 201);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // searchMaterial
            // 
            this.searchMaterial.FormattingEnabled = true;
            this.searchMaterial.Location = new System.Drawing.Point(101, 32);
            this.searchMaterial.Name = "searchMaterial";
            this.searchMaterial.Size = new System.Drawing.Size(121, 21);
            this.searchMaterial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchMaterial);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Back);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox searchMaterial;
        private System.Windows.Forms.Label label2;
    }
}